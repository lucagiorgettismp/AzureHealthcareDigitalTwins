using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_click(object sender, EventArgs e)
        {
            Console.WriteLine("Click button start!");
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click button create!");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patients_twins_collections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
