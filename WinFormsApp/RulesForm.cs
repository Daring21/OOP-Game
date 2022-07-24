using System.Diagnostics;
using WinFormsApp.Helpers;

namespace WinFormsApp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new MainMenuForm());
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var processStartInfo = new ProcessStartInfo("https://github.com/D4RK21")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(processStartInfo);
        }

        private void easterPictureBox_Click(object sender, EventArgs e)
        {
            easterPictureBox.Image = Image.FromFile("Assets/Images/easter.gif");
        }
    }
}