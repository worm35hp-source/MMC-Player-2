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
using Can;

namespace MMC_Player_2
{
    public partial class Form_ScreenSaver : Form
    {
        Form_Main Main;

        Font font_systime = new Font("Kor_Itelma", 40F, FontStyle.Regular);
        Font font_sysdate = new Font("Kor_Itelma", 16F, FontStyle.Regular);

        public Form_ScreenSaver(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();
            label_Date.Font = font_sysdate;
            label_Time.Font = font_systime;
            pictureBoxLine.Image = MMC_Res.ScreenSaverLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
        }

        private void Form_ScreenSaver_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void Disable()
        {
            Vars.timerScreenSaverTick = 0;
            Vars.ScreenSaverActive = false;

            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Audio:
                    Forms.Audio.Activate();
                    break;
                case Vars.Form_Active.AudioSettings:
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.DisplaySettings:
                    Forms.DisplaySettings.Activate();
                    break;
                case Vars.Form_Active.GeneralSettings:
                    Forms.GeneralSettings.Activate();
                    break;
                case Vars.Form_Active.Main:
                    Main.Activate();
                    break;
                case Vars.Form_Active.Navigation:
                    break;
                case Vars.Form_Active.Phone:
                    Forms.Phone.Activate();
                    break;
                case Vars.Form_Active.Phone_PhoneSettings:
                    Forms.PhoneSettings.Activate();
                    break;
                case Vars.Form_Active.PhoneSettings:
                    Forms.PhoneSettings.Activate();
                    break;
                case Vars.Form_Active.Player:
                    Forms.Player.Activate();
                    break;
                case Vars.Form_Active.Player_AudioSettings:
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.Radio:
                    Forms.Radio.Activate();
                    break;
                case Vars.Form_Active.Radio_AudioSettings:
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.Radio_RadioSettings:
                    Forms.RadioSettings.Activate();
                    break;
                case Vars.Form_Active.RadioSettings:
                    Forms.RadioSettings.Activate();
                    break;
                case Vars.Form_Active.Settings:
                    Forms.Settings.Activate();
                    break;
                default:
                    break;
            }
            this.Left = 801;
            this.Top = 481;
        }

        private void Form_ScreenSaver_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void label_Time_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void label_Date_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Disable();
        }
    }
}