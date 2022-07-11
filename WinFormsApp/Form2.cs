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

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        private Labyrinth Labyrinth { get; set; }
        
        public Form2()
        {
            InitializeComponent();
            Labyrinth = new Labyrinth(this);
            Labyrinth.StartGame();

           // var image = Image.FromFile("Assets/Images/wall.png");
            // var graphics = Graphics.FromImage(image);
            // graphics.DrawString("A", new Font("Arial", 100), Brushes.Yellow, 0, 0);
            // pictureBox23.Image = image;

            // pictureBox23.Refresh();
            // pictureBox23.Invalidate();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Labyrinth.KeyPressed(e.KeyCode);
            // if (e.KeyCode == Keys.Left)
            // {
            //     var pictureBox = new PictureBox();
            //     var image = Image.FromFile("Assets/Images/wall.png");
            //     pictureBox.Width = 25;
            //     pictureBox.Height = 25;
            //     pictureBox.Margin = Padding.Empty;
            //     pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            //     using (Graphics g = Graphics.FromImage(image))
            //     {
            //         g.DrawString("A", new Font("Arial", 100), Brushes.Yellow, 0, 0);
            //     }
            //
            //     // pictureBox.Location = new Point(X, Y);
            //     pictureBox.Image = image;
            //     panel1.Controls.Add(pictureBox);
            //
            //     // X += 25;
            //     // Y += 25;
            //     // flowLayoutPanel1.Controls.Add(pictureBox);
            // }
            // if (e.KeyCode == Keys.Right)
            // {
            //     panel1.Controls.Clear();
            //     // flowLayoutPanel1.Controls.RemoveAt(1);
            //     // flowLayoutPanel1.Controls.Clear();
            // }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
            // e.Cancel = (result == DialogResult.Cancel);
        }
    }
}
