using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;
using System.Diagnostics;
using Service;
using Microsoft.Win32;
//using System.Runtime.InteropServices;
using Microsoft.WindowsCE.Forms;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_Dial : Form
    {
        Form_Main Main;

        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);
        Font font_PhoneNumber = new Font("Itelma_Kor", 14F, FontStyle.Regular);

        //public IntPtr ptr = new IntPtr(0xFFFF);
        //Microsoft.WindowsCE.Forms.Message mes;

        public Form_Dial(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            pictureBoxDial_backgnd.Image = MMC_Res.Dial_backgnd;

            BtnMicMute.State1 = MMC_Res.Dial_MicMuteOff;
            BtnMicMute.State2 = MMC_Res.Dial_MicMuteOn;

            BtnHandsFree.State1 = MMC_Res.Dial_HandsFreeOff;
            BtnHandsFree.State2 = MMC_Res.Dial_HandsFreeOn;

            BtnAnswer.BackGndImage = MMC_Res.Dial_DialOff;
            BtnAnswer.PressedImage = MMC_Res.Dial_DialOn;
            BtnAnswer.NotActive = MMC_Res.Dial_DialOn;

            BtnReject.BackGndImage = MMC_Res.Dial_RejectOff;
            BtnReject.PressedImage = MMC_Res.Dial_RejectOn;

            label_Time.Font = font_systime;
            label_Date.Font = font_sysdate;
            label_PhoneNumber_1.Font = font_PhoneNumber;
        }

        private void Form_Dial_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            BtDll.Answer();
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (BtDll.m_callstate == 5)
            {
                BtDll.Reject();
            }
            else
            {
                BtDll.Terminate();
            }
        }

        private void BtnHandsFree_Click(object sender, EventArgs e)
        {
            if (BtDll.m_out_path == 1)
            //if (Bluetooth.HandsFreeStatus)
            {
                //Bluetooth.HandsFreeStatus = false;
                //BtDll.m_out_path = 0;
                BtnHandsFree.State = true;
                Forms.Phone.BtnHandsFree.State = 3;
                //Bluetooth.VoiceOutPath(0);
                BtDll.VoiceOutPath(0);
            }
            else
            {
                //Bluetooth.HandsFreeStatus = true;
                //BtDll.m_handsfreestatus = 1;
                BtnHandsFree.State = false;
                Forms.Phone.BtnHandsFree.State = 2;
                //Bluetooth.VoiceOutPath(1);
                BtDll.VoiceOutPath(1);
            }
        }

        private void BtnMicMute_Click(object sender, EventArgs e)
        {
            if (BtDll.m_callstate == 6)
            {
                //Bluetooth.Mute(0);
                if (BtDll.m_out_mute_state == 0)
                    BtDll.Mute(1);
                else
                    BtDll.Mute(0);
            }
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
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

        private void label_LevelFuel_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_temp_coolingwater_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }
    }
}