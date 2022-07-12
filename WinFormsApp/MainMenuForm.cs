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
            this.Hide();
            var enterNameForm = new EnterNameForm();
            enterNameForm.Show();
        }

        private void showRulesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to leave?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
