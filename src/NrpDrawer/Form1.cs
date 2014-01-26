using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NrpDrawer
{
    public partial class Form1 : Form
    {
        private readonly DbController controller = new DbController();
        private bool dbLoaded;
        private bool transaction;
        private readonly string[] observationMapper = {"Ø", "su", "c", "w", "wl"};
        private readonly string[] mucusMapper = {"b", "ż", "żt", "gr", "m", "kl", "S", "Bj", "szk", "pł", "mś"};
        private Point mainChartMouseLoc = Point.Empty;
        private Point mucusChartMouseLoc = Point.Empty;

        public Form1()
        {
            InitializeComponent();

            endDateTimePicker.Value = DateTime.Now;
            beginDateTimePicker.Value = DateTime.Now.AddDays(-40);

            baseSymbolsComboBox.SelectedIndex = 0;
            mucusTypeComboBox.SelectedIndex = 0;
        }

        private void openDatabaseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                controller.Disconnect();
                controller.Connect(dbOpenFileDialog.FileName);
                dbLoaded = true;
                ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbLoaded = false;
            }
        }

        private void beginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            mainChart.ChartAreas[0].AxisX.Minimum = mucusChart.ChartAreas[0].AxisX.Minimum = beginDateTimePicker.Value.ToOADate();
            mainChart.ChartAreas[0].AxisX.Maximum = mucusChart.ChartAreas[0].AxisX.Maximum = endDateTimePicker.Value.ToOADate();

            ReloadData();
        }

        private void ReloadData()
        {
            if (!dbLoaded)
                return;

            var s = new Series {ChartType = SeriesChartType.Line, Color = Color.DarkRed};
            var s2 = new Series { ChartType = SeriesChartType.Point, Color = Color.DarkRed };
            DateTime b = beginDateTimePicker.Value,
                e = endDateTimePicker.Value;

            try
            {
                foreach (var v in controller.GetFromRangeOfDate(
                    new DateTime(b.Year, b.Month, b.Day), new DateTime(e.Year, e.Month, e.Day)))
                {
                    s.Points.AddXY(v.Date, v.Temperature);
                    int index = s2.Points.AddXY(v.Date, 0.2);
                    s2.Points[index].Label = "   " + observationMapper[v.Observation];

                    if (v.Observation > 0)
                    {
                        index = s2.Points.AddXY(v.Date, 1.2);
                        s2.Points[index].Label = "   " + mucusMapper[v.MucusType];
                    }
                }
                mucusChart.Series.Clear();
                mucusChart.Series.Add(s2);
                mainChart.Series.Clear();
                mainChart.Series.Add(s);
                CalculateScale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Cannot reload data: " + ex.Message);
            }
        }

        private void mainChart_SizeChanged(object sender, EventArgs e)
        {
            CalculateScale();
        }

        private void CalculateScale()
        {
            double val;
            int h = mainChart.Height;
            if (h < 300) val = 1;
            else if (h >= 300 && h < 600) val = 0.5;
            else if (h >= 600 && h < 900) val = 0.2;
            else val = 0.1;

            mainChart.ChartAreas[0].AxisY.Interval = val;
        }

        private DateTime GetDateTimeFromPosition(Point pos, Chart chart)
        {
            var results = chart.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            foreach (var xVal in from result in results
                                 where result.ChartElementType == ChartElementType.PlottingArea
                                 select result.ChartArea.AxisX.PixelPositionToValue(pos.X))
            {
                return DateTime.FromOADate(xVal);
            }

            return DateTime.Now;
        }

        private void mainChart_MouseClick(object sender, MouseEventArgs e)
        {
            transaction = true;
            currentDateTimePicker.Value = GetDateTimeFromPosition(e.Location, mainChart);
            SetCurrentValue();
            transaction = false;
        }

        private void updateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                // todo replace??? you should use localle settings
                controller.InsertValue(Double.Parse(temperatureTextBox.Text.Replace('.', ',')),
                    currentDateTimePicker.Value, baseSymbolsComboBox.SelectedIndex, mucusTypeComboBox.SelectedIndex);
                ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Cannot update/insert value: " + ex.Message);
            }
        }

        private void currentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetCurrentValue();
            if (transaction)
                return;
            beginDateTimePicker.Value = currentDateTimePicker.Value.AddDays(-40/2);
            endDateTimePicker.Value = currentDateTimePicker.Value.AddDays(40/2);
        }

        void SetCurrentValue()
        {
            try
            {
                DbItem item = controller.GetFromCurrentDate(currentDateTimePicker.Value);
                temperatureTextBox.Text = item.Temperature.ToString(CultureInfo.InvariantCulture);
                baseSymbolsComboBox.SelectedIndex = item.Observation;
                mucusTypeComboBox.SelectedIndex = item.MucusType;
            }
            catch (Exception)
            {
                temperatureTextBox.Text = String.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure?", @"Removing item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;
            controller.RemoveValue(currentDateTimePicker.Value);
            ReloadData();
            temperatureTextBox.Text = string.Empty;
        }

        private void baseSymbolsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mucusTypeComboBox.Enabled = baseSymbolsComboBox.SelectedIndex != 0;
        }

        private void mainChart_MouseMove(object sender, MouseEventArgs e)
        {
            mainChartMouseLoc = e.Location;
            mainChart.Refresh();
            mucusChart.Refresh();
            dateToolStripLabel.Text = GetDateTimeFromPosition(e.Location, mainChart).ToShortDateString();
        }

        private void mainChart_Paint(object sender, PaintEventArgs e)
        {
            if (mainChartMouseLoc != Point.Empty)
            {
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(0, mainChartMouseLoc.Y),
                    new Point(mainChart.Width, mainChartMouseLoc.Y));
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(mainChartMouseLoc.X, 0),
                    new Point(mainChartMouseLoc.X, mainChart.Height));
            }
            else if (mucusChartMouseLoc != Point.Empty)
            {
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(mucusChartMouseLoc.X, 0),
                    new Point(mucusChartMouseLoc.X, mainChart.Height));
            }
        }

        private void mucusChart_Paint(object sender, PaintEventArgs e)
        {
            if (mainChartMouseLoc != Point.Empty)
            {
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(mainChartMouseLoc.X, 0), new Point(mainChartMouseLoc.X, mucusChart.Height));
            }
            else if (mucusChartMouseLoc != Point.Empty)
            {
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(0, mucusChartMouseLoc.Y),
                    new Point(mucusChart.Width, mucusChartMouseLoc.Y));
                e.Graphics.DrawLine(new Pen(Color.Red), new Point(mucusChartMouseLoc.X, 0),
                    new Point(mucusChartMouseLoc.X, mucusChart.Height));
            }
            
        }

        private void mucusChart_MouseMove(object sender, MouseEventArgs e)
        {
            mucusChartMouseLoc = e.Location;
            mainChart.Refresh();
            mucusChart.Refresh();
            dateToolStripLabel.Text = GetDateTimeFromPosition(e.Location, mucusChart).ToShortDateString();
        }

        private void mucusChart_MouseLeave(object sender, EventArgs e)
        {
            mucusChartMouseLoc = Point.Empty;
            Refresh();
        }

        private void mainChart_MouseLeave(object sender, EventArgs e)
        {
            mainChartMouseLoc = Point.Empty;
            Refresh();
        }

        void MovePicker(DateTimePicker picker, bool forward)
        {
            picker.Value = picker.Value.AddDays(forward ? 1 : -1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePicker(beginDateTimePicker, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovePicker(endDateTimePicker, false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovePicker(beginDateTimePicker, false);
            MovePicker(endDateTimePicker, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovePicker(beginDateTimePicker, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovePicker(endDateTimePicker, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MovePicker(beginDateTimePicker, true);
            MovePicker(endDateTimePicker, true);
        }
    }
}
