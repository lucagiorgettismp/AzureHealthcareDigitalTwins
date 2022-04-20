namespace Assets.Script.View.Panels
{
    using System;
    using TMPro;
    using UnityEngine;

    public abstract class BaseLineChartSensorPanel : BaseSensorPanel
    {
        public void UpdateView(Message message)
        {
            try
            {
                UpdateLineCharts(message);
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

        public abstract void UpdateLineCharts(Message message);
    }
}