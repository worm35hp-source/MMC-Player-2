using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;

namespace MMC_Player_2
{
    public partial class TrackBarAudioSettings : UserControl
    {
        public TrackBarAudioSettings()
        {
            InitializeComponent();
            pictureBox1.Image = MMC_Res.PolzunAudio;
            pictureBox2.Image = MMC_Res.PolzunVert;
        }

        public EventHandler TrackBarAudioSettingsValueChanged;

        private int _TrackBarValue = 93;

        public int Value
        {
            set
            {
                pictureBox2.Top = (int)((14 - value) * 6.607);
            }
        }

        public int TrackBarValue
        {
            get { return (14 - (int)(_TrackBarValue / 6.607)); }
            set
            {
                _TrackBarValue = value;
                if (TrackBarAudioSettingsValueChanged != null)
                {
                    TrackBarAudioSettingsValueChanged(this, EventArgs.Empty);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int value = e.Y * 187 / 200;
            if (value > 185) value = 185;
            if (value < 0) value = 0;
            this.TrackBarValue = value;
        }
    }
}
