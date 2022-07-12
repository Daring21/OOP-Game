using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
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
