using System;
using System.Windows.Forms;

namespace Simulator
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

            Form1 form = new Form1();
            form.Text = "Simulator";

            form.addPatients();

            Application.Run(form);
        }
    }
}
