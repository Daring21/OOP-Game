using WinFormsApp.Helpers;

namespace WinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new EnterNameForm());
        }

        private void showRulesButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new RulesForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new SettingsForm());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to leave?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to leave?", "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
