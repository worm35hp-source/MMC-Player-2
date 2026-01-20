using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;

namespace MMC_Player_2
{
    public partial class ProgressTrackBar : UserControl
    {
        public ProgressTrackBar()
        {
            InitializeComponent();
            ProgressBar.BackColor = Color.Red;
            Img_WhiteLine.Image = MMC_Res.WhiteLine1;
        }

        public EventHandler TrackBarValueChanged;

        private long _Maximum = 100;
        private long _Minimum = 0;
        private long _TrackBarValue = 0;

        public long Maximum
        {
            get { return _Maximum; }
            set { _Maximum = value; }
        }

        public long Minimum
        {
            get { return _Minimum; }
            set { _Minimum = value; }
        }

        public long Value
        {
            get { return ProgressBar.Width; }
            set
            {
                ProgressBar.Width = (int)(((long)this.Width * value) / (_Maximum - _Minimum));
            }
        }

        public long TrackBarValue
        {
            get { return _TrackBarValue; }
            set
            {
                _TrackBarValue = value;
                if (TrackBarValueChanged != null)
                {
                    TrackBarValueChanged(this, EventArgs.Empty);
                }
            }
        }

        private void ProgressTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            long value = _Minimum + ((long)e.X * (_Maximum - _Minimum)) / (long)this.ClientSize.Width;
            if (value > _Maximum) value = _Maximum;
            if (value < _Minimum) value = _Minimum;
            this.TrackBarValue = value;
        }

        private void ProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            long value = _Minimum + ((long)e.X * (_Maximum - _Minimum)) / (long)this.ClientSize.Width;
            if (value > _Maximum) value = _Maximum;
            if (value < _Minimum) value = _Minimum;
            this.TrackBarValue = value;
        }
    }
}
