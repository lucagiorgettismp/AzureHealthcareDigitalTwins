using System;
using System.Linq;
using System.Windows.Forms;

namespace Common.View
{
    public partial class ErrorForm : Form
    {
        private const string ID_LABEL = "LabelTextError";
       
        public ErrorForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public void SetText(string textError)
        {
            Label errorLabel = this.Controls.Find(ID_LABEL, true).FirstOrDefault() as Label;
            errorLabel.Text = textError;
            this.Show();
        }

        private void ButtonConfirmationClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
