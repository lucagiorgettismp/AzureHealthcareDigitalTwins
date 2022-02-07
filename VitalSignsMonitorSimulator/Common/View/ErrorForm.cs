using System;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    public partial class ErrorForm : Form
    {
        private const string ID_LABEL = "LabelTextError";
       
        public ErrorForm()
        {
            InitializeComponent();
        }

        public void setSext(string textError)
        {
            Label errorLabel = this.Controls.Find(ID_LABEL, true).FirstOrDefault() as Label;
            errorLabel.Text = textError;
            this.Show();
        }

        private void ButtonConfirmation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
