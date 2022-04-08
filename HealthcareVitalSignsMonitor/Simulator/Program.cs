namespace Simulator
{
    using Simulator.Controller;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    static class Program
    {
        public static SimulatorController _simulatorController;
        public static SettingsController _settingsController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevicesController controlPanelController = new DevicesController(() => OnControlPanelClose(), async (deviceId) => await OnDeviceSelectedAsync(deviceId), async () => await OnDeviceStartAsync(), () => OnDeviceStop(), () => OnSettings());

            controlPanelController.Start();
        }

        private static void OnSettings()
        {
            _settingsController.Start();
        }

        private static void OnDeviceStop()
        {
            _simulatorController.StopDevice();
        }

        private static async Task OnDeviceStartAsync()
        {
            await _simulatorController.StartDeviceAsync();
        }

        private static async Task OnDeviceSelectedAsync(string deviceId)
        {
            _simulatorController = new SimulatorController(deviceId);
            await _simulatorController.InitAsync();
            _settingsController = new SettingsController(deviceId);
        }

        private static void OnControlPanelClose()
        {
            _simulatorController.StopDevice();
            _settingsController.Close();
        }
    }
}
