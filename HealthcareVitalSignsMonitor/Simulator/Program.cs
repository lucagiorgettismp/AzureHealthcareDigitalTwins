namespace Simulator
{
    using Controller;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal static class Program
    {
        public static SimulationController _simulationController;
        public static SettingsController _settingsController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controlPanelController = new DevicesController(OnControlPanelClose, OnDeviceSelected, OnStartClick, OnDeviceStop, OnSettings);

            controlPanelController.Start();
        }

        private static async void OnStartClick()
        {
            await OnDeviceStartAsync();
        }

        private static async void OnDeviceSelected(string deviceId)
        {
            await OnDeviceSelectedAsync(deviceId);
        }

        private static void OnSettings()
        {
            _settingsController.Start();
        }

        private static void OnDeviceStop()
        {
            _simulationController.StopDevice();
        }

        private static async Task OnDeviceStartAsync()
        {
            await _simulationController.StartDeviceAsync();
        }

        private static async Task OnDeviceSelectedAsync(string deviceId)
        {
            _simulationController = new SimulationController(deviceId);
            await _simulationController.InitAsync();
            _settingsController = new SettingsController(deviceId);
        }

        private static void OnControlPanelClose()
        {
            _simulationController?.StopDevice();
            _settingsController?.Close();
        }
    }
}
