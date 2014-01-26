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

        public Form1()
        {
            InitializeComponent();

            endDateTimePicker.Value = DateTime.Now;
            beginDateTimePicker.Value = DateTime.Now.AddDays(-40);
        }

        private void openDatabaseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
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
        }

        private void beginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            mainChart.ChartAreas[0].AxisX.Minimum = beginDateTimePicker.Value.ToOADate();
            mainChart.ChartAreas[0].AxisX.Maximum = endDateTimePicker.Value.ToOADate();

            ReloadData();
        }

        private void ReloadData()
        {
            if (!dbLoaded)
                return;

            var s = new Series {ChartType = SeriesChartType.Line, Color = Color.DarkRed};
            DateTime b = beginDateTimePicker.Value,
                e = endDateTimePicker.Value;
            foreach (var v in controller.GetFromRangeOfDate(
                new DateTime(b.Year, b.Month, b.Day), new DateTime(e.Year, e.Month, e.Day)))
            {
                s.Points.AddXY(v.Date, v.Temperature);
            }

            mainChart.Series.Clear();
            mainChart.Series.Add(s);
            CalculateScale();
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
            // todo replace??? you should use localle settings
            controller.InsertValue(Double.Parse(temperatureTextBox.Text.Replace('.', ',')), currentDateTimePicker.Value);
            ReloadData();
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
            }
            catch (Exception)
            {
                temperatureTextBox.Text = String.Empty;
            }
        }
    }
}
