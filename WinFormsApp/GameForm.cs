using Core.Helpers;
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

        private void pictureBoxPlayPause_Click(object sender, EventArgs e)
        {
            SoundHelper.PausePlayMusic();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to leave?", "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Dispose(true);
                Application.Exit();
            }

            e.Cancel = true;
        }
    }
}
