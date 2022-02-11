using System;
using System.Linq;
using System.Windows.Forms;

namespace Common.View
{
    public partial class SuccessForm : Form
    {
        private const string ID_LABEL = "LabelTextError";

        public SuccessForm()
        {
            InitializeComponent();
        }

        public void SetSext(string textError)
        {
            Label errorLabel = this.Controls.Find(ID_LABEL, true).FirstOrDefault() as Label;
            errorLabel.Text = textError;
            this.Show();
        }

        private void ButtonConfirmationClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
