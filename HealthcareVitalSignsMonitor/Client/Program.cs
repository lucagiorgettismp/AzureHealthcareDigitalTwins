namespace Client
{
    using Controller;
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        private static PatientController _patientController;
        private static DigitalTwinsController _dtController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _patientController = new PatientController(OnPatientControllerClose);
            _dtController = new DigitalTwinsController(OnAddPatientClick, OnClose);

            _dtController.Start();
        }

        private static void OnClose()
        {
            _patientController.Close();
        }

        private static void OnAddPatientClick()
        {
            _patientController.Start();
        }

        private static void OnPatientControllerClose()
        {
            _dtController.Enable();
        }
    }
}