using Assets.Script.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.View
{
    public class BaseApplicationPanel : MonoBehaviour
    {
        public VitalSignsMonitorView Parent { get { return GameObject.FindObjectOfType<VitalSignsMonitorView>(); } }
    }

    public class VitalSignsMonitorView: MonoBehaviour
    {
        private VitalSignsMonitorPanel VitalSignsMonitorPanel;
        private HeartFrequencyPanel HeartFrequencyPanel;
        private BreathFrequencyPanel BreathFrequencyPanel;
        private SaturationPanel SaturationPanel;
        private BloodPressurePanel BloodPressurePanel;
        private SensorValuesPanel SensorValuesPanel;

        private PatientPanel PatientPanel;
        private ButtonMenu ButtonMenu;

        private Image LoadingCircle;

        private VitalSignsMonitorController Controller;
        private PanelWrapper[] Panels;

        public void Start()
        {
            this.Controller = GameObject.FindObjectOfType<VitalSignsMonitorController>();

            this.VitalSignsMonitorPanel = GameObject.Find("VitalSignsMonitorPanel").GetComponent<VitalSignsMonitorPanel>();
            this.HeartFrequencyPanel = GameObject.Find("HeartFrequencyPanel").GetComponent<HeartFrequencyPanel>();
            this.BreathFrequencyPanel = GameObject.Find("BreathFrequencyPanel").GetComponent<BreathFrequencyPanel>();
            this.SaturationPanel = GameObject.Find("SaturationPanel").GetComponent<SaturationPanel>();
            this.BloodPressurePanel = GameObject.Find("BloodPressurePanel").GetComponent<BloodPressurePanel>();
            this.SensorValuesPanel = GameObject.Find("SensorValuesPanel").GetComponent<SensorValuesPanel>();
            
            this.PatientPanel = GameObject.Find("PatientPanel").GetComponent<PatientPanel>();
            this.ButtonMenu = GameObject.Find("ButtonMenu").GetComponent<ButtonMenu>();
            this.LoadingCircle = GameObject.Find("LoadingCircle").GetComponent<Image>();

            var panelList = new List<PanelWrapper>
            {
                new PanelWrapper { Panel = VitalSignsMonitorPanel, PanelType = PanelType.Home},
                new PanelWrapper { Panel = HeartFrequencyPanel, PanelType = PanelType.HeartFrequency},
                new PanelWrapper { Panel = BreathFrequencyPanel, PanelType = PanelType.BreathFrequency},
                new PanelWrapper { Panel = SaturationPanel, PanelType = PanelType.Saturation},
                new PanelWrapper { Panel = BloodPressurePanel, PanelType = PanelType.BloodPressure},
                new PanelWrapper { Panel = SensorValuesPanel, PanelType = PanelType.Values},
            };

            Panels = panelList.ToArray();
        }

        internal void StopLoading()
        {
            this.LoadingCircle.gameObject.SetActive(false);
        }

        internal void StartLoading()
        {
            this.ButtonMenu.gameObject.SetActive(true);
            this.LoadingCircle.gameObject.SetActive(true);
        }

        internal void SetPatient(Patient patient)
        {
            this.LoadingCircle.gameObject.SetActive(false);
            this.PatientPanel.transform.position = GetPatientCurrentPosition();
            this.PatientPanel.SetPatient(patient);
            this.PatientPanel.gameObject.SetActive(true);
        }

        internal void SetPatientPanelLoading()
        {
            this.PatientPanel.SetLoading();
        }

        internal void UpdateData(Message message)
        {
            this.VitalSignsMonitorPanel.UpdateView(message);
            this.HeartFrequencyPanel.UpdateView(message);
            this.BreathFrequencyPanel.UpdateView(message);
            this.SaturationPanel.UpdateView(message);
            this.BloodPressurePanel.UpdateView(message);
            this.SensorValuesPanel.UpdateView(message);
        }

        internal void HideAllPanels()
        {
            foreach (var panel in Panels)
            {
                panel.Panel.gameObject.SetActive(false);
            }

            this.PatientPanel.gameObject.SetActive(false);
            this.ButtonMenu.gameObject.SetActive(false);
            this.LoadingCircle.gameObject.SetActive(false);
        }

        internal void SetSelectedPanel(PanelType selectedPanel)
        {
            this.LoadingCircle.gameObject.SetActive(false);

            this.ButtonMenu.gameObject.SetActive(true);
            this.UpdateSelectedPanel(selectedPanel);
        }

        private void UpdateSelectedPanel(PanelType selectedPanel)
        {
            foreach (var panel in Panels)
            {
                if (panel.PanelType == selectedPanel)
                {
                    panel.Panel.transform.position = GetMonitorCurrentPosition();
                }

                panel.Panel.gameObject.SetActive(panel.PanelType == selectedPanel);
            }
        }

        internal async Task PanelSelectionChanged(PanelType selectedPanel)
        {
            this.UpdateSelectedPanel(selectedPanel);
            await this.Controller.PersistSelectedPanel(selectedPanel);
        }

        internal void CloseApplication()
        {
            this.Controller.CloseApplication();
        }

        private Vector3 GetMonitorCurrentPosition()
        {
            Vector3 currentPosition = this.ButtonMenu.transform.position;
            return new Vector3(currentPosition.x + 0.15f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
        }

        private Vector3 GetPatientCurrentPosition()
        {
            Vector3 currentPosition = this.ButtonMenu.transform.position;
            return new Vector3(currentPosition.x - 0.1f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
        }
    }

    internal class PanelWrapper
    {
        public BaseApplicationPanel Panel { get; set; }

        public PanelType PanelType { get; set; }
    }
}
