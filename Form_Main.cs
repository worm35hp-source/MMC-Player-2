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
using System.Runtime.InteropServices;
using Microsoft.WindowsCE.Forms;
using System.IO;
using System.Diagnostics;

using System.Threading;

using Service;
using Can;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_Main : Form
    {
        [DllImport("coredll.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("coredll.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("coredll.dll")]
        static extern IntPtr FindWindow(String lpClassName, String lpWindowName);
        [DllImport("coredll.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        
        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);

        // Цвета
        Color Red = Color.FromArgb(255, 0, 0);
        Color Green = Color.FromArgb(174, 255, 199);
        Color Yellow = Color.FromArgb(255, 255, 0);
        Color Blue = Color.FromArgb(0, 128, 255);

        // Процесс Bluetooth
        //public Process pr;

        MsgWindow MsgWin;
        

        public void HideWindow()
        {
            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Audio:
                    Forms.Audio.Left = 801;
                    Forms.Audio.Top = 481;
                    break;
                case Vars.Form_Active.AudioSettings:
                    Forms.AudioSettings.Left = 801;
                    Forms.AudioSettings.Top = 481;
                    break;
                case Vars.Form_Active.DisplaySettings:
                    Forms.DisplaySettings.Left = 801;
                    Forms.DisplaySettings.Top = 481;
                    break;
                case Vars.Form_Active.GeneralSettings:
                    Forms.GeneralSettings.Left = 801;
                    Forms.GeneralSettings.Top = 481;
                    break;
                case Vars.Form_Active.Main:
                    this.Left = 801;
                    this.Top = 481;
                    break;
                case Vars.Form_Active.Phone:
                    Forms.Phone.Left = 801;
                    Forms.Phone.Top = 481;
                    break;
                case Vars.Form_Active.Phone_PhoneSettings:
                    Forms.PhoneSettings.Left = 801;
                    Forms.PhoneSettings.Top = 481;
                    break;
                case Vars.Form_Active.PhoneSettings:
                    Forms.PhoneSettings.Left = 801;
                    Forms.PhoneSettings.Top = 481;
                    break;
                case Vars.Form_Active.Player:
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    break;
                case Vars.Form_Active.Player_AudioSettings:
                    Forms.AudioSettings.Left = 801;
                    Forms.AudioSettings.Top = 481;
                    break;
                case Vars.Form_Active.Radio:
                    Forms.Radio.Left = 801;
                    Forms.Radio.Top = 481;
                    break;
                case Vars.Form_Active.Radio_AudioSettings:
                    Forms.AudioSettings.Left = 801;
                    Forms.AudioSettings.Top = 481;
                    break;
                case Vars.Form_Active.Radio_RadioSettings:
                    Forms.RadioSettings.Left = 801;
                    Forms.RadioSettings.Top = 481;
                    break;
                case Vars.Form_Active.RadioSettings:
                    Forms.RadioSettings.Left = 801;
                    Forms.RadioSettings.Top = 481;
                    break;
                case Vars.Form_Active.Settings:
                    Forms.Settings.Left = 801;
                    Forms.Settings.Top = 481;
                    break;
                case Vars.Form_Active.Dial:
                    Forms.Dial.Left = 801;
                    Forms.Dial.Top = 481;
                    break;
                case Vars.Form_Active.PlayerPhone:
                    Forms.PlayerPhone.Left = 801;
                    Forms.PlayerPhone.Top = 481;
                    break;
                default:
                    break;
            }
        }

        public void ShowWindow()
        {
            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Audio:
                    Forms.Audio.Left = 0;
                    Forms.Audio.Top = 0;
                    Forms.Audio.Activate();
                    break;
                case Vars.Form_Active.AudioSettings:
                    Forms.AudioSettings.Left = 0;
                    Forms.AudioSettings.Top = 0;
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.DisplaySettings:
                    Forms.DisplaySettings.Left = 0;
                    Forms.DisplaySettings.Top = 0;
                    Forms.DisplaySettings.Activate();
                    break;
                case Vars.Form_Active.GeneralSettings:
                    Forms.GeneralSettings.Left = 0;
                    Forms.GeneralSettings.Top = 0;
                    Forms.GeneralSettings.Activate();
                    break;
                case Vars.Form_Active.Main:
                    this.Left = 0;
                    this.Top = 0;
                    this.Activate();
                    break;
                case Vars.Form_Active.Phone:
                    Forms.Phone.Left = 0;
                    Forms.Phone.Top = 0;
                    Forms.Phone.Activate();
                    break;
                case Vars.Form_Active.Phone_PhoneSettings:
                    Forms.PhoneSettings.Left = 0;
                    Forms.PhoneSettings.Top = 0;
                    Forms.PhoneSettings.Activate();
                    break;
                case Vars.Form_Active.PhoneSettings:
                    Forms.PhoneSettings.Left = 0;
                    Forms.PhoneSettings.Top = 0;
                    Forms.PhoneSettings.Activate();
                    break;
                case Vars.Form_Active.Player:
                    Forms.Player.Left = 0;
                    Forms.Player.Top = 0;
                    Forms.Player.Activate();
                    break;
                case Vars.Form_Active.Player_AudioSettings:
                    Forms.AudioSettings.Left = 0;
                    Forms.AudioSettings.Top = 0;
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.Radio:
                    Forms.Radio.Left = 0;
                    Forms.Radio.Top = 0;
                    Forms.Radio.Activate();
                    break;
                case Vars.Form_Active.Radio_AudioSettings:
                    Forms.AudioSettings.Left = 0;
                    Forms.AudioSettings.Top = 0;
                    Forms.AudioSettings.Activate();
                    break;
                case Vars.Form_Active.Radio_RadioSettings:
                    Forms.RadioSettings.Left = 0;
                    Forms.RadioSettings.Top = 0;
                    Forms.RadioSettings.Activate();
                    break;
                case Vars.Form_Active.RadioSettings:
                    Forms.RadioSettings.Left = 0;
                    Forms.RadioSettings.Top = 0;
                    Forms.RadioSettings.Activate();
                    break;
                case Vars.Form_Active.Settings:
                    Forms.Settings.Left = 0;
                    Forms.Settings.Top = 0;
                    Forms.Settings.Activate();
                    break;
                case Vars.Form_Active.Dial:
                    Forms.Dial.Left = 0;
                    Forms.Dial.Top = 0;
                    Forms.Dial.Activate();
                    break;
                case Vars.Form_Active.PlayerPhone:
                    Forms.PlayerPhone.Left = 0;
                    Forms.PlayerPhone.Top = 0;
                    Forms.PlayerPhone.Activate();
                    break;
                default:
                    break;
            }
        }

        public void SendMessage(int Message, int wParam, int lParam)
        {
            // Формируем сообщение
            Microsoft.WindowsCE.Forms.Message mes = Microsoft.WindowsCE.Forms.Message.Create(new IntPtr(0xFFFF), Message, new IntPtr(wParam), new IntPtr(lParam));
            // Отправляем
            Microsoft.WindowsCE.Forms.MessageWindow.SendMessage(ref mes);
        }

        public void PostMessage(int Message, int wParam, int lParam)
        {
            // Формируем сообщение
            Microsoft.WindowsCE.Forms.Message mes = Microsoft.WindowsCE.Forms.Message.Create(new IntPtr(0xFFFF), Message, new IntPtr(wParam), new IntPtr(lParam));
            // Отправляем
            Microsoft.WindowsCE.Forms.MessageWindow.PostMessage(ref mes);
        }

        public Form_Main()
        {
            MMC_Data.ReadSetting();

            InitializeComponent();
            this.MsgWin = new MsgWindow(this);

            // Подписываемся на события аппаратных кнопок
            SerialCOM1.BtnMODE += new SerialCOM1.AlertEventHandler(Btn_MODE_Click);
            SerialCOM1.SysTime += new SerialCOM1.AlertEventHandler(SerialCOM1_SysTime);
            SerialCOM1.Sys_Mute += new SerialCOM1.AlertEventHandlerData(SerialCOM1_Sys_Mute);
            SerialCOM1.ResumeMMC += new SerialCOM1.AlertEventHandler(SerialCOM1_ResumeMMC);
            SerialCOM1.Sys_R_Gear_OFF += new SerialCOM1.AlertEventHandler(SerialCOM1_Sys_R_Gear_OFF);

            CAN.Data_245 += new CAN.AlertEventHandlerByte(CAN_Data_245);
            CAN.Data_280 += new CAN.AlertEventHandlerByte(CAN_Data_280);
            CAN.Data_281 += new CAN.AlertEventHandlerByte(CAN_Data_281);
            CAN.Data_354 += new CAN.AlertEventHandlerByte(CAN_Data_354);
            CAN.Data_481 += new CAN.AlertEventHandlerByte(CAN_Data_481);
            CAN.Data_498 += new CAN.AlertEventHandlerByte(CAN_Data_498);
            CAN.Data_551 += new CAN.AlertEventHandlerByte(CAN_Data_551);
            CAN.Data_555 += new CAN.AlertEventHandlerByte(CAN_Data_555);
            CAN.Data_560 += new CAN.AlertEventHandlerByte(CAN_Data_560);
            CAN.Data_565 += new CAN.AlertEventHandlerByte(CAN_Data_565);
            CAN.Data_7F0 += new CAN.AlertEventHandlerByte(CAN_Data_7F0);

            CAN.Data_2DE += new CAN.AlertEventHandlerByte(CAN_Data_2DE);
            CAN.Data_7E8 += new CAN.AlertEventHandlerByte(CAN_Data_7E8);
            CAN.Data_180 += new CAN.AlertEventHandlerByte(CAN_Data_180);
            CAN.Data_ver += new CAN.AlertEventHandlerData(CAN_Data_ver);

            Button_Radio.BackGndImage = MMC_Res.MainBtnRadioOff;
            Button_Radio.PressedImage = MMC_Res.MainBtnRadioOn;
            Button_Audio.BackGndImage = MMC_Res.MainBtnAudioOff;
            Button_Audio.PressedImage = MMC_Res.MainBtnAudioOn;
            Button_Settings.BackGndImage = MMC_Res.MainBtnSettingOff;
            Button_Settings.PressedImage = MMC_Res.MainBtnSettingOn;
            Button_Navi.BackGndImage = MMC_Res.MainBtnNaviOff;
            Button_Navi.PressedImage = MMC_Res.MainBtnNaviOn;
            Button_Phone.BackGndImage = MMC_Res.MainBtnPhoneOff;
            Button_Phone.PressedImage = MMC_Res.MainBtnPhoneOn;
            Button_Exit.BackGndImage = MMC_Res.MainBtnExitOff;
            Button_Exit.PressedImage = MMC_Res.MainBtnExitOn;

            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            label_Time.Font = font_systime;
            label_Date.Font = font_sysdate;
        }
        
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MessageBox.Show("Вы хотите закрыть MMC Player 2?", "Закрытие MMC Player 2", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SerialCOM1.BtnMODE -= new SerialCOM1.AlertEventHandler(Btn_MODE_Click);
                SerialCOM1.SysTime -= new SerialCOM1.AlertEventHandler(SerialCOM1_SysTime);
                SerialCOM1.Sys_Mute -= new SerialCOM1.AlertEventHandlerData(SerialCOM1_Sys_Mute);
                SerialCOM1.ResumeMMC -= new SerialCOM1.AlertEventHandler(SerialCOM1_ResumeMMC);
                SerialCOM1.Sys_R_Gear_OFF -= new SerialCOM1.AlertEventHandler(SerialCOM1_Sys_R_Gear_OFF);

                CAN.Data_245 -= new CAN.AlertEventHandlerByte(CAN_Data_245);
                CAN.Data_280 -= new CAN.AlertEventHandlerByte(CAN_Data_280);
                CAN.Data_281 -= new CAN.AlertEventHandlerByte(CAN_Data_281);
                CAN.Data_354 -= new CAN.AlertEventHandlerByte(CAN_Data_354);
                CAN.Data_481 -= new CAN.AlertEventHandlerByte(CAN_Data_481);
                CAN.Data_498 -= new CAN.AlertEventHandlerByte(CAN_Data_498);
                CAN.Data_551 -= new CAN.AlertEventHandlerByte(CAN_Data_551);
                CAN.Data_555 -= new CAN.AlertEventHandlerByte(CAN_Data_555);
                CAN.Data_560 -= new CAN.AlertEventHandlerByte(CAN_Data_560);
                CAN.Data_565 -= new CAN.AlertEventHandlerByte(CAN_Data_565);
                CAN.Data_7F0 -= new CAN.AlertEventHandlerByte(CAN_Data_7F0);

                CAN.Data_2DE -= new CAN.AlertEventHandlerByte(CAN_Data_2DE);
                CAN.Data_7E8 -= new CAN.AlertEventHandlerByte(CAN_Data_7E8);
                CAN.Data_180 -= new CAN.AlertEventHandlerByte(CAN_Data_180);
                CAN.Data_ver -= new CAN.AlertEventHandlerData(CAN_Data_ver);

                SerialCOM1.Api_SetActivateMode(1);
                Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
                MMC_Data.WriteSetting();
                SerialCOM1.UnInit();
                CAN.UnInit();
                //Bluetooth.Uninit(); //Новые функции
                BtDll.UnInit();

                // Выгрузка всех форм
                Forms.UnLoadForms();

                // Находим панель задач
                IntPtr hWnd = FindWindow("HHTaskBar", String.Empty);
                // Отображаем панель задач
                if (hWnd != IntPtr.Zero) { ShowWindow(hWnd, 1); }

                try
                {
                    if (Vars.Navigation.StartInfo.FileName != "")
                    {
                        SetWindowPos(Vars.Navigation.MainWindowHandle, -1, 0, 0, 800, 480, 0);
                        if (Vars.hWndNavigator != IntPtr.Zero) { SetForegroundWindow(Vars.hWndNavigator); }
                    }
                }
                catch
                {
                    this.Close();
                }
                this.Close();
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Скрываем панель задач
            IntPtr hWnd = FindWindow("HHTaskBar", String.Empty);
            if (hWnd != IntPtr.Zero) { ShowWindow(hWnd, 0); }
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Инициализация COM1 и COM3
             SerialCOM1.Init();
            CAN.Init();
            //Bluetooth.Init(new IntPtr(0xFFFF)); //Новые функции
            BtDll.Init();

            // Активация настроек
            Audio_SetSetting();

            // Загрузка всех форм
            Forms.LoadForms(this);

            Vars.Navigation = new Process();

            // Регистрация BASS.dll
            BassNet.Registration("pismo_imv@mail.ru", "2X252917172238");
            // Инициализация BASS.dll по умолчанию
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

            Vars.FormActivated = Vars.Form_Active.Main;
        }

        private void Button_Radio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Radio.Left = 0;
            Forms.Radio.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.Radio.Activate();
            Vars.FormActivated = Vars.Form_Active.Radio;

            if (Vars.BASS_Stream != 0) Bass.BASS_ChannelPause(Vars.BASS_Stream);

            if (SerialCOM1.Api_GetActivateMode() != 0)
            {
                SerialCOM1.Api_SetActivateMode(0);
                Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
                SerialCOM1.Rds_SetAFMsg(MMC_Data.AF);
                SerialCOM1.Radio_SetSearchLevel(MMC_Data.SearchLevel);
                SerialCOM1.Radio_SetStereoStatus(MMC_Data.Stereo);
                SerialCOM1.Radio_SetBand(MMC_Data.Current_Band);
                SerialCOM1.Radio_SetFreq(MMC_Data.Current_Freq);
            }
        }

        private void Button_Audio_Click(object sender, EventArgs e)
        {
            // Если идет воспроизведение трека
            if (Vars.StatusPlay)
            {
                if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
                {
                    if (SerialCOM1.Api_GetActivateMode() == 0)
                    {
                        SerialCOM1.Api_SetActivateMode(1);
                        Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
                        Bass.BASS_ChannelPlay(Vars.BASS_Stream, false);
                        Vars.timerScreenSaverTick = 0;
                        Forms.Player.Left = 0;
                        Forms.Player.Top = 0;
                        this.Left = 801;
                        this.Top = 481;
                        Forms.Player.Activate();
                        Vars.FormActivated = Vars.Form_Active.Player;
                    }
                    else
                    {
                        Vars.timerScreenSaverTick = 0;
                        Forms.Audio.Left = 0;
                        Forms.Audio.Top = 0;
                        this.Left = 801;
                        this.Top = 481;
                        Forms.Audio.Activate();
                        Vars.FormActivated = Vars.Form_Active.Audio;
                    }
                }
                else
                {
                    Vars.timerScreenSaverTick = 0;
                    Forms.Player.Left = 0;
                    Forms.Player.Top = 0;
                    this.Left = 801;
                    this.Top = 481;
                    Forms.Player.Activate();
                    Vars.FormActivated = Vars.Form_Active.Player;
                }
            }
            else
            {
                Vars.timerScreenSaverTick = 0;
                Forms.Audio.Left = 0;
                Forms.Audio.Top = 0;
                this.Left = 801;
                this.Top = 481;
                Forms.Audio.Activate();
                Vars.FormActivated = Vars.Form_Active.Audio;
            }
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Settings.Left = 0;
            Forms.Settings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.Settings.Activate();
            Vars.FormActivated = Vars.Form_Active.Settings;
        }

        private void Button_Navi_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            try
            {
                if (Vars.Navigation.StartInfo.FileName == "")
                {
                    if (new FileInfo("\\SDMMC\\Navigation\\Navi.exe").Exists)
                    {
                        Vars.NavigatorActive = true;
                        Vars.Navigation = Process.Start("\\SDMMC\\Navigation\\Navi.exe", null);
                        Vars.Navigation.Exited += new EventHandler(Navitel_Exited);
                        Vars.Navigation.EnableRaisingEvents = true;
                        Thread.Sleep(2000);
                        Vars.hWndNavigator = Vars.Navigation.MainWindowHandle;
                        HideWindow();
                    }
                    else
                    {
                        MessageBox.Show("Нет файла");
                    }
                }
                else
                {
                    Vars.NavigatorActive = true;
                    SetWindowPos(Vars.hWndNavigator, -1, 0, 0, 800, 480, 0);
                    if (Vars.hWndNavigator != IntPtr.Zero) { SetForegroundWindow(Vars.hWndNavigator); }
                    HideWindow();
                }
            }
            catch { }
        }

        void Navitel_Exited(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Vars.Navigation.Dispose();
            Vars.Navigation = new Process();
            Vars.NavigatorActive = false;

            Action action = ShowWindow;
            if (InvokeRequired)
                Invoke(action);
        }

        public void Btn_MODE_Click(object sender, EventArgs e)
        {
            try
            {
                if (Vars.Navigation.StartInfo.FileName != "")
                {
                    Vars.timerScreenSaverTick = 0;
                    if (!Vars.DialActive)
                    {
                        if (Vars.NavigatorActive)
                        {
                            Vars.NavigatorActive = false;
                            Action action = ShowWindow;
                            if (InvokeRequired)
                                Invoke(action);
                            SetWindowPos(Vars.hWndNavigator, -1, 801, 481, 800, 480, 0);
                        }
                        else
                        {
                            Vars.NavigatorActive = true;
                            SetWindowPos(Vars.hWndNavigator, -1, 0, 0, 800, 480, 0);

                            if (Vars.hWndNavigator != IntPtr.Zero)
                            {
                                SetForegroundWindow(Vars.hWndNavigator);
                            }
                            Action action = HideWindow;
                            if (InvokeRequired)
                                Invoke(action);
                        }
                    }
                }
                //else
                //{
                //    Vars.timerScreenSaverTick = 0;
                //    this.Left = 0;
                //    this.Top = 0;
                //    HideWindow();
                //    this.Activate();
                //    Vars.FormActivated = Vars.Form_Active.Main;
                //}
            }
            catch { }
        }

        void SerialCOM1_ResumeMMC(object sender, EventArgs e)
        {
            Action action = ResumeMMC;
            if (InvokeRequired)
                BeginInvoke(action);
        }

        private void ResumeMMC()
        {
            SetLight();
            Forms.Phone.Deactivate_Phone_Keyboard();
            //Bluetooth.ConnectedTelephone = false;
            Forms.PhoneSettings.listBox1.SelectedItem = -1;
        }

        public void SetLight()
        {
            switch (MMC_Data.DispModeColor)
            {
                case MMC_Data.LightMode.Day:
                    SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                    SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                    SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                    break;
                case MMC_Data.LightMode.Night:
                    SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                    SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                    SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                    break;
                case MMC_Data.LightMode.Auto:
                    if (Light)
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
                    break;
                default:
                    break;
            }
        }

        private void SerialCOM1_Sys_Mute(object sender, EventArgs e, int data)
        {
            Action<int> action = ChangeMute;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ChangeMute(int data)
        {
            if (data == 1)
            {
                pictureBoxMute.Visible = true;
                Forms.Audio.pictureBoxMute.Visible = true;
                Forms.Phone.pictureBoxMute.Visible = true;
                Forms.Radio.pictureBoxMute.Visible = true;
                Forms.ScreenSaver.pictureBoxMute.Visible = true;
                Forms.Settings.pictureBoxMute.Visible = true;
                Forms.Dial.pictureBoxMute.Visible = true;
            }
            else
            {
                pictureBoxMute.Visible = false;
                Forms.Audio.pictureBoxMute.Visible = false;
                Forms.Phone.pictureBoxMute.Visible = false;
                Forms.Radio.pictureBoxMute.Visible = false;
                Forms.ScreenSaver.pictureBoxMute.Visible = false;
                Forms.Settings.pictureBoxMute.Visible = false;
                Forms.Dial.pictureBoxMute.Visible = false;
            }
        }

        // Активация настроек
        private void Audio_SetSetting()
        {
            // Переключение режима работы
            SerialCOM1.Api_SetActivateMode(1);
            // Сохранение текущего режима работы
            Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();

            // Регистрация сообщений Bluetooth
            //BTMessage.BT_RegisterMessage();

            //pr = Process.Start("\\Program Files\\MMC\\BTcore.exe", null);

 //           SerialCOM1.Radio_SetSearchLevel(MMC_Data.SearchLevel);
  //          SerialCOM1.Radio_SetStereoStatus(MMC_Data.Stereo);
            timer_Init.Enabled = true;
        }

        int i = 0;
        private void timer_Init_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    // Предустановленное значение
                    SerialCOM1.Api_SetBTMuteState(1);
                    //Bluetooth.Mute(1);
                    break;
                case 1:
                    SerialCOM1.Api_SetActivateMode(2);
                    Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
                    break;
                case 2:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetLoudCFre(2);
                    SerialCOM1.Aud_SetLoudCFre(MMC_Data.LoudTone);
                    break;
                case 3:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetBassCFre(1);
                    SerialCOM1.Aud_SetBassCFre(MMC_Data.BassCFre);
                    break;
                case 4:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetMiddleCFre(3);
                    SerialCOM1.Aud_SetMiddleCFre(MMC_Data.MiddleCFre);
                    break;
                case 5:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetTrebleCFre(2);
                    SerialCOM1.Aud_SetTrebleCFre(MMC_Data.TrebleCFre);
                    break;
                case 6:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetBassQ(1);
                    SerialCOM1.Aud_SetBassQ(MMC_Data.BassQ);
                    break;
                case 7:
                    // Предустановленное значение
                    //SerialCOM1.Aud_SetMiddleQ(1);
                    SerialCOM1.Aud_SetMiddleQ(MMC_Data.MiddleQ);
                    break;
                case 8:
                    SerialCOM1.Aud_SetTreble(MMC_Data.Treble);
                    break;
                case 9:
                    SerialCOM1.Aud_SetMid(MMC_Data.Middle);
                    break;
                case 10:
                    SerialCOM1.Aud_SetBass(MMC_Data.Bass);
                    break;
                case 11:
                    int balance = (int)(Math.Round((MMC_Data.Balance - 25) / 14.2857) - 7);
                    int fader = (int)(7 - Math.Round((MMC_Data.Fader - 75) / 17.857));

                    SerialCOM1.Aud_SetBalanceFader(balance, fader);
                    break;
                case 12:
                    SerialCOM1.Aud_SetLoud(MMC_Data.Loud);
                    break;
                case 13:
                    SerialCOM1.Aud_SetVolume(30);
                    MMC_Data.SaveVolume = 30;
                    break;
                case 14:
                    SerialCOM1.Vid_SetBackLight(0);
                    break;
                case 15:
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day) SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night) SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
                    {
                        if (Light) SerialCOM1.Vid_SetBright(MMC_Data.Bright_Night);
                        else SerialCOM1.Vid_SetBright(MMC_Data.Bright_Day);
                    }
                    break;
                case 16:
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day) SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night) SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
                    {
                        if (Light) SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Night);
                        else SerialCOM1.Vid_SetContrast(MMC_Data.Contrast_Day);
                    }
                    break;
                case 17:
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Day) SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Night) SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                    if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
                    {
                        if (Light) SerialCOM1.Vid_SetColor(MMC_Data.Color_Night);
                        else SerialCOM1.Vid_SetColor(MMC_Data.Color_Day);
                    }
                    break;
                case 18:
                    // 22 05 85 00 02 00 00 74
                    //AudioSet(0x22, 0x05, 0x85, 0x00, 0x02, 0x00, 0x00, 0x00);
                    break;
                case 19:
                    // 22 05 85 00 00 01 00 75
                    //AudioSet(0x22, 0x05, 0x85, 0x00, 0x00, 0x01, 0x00, 0x00);
                    break;
                case 20:
                    SerialCOM1.Radio_SetSearchLevel(MMC_Data.SearchLevel);
                    break;
                case 21:
                    SerialCOM1.Radio_SetStereoStatus(MMC_Data.Stereo);
                    break;
                case 22:
                    if (MMC_Data.CAMState == false) SerialCOM1.API_SetCAMState(0);
                    if (MMC_Data.CAMState == true) SerialCOM1.API_SetCAMState(1);
                    break;
                case 23:
                    timer_Init.Enabled = false;
                    break;
                default:
                    timer_Init.Enabled = false;
                    break;
            }
            i++;
        }

        void SerialCOM1_SysTime(object sender, EventArgs e)
        {
            Action action = ViewSystemTime;
            if (InvokeRequired)
                BeginInvoke(action);
        }

        int BT = 0;
        private void ViewSystemTime()
        {
            // Установка времени и даты на всех формах
            label_Date.Text = MMC_Data.date;
            label_Time.Text = MMC_Data.time;
            Forms.Audio.label_Date.Text = MMC_Data.date;
            Forms.Audio.label_Time.Text = MMC_Data.time;
            Forms.Phone.label_Date.Text = MMC_Data.date;
            Forms.Phone.label_Time.Text = MMC_Data.time;
            Forms.Dial.label_Date.Text = MMC_Data.date;
            Forms.Dial.label_Time.Text = MMC_Data.time;
            Forms.Radio.label_Date.Text = MMC_Data.date;
            Forms.Radio.label_Time.Text = MMC_Data.time;
            Forms.ScreenSaver.label_Date.Text = MMC_Data.date;
            Forms.ScreenSaver.label_Time.Text = MMC_Data.time;
            Forms.ScreenSaver.pictureBoxLine.Visible = !Forms.ScreenSaver.pictureBoxLine.Visible;
            Forms.Settings.label_Date.Text = MMC_Data.date;
            Forms.Settings.label_Time.Text = MMC_Data.time;

            // Поиск окна навигации и сохранение хэндла
   /*         if (Vars.NavigatorActive)
            {
                if (Vars.hWndNavigator == IntPtr.Zero) Vars.hWndNavigator = FindWindow("navitel", "Navitel Navigator (Auto)");
            }*/
            //if (Bluetooth.AutoConnect && Bluetooth.indexPairedPhone != 0)

            //if ((BtDll.m_autoconnect == 1) && (BtDll.m_connstate == 3))
            if (BtDll.m_autoconnect == 1)
            {
                if (BT > 30)
                {
                    // Опрос Bluetooth
                    //if (!Bluetooth.ConnectedTelephone)
                    if (BtDll.m_connstate == 0)
                    {
                        //PostMessage(BTMessage.WM_NFORE_CORE_SET_AUTO_RECONNECT, 1, 0);
                        //Bluetooth.SetAutoconnect(1);
                        BtDll.Autoconnect();
                        BT = 0;
                    }
                    else
                    {
                        BT = 0;
                    }
                }
                else
                {
                    BT++;
                }
            }
        }

        // Восстановление настроек экрана после выключения З/Х
        void SerialCOM1_Sys_R_Gear_OFF(object sender, EventArgs e)
        {
            SetLight();
        }

        private void timer_ScreenSaver_Tick(object sender, EventArgs e)
        {
            // Если разрешена установка скринсейвера
            if (MMC_Data.ScreenSaver)
            {
                Vars.timerScreenSaverTick++;
                if (Vars.timerScreenSaverTick > 1000) Vars.timerScreenSaverTick = 100;

                if (Vars.timerScreenSaverTick > MMC_Data.ScreenSaverTime)
                {
                    // Если не активно окно навигатора или звонка
                    if (!Vars.NavigatorActive && Vars.FormActivated != Vars.Form_Active.Dial)
                    {
                        if (!Vars.ScreenSaverActive)
                        {
                            Vars.ScreenSaverActive = true;
                            Forms.ScreenSaver.Left = 0;
                            Forms.ScreenSaver.Top = 0;
                            Forms.ScreenSaver.Activate();
                        }
                    }
                    else
                    {
                        Forms.ScreenSaver.Left = 801;
                        Forms.ScreenSaver.Top = 481;
                        Vars.ScreenSaverActive = false;
                    }
                }
                else
                {
                    if (Vars.ScreenSaverActive)
                    {
                        Forms.ScreenSaver.Left = 801;
                        Forms.ScreenSaver.Top = 481;
                        Vars.ScreenSaverActive = false;
                    }
                }
            }
        }

        private void Form_Main_Click(object sender, EventArgs e)
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

        private void Button_Phone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Phone.Left = 0;
            Forms.Phone.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.Phone.Activate();
            Vars.FormActivated = Vars.Form_Active.Phone;
        }

        private void pictureBoxPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        #region // Вызов функций BeginInvoke
        void CAN_Data_7F0(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_7F0;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_565(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_565;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_560(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_560;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_555(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_555;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_551(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_551;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_498(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_498;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_481(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_481;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_354(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_354;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_281(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_281;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_280(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_280;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_245(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_245;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_2DE(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_2DE;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_7E8(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_7E8;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_180(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = _CAN_Data_180;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        void CAN_Data_ver(object sender, EventArgs e, int data)
        {
            Action<int> action = _CAN_Data_ver;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }
        #endregion

        #region // Can Data
        private void _CAN_Data_ver(int data)
        {
            //MessageBox.Show(data.ToString());
        }

        private void _CAN_Data_245(byte[] data)
        {
            
        }

        private void _CAN_Data_280(byte[] data)
        {
            // Красный
            if (data[7] >= 0 && data[7] <= 20)
            {
                Forms.ScreenSaver.label_LevelFuel.ForeColor = Red;
                Forms.Radio.label_LevelFuel.ForeColor = Red;
                Forms.Audio.label_LevelFuel.ForeColor = Red;
                Forms.Settings.label_LevelFuel.ForeColor = Red;
                Forms.Phone.label_LevelFuel.ForeColor = Red;
                Forms.Dial.label_LevelFuel.ForeColor = Red;
                this.label_LevelFuel.ForeColor = Red;
            }
            // Зеленый 174; 255; 199
            else if (data[7] >= 21)
            {
                Forms.ScreenSaver.label_LevelFuel.ForeColor = Green;
                Forms.Radio.label_LevelFuel.ForeColor = Green;
                Forms.Audio.label_LevelFuel.ForeColor = Green;
                Forms.Settings.label_LevelFuel.ForeColor = Green;
                Forms.Phone.label_LevelFuel.ForeColor = Green;
                Forms.Dial.label_LevelFuel.ForeColor = Green;
                this.label_LevelFuel.ForeColor = Green;
            }

            Forms.ScreenSaver.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            Forms.Radio.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            Forms.Audio.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            Forms.Settings.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            Forms.Phone.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            Forms.Dial.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";
            this.label_LevelFuel.Text = ((int)(data[7] * 0.5)).ToString() + "л";

            CanActive();
        }

        private void _CAN_Data_281(byte[] data)
        {
            
        }

        private void _CAN_Data_354(byte[] data)
        {
            
        }

        bool Light = false;
        private void _CAN_Data_481(byte[] data)
        {
            if (MMC_Data.DispModeColor == MMC_Data.LightMode.Auto)
            {
                // Состояние света
                if (((data[6] & 0x40) == 0x40 || (data[6] & 0x10) == 0x10) && !Light)
                {
                    Light = true;
                    SetLight();
                }
                else if (((data[6] & 0x40) != 0x40 && (data[6] & 0x10) != 0x10) && Light)
                {
                    Light = false;
                    SetLight();
                }
            }
            else
            {
                Light = false;
            }

            
        }

        private void _CAN_Data_498(byte[] data)
        {
            
        }

        private void _CAN_Data_551(byte[] data)
        {
            // Синий
            if (data[7] >= 0 && data[7] <= 39)
            {
                Forms.ScreenSaver.label_temp_coolingwater.ForeColor = Blue;
                Forms.Radio.label_temp_coolingwater.ForeColor = Blue;
                Forms.Audio.label_temp_coolingwater.ForeColor = Blue;
                Forms.Settings.label_temp_coolingwater.ForeColor = Blue;
                Forms.Phone.label_temp_coolingwater.ForeColor = Blue;
                Forms.Dial.label_temp_coolingwater.ForeColor = Blue;
                this.label_temp_coolingwater.ForeColor = Blue;
            }
            // Зеленый 174; 255; 199
            else if (data[7] >= 40 && data[7] <= 129)
            {
                Forms.ScreenSaver.label_temp_coolingwater.ForeColor = Green;
                Forms.Radio.label_temp_coolingwater.ForeColor = Green;
                Forms.Audio.label_temp_coolingwater.ForeColor = Green;
                Forms.Settings.label_temp_coolingwater.ForeColor = Green;
                Forms.Phone.label_temp_coolingwater.ForeColor = Green;
                Forms.Dial.label_temp_coolingwater.ForeColor = Green;
                this.label_temp_coolingwater.ForeColor = Green;
            }
            // Желтый
            else if (data[7] >= 130 && data[7] <= 142)
            {
                Forms.ScreenSaver.label_temp_coolingwater.ForeColor = Yellow;
                Forms.Radio.label_temp_coolingwater.ForeColor = Yellow;
                Forms.Audio.label_temp_coolingwater.ForeColor = Yellow;
                Forms.Settings.label_temp_coolingwater.ForeColor = Yellow;
                Forms.Phone.label_temp_coolingwater.ForeColor = Yellow;
                Forms.Dial.label_temp_coolingwater.ForeColor = Yellow;
                this.label_temp_coolingwater.ForeColor = Yellow;
            }
            // Красный
            else if (data[7] >= 143)
            {
                Forms.ScreenSaver.label_temp_coolingwater.ForeColor = Red;
                Forms.Radio.label_temp_coolingwater.ForeColor = Red;
                Forms.Audio.label_temp_coolingwater.ForeColor = Red;
                Forms.Settings.label_temp_coolingwater.ForeColor = Red;
                Forms.Phone.label_temp_coolingwater.ForeColor = Red;
                Forms.Dial.label_temp_coolingwater.ForeColor = Red;
                this.label_temp_coolingwater.ForeColor = Red;
            }

            byte[] temp = { data[7], 0x00 };
            Forms.ScreenSaver.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Radio.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Audio.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Settings.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Phone.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Dial.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            this.label_temp_coolingwater.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";

            //byte[] consumption12 = { data[12], 0x00 };
            //byte[] consumption13 = { data[13], 0x00 };

            //ulong templong = BitConverter.ToUInt64(consumption13, 0);
            //templong |= BitConverter.ToUInt64(consumption12, 0) << 8;
            ////if(m_inst_consumption != templong)
            ////{
            ////    m_inst_consumption = templong;
            //////PostMessage(m_HWND_dest,WM_CAN_CHANGE_FUEL_INSTANT_CONSUMPTION,(WPARAM)m_inst_consumption,0);
            ////}
            //this.label_consumption.Text = (templong * 0.002145).ToString() + "Л/ч";

            CanActive();
        }

        private void _CAN_Data_555(byte[] data)
        {
            
        }

        private void _CAN_Data_560(byte[] data)
        {
            Forms.ScreenSaver.label_tempAKPP.ForeColor = Green;
            Forms.Radio.label_tempAKPP.ForeColor = Green;
            Forms.Audio.label_tempAKPP.ForeColor = Green;
            Forms.Settings.label_tempAKPP.ForeColor = Green;
            Forms.Phone.label_tempAKPP.ForeColor = Green;
            Forms.Dial.label_tempAKPP.ForeColor = Green;
            this.label_tempAKPP.ForeColor = Green;

            byte[] temp = { data[6], 0x00 };
            Forms.ScreenSaver.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Radio.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Audio.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Settings.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Phone.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            Forms.Dial.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";
            this.label_tempAKPP.Text = (Convert.ToInt32(BitConverter.ToInt16(temp, 0)) - 40).ToString() + "°C";

            CanActive();
        }

        private void _CAN_Data_565(byte[] data)
        {
            
        }

        private void _CAN_Data_7F0(byte[] data)
        {
            //            string allData = BitConverter.ToString(data, 0).Replace("-", " ");
            //            textBox1.Text = allData;
            
        }

        private void _CAN_Data_2DE(byte[] data)
        {
            
        }

        private void _CAN_Data_7E8(byte[] data)
        {
            
        }

        private void _CAN_Data_180(byte[] data)
        {
            
        }
        #endregion

        // Класс приема сообщений Windows
        public class MsgWindow : MessageWindow
        {
            // Константы
            const int WM_DEVICECHANGE = 0x0219;
            IntPtr DBT_DEVICEARRIVAL = new IntPtr(0x8000);
            IntPtr DBT_DEVICEREMOVECOMPLETE = new IntPtr(0x8004);

            // Create an instance of the form.
            private Form_Main msgform;

            // Save a reference to the form so it can
            // be notified when messages are received.
            public MsgWindow(Form_Main msgform)
            {
                this.msgform = msgform;
            }

            // Override the default WndProc behavior to examine messages.
            protected override void WndProc(ref Microsoft.WindowsCE.Forms.Message msg)
            {
     /*           if (msg.Msg == WM_DEVICECHANGE)
                {
                    if (msg.WParam == DBT_DEVICEARRIVAL)
                        Forms.Audio.SDUSB_ins();

                    if (msg.WParam == DBT_DEVICEREMOVECOMPLETE)
                        Forms.Audio.SDUSB_Del();
                }*/
                // Call the base WndProc method
                // to process any messages not handled.
                base.WndProc(ref msg);
            }
        }

        private void CanActive()
        {
            Vars.timerCanDataTick = 0;
            Vars.CanActive = true;
        }

        private void timer_CanData_Tick(object sender, EventArgs e)
        {
            Vars.timerCanDataTick++;
            if (Vars.timerCanDataTick > 4)
                Vars.CanActive = false;
            LabelCanVisible();
        }

        private void LabelCanVisible()
        {
            Forms.ScreenSaver.label_tempAKPP.Visible = Vars.CanActive;
            Forms.Radio.label_tempAKPP.Visible = Vars.CanActive;
            Forms.Audio.label_tempAKPP.Visible = Vars.CanActive;
            Forms.Settings.label_tempAKPP.Visible = Vars.CanActive;
            Forms.Phone.label_tempAKPP.Visible = Vars.CanActive;
            Forms.Dial.label_tempAKPP.Visible = Vars.CanActive;
            this.label_tempAKPP.Visible = Vars.CanActive;

            Forms.ScreenSaver.label_temp_coolingwater.Visible = Vars.CanActive;
            Forms.Radio.label_temp_coolingwater.Visible = Vars.CanActive;
            Forms.Audio.label_temp_coolingwater.Visible = Vars.CanActive;
            Forms.Settings.label_temp_coolingwater.Visible = Vars.CanActive;
            Forms.Phone.label_temp_coolingwater.Visible = Vars.CanActive;
            Forms.Dial.label_temp_coolingwater.Visible = Vars.CanActive;
            this.label_temp_coolingwater.Visible = Vars.CanActive;

            Forms.ScreenSaver.label_LevelFuel.Visible = Vars.CanActive;
            Forms.Radio.label_LevelFuel.Visible = Vars.CanActive;
            Forms.Audio.label_LevelFuel.Visible = Vars.CanActive;
            Forms.Settings.label_LevelFuel.Visible = Vars.CanActive;
            Forms.Phone.label_LevelFuel.Visible = Vars.CanActive;
            Forms.Dial.label_LevelFuel.Visible = Vars.CanActive;
            this.label_LevelFuel.Visible = Vars.CanActive;
        }
    }
}
