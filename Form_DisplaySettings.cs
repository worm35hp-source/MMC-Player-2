using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

using MMC_Resources;
using System.IO;
using Service;

namespace MMC_Player_2
{
    public partial class Form_DisplaySettings : Form
    {
        Form_Main Main;

        [DllImport("coredll")]
        private static extern bool TouchCalibrate();


        public Form_DisplaySettings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxImgSetting.Image = MMC_Res.Img_DispSet;
            pictureBoxColorTable.Image = MMC_Res.Img_Disp_ColorTable;
            pictureBoxCalibration.Image = MMC_Res.Img_Disp_Calibration;
            pictureBoxDayNight.Image = MMC_Res.Img_Disp_Day_Night;
            pictureBoxColorSet.Image = MMC_Res.Img_Disp_ColorSet;

            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;

            ButtonCalibration.BackGndImage = MMC_Res.Disp_Calibration_Off;
            ButtonCalibration.PressedImage = MMC_Res.Disp_Calibration_On;

            BtnBrightLeft.BackGndImage = MMC_Res.BtnLeftOff;
            BtnBrightLeft.PressedImage = MMC_Res.BtnLeftOn;
            BtnBrightLeft.NotActive = MMC_Res.BtnLeftDis;

            BtnBrightRight.BackGndImage = MMC_Res.BtnRightOff;
            BtnBrightRight.PressedImage = MMC_Res.BtnRightOn;
            BtnBrightRight.NotActive = MMC_Res.BtnRightDis;

            BtnContrastLeft.BackGndImage = MMC_Res.BtnLeftOff;
            BtnContrastLeft.PressedImage = MMC_Res.BtnLeftOn;
            BtnContrastLeft.NotActive = MMC_Res.BtnLeftDis;

            BtnContrastRight.BackGndImage = MMC_Res.BtnRightOff;
            BtnContrastRight.PressedImage = MMC_Res.BtnRightOn;
            BtnContrastRight.NotActive = MMC_Res.BtnRightDis;

            BtnColorLeft.BackGndImage = MMC_Res.BtnLeftOff;
            BtnColorLeft.PressedImage = MMC_Res.BtnLeftOn;
            BtnColorLeft.NotActive = MMC_Res.BtnLeftDis;

            BtnColorRight.BackGndImage = MMC_Res.BtnRightOff;
            BtnColorRight.PressedImage = MMC_Res.BtnRightOn;
            BtnColorRight.NotActive = MMC_Res.BtnRightDis;

            BtnSelectDay.State1 = MMC_Res.Btn_SelectOff;
            BtnSelectDay.State2 = MMC_Res.Btn_SelectOn;
            BtnSelectNight.State1 = MMC_Res.Btn_SelectOff;
            BtnSelectNight.State2 = MMC_Res.Btn_SelectOn;
            BtnSelectAuto.State1 = MMC_Res.Btn_SelectOff;
            BtnSelectAuto.State2 = MMC_Res.Btn_SelectOn;

            trackBarDisplaySettings1.TrackBarDisplaySettingsValueChanged +=
                new EventHandler(trackBarDisplaySettings1_TrackBarDisplaySettingsValueChanged);
            trackBarDisplaySettings2.TrackBarDisplaySettingsValueChanged +=
                new EventHandler(trackBarDisplaySettings2_TrackBarDisplaySettingsValueChanged);
            trackBarDisplaySettings3.TrackBarDisplaySettingsValueChanged +=
                new EventHandler(trackBarDisplaySettings3_TrackBarDisplaySettingsValueChanged);
        }

        private void Form_DisplaySettings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;

            SelectDispModeColor();

            BrightBtnService();
            ContrastBtnService();
            ColorBtnService();
        }


        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            Forms.Settings.Left = 0;
            Forms.Settings.Top = 0;
            Forms.Settings.Activate();
            Vars.FormActivated = Vars.Form_Active.Settings;
            this.Left = 801;
            this.Top = 481;
        }

        // Изменение прогресстрекбара
        void trackBarDisplaySettings1_TrackBarDisplaySettingsValueChanged(object sender, EventArgs e)
        {
            //Установка значения в прогрессбар
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Bright_Day = ptb.TrackBarValue;
                SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                trackBarDisplaySettings1.Value = MMC_Data.Bright_Day;
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Bright_Night = ptb.TrackBarValue;
                SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                trackBarDisplaySettings1.Value = MMC_Data.Bright_Night;
            }
            BrightBtnService();
        }

        // Изменение прогресстрекбара
        void trackBarDisplaySettings2_TrackBarDisplaySettingsValueChanged(object sender, EventArgs e)
        {
            //Установка значения в прогрессбар
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Contrast_Day = ptb.TrackBarValue;
                SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                trackBarDisplaySettings2.Value = MMC_Data.Contrast_Day;
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Contrast_Night = ptb.TrackBarValue;
                SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                trackBarDisplaySettings2.Value = MMC_Data.Contrast_Night;
            }
            ContrastBtnService();
        }

        // Изменение прогресстрекбара
        void trackBarDisplaySettings3_TrackBarDisplaySettingsValueChanged(object sender, EventArgs e)
        {
            //Установка значения в прогрессбар
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Color_Day = ptb.TrackBarValue;
                SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                trackBarDisplaySettings3.Value = MMC_Data.Color_Day;
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                TrackBarDisplaySettings ptb = (TrackBarDisplaySettings)sender;
                MMC_Data.Color_Night = ptb.TrackBarValue;
                SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                trackBarDisplaySettings3.Value = MMC_Data.Color_Night;
            }
            ColorBtnService();
        }

        private void BrightBtnService()
        {
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                if (MMC_Data.Bright_Day <= 0) { BtnBrightLeft.Active = false; }
                else { BtnBrightLeft.Active = true; }

                if (MMC_Data.Bright_Day >= 60) { BtnBrightRight.Active = false; }
                else { BtnBrightRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                if (MMC_Data.Bright_Night <= 0) { BtnBrightLeft.Active = false; }
                else { BtnBrightLeft.Active = true; }

                if (MMC_Data.Bright_Night >= 60) { BtnBrightRight.Active = false; }
                else { BtnBrightRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
            {
                BtnBrightLeft.Active = false;
                BtnBrightRight.Active = false;
                trackBarDisplaySettings1.Value = 30;
            }
            
            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void ContrastBtnService()
        {
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                if (MMC_Data.Contrast_Day <= 0) { BtnContrastLeft.Active = false; }
                else { BtnContrastLeft.Active = true; }

                if (MMC_Data.Contrast_Day >= 60) { BtnContrastRight.Active = false; }
                else { BtnContrastRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                if (MMC_Data.Contrast_Night <= 0) { BtnContrastLeft.Active = false; }
                else { BtnContrastLeft.Active = true; }

                if (MMC_Data.Contrast_Night >= 60) { BtnContrastRight.Active = false; }
                else { BtnContrastRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
            {
                BtnContrastLeft.Active = false;
                BtnContrastRight.Active = false;
                trackBarDisplaySettings2.Value = 30;
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void ColorBtnService()
        {
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
            {
                if (MMC_Data.Color_Day <= 0) { BtnColorLeft.Active = false; }
                else { BtnColorLeft.Active = true; }

                if (MMC_Data.Color_Day >= 60) { BtnColorRight.Active = false; }
                else { BtnColorRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
            {
                if (MMC_Data.Color_Night <= 0) { BtnColorLeft.Active = false; }
                else { BtnColorLeft.Active = true; }

                if (MMC_Data.Color_Night >= 60) { BtnColorRight.Active = false; }
                else { BtnColorRight.Active = true; }
            }
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
            {
                BtnColorLeft.Active = false;
                BtnColorRight.Active = false;
                trackBarDisplaySettings3.Value = 30;
            }

            // Запись настроек
            MMC_Data.WriteSetting();
        }











        

        private void BtnBrightLeft_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnBrightLeft.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Bright_Day > 0)
                    {
                        MMC_Data.Bright_Day--;
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                        trackBarDisplaySettings1.Value = MMC_Data.Bright_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Bright_Night > 0)
                    {
                        MMC_Data.Bright_Night--;
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                        trackBarDisplaySettings1.Value = MMC_Data.Bright_Night;
                    }
                }

                BrightBtnService();
            }
        }

        private void BtnBrightRight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnBrightRight.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Bright_Day < 60)
                    {
                        MMC_Data.Bright_Day++;
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                        trackBarDisplaySettings1.Value = MMC_Data.Bright_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Bright_Night < 60)
                    {
                        MMC_Data.Bright_Night++;
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                        trackBarDisplaySettings1.Value = MMC_Data.Bright_Night;
                    }
                }

                BrightBtnService();
            }
        }

        private void BtnContrastLeft_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnContrastLeft.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Contrast_Day > 0)
                    {
                        MMC_Data.Contrast_Day--;
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                        trackBarDisplaySettings2.Value = MMC_Data.Contrast_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Contrast_Night > 0)
                    {
                        MMC_Data.Contrast_Night--;
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                        trackBarDisplaySettings2.Value = MMC_Data.Contrast_Night;
                    }
                }

                ContrastBtnService();
            }
        }

        private void BtnContrastRight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnContrastRight.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Contrast_Day < 60)
                    {
                        MMC_Data.Contrast_Day++;
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                        trackBarDisplaySettings2.Value = MMC_Data.Contrast_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Contrast_Night < 60)
                    {
                        MMC_Data.Contrast_Night++;
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                        trackBarDisplaySettings2.Value = MMC_Data.Contrast_Night;
                    }
                }

                ContrastBtnService();
            }
        }

        private void BtnColorLeft_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnColorLeft.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Color_Day > 0)
                    {
                        MMC_Data.Color_Day--;
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                        trackBarDisplaySettings3.Value = MMC_Data.Color_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Color_Night > 0)
                    {
                        MMC_Data.Color_Night--;
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                        trackBarDisplaySettings3.Value = MMC_Data.Color_Night;
                    }
                }

                ColorBtnService();
            }
        }

        private void BtnColorRight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnColorRight.Active)
            {
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day)
                {
                    if (MMC_Data.Color_Day < 60)
                    {
                        MMC_Data.Color_Day++;
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                        trackBarDisplaySettings3.Value = MMC_Data.Color_Day;
                    }
                }
                if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night)
                {
                    if (MMC_Data.Color_Night < 60)
                    {
                        MMC_Data.Color_Night++;
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                        trackBarDisplaySettings3.Value = MMC_Data.Color_Night;
                    }
                }

                ColorBtnService();
            }
        }

        private void BtnSelectDay_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            MMC_Data.DispModeColor = MMC_Data.LightMode.Day;
            SerialCOM1.Vid_SetLightMode((int)MMC_Data.DispModeColor);
            SelectDispModeColor();
            BrightBtnService();
            ContrastBtnService();
            ColorBtnService();
        }

        private void BtnSelectNight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            MMC_Data.DispModeColor = MMC_Data.LightMode.Night;
            SerialCOM1.Vid_SetLightMode((int)MMC_Data.DispModeColor);
            SelectDispModeColor();
            BrightBtnService();
            ContrastBtnService();
            ColorBtnService();
        }

        private void BtnSelectAuto_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            MMC_Data.DispModeColor = MMC_Data.LightMode.Auto;
            SerialCOM1.Vid_SetLightMode((int)MMC_Data.DispModeColor);
            SelectDispModeColor();
            BrightBtnService();
            ContrastBtnService();
            ColorBtnService();
        }

        // Загрузка настроек
        public void SelectDispModeColor()
        {
            switch (MMC_Data.DispModeColor)
            {
                case MMC_Data.LightMode.Day:
                    SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                    trackBarDisplaySettings1.Value = MMC_Data.Bright_Day;

                    SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                    trackBarDisplaySettings2.Value = MMC_Data.Contrast_Day;

                    SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                    trackBarDisplaySettings3.Value = MMC_Data.Color_Day;

                    BtnSelectDay.State = true;
                    BtnSelectNight.State = false;
                    BtnSelectAuto.State = false;
                    break;
                case MMC_Data.LightMode.Night:
                    SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                    trackBarDisplaySettings1.Value = MMC_Data.Bright_Night;

                    SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                    trackBarDisplaySettings2.Value = MMC_Data.Contrast_Night;

                    SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                    trackBarDisplaySettings3.Value = MMC_Data.Color_Night;

                    BtnSelectDay.State = false;
                    BtnSelectNight.State = true;
                    BtnSelectAuto.State = false;
                    break;
                case MMC_Data.LightMode.Auto:
                    if (Vars.Passing_Light || Vars.Distant_Light)
                    {
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                    }
                    else
                    {
                        SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                        SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                        SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                    }

                    BtnSelectDay.State = false;
                    BtnSelectNight.State = false;
                    BtnSelectAuto.State = true;
                    break;
                default:
                    break;
            }
        }

        private void Form_DisplaySettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxColorTable_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void ButtonCalibration_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            TouchCalibrate();
        }

        private void pictureBoxDayNight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxColorSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarDisplaySettings1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarDisplaySettings2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void trackBarDisplaySettings3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label5_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Form_DisplaySettings_Closing(object sender, CancelEventArgs e)
        {
            trackBarDisplaySettings1.TrackBarDisplaySettingsValueChanged -=
                new EventHandler(trackBarDisplaySettings1_TrackBarDisplaySettingsValueChanged);
            trackBarDisplaySettings2.TrackBarDisplaySettingsValueChanged -=
                new EventHandler(trackBarDisplaySettings2_TrackBarDisplaySettingsValueChanged);
            trackBarDisplaySettings3.TrackBarDisplaySettingsValueChanged -=
                new EventHandler(trackBarDisplaySettings3_TrackBarDisplaySettingsValueChanged);
        }
    }
}