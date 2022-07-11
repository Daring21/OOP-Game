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
            mainMenuForm.Closed += (s, args) => this.Close();
            mainMenuForm.Show();
        }
    }
}
