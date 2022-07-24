using WinFormsApp.Helpers;

namespace WinFormsApp
{
    public partial class EnterNameForm : Form
    {
        public EnterNameForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                FormHelper.OpenForm(this, new GameForm(textBoxName.Text));
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new MainMenuForm());
        }
    }
}