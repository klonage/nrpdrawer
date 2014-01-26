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

        private void mainChart_MouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = mainChart.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            transaction = true;
            foreach (var xVal in from result in results
                where result.ChartElementType == ChartElementType.PlottingArea
                select result.ChartArea.AxisX.PixelPositionToValue(pos.X))
            {
                currentDateTimePicker.Value = DateTime.FromOADate(xVal);
                SetCurrentValue();
                break;
            }
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
            controller.RemoveValue(currentDateTimePicker.Value);
            ReloadData();
            temperatureTextBox.Text = string.Empty;
        }

        private void baseSymbolsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mucusTypeComboBox.Enabled = baseSymbolsComboBox.SelectedIndex != 0;
        }
    }
}
