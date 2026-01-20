using System;
using System.Drawing;
using System.Windows.Forms;

namespace MMC_Player_2
{
    public partial class ImageButton : UserControl
    {
        /*      public ImageButton()
              {
                  InitializeComponent();
              }*/

        Image pressedImage;
        Image backgndImage;
        Image notactive;
        bool pressed = false;
        bool active = true;

        public Image NotActive
        {
            get { return this.notactive; }
            set { this.notactive = value; }
        }

        // Property for the background image to be drawn behind the button text.
        public Image BackGndImage
        {
            get { return this.backgndImage; }
            set { this.backgndImage = value; }
        }

        // Property for the background image to be drawn behind the button text when
        // the button is pressed.
        public Image PressedImage
        {
            get { return this.pressedImage; }
            set { this.pressedImage = value; }
        }



        public bool Active
        {
            get { return this.active; }
            set { this.active = value; pressed = false; this.Invalidate(); }
        }
        // When the mouse button is pressed, set the "pressed" flag to true 
        // and invalidate the form to cause a repaint.  The .NET Compact Framework 
        // sets the mouse capture automatically.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (active)
            {
                this.pressed = true;
                this.Invalidate();
                base.OnMouseDown(e);
            }
        }

        // When the mouse is released, reset the "pressed" flag 
        // and invalidate to redraw the button in the unpressed state.
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (active)
            {
                this.pressed = false;
                this.Invalidate();
                base.OnMouseUp(e);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (active)
            {
    //            this.Invalidate();
                this.pressed = false;
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
                if (active)
                {
                    if (pressed)
                    {
                        gxOff.DrawImage(this.pressedImage, 0, 0);
                    }
                    else
                    {
                        gxOff.DrawImage(this.backgndImage, 0, 0);
                    }
                }
                else
                {
                    gxOff.DrawImage(this.notactive, 0, 0);
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
