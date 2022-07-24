namespace WinFormsApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSounds = new System.Windows.Forms.TrackBar();
            this.labelMusicValue = new System.Windows.Forms.Label();
            this.labelSoundsValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSounds)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Organetto Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(27, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 51);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "◀ Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(376, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "⚙️ Settings";
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.Location = new System.Drawing.Point(396, 178);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(365, 56);
            this.trackBarMusic.TabIndex = 7;
            this.trackBarMusic.TickFrequency = 5;
            this.trackBarMusic.Value = 100;
            this.trackBarMusic.ValueChanged += new System.EventHandler(this.trackBarMusic_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Music\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sounds";
            // 
            // trackBarSounds
            // 
            this.trackBarSounds.Location = new System.Drawing.Point(396, 258);
            this.trackBarSounds.Maximum = 100;
            this.trackBarSounds.Name = "trackBarSounds";
            this.trackBarSounds.Size = new System.Drawing.Size(365, 56);
            this.trackBarSounds.TabIndex = 10;
            this.trackBarSounds.TickFrequency = 5;
            this.trackBarSounds.Value = 100;
            this.trackBarSounds.ValueChanged += new System.EventHandler(this.trackBarSounds_ValueChanged);
            // 
            // labelMusicValue
            // 
            this.labelMusicValue.AutoSize = true;
            this.labelMusicValue.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMusicValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelMusicValue.Location = new System.Drawing.Point(767, 173);
            this.labelMusicValue.Name = "labelMusicValue";
            this.labelMusicValue.Size = new System.Drawing.Size(69, 38);
            this.labelMusicValue.TabIndex = 12;
            this.labelMusicValue.Text = "100";
            // 
            // labelSoundsValue
            // 
            this.labelSoundsValue.AutoSize = true;
            this.labelSoundsValue.Font = new System.Drawing.Font("Organetto Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSoundsValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelSoundsValue.Location = new System.Drawing.Point(765, 251);
            this.labelSoundsValue.Name = "labelSoundsValue";
            this.labelSoundsValue.Size = new System.Drawing.Size(69, 38);
            this.labelSoundsValue.TabIndex = 13;
            this.labelSoundsValue.Text = "100";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.labelSoundsValue);
            this.Controls.Add(this.labelMusicValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarSounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Label label2;
        private TrackBar trackBarMusic;
        private Label label1;
        private Label label3;
        private TrackBar trackBarSounds;
        private Label labelMusicValue;
        private Label labelSoundsValue;
    }
}