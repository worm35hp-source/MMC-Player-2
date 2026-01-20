using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MMC_Player_2
{
    public partial class TriggerButton : UserControl
    {
        /*      public TriggerButton()
              {
                  InitializeComponent();
              }*/

        Image state1;
        Image state2;
        bool state = false;

        // Property for the background image to be drawn behind the button text.
        public Image State1
        {
            get { return this.state1; }
            set { this.state1 = value; }
        }

        // Property for the background image to be drawn behind the button text when
        // the button is pressed.
        public Image State2
        {
            get { return this.state2; }
            set { this.state2 = value; }
        }

        public bool State
        {
            get { return this.state; }
            set { this.state = value; this.Invalidate(); }
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.state)
            {
                this.state = false;
                this.Invalidate();
                base.OnClick(e);
            }
            else
            {
                this.state = true;
                this.Invalidate();
                base.OnClick(e);
            }

        }

        Graphics gxOff;
        Bitmap m_bmpOffscreen;
        // Override the OnPaint method to draw the background image and the text.
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (m_bmpOffscreen == null)
                {
                    m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
                }

                gxOff = Graphics.FromImage(m_bmpOffscreen);

                gxOff.Clear(Color.Black);

                if (this.state)
                {
                    gxOff.DrawImage(this.state2, 0, 0);
                }
                else
                {
                    gxOff.DrawImage(this.state1, 0, 0);
                }

                e.Graphics.DrawImage(m_bmpOffscreen, 0, 0);
            }
            catch { }
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Disable background drawing...
        }
    }
}
