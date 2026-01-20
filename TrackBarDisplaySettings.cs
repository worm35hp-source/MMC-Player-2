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
    public partial class TrackBarDisplaySettings : UserControl
    {
        public TrackBarDisplaySettings()
        {
            InitializeComponent();
            pictureBox1.Image = MMC_Res.Polzun_Back;
            pictureBox2.Image = MMC_Res.Polzun;
        }

        public EventHandler TrackBarDisplaySettingsValueChanged;

        private int _TrackBarValue = 0;

        public int Value
        {
            get { return (int)(pictureBox2.Left / 2.75); }
            set
            {
                pictureBox2.Left = (int)(value * 2.75);
            }
        }

        public int TrackBarValue
        {
            get { return (int)(_TrackBarValue / 2.75); }
            set
            {
                _TrackBarValue = value;
                if (TrackBarDisplaySettingsValueChanged != null)
                {
                    TrackBarDisplaySettingsValueChanged(this, EventArgs.Empty);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int value = e.X * 165 / 180;
            if (value > 165) value = 165;
            if (value < 0) value = 0;
            this.TrackBarValue = value;
        }
    }
}
