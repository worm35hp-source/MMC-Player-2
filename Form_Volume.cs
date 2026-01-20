using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;
using System.IO;
using Service;
using System.Runtime.InteropServices;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_Volume : Form
    {
        [DllImport("coredll.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        Form_Main Main;

        int Volume = 0;

        public Form_Volume(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();
            pictureBox1.Image = MMC_Res.Volume;

            SerialCOM1.SysVolume += new SerialCOM1.AlertEventHandlerData(SerialCOM1_SysVolume);
        }

        public void SerialCOM1_SysVolume(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewVolume;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void ViewVolume(int data)
        {
            // Если режим разговора, то звук не сохраняем, чтобы потом восстановить
            //if (Bluetooth.HFP_STATE < 4) MMC_Data.SaveVolume = data;
            if (BtDll.m_callstate < 4) MMC_Data.SaveVolume = data;
            Volume = data;
            this.Left = 205;
            //          this.Top = 211;
            this.Top = 400;
            pictureBox1.Invalidate();
            timer1tick = 0;
            timer1.Enabled = true;

            #region // Отображение полосы звука
            switch (Volume)
            {
                case 0: pictureBox1.Image = MMC_Res.Volume;
                    break;
                case 1: pictureBox1.Image = MMC_Res.Volume;
                    break;
                case 2: pictureBox1.Image = MMC_Res.Volume;
                    break;
                case 3: pictureBox1.Image = MMC_Res._1;
                    break;
                case 4: pictureBox1.Image = MMC_Res._1;
                    break;
                case 5: pictureBox1.Image = MMC_Res._2;
                    break;
                case 6: pictureBox1.Image = MMC_Res._2;
                    break;
                case 7: pictureBox1.Image = MMC_Res._3;
                    break;
                case 8: pictureBox1.Image = MMC_Res._3;
                    break;
                case 9: pictureBox1.Image = MMC_Res._4;
                    break;
                case 10: pictureBox1.Image = MMC_Res._4;
                    break;
                case 11: pictureBox1.Image = MMC_Res._5;
                    break;
                case 12: pictureBox1.Image = MMC_Res._5;
                    break;
                case 13: pictureBox1.Image = MMC_Res._5;
                    break;
                case 14: pictureBox1.Image = MMC_Res._6;
                    break;
                case 15: pictureBox1.Image = MMC_Res._6;
                    break;
                case 16: pictureBox1.Image = MMC_Res._7;
                    break;
                case 17: pictureBox1.Image = MMC_Res._7;
                    break;
                case 18: pictureBox1.Image = MMC_Res._8;
                    break;
                case 19: pictureBox1.Image = MMC_Res._8;
                    break;
                case 20: pictureBox1.Image = MMC_Res._9;
                    break;
                case 21: pictureBox1.Image = MMC_Res._9;
                    break;
                case 22: pictureBox1.Image = MMC_Res._10;
                    break;
                case 23: pictureBox1.Image = MMC_Res._10;
                    break;
                case 24: pictureBox1.Image = MMC_Res._10;
                    break;
                case 25: pictureBox1.Image = MMC_Res._11;
                    break;
                case 26: pictureBox1.Image = MMC_Res._11;
                    break;
                case 27: pictureBox1.Image = MMC_Res._12;
                    break;
                case 28: pictureBox1.Image = MMC_Res._12;
                    break;
                case 29: pictureBox1.Image = MMC_Res._13;
                    break;
                case 30: pictureBox1.Image = MMC_Res._13;
                    break;
                case 31: pictureBox1.Image = MMC_Res._14;
                    break;
                case 32: pictureBox1.Image = MMC_Res._14;
                    break;
                case 33: pictureBox1.Image = MMC_Res._15;
                    break;
                case 34: pictureBox1.Image = MMC_Res._15;
                    break;
                case 35: pictureBox1.Image = MMC_Res._15;
                    break;
                case 36: pictureBox1.Image = MMC_Res._16;
                    break;
                case 37: pictureBox1.Image = MMC_Res._16;
                    break;
                case 38: pictureBox1.Image = MMC_Res._17;
                    break;
                case 39: pictureBox1.Image = MMC_Res._17;
                    break;
                case 40: pictureBox1.Image = MMC_Res._18;
                    break;
                case 41: pictureBox1.Image = MMC_Res._18;
                    break;
                case 42: pictureBox1.Image = MMC_Res._19;
                    break;
                case 43: pictureBox1.Image = MMC_Res._19;
                    break;
                case 44: pictureBox1.Image = MMC_Res._20;
                    break;
                case 45: pictureBox1.Image = MMC_Res._20;
                    break;
                case 46: pictureBox1.Image = MMC_Res._20;
                    break;
                case 47: pictureBox1.Image = MMC_Res._21;
                    break;
                case 48: pictureBox1.Image = MMC_Res._21;
                    break;
                case 49: pictureBox1.Image = MMC_Res._22;
                    break;
                case 50: pictureBox1.Image = MMC_Res._22;
                    break;
                case 51: pictureBox1.Image = MMC_Res._23;
                    break;
                case 52: pictureBox1.Image = MMC_Res._23;
                    break;
                case 53: pictureBox1.Image = MMC_Res._24;
                    break;
                case 54: pictureBox1.Image = MMC_Res._24;
                    break;
                case 55: pictureBox1.Image = MMC_Res._25;
                    break;
                case 56: pictureBox1.Image = MMC_Res._25;
                    break;
                case 57: pictureBox1.Image = MMC_Res._25;
                    break;
                case 58: pictureBox1.Image = MMC_Res._26;
                    break;
                case 59: pictureBox1.Image = MMC_Res._26;
                    break;
                case 60: pictureBox1.Image = MMC_Res._27;
                    break;
                case 61: pictureBox1.Image = MMC_Res._27;
                    break;
                case 62: pictureBox1.Image = MMC_Res._28;
                    break;
                case 63: pictureBox1.Image = MMC_Res._28;
                    break;
                case 64: pictureBox1.Image = MMC_Res._29;
                    break;
                case 65: pictureBox1.Image = MMC_Res._29;
                    break;
                case 66: pictureBox1.Image = MMC_Res._30;
                    break;
                case 67: pictureBox1.Image = MMC_Res._30;
                    break;
                case 68: pictureBox1.Image = MMC_Res._30;
                    break;
                case 69: pictureBox1.Image = MMC_Res._31;
                    break;
                case 70: pictureBox1.Image = MMC_Res._31;
                    break;
                case 71: pictureBox1.Image = MMC_Res._32;
                    break;
                case 72: pictureBox1.Image = MMC_Res._32;
                    break;
                case 73: pictureBox1.Image = MMC_Res._33;
                    break;
                case 74: pictureBox1.Image = MMC_Res._33;
                    break;
                case 75: pictureBox1.Image = MMC_Res._34;
                    break;
                case 76: pictureBox1.Image = MMC_Res._34;
                    break;
                case 77: pictureBox1.Image = MMC_Res._35;
                    break;
                case 78: pictureBox1.Image = MMC_Res._35;
                    break;
                case 79: pictureBox1.Image = MMC_Res._35;
                    break;
                case 80: pictureBox1.Image = MMC_Res._36;
                    break;
                case 81: pictureBox1.Image = MMC_Res._36;
                    break;
                case 82: pictureBox1.Image = MMC_Res._37;
                    break;
                case 83: pictureBox1.Image = MMC_Res._37;
                    break;
                case 84: pictureBox1.Image = MMC_Res._38;
                    break;
                case 85: pictureBox1.Image = MMC_Res._38;
                    break;
                case 86: pictureBox1.Image = MMC_Res._39;
                    break;
                case 87: pictureBox1.Image = MMC_Res._39;
                    break;
                case 88: pictureBox1.Image = MMC_Res._40;
                    break;
                case 89: pictureBox1.Image = MMC_Res._40;
                    break;
                case 90: pictureBox1.Image = MMC_Res._40;
                    break;
                case 91: pictureBox1.Image = MMC_Res._41;
                    break;
                case 92: pictureBox1.Image = MMC_Res._41;
                    break;
                case 93: pictureBox1.Image = MMC_Res._42;
                    break;
                case 94: pictureBox1.Image = MMC_Res._42;
                    break;
                case 95: pictureBox1.Image = MMC_Res._43;
                    break;
                case 96: pictureBox1.Image = MMC_Res._43;
                    break;
                case 97: pictureBox1.Image = MMC_Res._44;
                    break;
                case 98: pictureBox1.Image = MMC_Res._44;
                    break;
                case 99: pictureBox1.Image = MMC_Res._45;
                    break;
                case 100: pictureBox1.Image = MMC_Res._45;
                    break;
                default:
                    break;
            }
            #endregion

            Forms.Volume.Activate();
            Forms.Volume.TopMost = true;
        }

        int timer1tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1tick++;
            if (timer1tick > 9)
            {
                this.Left = 801;
                this.Top = 481;
                if (!Vars.ScreenSaverActive && !Vars.NavigatorActive && Vars.FormActivated != Vars.Form_Active.Dial)
                    Main.ShowWindow();
                Forms.Volume.TopMost = false;
                if (Vars.NavigatorActive && !Vars.DialActive)
                {
                    if (Vars.hWndNavigator != IntPtr.Zero) { SetForegroundWindow(Vars.hWndNavigator); }
                }
                timer1tick = 0;
                timer1.Enabled = false;
            }
        }


        StringFormat stringformat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        Brush brush = new SolidBrush(Color.White);
        Font font = new Font("Kor_Itelma", 18F, FontStyle.Regular);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Volume.ToString(), font, brush, 194, 29, stringformat);
        }

        private void Form_Volume_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void Form_Volume_Closing(object sender, CancelEventArgs e)
        {
            SerialCOM1.SysVolume -= new SerialCOM1.AlertEventHandlerData(SerialCOM1_SysVolume);
        }
    }
}