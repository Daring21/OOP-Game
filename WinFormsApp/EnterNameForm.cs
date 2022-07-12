using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            var gameForm = new GameForm(textBoxName.Text);
            gameForm.Closed += (s, args) => this.Close();
            gameForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Closed += (s, args) => this.Close();
            mainMenuForm.Show();
        }
    }
}
