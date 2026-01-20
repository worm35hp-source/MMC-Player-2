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
    public partial class TrackBarAudio : UserControl
    {
        public TrackBarAudio()
        {
            InitializeComponent();
            pictureBox1.Image = MMC_Res.PolzunVert;
        }

        public EventHandler TrackBarAudioValueChanged;

        int _TrackBarValue = 0;
        int _TrackBarValueMax = 0;
        int[] mas_period;

        public int TrackBarValue
        {
            get { return _TrackBarValue; }
            set
            {
                _TrackBarValue = value;
                if (_TrackBarValue > 8 && _TrackBarValue < _TrackBarValueMax)
                {
                    try
                    {
                        pictureBox1.Top = mas_period[_TrackBarValue - 9];
                    }
                    catch
                    {
                        MessageBox.Show("Массив mas_period: Размер = " + mas_period.Length.ToString() +
                            ", обращение к индексу " + (_TrackBarValue - 9).ToString());
                        return;
                    }
                }
                else if (_TrackBarValue != 0 && _TrackBarValue == _TrackBarValueMax)
                {
                    pictureBox1.Top = 232;
                }
                else if(_TrackBarValue <= 8)
                {
                    pictureBox1.Top = 0;
                }
                panel1.Height = pictureBox1.Top;

                if (TrackBarAudioValueChanged != null)
                {
                    TrackBarAudioValueChanged(this, EventArgs.Empty);
                }
            }
        }

        public int TrackBarValueMax
        {
            get { return _TrackBarValueMax; }
            set
            {
                if (value > 10)
                {
                    _TrackBarValueMax = value - 1;
                    mas_period = new int[_TrackBarValueMax - 8];

                    double period = 232 / (_TrackBarValueMax - 9);
                    mas_period[0] = 0;
                    double period2 = 0;
                    for (int i = 1; i < _TrackBarValueMax - 9; i++)
                    {
                        period2 += period + 0.5;
                        mas_period[i] = (int)(period2);
                    }
                    mas_period[_TrackBarValueMax - 9] = 232;
                }
                else
                    _TrackBarValueMax = 0;

                pictureBox1.Top = 0;
                panel1.Height = pictureBox1.Top;
            }
        }

        private void TrackBarAudio_MouseDown(object sender, MouseEventArgs e)
        {
            if (_TrackBarValueMax != 0)
            {
                int period = 232 / (_TrackBarValueMax - 8);
                for (int i = 0; i < _TrackBarValueMax - 9; i++)
                {
                    try
                    {
                        if (e.Y >= mas_period[i] && e.Y < mas_period[i + 1])
                        {
                            this.TrackBarValue = 9 + i;
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("TrackBarAudio_MouseDown: Массив mas_period: Размер = " + mas_period.Length.ToString() +
                            ", обращение к индексу " + i.ToString() + " и " + (i+1).ToString());
                        return;
                    }
                }
                this.TrackBarValue = _TrackBarValueMax;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_TrackBarValueMax != 0)
            {
                int period = 232 / (_TrackBarValueMax - 8);
                for (int i = 0; i < _TrackBarValueMax - 9; i++)
                {
                    try
                    {
                        if (e.Y >= mas_period[i] && e.Y < mas_period[i + 1])
                        {
                            this.TrackBarValue = 9 + i;
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("panel1_MouseDown: Массив mas_period: Размер = " + mas_period.Length.ToString() +
                            ", обращение к индексу " + i.ToString() + " и " + (i + 1).ToString());
                        return;
                    }
                }
                this.TrackBarValue = _TrackBarValueMax;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_TrackBarValueMax != 0)
            {
                int period = 232 / (_TrackBarValueMax - 8);
                for (int i = 0; i < _TrackBarValueMax - 9; i++)
                {
                    try
                    {
                        if (e.Y >= mas_period[i] && e.Y < mas_period[i + 1])
                        {
                            this.TrackBarValue = 9 + i;
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("panel2_MouseDown: Массив mas_period: Размер = " + mas_period.Length.ToString() +
                            ", обращение к индексу " + i.ToString() + " и " + (i + 1).ToString());
                        return;
                    }
                }
                this.TrackBarValue = _TrackBarValueMax;
            }
        }
    }
}
