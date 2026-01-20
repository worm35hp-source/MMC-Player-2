using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;
using Un4seen.Bass;
using Service;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_PlayerPhone : Form
    {
        Form_Main Main;

        public Form_PlayerPhone(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            Img_Border.Image = MMC_Res.Border;
            pictureBox_ImgTag.Image = MMC_Res.Img_TagAudioBT;
            Img_LineButton.Image = MMC_Res.LineButton;

            Button_Back.BackGndImage = MMC_Res.AudBtnBackOff;
            Button_Back.PressedImage = MMC_Res.AudBtnBackOn;

            Button_PrevTrack.BackGndImage = MMC_Res.AudBtnPrevTrackOff;
            Button_PrevTrack.PressedImage = MMC_Res.AudBtnPrevTrackOn;
            Button_PrevTrack.NotActive = MMC_Res.AudBtnPrevTrackDis;

            Button_Play.BackGndImage = MMC_Res.AudBtnPlayOff;
            Button_Play.PressedImage = MMC_Res.AudBtnPlayOn;

            Button_Pause.BackGndImage = MMC_Res.AudBtnPauseOff;
            Button_Pause.PressedImage = MMC_Res.AudBtnPauseOn;

            Button_FwdTrack.BackGndImage = MMC_Res.AudBtnFwdTrackOff;
            Button_FwdTrack.PressedImage = MMC_Res.AudBtnFwdTrackOn;
            Button_FwdTrack.NotActive = MMC_Res.AudBtnFwdTrackDis;

            //BtnAudioSet.BackGndImage = MMC_Res.AudBtnPlayerAudioSet;
            //BtnAudioSet.PressedImage = MMC_Res.AudBtnPlayerAudioSet;

            BtnAudioSet2.BackGndImage = MMC_Res.EQBtnOff;
            BtnAudioSet2.PressedImage = MMC_Res.EQBtnOn;
        }

        //public void SendMessage(int Message, int wParam, int lParam)
        //{
        //    // Формируем сообщение
        //    Microsoft.WindowsCE.Forms.Message mes = Microsoft.WindowsCE.Forms.Message.Create(new IntPtr(0xFFFF), Message, new IntPtr(wParam), new IntPtr(lParam));
        //    // Отправляем
        //    Microsoft.WindowsCE.Forms.MessageWindow.SendMessage(ref mes);
        //}

        //public void PostMessage(int Message, int wParam, int lParam)
        //{
        //    // Формируем сообщение
        //    Microsoft.WindowsCE.Forms.Message mes = Microsoft.WindowsCE.Forms.Message.Create(new IntPtr(0xFFFF), Message, new IntPtr(wParam), new IntPtr(lParam));
        //    // Отправляем
        //    Microsoft.WindowsCE.Forms.MessageWindow.PostMessage(ref mes);
        //}

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            timer_Exit.Enabled = false;

            Forms.Phone.Left = 0;
            Forms.Phone.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.Phone.Activate();
            Vars.FormActivated = Vars.Form_Active.Phone;

            //Button_Pause.Visible = false;
            //Button_Play.Visible = true;
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 3, 0);
            //SerialCOM1.Api_SetActivateMode(1);
            //SerialCOM1.Api_SetBTMuteState(1);
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 2, 0);
        }

        private void Button_PrevTrack_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 5, 0);
            //Bluetooth.AVRCPCmd(5);
            BtDll.AVRCPCmd(5);
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Button_Pause.Visible = false;
            Button_Play.Visible = true;
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 2, 0);
            //Bluetooth.AVRCPCmd(2);
            BtDll.AVRCPCmd(2);
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Button_Pause.Visible = true;
            Button_Play.Visible = false;
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 1, 0);
            //Bluetooth.AVRCPCmd(1);
            BtDll.AVRCPCmd(1);
        }

        private void Button_FwdTrack_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 4, 0);
            //Bluetooth.AVRCPCmd(4);
            BtDll.AVRCPCmd(4);
        }

        private void BtnAudioSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            Forms.AudioSettings.Left = 0;
            Forms.AudioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.PlayerPhone_AudioSettings;
        }

        private void Form_PlayerPhone_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void label_artist_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_trackname_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void timer_Exit_Tick(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            timer_Exit.Enabled = false;

            SerialCOM1.Api_SetActivateMode(1);
            Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
            //Bluetooth.AVRCPCmd(2);
            BtDll.AVRCPCmd(2);
            //Bluetooth.Mute(1);
            BtDll.Mute(1);
            Button_Back_Click(sender, e);
        }

        private void Button_Back_MouseDown(object sender, MouseEventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            timer_Exit.Enabled = true;
        }
    }
}