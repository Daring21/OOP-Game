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
    public partial class WonForm : Form
    {
        public WonForm(int passedLevelCount)
        {
            InitializeComponent();
            labelWonLevelCount.Text = $"COUNT OF PASSED LEVELS: {passedLevelCount}";
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
    }
}
