namespace Assets.Script.View.Panels
{
    using System;
    using TMPro;
    using UnityEngine;

    public abstract class BaseSensorPanel : BasePanel
    {
        internal TextMeshPro _date;
        internal TextMeshPro _hour;

        internal Material _redColor;
        internal Material _whiteColor;

        internal TextMeshPro _batterySensorName;
        internal TextMeshPro _batteryValue;
        internal TextMeshPro _batterySymbol;
        internal GameObject _batteryAlert;

        const string RED_COLOR = "Materials/RedColor";
        const string WHITE_COLOR = "Materials/WhiteColor";

        public void Awake()
        {
            /* Datetime components */
            this._date = GameObject.Find("Date").GetComponent<TextMeshPro>();
            this._hour = GameObject.Find("Hour").GetComponent<TextMeshPro>();

            /* Load color resources */
            _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
            _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

            InitializeComponent();
        }

        public void Update()
        {
            var dateTime = DateTime.Now;
            this._hour.text = dateTime.ToShortDateString();
            this._date.text = dateTime.ToLongTimeString();
        }

        public void UpdateView(Message message)
        {
            this._batterySensorName.text = message.battery_sensor_name;
            this._batteryValue.text = message.battery_sensor_value.value.ToString();
            this._batterySymbol.text = message.battery_sensor_value.symbol;
            SetSensorAlert(this._batteryAlert, message.battery_alarm);

            try
            {
                UpdateSensorNames(message);
                UpdateSensorSymbols(message);
                UpdateSensorAlerts(message);
                UpdateSensorValues(message);
            }
            catch (Exception e)
            {
                Debug.LogError("Error: " + e.Message);
            }
        }

        public void SetSensorAlert(GameObject sensor, bool inAlarm)
        {
            sensor.GetComponent<Renderer>().material = inAlarm ? _redColor : _whiteColor;

            if (inAlarm)
            {
                sensor.GetComponent<AudioSource>().Play();
            }
        }


        public abstract void InitializeComponent();
        public abstract void UpdateSensorNames(Message message);
        public abstract void UpdateSensorSymbols(Message message);
        public abstract void UpdateSensorAlerts(Message message);
        public abstract void UpdateSensorValues(Message message);
    }
}