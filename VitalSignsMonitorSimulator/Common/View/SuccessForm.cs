using System;
using System.Linq;
using System.Windows.Forms;

namespace Common.View
{
    public partial class SuccessForm : Form
    {
        private const string ID_LABEL = "LabelTextSuccess";

        public SuccessForm()
        {
            InitializeComponent();
        }

        public void SetSext(string text)
        {
            Label successLabel = this.Controls.Find(ID_LABEL, true).FirstOrDefault() as Label;
            successLabel.Text = text;
            this.Show();
        }

        private void ButtonConfirmationClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
