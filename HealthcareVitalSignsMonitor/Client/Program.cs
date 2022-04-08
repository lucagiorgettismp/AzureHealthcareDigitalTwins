using System;
using System.Windows.Forms;
using Client.src.Controller;

namespace Client
{
    static class Program
    {
        private static PatientController patientController;
        private static DigitalTwinsController dtController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            patientController = new PatientController(() => OnPatientControllerClose());
            dtController = new DigitalTwinsController(() => OnAddPatientClick(), () => OnClose());

            dtController.Start();
        }

        private static void OnClose()
        {
            patientController.Close();
        }

        private static void OnAddPatientClick()
        {
            patientController.Start();
        }

        private static void OnPatientControllerClose()
        {
            dtController.Enable();
        }
    }
}