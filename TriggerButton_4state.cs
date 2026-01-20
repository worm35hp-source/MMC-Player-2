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
    public partial class TriggerButton_4state : UserControl
    {
        Image state1;
        Image state2;
        Image state3;
        Image state4;
        int state = 1;

        private string _labelText;
        Font _Font;

        ContentAlignment _align = ContentAlignment.TopCenter;

        public Image State1
        {
            get { return this.state1; }
            set { this.state1 = value; }
        }

        public Image State2
        {
            get { return this.state2; }
            set { this.state2 = value; }
        }

        public Image State3
        {
            get { return this.state3; }
            set { this.state3 = value; }
        }

        public Image State4
        {
            get { return this.state4; }
            set { this.state4 = value; }
        }

        public int State
        {
            get { return this.state; }
            set { this.state = value; this.Invalidate(); }
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

                switch (this.state)
                {
                    case 1:
                        gxOff.DrawImage(this.state1, 0, 0);
                        break;
                    case 2:
                        gxOff.DrawImage(this.state2, 0, 0);
                        break;
                    case 3:
                        gxOff.DrawImage(this.state3, 0, 0);
                        break;
                    case 4:
                        gxOff.DrawImage(this.state4, 0, 0);
                        break;
                    default:
                        gxOff.DrawImage(this.state1, 0, 0);
                        break;
                }

                // Рисуем текст
                if (_labelText != null)
                {
                    if (this._align == ContentAlignment.TopLeft)
                    {
                        gxOff.DrawString(_labelText, _Font, new SolidBrush(ForeColor), 0, 0);
                    }
                    else
                        if (this._align == ContentAlignment.TopCenter)
                        {
                            StringFormat stringformat = new StringFormat()
                            {
                                Alignment = StringAlignment.Center,
                                LineAlignment = StringAlignment.Center
                            };
                            gxOff.DrawString(_labelText, _Font, new SolidBrush(ForeColor), ClientSize.Width / 2, ClientSize.Height / 2, stringformat);
                        }
                        else
                            if (this._align == ContentAlignment.TopRight)
                            {
                                StringFormat stringformat = new StringFormat()
                                {
                                    Alignment = StringAlignment.Far,
                                    LineAlignment = StringAlignment.Center
                                };
                                gxOff.DrawString(_labelText, _Font, new SolidBrush(ForeColor), ClientSize.Width, ClientSize.Height / 2, stringformat);
                            }
                }

                e.Graphics.DrawImage(m_bmpOffscreen, 0, 0);
            }
            catch { }
            base.OnPaint(e);
        }

        public override string Text
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                Invalidate();
            }
        }

        public override Font Font
        {
            get { return _Font; }
            set { _Font = value; }
        }

        public ContentAlignment Align
        {
            get { return _align; }
            set
            {
                _align = value;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Disable background drawing...
        }
    }
}
