namespace Common.View
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public void SetText(string textError)
        {
            this.LabelTextError.Text = textError;
            this.Show();
        }

        private void ButtonConfirmationClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
