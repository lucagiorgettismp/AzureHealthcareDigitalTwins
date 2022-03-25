namespace Assets.Script.View
{
    using Assets.Script.Model;
    using Assets.Script.View.Panels;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnityEngine;
    using UnityEngine.UI;

    public class VitalSignsMonitorView: MonoBehaviour
    {
        public VitalSignsMonitorPanel _vitalSignsMonitorPanel;
        public HeartFrequencyPanel _heartFrequencyPanel;
        public BreathFrequencyPanel _breathFrequencyPanel;
        public SaturationPanel _saturationPanel;
        public BloodPressurePanel _bloodPressurePanel;
        public SensorValuesPanel _sensorValuesPanel;

        public PatientPanel _patientPanel;
        public ButtonMenu _buttonMenu;

        public Image _loadingCircle;

        private VitalSignsMonitorController _controller;
        private PanelWrapper[] _panels;

        public void Start()
        {
            this._controller = GameObject.FindObjectOfType<VitalSignsMonitorController>();

            var panelList = new List<PanelWrapper>
            {
                new PanelWrapper { Panel = _vitalSignsMonitorPanel, PanelType = PanelType.Home},
                new PanelWrapper { Panel = _heartFrequencyPanel, PanelType = PanelType.HeartFrequency},
                new PanelWrapper { Panel = _breathFrequencyPanel, PanelType = PanelType.BreathFrequency},
                new PanelWrapper { Panel = _saturationPanel, PanelType = PanelType.Saturation},
                new PanelWrapper { Panel = _bloodPressurePanel, PanelType = PanelType.BloodPressure},
                new PanelWrapper { Panel = _sensorValuesPanel, PanelType = PanelType.Values},
            };

            _panels = panelList.ToArray();
        }

        internal void StopLoading()
        {
            this._loadingCircle.gameObject.SetActive(false);
        }

        internal void StartLoading()
        {
            this._loadingCircle.gameObject.SetActive(true);
        }

        internal void SetPatient(Patient patient)
        {
            this._loadingCircle.gameObject.SetActive(false);
            this._patientPanel.transform.position = GetPatientCurrentPosition();
            this._patientPanel.SetPatient(patient);
            this._patientPanel.gameObject.SetActive(true);
        }

        internal void UpdateData(Message message)
        {
            this._vitalSignsMonitorPanel.UpdateView(message);
            this._heartFrequencyPanel.UpdateView(message);
            this._breathFrequencyPanel.UpdateView(message);
            this._saturationPanel.UpdateView(message);
            this._bloodPressurePanel.UpdateView(message);
            this._sensorValuesPanel.UpdateView(message);
        }

        internal void HideAllPanels()
        {
            foreach (var panel in _panels)
            {
                panel.Panel.gameObject.SetActive(false);
            }

            this._patientPanel.gameObject.SetActive(false);
            this._buttonMenu.gameObject.SetActive(false);
            this._loadingCircle.gameObject.SetActive(false);
        }

        internal void SetSelectedPanel(PanelType selectedPanel)
        {
            this._loadingCircle.gameObject.SetActive(false);

            this._buttonMenu.gameObject.SetActive(true);
            this.UpdateSelectedPanel(selectedPanel);
        }

        private void UpdateSelectedPanel(PanelType selectedPanel)
        {
            foreach (var panel in _panels)
            {
                if (panel.PanelType == selectedPanel)
                {
                    panel.Panel.transform.position = GetMonitorCurrentPosition();
                }

                panel.Panel.gameObject.SetActive(panel.PanelType == selectedPanel);
            }

            _patientPanel.transform.position = GetPatientCurrentPosition();
        }

        internal async Task PanelSelectionChanged(PanelType selectedPanel)
        {
            this.UpdateSelectedPanel(selectedPanel);
            await this._controller.PersistSelectedPanel(selectedPanel);
        }

        internal void CloseApplication()
        {
            this._controller.CloseApplication();
        }

        private Vector3 GetMonitorCurrentPosition()
        {
            Vector3 currentPosition = this._buttonMenu.transform.position;
            return new Vector3(currentPosition.x + 0.15f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
        }

        private Vector3 GetPatientCurrentPosition()
        {
            Vector3 currentPosition = this._buttonMenu.transform.position;
            return new Vector3(currentPosition.x - 0.1f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
        }
    }

    internal class PanelWrapper
    {
        public BaseSensorPanel Panel { get; set; }
        public PanelType PanelType { get; set; }
    }
}