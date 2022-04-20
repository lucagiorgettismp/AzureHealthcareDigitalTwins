namespace Simulator
{
    using Simulator.Model;
    using System;
    using System.Configuration;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class SimulationForm : Form
    {
        private readonly Timer timerHour = new Timer();
        private readonly DateTimePicker datePicker = new DateTimePicker();

        private Label labDate;
        private Label labHour;

        private Label labTemperature;
        private Label labSaturation;
        private Label labBloodPressure;
        private Label labHeartFrequency;
        private Label labBreathFrequency;
        private Label labBattery;

        private TableLayoutPanel alarmHeartFrequency;
        private TableLayoutPanel alarmBreathFrequency;
        private TableLayoutPanel alarmBloodPressure;
        private TableLayoutPanel alarmSaturation;
        private TableLayoutPanel alarmTemperature;
        private TableLayoutPanel alarmBattery;

        private Chart chartHeartFrequency;
        private Chart chartBreathFrequency;
        private Chart chartSaturation;
        private Chart chartBloodPressure;

        // Date and hour
        private const string ID_LABEL_DATE = "DateLabel";
        private const string ID_LABEL_HOUR = "HourLabel";

        // Id Sensor
        private const string ID_LABEL_TEMPERATURE = "ValueTemperatureLabel";
        private const string ID_LABEL_SATURATION = "ValueSaturationLabel";
        private const string ID_LABEL_BLOOD_PRESSURE = "ValueBloodPressureLabel";
        private const string ID_LABEL_HEART_FREQUENCY = "ValueHeartFrequency";
        private const string ID_LABEL_BREATH_FREQUENCY = "ValueBreathFrequencyLabel";
        private const string ID_LABEL_BATTERY = "ValueBatteryLabel";

        // Id Alarm
        private const string ID_ALARM_SATURATION = "AlarmSaturation";
        private const string ID_ALARM_BLOOD_PRESSURE = "AlarmBloodPressure";
        private const string ID_ALARM_HEART_FREQUENCY = "AlarmHeartFrequency";
        private const string ID_ALARM_BREATH_FREQUENCY = "AlarmBreathFrequency";
        private const string ID_ALARM_TEMPERATURE = "AlarmTemperature";
        private const string ID_ALARM_BATTERY = "AlarmBattery";

        // Id chart
        private const string ID_CHART_HEART_FREQUENCY = "HeartFrequencyChart";
        private const string ID_CHART_BREATH_FREQUENCY = "BreathFrequencyChart";
        private const string ID_CHART_SATURATION = "SaturationChart";
        private const string ID_CHART_BLOOD_PRESSURE = "BloodPressureChart";
        readonly int MaxPointsInGraph;

        public SimulationForm(int maxPointsInGraph = 20)
        {
            InitializeComponent();

            this.MaxPointsInGraph = maxPointsInGraph;
            this.ControlBox = false;
        }

        private void SimulationFormLoad(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;

            // Hour and date
            this.labDate = this.Controls.Find(ID_LABEL_DATE, true).FirstOrDefault() as Label;
            this.labHour = this.Controls.Find(ID_LABEL_HOUR, true).FirstOrDefault() as Label;

            // Labels sensor
            this.labTemperature = this.Controls.Find(ID_LABEL_TEMPERATURE, true).FirstOrDefault() as Label;
            this.labHeartFrequency = this.Controls.Find(ID_LABEL_HEART_FREQUENCY, true).FirstOrDefault() as Label;
            this.labSaturation = this.Controls.Find(ID_LABEL_SATURATION, true).FirstOrDefault() as Label;
            this.labBloodPressure = this.Controls.Find(ID_LABEL_BLOOD_PRESSURE, true).FirstOrDefault() as Label;
            this.labBreathFrequency = this.Controls.Find(ID_LABEL_BREATH_FREQUENCY, true).FirstOrDefault() as Label;
            this.labBattery = this.Controls.Find(ID_LABEL_BATTERY, true).FirstOrDefault() as Label;

            // Table panel sensor
            this.alarmBloodPressure = this.Controls.Find(ID_ALARM_BLOOD_PRESSURE, true).FirstOrDefault() as TableLayoutPanel;
            this.alarmSaturation = this.Controls.Find(ID_ALARM_SATURATION, true).FirstOrDefault() as TableLayoutPanel;
            this.alarmHeartFrequency = this.Controls.Find(ID_ALARM_HEART_FREQUENCY, true).FirstOrDefault() as TableLayoutPanel;
            this.alarmBreathFrequency = this.Controls.Find(ID_ALARM_BREATH_FREQUENCY, true).FirstOrDefault() as TableLayoutPanel;
            this.alarmTemperature = this.Controls.Find(ID_ALARM_TEMPERATURE, true).FirstOrDefault() as TableLayoutPanel;
            this.alarmBattery = this.Controls.Find(ID_ALARM_BATTERY, true).FirstOrDefault() as TableLayoutPanel;

            // Charts sensor
            this.chartHeartFrequency = this.Controls.Find(ID_CHART_HEART_FREQUENCY, true).FirstOrDefault() as Chart;
            ChartArea chartAreaHeartFrequency = chartHeartFrequency.ChartAreas[0];
            chartAreaHeartFrequency.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaHeartFrequency.AxisY.Minimum = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]);
            chartAreaHeartFrequency.AxisY.Maximum = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]);

            this.chartBreathFrequency = this.Controls.Find(ID_CHART_BREATH_FREQUENCY, true).FirstOrDefault() as Chart;
            ChartArea chartAreaBreathFrequency = chartBreathFrequency.ChartAreas[0];
            chartAreaBreathFrequency.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaBreathFrequency.AxisY.Minimum = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]);
            chartAreaBreathFrequency.AxisY.Maximum = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]);

            this.chartSaturation = this.Controls.Find(ID_CHART_SATURATION, true).FirstOrDefault() as Chart;
            ChartArea chartAreaSaturation = chartSaturation.ChartAreas[0];
            chartAreaSaturation.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaSaturation.AxisY.Minimum = Convert.ToInt32(appSettings["SaturationMinValue"]);
            chartAreaSaturation.AxisY.Maximum = Convert.ToInt32(appSettings["SaturationMaxValue"]);

            this.chartBloodPressure = this.Controls.Find(ID_CHART_BLOOD_PRESSURE, true).FirstOrDefault() as Chart;
            ChartArea chartAreaBloodPressure = chartBloodPressure.ChartAreas[0];
            chartAreaBloodPressure.AxisY.IntervalType = DateTimeIntervalType.Number;
            chartAreaBloodPressure.AxisY.Minimum = Convert.ToInt32(appSettings["BloodPressureMinValue"]);
            chartAreaBloodPressure.AxisY.Maximum = Convert.ToInt32(appSettings["BloodPressureMaxValue"]);

            timerHour.Interval = 1000;
            timerHour.Tick += new EventHandler(TimerTick);
            timerHour.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.labHour.Text = datePicker.Value.ToShortDateString();
            this.labDate.Text = DateTime.Now.ToLongTimeString();
        }

        public void UpdateValues(DeviceData data)
        {
            // Labels
            this.labTemperature.Text = Math.Round(data.Temperature.Value, 1).ToString();
            this.labHeartFrequency.Text = data.HeartFrequency.Value.ToString();
            this.labSaturation.Text = data.Saturation.Value.ToString();
            this.labBloodPressure.Text = data.BloodPressure.Value.ToString();
            this.labBreathFrequency.Text = data.BreathFrequency.Value.ToString();
            this.labBattery.Text = data.BatteryPower.Value.ToString() + " %";

            // Alarm
            if (data.HeartFrequency.InAlarm) this.alarmHeartFrequency.BackColor = Color.Red;
            else this.alarmHeartFrequency.BackColor = Color.Black;

            if (data.BreathFrequency.InAlarm) this.alarmBreathFrequency.BackColor = Color.Red;
            else this.alarmBreathFrequency.BackColor = Color.Black;

            if (data.Saturation.InAlarm) this.alarmSaturation.BackColor = Color.Red;
            else this.alarmSaturation.BackColor = Color.Black;

            if (data.BloodPressure.InAlarm) this.alarmBloodPressure.BackColor = Color.Red;
            else this.alarmBloodPressure.BackColor = Color.Black;

            if (data.Temperature.InAlarm) this.alarmTemperature.BackColor = Color.Red;
            else this.alarmTemperature.BackColor = Color.Black;

            if (data.BatteryPower.InAlarm) this.alarmBattery.BackColor = Color.Red;
            else this.alarmBattery.BackColor = Color.Black;

            // Charts
            const int position = 0;

            this.chartHeartFrequency.Series[position].Points.AddXY(position, Convert.ToInt32(data.HeartFrequency.Value));
            this.chartBreathFrequency.Series[position].Points.AddXY(position, Convert.ToInt32(data.BreathFrequency.Value));
            this.chartSaturation.Series[position].Points.AddXY(position, Convert.ToInt32(data.Saturation.Value));
            this.chartBloodPressure.Series[position].Points.AddXY(position, Convert.ToInt32(data.BloodPressure.Value));

            int numItems = this.chartBloodPressure.Series[0].Points.Count();
            if(numItems == this.MaxPointsInGraph)
            {
                // Remove first point
                this.chartHeartFrequency.Series[position].Points.RemoveAt(position);
                this.chartBreathFrequency.Series[position].Points.RemoveAt(position);
                this.chartSaturation.Series[position].Points.RemoveAt(position);
                this.chartBloodPressure.Series[position].Points.RemoveAt(position);
            }
        }
    }
}
