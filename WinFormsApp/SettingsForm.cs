using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Helpers;
using WinFormsApp.Helpers;

namespace WinFormsApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            trackBarMusic.Value = SoundHelper.MusicVolume;
            labelMusicValue.Text = SoundHelper.MusicVolume.ToString();
            trackBarSounds.Value = SoundHelper.SoundsVolume;
            labelSoundsValue.Text = SoundHelper.SoundsVolume.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new MainMenuForm());
        }

        private void trackBarMusic_ValueChanged(object sender, EventArgs e)
        {
            labelMusicValue.Text = trackBarMusic.Value.ToString();
            SoundHelper.MusicVolume = trackBarMusic.Value;
        }

        private void trackBarSounds_ValueChanged(object sender, EventArgs e)
        {
            labelSoundsValue.Text = trackBarSounds.Value.ToString();
            SoundHelper.SoundsVolume = trackBarSounds.Value;
        }
    }
}
