namespace Simulator.View
{
    using System;
    using System.Configuration;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using Model;

    public partial class SimulationForm : Form
    {
        private readonly Timer _timerHour = new Timer();
        private readonly DateTimePicker _datePicker = new DateTimePicker();
        private readonly int _maxPointsInGraph;

        public SimulationForm(int maxPointsInGraph = 20)
        {
            InitializeComponent();

            this._maxPointsInGraph = maxPointsInGraph;
            this.ControlBox = false;
        }

        private void SimulationFormLoad(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;

            // Charts sensor
            var chartAreaHeartFrequency = this.HeartFrequencyChart.ChartAreas[0];
            chartAreaHeartFrequency.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaHeartFrequency.AxisY.Minimum = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]);
            chartAreaHeartFrequency.AxisY.Maximum = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]);

            var chartAreaBreathFrequency = this.BreathFrequencyChart.ChartAreas[0];
            chartAreaBreathFrequency.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaBreathFrequency.AxisY.Minimum = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]);
            chartAreaBreathFrequency.AxisY.Maximum = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]);

            var chartAreaSaturation = this.SaturationChart.ChartAreas[0];
            chartAreaSaturation.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaSaturation.AxisY.Minimum = Convert.ToInt32(appSettings["SaturationMinValue"]);
            chartAreaSaturation.AxisY.Maximum = Convert.ToInt32(appSettings["SaturationMaxValue"]);

            var chartAreaBloodPressure = this.BloodPressureChart.ChartAreas[0];
            chartAreaBloodPressure.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaBloodPressure.AxisY.Minimum = Convert.ToInt32(appSettings["BloodPressureMinValue"]);
            chartAreaBloodPressure.AxisY.Maximum = Convert.ToInt32(appSettings["BloodPressureMaxValue"]);

            _timerHour.Interval = 1000;
            _timerHour.Tick += new EventHandler(TimerTick);
            _timerHour.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.Hour.Text = this._datePicker.Value.ToShortDateString();
            this.Date.Text = DateTime.Now.ToLongTimeString();
        }

        public void UpdateValues(DeviceData data)
        {
            // Labels
            this.TemperatureValue.Text = Math.Round(data.Temperature.Value, 1).ToString();
            this.HeartFrequencyValue.Text = data.HeartFrequency.Value.ToString();
            this.SaturationValue.Text = data.Saturation.Value.ToString();
            this.BloodPressureValue.Text = data.BloodPressure.Value.ToString();
            this.BreathFrequencyValue.Text = data.BreathFrequency.Value.ToString();
            this.BatteryValue.Text = $"{data.BatteryPower.Value} {data.BatteryPower.UnitOfMeasurement}";

            // Units of measurement
            this.TemperatureUnit.Text = data.Temperature.UnitOfMeasurement;
            this.SaturationUnit.Text = data.Saturation.UnitOfMeasurement;
            this.BloodPressureUnit.Text = data.BloodPressure.UnitOfMeasurement;
            this.BreathFrequencyUnit.Text = data.BreathFrequency.UnitOfMeasurement;

            // Alert
            SetAlert(this.HeartFrequencyAlert, data.HeartFrequency.InAlert);
            SetAlert(this.BreathFrequencyAlert, data.BreathFrequency.InAlert);
            SetAlert(this.SaturationAlert, data.Saturation.InAlert);
            SetAlert(this.BloodPressureAlert, data.BloodPressure.InAlert);
            SetAlert(this.TemperatureAlert, data.Temperature.InAlert);
            SetAlert(this.BatteryAlert, data.BatteryPower.InAlert);

            // Charts
            const int position = 0;

            this.HeartFrequencyChart.Series[position].Points.AddXY(position, Convert.ToInt32(data.HeartFrequency.Value));
            this.BreathFrequencyChart.Series[position].Points.AddXY(position, Convert.ToInt32(data.BreathFrequency.Value));
            this.SaturationChart.Series[position].Points.AddXY(position, Convert.ToInt32(data.Saturation.Value));
            this.BloodPressureChart.Series[position].Points.AddXY(position, Convert.ToInt32(data.BloodPressure.Value));

            var numItems = this.BloodPressureChart.Series[0].Points.Count();
            if(numItems >= this._maxPointsInGraph)
            {
                // Remove first point
                this.HeartFrequencyChart.Series[position].Points.RemoveAt(position);
                this.BreathFrequencyChart.Series[position].Points.RemoveAt(position);
                this.SaturationChart.Series[position].Points.RemoveAt(position);
                this.BloodPressureChart.Series[position].Points.RemoveAt(position);
            }
        }

        private static void SetAlert(Control alertPanel, bool inAlert)
        {
            alertPanel.BackColor = inAlert ? Color.Red : Color.Black;
        }
    }
}
