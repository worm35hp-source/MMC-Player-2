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
    public partial class Label_ : UserControl
    {
  /*      public Label_()
        {
            //           InitializeComponent();
        }*/

        private string _labelText;
        Font _Font;
        Color _Color;
        Color _BackColor;

        ContentAlignment _align = ContentAlignment.TopCenter;
        Graphics gxOff;
        Bitmap m_bmpOffscreen;

        // Override the OnPaint method to draw the background image and the text.
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (this._labelText == null) this._labelText = " ";

                if (m_bmpOffscreen == null)
                {
                    m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
                }

                gxOff = Graphics.FromImage(m_bmpOffscreen);

                gxOff.Clear(_BackColor);

                if (this._align == ContentAlignment.TopLeft)
                {
                    gxOff.DrawString(_labelText, _Font, new SolidBrush(_Color), 0, 0);
                }
                else
                    if (this._align == ContentAlignment.TopCenter)
                    {
                        StringFormat stringformat = new StringFormat()
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        gxOff.DrawString(_labelText, _Font, new SolidBrush(_Color), ClientSize.Width / 2, ClientSize.Height / 2, stringformat);
                    }
                    else
                        if (this._align == ContentAlignment.TopRight)
                        {
                            StringFormat stringformat = new StringFormat()
                            {
                                Alignment = StringAlignment.Far,
                                LineAlignment = StringAlignment.Center
                            };
                            gxOff.DrawString(_labelText, _Font, new SolidBrush(_Color), ClientSize.Width, ClientSize.Height / 2, stringformat);
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

        public override Color ForeColor
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public override Color BackColor
        {
            get { return _BackColor; }
            set { _BackColor = value; }
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
