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
    public partial class Form_AudioSettings : Form
    {
        Form_Main Main;

        public Form_AudioSettings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxImgSetting.Image = MMC_Res.Img_AudSettings;
            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;
            pictureBoxToncompensation.Image = MMC_Res.ImgTonCompensation;
            pictureBoxTembr.Image = MMC_Res.ImgSetTembr;

            BtnTembr1.State2 = MMC_Res.Tembr1On;
            BtnTembr1.State1 = MMC_Res.Tembr1Off;
            BtnTembr2.State2 = MMC_Res.Tembr2On;
            BtnTembr2.State1 = MMC_Res.Tembr2Off;
            BtnTembr3.State2 = MMC_Res.Tembr3On;
            BtnTembr3.State1 = MMC_Res.Tembr3Off;
            BtnTembr4.State2 = MMC_Res.Tembr4On;
            BtnTembr4.State1 = MMC_Res.Tembr4Off;
            BtnTembr5.State2 = MMC_Res.Tembr5On;
            BtnTembr5.State1 = MMC_Res.Tembr5Off;
            BtnTembr6.State2 = MMC_Res.Tembr6On;
            BtnTembr6.State1 = MMC_Res.Tembr6Off;

            BtnBassUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnBassUp.PressedImage = MMC_Res.BtnUpOn;
            BtnBassUp.NotActive = MMC_Res.BtnUpDis;

            BtnBassDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnBassDown.PressedImage = MMC_Res.BtnDownOn;
            BtnBassDown.NotActive = MMC_Res.BtnDownDis;

            BtnMiddleUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnMiddleUp.PressedImage = MMC_Res.BtnUpOn;
            BtnMiddleUp.NotActive = MMC_Res.BtnUpDis;

            BtnMiddleDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnMiddleDown.PressedImage = MMC_Res.BtnDownOn;
            BtnMiddleDown.NotActive = MMC_Res.BtnDownDis;

            BtnTrebleUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnTrebleUp.PressedImage = MMC_Res.BtnUpOn;
            BtnTrebleUp.NotActive = MMC_Res.BtnUpDis;

            BtnTrebleDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnTrebleDown.PressedImage = MMC_Res.BtnDownOn;
            BtnTrebleDown.NotActive = MMC_Res.BtnDownDis;

            BtnLoud.State1 = MMC_Res.Btn_SelectOff;
            BtnLoud.State2 = MMC_Res.Btn_SelectOn;

            if (MMC_Data.LoudTone == 0) BtnLoudTone.BackGndImage = MMC_Res.LoudToneDirect;
            if (MMC_Data.LoudTone == 1) BtnLoudTone.BackGndImage = MMC_Res.LoudTone400;
            if (MMC_Data.LoudTone == 2) BtnLoudTone.BackGndImage = MMC_Res.LoudTone800;
            if (MMC_Data.LoudTone == 3) BtnLoudTone.BackGndImage = MMC_Res.LoudTone24;

            if (MMC_Data.TrebleCFre == 0) BtnTrebleCFre.BackGndImage = MMC_Res._10kHz;
            if (MMC_Data.TrebleCFre == 1) BtnTrebleCFre.BackGndImage = MMC_Res._12_5kHz;
            if (MMC_Data.TrebleCFre == 2) BtnTrebleCFre.BackGndImage = MMC_Res._15kHz;
            if (MMC_Data.TrebleCFre == 3) BtnTrebleCFre.BackGndImage = MMC_Res._17_5kHz;

            if (MMC_Data.MiddleCFre == 0) BtnMiddleCFre.BackGndImage = MMC_Res._0_5kHz;
            if (MMC_Data.MiddleCFre == 1) BtnMiddleCFre.BackGndImage = MMC_Res._1kHz;
            if (MMC_Data.MiddleCFre == 2) BtnMiddleCFre.BackGndImage = MMC_Res._1_5kHz;
            if (MMC_Data.MiddleCFre == 3) BtnMiddleCFre.BackGndImage = MMC_Res._2_5kHz;

            if (MMC_Data.BassCFre == 0) BtnBassCFre.BackGndImage = MMC_Res._60Hz;
            if (MMC_Data.BassCFre == 1) BtnBassCFre.BackGndImage = MMC_Res._80Hz;
            if (MMC_Data.BassCFre == 2) BtnBassCFre.BackGndImage = MMC_Res._100Hz;
            if (MMC_Data.BassCFre == 3) BtnBassCFre.BackGndImage = MMC_Res._200Hz;

            if (MMC_Data.MiddleQ == 0) BtnMiddleQ.BackGndImage = MMC_Res._0_5;
            if (MMC_Data.MiddleQ == 1) BtnMiddleQ.BackGndImage = MMC_Res._0_75;
            if (MMC_Data.MiddleQ == 2) BtnMiddleQ.BackGndImage = MMC_Res._1_0;
            if (MMC_Data.MiddleQ == 3) BtnMiddleQ.BackGndImage = MMC_Res._1_25;

            if (MMC_Data.BassQ == 0) BtnBassQ.BackGndImage = MMC_Res._1_0;
            if (MMC_Data.BassQ == 1) BtnBassQ.BackGndImage = MMC_Res._1_25;
            if (MMC_Data.BassQ == 2) BtnBassQ.BackGndImage = MMC_Res._1_5;
            if (MMC_Data.BassQ == 3) BtnBassQ.BackGndImage = MMC_Res._2_0;


            trackBarAudioSettings1.TrackBarAudioSettingsValueChanged +=
               new EventHandler(trackBarAudioSettings1_TrackBarAudioSettingsValueChanged);
            trackBarAudioSettings2.TrackBarAudioSettingsValueChanged +=
                new EventHandler(trackBarAudioSettings2_TrackBarAudioSettingsValueChanged);
            trackBarAudioSettings3.TrackBarAudioSettingsValueChanged +=
                new EventHandler(trackBarAudioSettings3_TrackBarAudioSettingsValueChanged);
        }

        private void Form_AudioSettings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;

            switch (MMC_Data.AudioMode)
            {
                case 1:
                    BtnTembr1.State = true;
                    break;
                case 2:
                    BtnTembr2.State = true;
                    break;
                case 3:
                    BtnTembr3.State = true;
                    break;
                case 4:
                    BtnTembr4.State = true;
                    break;
                case 5:
                    BtnTembr5.State = true;
                    break;
                case 6:
                    BtnTembr6.State = true;
                    break;
                default:
                    BtnTembr6.State = true;
                    break;
            }

            if (MMC_Data.Loud) BtnLoud.State = true;
            SetButton(MMC_Data.AudioMode);
        }

        // Изменение прогресстрекбара
        void trackBarAudioSettings1_TrackBarAudioSettingsValueChanged(object sender, EventArgs e)
        {
            if (MMC_Data.AudioMode == 6)
            {
                //Установка значения в прогрессбар
                TrackBarAudioSettings ptb = (TrackBarAudioSettings)sender;
                MMC_Data.Bass = ptb.TrackBarValue;
                SerialCOM1.Aud_SetBass(MMC_Data.Bass);
                trackBarAudioSettings1.Value = MMC_Data.Bass;
                BassBtnService();
            }
        }

        // Изменение прогресстрекбара
        void trackBarAudioSettings2_TrackBarAudioSettingsValueChanged(object sender, EventArgs e)
        {
            if (MMC_Data.AudioMode == 6)
            {
                //Установка значения в прогрессбар
                TrackBarAudioSettings ptb = (TrackBarAudioSettings)sender;
                MMC_Data.Middle = ptb.TrackBarValue;
                SerialCOM1.Aud_SetMid(MMC_Data.Middle);
                trackBarAudioSettings2.Value = MMC_Data.Middle;
                MiddleBtnService();
            }
        }

        // Изменение прогресстрекбара
        void trackBarAudioSettings3_TrackBarAudioSettingsValueChanged(object sender, EventArgs e)
        {
            if (MMC_Data.AudioMode == 6)
            {
                //Установка значения в прогрессбар
                TrackBarAudioSettings ptb = (TrackBarAudioSettings)sender;
                MMC_Data.Treble = ptb.TrackBarValue;
                SerialCOM1.Aud_SetTreble(MMC_Data.Treble);
                trackBarAudioSettings3.Value = MMC_Data.Treble;
                TrebleBtnService();
            }
        }

        private void BassBtnService()
        {
            if (MMC_Data.AudioMode == 6)
            {
                if (MMC_Data.Bass <= -14) BtnBassDown.Active = false;
                else BtnBassDown.Active = true;

                if (MMC_Data.Bass >= 14) BtnBassUp.Active = false;
                else BtnBassUp.Active = true;
            }
            else
            {
                BtnBassDown.Active = false;
                BtnBassUp.Active = false;
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void MiddleBtnService()
        {
            if (MMC_Data.AudioMode == 6)
            {
                if (MMC_Data.Middle <= -14) BtnMiddleDown.Active = false;
                else BtnMiddleDown.Active = true;

                if (MMC_Data.Middle >= 14) BtnMiddleUp.Active = false;
                else BtnMiddleUp.Active = true;
            }
            else
            {
                BtnMiddleDown.Active = false;
                BtnMiddleUp.Active = false;
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void TrebleBtnService()
        {
            if (MMC_Data.AudioMode == 6)
            {
                if (MMC_Data.Treble <= -14) BtnTrebleDown.Active = false;
                else BtnTrebleDown.Active = true;

                if (MMC_Data.Treble >= 14) BtnTrebleUp.Active = false;
                else BtnTrebleUp.Active = true;
            }
            else
            {
                BtnTrebleDown.Active = false;
                BtnTrebleUp.Active = false;
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Player_AudioSettings:
                    Forms.Player.Left = 0;
                    Forms.Player.Top = 0;
                    Forms.Player.Activate();
                    Vars.FormActivated = Vars.Form_Active.Player;
                    break;
                case Vars.Form_Active.Radio_AudioSettings:
                    Forms.Radio.Left = 0;
                    Forms.Radio.Top = 0;
                    Forms.Radio.Activate();
                    Vars.FormActivated = Vars.Form_Active.Radio;
                    break;
                case Vars.Form_Active.PlayerPhone_AudioSettings:
                    Forms.PlayerPhone.Left = 0;
                    Forms.PlayerPhone.Top = 0;
                    Forms.PlayerPhone.Activate();
                    Vars.FormActivated = Vars.Form_Active.PlayerPhone;
                    break;
                default:
                    Forms.Settings.Left = 0;
                    Forms.Settings.Top = 0;
                    Forms.Settings.Activate();
                    Vars.FormActivated = Vars.Form_Active.Settings;
                    break;
            }

            this.Left = 801;
            this.Top = 481;
        }

        private void BtnBassUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Bass < 14)
            {
                MMC_Data.Bass++;
                SerialCOM1.Aud_SetBass(MMC_Data.Bass);
                trackBarAudioSettings1.Value = MMC_Data.Bass;
            }
            BassBtnService();
        }

        private void BtnBassDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Bass > -14)
            {
                MMC_Data.Bass--;
                SerialCOM1.Aud_SetBass(MMC_Data.Bass);
                trackBarAudioSettings1.Value = MMC_Data.Bass;
            }
            BassBtnService();
        }

        private void BtnMiddleUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Middle < 14)
            {
                MMC_Data.Middle++;
                SerialCOM1.Aud_SetMid(MMC_Data.Middle);
                trackBarAudioSettings2.Value = MMC_Data.Middle;
            }
            MiddleBtnService();
        }

        private void BtnMiddleDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Middle > -14)
            {
                MMC_Data.Middle--;
                SerialCOM1.Aud_SetMid(MMC_Data.Middle);
                trackBarAudioSettings2.Value = MMC_Data.Middle;
            }
            MiddleBtnService();
        }

        private void BtnTrebleUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Treble < 14)
            {
                MMC_Data.Treble++;
                SerialCOM1.Aud_SetTreble(MMC_Data.Treble);
                trackBarAudioSettings3.Value = MMC_Data.Treble;
            }
            TrebleBtnService();
        }

        private void BtnTrebleDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Treble > -14)
            {
                MMC_Data.Treble--;
                SerialCOM1.Aud_SetTreble(MMC_Data.Treble);
                trackBarAudioSettings3.Value = MMC_Data.Treble;
            }
            TrebleBtnService();
        }

        private void BtnTembr1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = true;
            BtnTembr2.State = false;
            BtnTembr3.State = false;
            BtnTembr4.State = false;
            BtnTembr5.State = false;
            BtnTembr6.State = false;
            MMC_Data.AudioMode = 1;

            SetButton(MMC_Data.AudioMode);
        }

        private void BtnTembr2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = false;
            BtnTembr2.State = true;
            BtnTembr3.State = false;
            BtnTembr4.State = false;
            BtnTembr5.State = false;
            BtnTembr6.State = false;
            MMC_Data.AudioMode = 2;

            SetButton(MMC_Data.AudioMode);
        }

        private void BtnTembr3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = false;
            BtnTembr2.State = false;
            BtnTembr3.State = true;
            BtnTembr4.State = false;
            BtnTembr5.State = false;
            BtnTembr6.State = false;
            MMC_Data.AudioMode = 3;

            SetButton(MMC_Data.AudioMode);
        }

        private void BtnTembr4_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = false;
            BtnTembr2.State = false;
            BtnTembr3.State = false;
            BtnTembr4.State = true;
            BtnTembr5.State = false;
            BtnTembr6.State = false;
            MMC_Data.AudioMode = 4;

            SetButton(MMC_Data.AudioMode);
        }

        private void BtnTembr5_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = false;
            BtnTembr2.State = false;
            BtnTembr3.State = false;
            BtnTembr4.State = false;
            BtnTembr5.State = true;
            BtnTembr6.State = false;
            MMC_Data.AudioMode = 5;

            SetButton(MMC_Data.AudioMode);
        }

        private void BtnTembr6_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            BtnTembr1.State = false;
            BtnTembr2.State = false;
            BtnTembr3.State = false;
            BtnTembr4.State = false;
            BtnTembr5.State = false;
            BtnTembr6.State = true;
            MMC_Data.AudioMode = 6;

            SetButton(MMC_Data.AudioMode);
        }

        private void _SetTembr(int bass, int middle, int treble)
        {
            SerialCOM1.Aud_SetBass(bass);
            SerialCOM1.Aud_SetMid(middle);
            SerialCOM1.Aud_SetTreble(treble);
            trackBarAudioSettings1.Value = bass;
            trackBarAudioSettings2.Value = middle;
            trackBarAudioSettings3.Value = treble;
        }

        private void SetButton(int audiomode)
        {
            switch (audiomode)
            {
                case 1:
                    _SetTembr(4, 4, 2);
                    break;
                case 2:
                    _SetTembr(2, 3, 6);
                    break;
                case 3:
                    _SetTembr(1, 2, 7);
                    break;
                case 4:
                    _SetTembr(2, 5, 7);
                    break;
                case 5:
                    _SetTembr(0, 3, 2);
                    break;
                case 6:
                    _SetTembr(MMC_Data.Bass, MMC_Data.Middle, MMC_Data.Treble);
                    break;
                default:
                    _SetTembr(0, 0, 0);
                    break;
            }

            if (audiomode > 0 && audiomode < 6)
            {
                trackBarAudioSettings1.pictureBox2.Image = MMC_Res.PolzunVertOff;
                trackBarAudioSettings2.pictureBox2.Image = MMC_Res.PolzunVertOff;
                trackBarAudioSettings3.pictureBox2.Image = MMC_Res.PolzunVertOff;

                BtnBassUp.Active = false;
                BtnBassDown.Active = false;
                BtnMiddleUp.Active = false;
                BtnMiddleDown.Active = false;
                BtnTrebleUp.Active = false;
                BtnTrebleDown.Active = false;
            }
            else
            {
                trackBarAudioSettings1.pictureBox2.Image = MMC_Res.PolzunVert;
                trackBarAudioSettings2.pictureBox2.Image = MMC_Res.PolzunVert;
                trackBarAudioSettings3.pictureBox2.Image = MMC_Res.PolzunVert;

                BassBtnService();
                MiddleBtnService();
                TrebleBtnService();
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnLoud_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Loud)
            {
                BtnLoud.State = false;
                MMC_Data.Loud = false;
                SerialCOM1.Aud_SetLoud(MMC_Data.Loud);
            }
            else
            {
                BtnLoud.State = true;
                MMC_Data.Loud = true;
                SerialCOM1.Aud_SetLoud(MMC_Data.Loud);
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }


        private void Form_AudioSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxToncompensation_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarAudioSettings1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarAudioSettings2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarAudioSettings3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxTembr_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Form_AudioSettings_Closing(object sender, CancelEventArgs e)
        {
            trackBarAudioSettings1.TrackBarAudioSettingsValueChanged -=
               new EventHandler(trackBarAudioSettings1_TrackBarAudioSettingsValueChanged);
            trackBarAudioSettings2.TrackBarAudioSettingsValueChanged -=
                new EventHandler(trackBarAudioSettings2_TrackBarAudioSettingsValueChanged);
            trackBarAudioSettings3.TrackBarAudioSettingsValueChanged -=
                new EventHandler(trackBarAudioSettings3_TrackBarAudioSettingsValueChanged);
        }

        private void BtnLoudTone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.LoudTone == 3)
	            {
	                MMC_Data.LoudTone = 0;
	            }
            else
	            {
	                MMC_Data.LoudTone += 1;
	            }
	
            if (MMC_Data.LoudTone == 0)
	        {
	        //LoudCF, Direct
                BtnLoudTone.BackGndImage = MMC_Res.LoudToneDirect;

                MMC_Data.LoudTone = 0;
                SerialCOM1.Aud_SetLoudCFre(MMC_Data.LoudTone);
	        }
	        if (MMC_Data.LoudTone == 1)
	        {
	        //LoudCF, 400Hz
                BtnLoudTone.BackGndImage = MMC_Res.LoudTone400;

                MMC_Data.LoudTone = 1;
                SerialCOM1.Aud_SetLoudCFre(MMC_Data.LoudTone);
	        }
	        if (MMC_Data.LoudTone == 2)
	        {
	        //LoudCF, 800Hz
                BtnLoudTone.BackGndImage = MMC_Res.LoudTone800;

                MMC_Data.LoudTone = 2;
                SerialCOM1.Aud_SetLoudCFre(MMC_Data.LoudTone);
	        }
	        if (MMC_Data.LoudTone == 3)
	        {
	        //LoudCF, 2,4kHz
                BtnLoudTone.BackGndImage = MMC_Res.LoudTone24;

                MMC_Data.LoudTone = 3;
                SerialCOM1.Aud_SetLoudCFre(MMC_Data.LoudTone);
	        }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void Button_Balance_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.AudioSettingsBalance.Left = 0;
            Forms.AudioSettingsBalance.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettingsBalance.Activate();
            Vars.FormActivated = Vars.Form_Active.AudioSettingsBalance;
        }

        private void BtnTrebleCFre_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.TrebleCFre == 3)
            {
                MMC_Data.TrebleCFre = 0;
            }
            else
            {
                MMC_Data.TrebleCFre += 1;
            }

            if (MMC_Data.TrebleCFre == 0)
            {
                //TrebleCFre, 10kHz
                BtnTrebleCFre.BackGndImage = MMC_Res._10kHz;

                MMC_Data.TrebleCFre = 0;
                SerialCOM1.Aud_SetTrebleCFre(MMC_Data.TrebleCFre);
            }
            if (MMC_Data.TrebleCFre == 1)
            {
                //TrebleCFre, 12.5kHz
                BtnTrebleCFre.BackGndImage = MMC_Res._12_5kHz;

                MMC_Data.TrebleCFre = 1;
                SerialCOM1.Aud_SetTrebleCFre(MMC_Data.TrebleCFre);
            }
            if (MMC_Data.TrebleCFre == 2)
            {
                //TrebleCFre, 15kHz
                BtnTrebleCFre.BackGndImage = MMC_Res._15kHz;

                MMC_Data.TrebleCFre = 2;
                SerialCOM1.Aud_SetTrebleCFre(MMC_Data.TrebleCFre);
            }
            if (MMC_Data.TrebleCFre == 3)
            {
                //TrebleCFre, 17.5kHz
                BtnTrebleCFre.BackGndImage = MMC_Res._17_5kHz;

                MMC_Data.TrebleCFre = 3;
                SerialCOM1.Aud_SetTrebleCFre(MMC_Data.TrebleCFre);
            }
            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnMiddleCFre_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.MiddleCFre == 3)
            {
                MMC_Data.MiddleCFre = 0;
            }
            else
            {
                MMC_Data.MiddleCFre += 1;
            }

            if (MMC_Data.MiddleCFre == 0)
            {
                //MiddleCFre, 0.5kHz
                BtnMiddleCFre.BackGndImage = MMC_Res._0_5kHz;

                MMC_Data.MiddleCFre = 0;
                SerialCOM1.Aud_SetMiddleCFre(MMC_Data.MiddleCFre);
            }
            if (MMC_Data.MiddleCFre == 1)
            {
                //MiddleCFre, 1kHz
                BtnMiddleCFre.BackGndImage = MMC_Res._1kHz;

                MMC_Data.MiddleCFre = 1;
                SerialCOM1.Aud_SetMiddleCFre(MMC_Data.MiddleCFre);
            }
            if (MMC_Data.MiddleCFre == 2)
            {
                //MiddleCFre, 1.5kHz
                BtnMiddleCFre.BackGndImage = MMC_Res._1_5kHz;

                MMC_Data.MiddleCFre = 2;
                SerialCOM1.Aud_SetMiddleCFre(MMC_Data.MiddleCFre);
            }
            if (MMC_Data.MiddleCFre == 3)
            {
                //MiddleCFre, 2.5kHz
                BtnMiddleCFre.BackGndImage = MMC_Res._2_5kHz;

                MMC_Data.MiddleCFre = 3;
                SerialCOM1.Aud_SetMiddleCFre(MMC_Data.MiddleCFre);
            }
            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnBassCFre_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.BassCFre == 3)
            {
                MMC_Data.BassCFre = 0;
            }
            else
            {
                MMC_Data.BassCFre += 1;
            }

            if (MMC_Data.BassCFre == 0)
            {
                //BassCFre, 60Hz
                BtnBassCFre.BackGndImage = MMC_Res._60Hz;

                MMC_Data.BassCFre = 0;
                SerialCOM1.Aud_SetBassCFre(MMC_Data.BassCFre);
            }
            if (MMC_Data.BassCFre == 1)
            {
                //BassCFre, 80Hz
                BtnBassCFre.BackGndImage = MMC_Res._80Hz;

                MMC_Data.BassCFre = 1;
                SerialCOM1.Aud_SetBassCFre(MMC_Data.BassCFre);
            }
            if (MMC_Data.BassCFre == 2)
            {
                //BassCFre, 100Hz
                BtnBassCFre.BackGndImage = MMC_Res._100Hz;

                MMC_Data.BassCFre = 2;
                SerialCOM1.Aud_SetBassCFre(MMC_Data.BassCFre);
            }
            if (MMC_Data.BassCFre == 3)
            {
                //BassCFre, 200Hz
                BtnBassCFre.BackGndImage = MMC_Res._200Hz;

                MMC_Data.BassCFre = 3;
                SerialCOM1.Aud_SetBassCFre(MMC_Data.BassCFre);
            }
            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnMiddleQ_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.MiddleQ == 3)
            {
                MMC_Data.MiddleQ = 0;
            }
            else
            {
                MMC_Data.MiddleQ += 1;
            }

            if (MMC_Data.MiddleQ == 0)
            {
                //MiddleQ, 0.5
                BtnMiddleQ.BackGndImage = MMC_Res._0_5;

                MMC_Data.MiddleQ = 0;
                SerialCOM1.Aud_SetMiddleQ(MMC_Data.MiddleQ);
            }
            if (MMC_Data.MiddleQ == 1)
            {
                //MiddleQ, 0.75
                BtnMiddleQ.BackGndImage = MMC_Res._0_75;

                MMC_Data.MiddleQ = 1;
                SerialCOM1.Aud_SetMiddleQ(MMC_Data.MiddleQ);
            }
            if (MMC_Data.MiddleQ == 2)
            {
                //MiddleQ, 1.0
                BtnMiddleQ.BackGndImage = MMC_Res._1_0;

                MMC_Data.MiddleQ = 2;
                SerialCOM1.Aud_SetMiddleQ(MMC_Data.MiddleQ);
            }
            if (MMC_Data.MiddleQ == 3)
            {
                //MiddleQ, 1.25
                BtnMiddleQ.BackGndImage = MMC_Res._1_25;

                MMC_Data.MiddleQ = 3;
                SerialCOM1.Aud_SetMiddleQ(MMC_Data.MiddleQ);
            }
            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnBassQ_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.BassQ == 3)
            {
                MMC_Data.BassQ = 0;
            }
            else
            {
                MMC_Data.BassQ += 1;
            }

            if (MMC_Data.BassQ == 0)
            {
                //BassQ, 1.0
                BtnBassQ.BackGndImage = MMC_Res._1_0;

                MMC_Data.BassQ = 0;
                SerialCOM1.Aud_SetBassQ(MMC_Data.BassQ);
            }
            if (MMC_Data.BassQ == 1)
            {
                //BassQ, 1.25
                BtnBassQ.BackGndImage = MMC_Res._1_25;

                MMC_Data.BassQ = 1;
                SerialCOM1.Aud_SetBassQ(MMC_Data.BassQ);
            }
            if (MMC_Data.BassQ == 2)
            {
                //BassQ, 1.5
                BtnBassQ.BackGndImage = MMC_Res._1_5;

                MMC_Data.BassQ = 2;
                SerialCOM1.Aud_SetBassQ(MMC_Data.BassQ);
            }
            if (MMC_Data.BassQ == 3)
            {
                //BassQ, 2.0
                BtnBassQ.BackGndImage = MMC_Res._2_0;

                MMC_Data.BassQ = 3;
                SerialCOM1.Aud_SetBassQ(MMC_Data.BassQ);
            }
            // Запись настроек
            MMC_Data.WriteSetting();
        }
    }
}