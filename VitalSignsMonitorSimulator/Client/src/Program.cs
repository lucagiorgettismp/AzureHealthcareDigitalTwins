using System;
using System.Windows.Forms;
using Client.View;

namespace Client
{
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

            ClientForm form = new ClientForm();
            form.Text = "Client";

            Application.Run(form);
        }
    }
}
