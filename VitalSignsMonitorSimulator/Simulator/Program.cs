namespace Simulator
{
    using System;
    using System.Windows.Forms;
    using View;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ControlPanelForm controlPanel = new ControlPanelForm();
            controlPanel.Text = "Control Panel";
            controlPanel.FormBorderStyle = FormBorderStyle.FixedDialog;

            Application.Run(controlPanel);
        }
    }
}
