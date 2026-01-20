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

namespace MMC_Player_2
{
    public partial class Form_Settings : Form
    {
        Form_Main Main;
        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);

        public Form_Settings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;
            Button_Back.NotActive = MMC_Res.SetBtnBackOn;

            Button_GeneralSet.BackGndImage = MMC_Res.GenSetBtnMainSetOff;
            Button_GeneralSet.PressedImage = MMC_Res.GenSetBtnMainSetOn;
            Button_GeneralSet.NotActive = MMC_Res.GenSetBtnMainSetOn;

            Button_RadioSet.BackGndImage = MMC_Res.GenSetBtnRadioOff;
            Button_RadioSet.PressedImage = MMC_Res.GenSetBtnRadioOn;
            Button_RadioSet.NotActive = MMC_Res.GenSetBtnRadioOn;

            Button_AudioSet.BackGndImage = MMC_Res.GenSetBtnAudioOff;
            Button_AudioSet.PressedImage = MMC_Res.GenSetBtnAudioOn;
            Button_AudioSet.NotActive = MMC_Res.GenSetBtnAudioOn;

            Button_DisplaySet.BackGndImage = MMC_Res.GenSetBtnDisplayOff;
            Button_DisplaySet.PressedImage = MMC_Res.GenSetBtnDisplayOn;
            Button_DisplaySet.NotActive = MMC_Res.GenSetBtnDisplayOn;

            Button_PhoneSettings.BackGndImage = MMC_Res.GenSetBtnPhoneOff;
            Button_PhoneSettings.PressedImage = MMC_Res.GenSetBtnPhoneOn;
            Button_PhoneSettings.NotActive = MMC_Res.GenSetBtnPhoneOn;

            Button_RearCam.BackGndImage = MMC_Res.GenSetBtnCamOff;
            Button_RearCam.PressedImage = MMC_Res.GenSetBtnCamOn;
            Button_RearCam.NotActive = MMC_Res.GenSetBtnCamOn;

            label_Date.Font = font_sysdate;
            label_Time.Font = font_systime;
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Main.Left = 0;
            Main.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Main.Activate();
            Vars.FormActivated = Vars.Form_Active.Main;
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void Button_DisplaySet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.DisplaySettings.Left = 0;
            Forms.DisplaySettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.DisplaySettings.Activate();
            Vars.FormActivated = Vars.Form_Active.DisplaySettings;
        }

        private void Button_AudioSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.AudioSettings.Left = 0;
            Forms.AudioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.AudioSettings;
        }

        private void Button_GeneralSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.GeneralSettings.Left = 0;
            Forms.GeneralSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.GeneralSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.GeneralSettings;
        }

        private void Button_RadioSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.RadioSettings.Left = 0;
            Forms.RadioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.RadioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.RadioSettings;
        }

        private void Button_PhoneSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.PhoneSettings.Left = 0;
            Forms.PhoneSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.PhoneSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.PhoneSettings;
        }

        private void Form_Settings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_Time_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_Date_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void Button_RearCam_Click(object sender, EventArgs e)
        {
            if (SerialCOM1.API_GetCAMState() == true)
            {
                SerialCOM1.API_SetCAMState(0);
                MessageBox.Show("Камера выключена");
            }
            else
            {
                SerialCOM1.API_SetCAMState(1);
                MessageBox.Show("Камера включена");
            }
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            //Bluetooth.ShowWndSettings();
            Forms.Phone.Activate_Phone_Board();
        }
    }
}