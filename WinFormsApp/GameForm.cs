using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.Helpers;
using Core.Models;
using WinFormsApp.GameEngine;

namespace WinFormsApp
{
    public partial class GameForm : Form
    {
        private Labyrinth Labyrinth { get; set; }
        
        public GameForm(string name)
        {
            InitializeComponent();
            labelName.Text = $"Player: {name}";
            Labyrinth = new Labyrinth(this);
            Labyrinth.StartGame();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            Labyrinth.KeyPressed(e.KeyCode);
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
