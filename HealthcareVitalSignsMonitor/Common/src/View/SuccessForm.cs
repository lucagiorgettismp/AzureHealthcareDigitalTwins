namespace Common.View
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class SuccessForm : Form
    {
        private readonly Action _onClose = null;

        public SuccessForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public SuccessForm(Action onCloseAction) : this()
        {
            this._onClose = onCloseAction;
        }

        public void SetText(string text)
        {
            this.LabelTextSuccess.Text = text;
            this.Show();
        }

        private void ButtonConfirmationClick(object sender, EventArgs e)
        {
            this.Hide();
            if (this._onClose != null)
            {
                _onClose();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            if (this._onClose != null)
            {
                _onClose();
            }
        }
    }
}
