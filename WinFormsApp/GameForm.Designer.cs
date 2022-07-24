using WinFormsApp.Helpers;

namespace WinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panelGameField = new System.Windows.Forms.Panel();
            this.labelCollectedKeys = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxPlayPause = new System.Windows.Forms.PictureBox();
            this.labelRemainingDoors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use Arrows to move";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGameField
            // 
            this.panelGameField.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelGameField.Location = new System.Drawing.Point(214, 157);
            this.panelGameField.Name = "panelGameField";
            this.panelGameField.Size = new System.Drawing.Size(569, 254);
            this.panelGameField.TabIndex = 2;
            // 
            // labelCollectedKeys
            // 
            this.labelCollectedKeys.AutoSize = true;
            this.labelCollectedKeys.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCollectedKeys.ForeColor = System.Drawing.Color.White;
            this.labelCollectedKeys.Location = new System.Drawing.Point(315, 44);
            this.labelCollectedKeys.Name = "labelCollectedKeys";
            this.labelCollectedKeys.Size = new System.Drawing.Size(316, 38);
            this.labelCollectedKeys.TabIndex = 3;
            this.labelCollectedKeys.Text = "🗝 Collected Keys: ";
            this.labelCollectedKeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Organetto Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Yellow;
            this.labelName.Location = new System.Drawing.Point(7, 502);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 31);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Player:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlayPause
            // 
            this.pictureBoxPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayPause.Image")));
            this.pictureBoxPlayPause.Location = new System.Drawing.Point(893, 15);
            this.pictureBoxPlayPause.Name = "pictureBoxPlayPause";
            this.pictureBoxPlayPause.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayPause.TabIndex = 5;
            this.pictureBoxPlayPause.TabStop = false;
            this.pictureBoxPlayPause.Click += new System.EventHandler(this.pictureBoxPlayPause_Click);
            // 
            // labelRemainingDoors
            // 
            this.labelRemainingDoors.AutoSize = true;
            this.labelRemainingDoors.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRemainingDoors.ForeColor = System.Drawing.Color.White;
            this.labelRemainingDoors.Location = new System.Drawing.Point(295, 80);
            this.labelRemainingDoors.Name = "labelRemainingDoors";
            this.labelRemainingDoors.Size = new System.Drawing.Size(336, 38);
            this.labelRemainingDoors.TabIndex = 6;
            this.labelRemainingDoors.Text = "🚪 Remaining Doors: \r\n";
            this.labelRemainingDoors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.labelRemainingDoors);
            this.Controls.Add(this.pictureBoxPlayPause);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCollectedKeys);
            this.Controls.Add(this.panelGameField);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        public Panel panelGameField;
        public Label labelCollectedKeys;
        private Label labelName;
        private PictureBox pictureBoxPlayPause;
        public Label labelRemainingDoors;
    }
}
