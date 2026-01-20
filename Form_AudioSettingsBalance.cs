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

namespace MMC_Player_2
{
    public partial class Form_AudioSettingsBalance : Form
    {
        Form_Main Main;

        public Form_AudioSettingsBalance(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxImgSetting.Image = MMC_Res.Img_AudSettings;
            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;
            pictureBoxBalance.Image = MMC_Res.ImgSetBalance;

        }

        private void Form_AudioSettingsBalance_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void Form_AudioSettingsBalance_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            Forms.AudioSettings.Left = 0;
            Forms.AudioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.AudioSettings;
        }

        private void pictureBoxBalance_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxBalance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= 25 && e.X <= 225 && e.Y >= 75 && e.Y <= 325)
            {
                MMC_Data.Fader = e.Y;
                MMC_Data.Balance = e.X;

                balance = (int)(Math.Round((MMC_Data.Balance - 25) / 14.2857) - 7);
                fader = (int)(7 - Math.Round((MMC_Data.Fader - 75) / 17.857));

                SerialCOM1.Aud_SetBalanceFader(balance, fader);

                pictureBoxBalance.Invalidate();

                // Запись настроек
                MMC_Data.WriteSetting();
            }
        }

        private void DrawEllipse(int X, int Y, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(43, 124, 55));
            pen.Width = 5;
            e.Graphics.DrawEllipse(pen, X - 15, Y - 15, 30, 30); ;
            pen.Width = 8;
            e.Graphics.DrawEllipse(pen, X - 4, Y - 4, 8, 8);
        }

        private void pictureBoxBalance_Paint(object sender, PaintEventArgs e)
        {
            DrawEllipse(MMC_Data.Balance, MMC_Data.Fader, e);
        }

        int balance = 0;
        int fader = 0;
    }
}