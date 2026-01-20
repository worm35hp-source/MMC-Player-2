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
using System.Runtime.InteropServices;
using Microsoft.WindowsCE.Forms;
using Un4seen.Bass;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_Phone : Form
    {
        [DllImport("coredll.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static Form_Main Main;

        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);
        Font font_PhoneNumber = new Font("Itelma_Kor", 26F, FontStyle.Regular);

        int BassStreamCall = 0;

        bool PlayerState = false;

        public Vars.Form_Active PrevFormActive;

        // Статус микрофона
        //public bool MicMuteState = false;

        #region // Конвертировние символов
        char[] cp1251 =
        {
            Convert.ToChar(0x0000), Convert.ToChar(0x0001), Convert.ToChar(0x0002), Convert.ToChar(0x0003), Convert.ToChar(0x0004), Convert.ToChar(0x0005), Convert.ToChar(0x0006), Convert.ToChar(0x0007), Convert.ToChar(0x0008), Convert.ToChar(0x0009), Convert.ToChar(0x000A), Convert.ToChar(0x000B), Convert.ToChar(0x000C), Convert.ToChar(0x000D), Convert.ToChar(0x000E), Convert.ToChar(0x000F),
            Convert.ToChar(0x0010), Convert.ToChar(0x0011), Convert.ToChar(0x0012), Convert.ToChar(0x0013), Convert.ToChar(0x0014), Convert.ToChar(0x0015), Convert.ToChar(0x0016), Convert.ToChar(0x0017), Convert.ToChar(0x0018), Convert.ToChar(0x0019), Convert.ToChar(0x001A), Convert.ToChar(0x001B), Convert.ToChar(0x001C), Convert.ToChar(0x001D), Convert.ToChar(0x001E), Convert.ToChar(0x001F),
            Convert.ToChar(0x0020), Convert.ToChar(0x0021), Convert.ToChar(0x0022), Convert.ToChar(0x0023), Convert.ToChar(0x0024), Convert.ToChar(0x0025), Convert.ToChar(0x0026), Convert.ToChar(0x0027), Convert.ToChar(0x0028), Convert.ToChar(0x0029), Convert.ToChar(0x002A), Convert.ToChar(0x002B), Convert.ToChar(0x002C), Convert.ToChar(0x002D), Convert.ToChar(0x002E), Convert.ToChar(0x002F),
            Convert.ToChar(0x0030), Convert.ToChar(0x0031), Convert.ToChar(0x0032), Convert.ToChar(0x0033), Convert.ToChar(0x0034), Convert.ToChar(0x0035), Convert.ToChar(0x0036), Convert.ToChar(0x0037), Convert.ToChar(0x0038), Convert.ToChar(0x0039), Convert.ToChar(0x003A), Convert.ToChar(0x003B), Convert.ToChar(0x003C), Convert.ToChar(0x003D), Convert.ToChar(0x003E), Convert.ToChar(0x003F),
            Convert.ToChar(0x0040), Convert.ToChar(0x0041), Convert.ToChar(0x0042), Convert.ToChar(0x0043), Convert.ToChar(0x0044), Convert.ToChar(0x0045), Convert.ToChar(0x0046), Convert.ToChar(0x0047), Convert.ToChar(0x0048), Convert.ToChar(0x0049), Convert.ToChar(0x004A), Convert.ToChar(0x004B), Convert.ToChar(0x004C), Convert.ToChar(0x004D), Convert.ToChar(0x004E), Convert.ToChar(0x004F),
            Convert.ToChar(0x0050), Convert.ToChar(0x0051), Convert.ToChar(0x0052), Convert.ToChar(0x0053), Convert.ToChar(0x0054), Convert.ToChar(0x0055), Convert.ToChar(0x0056), Convert.ToChar(0x0057), Convert.ToChar(0x0058), Convert.ToChar(0x0059), Convert.ToChar(0x005A), Convert.ToChar(0x005B), Convert.ToChar(0x005C), Convert.ToChar(0x005D), Convert.ToChar(0x005E), Convert.ToChar(0x005F),
            Convert.ToChar(0x0060), Convert.ToChar(0x0061), Convert.ToChar(0x0062), Convert.ToChar(0x0063), Convert.ToChar(0x0064), Convert.ToChar(0x0065), Convert.ToChar(0x0066), Convert.ToChar(0x0067), Convert.ToChar(0x0068), Convert.ToChar(0x0069), Convert.ToChar(0x006A), Convert.ToChar(0x006B), Convert.ToChar(0x006C), Convert.ToChar(0x006D), Convert.ToChar(0x006E), Convert.ToChar(0x006F),
            Convert.ToChar(0x0070), Convert.ToChar(0x0071), Convert.ToChar(0x0072), Convert.ToChar(0x0073), Convert.ToChar(0x0074), Convert.ToChar(0x0075), Convert.ToChar(0x0076), Convert.ToChar(0x0077), Convert.ToChar(0x0078), Convert.ToChar(0x0079), Convert.ToChar(0x007A), Convert.ToChar(0x007B), Convert.ToChar(0x007C), Convert.ToChar(0x007D), Convert.ToChar(0x007E), Convert.ToChar(0x007F),

            Convert.ToChar(0x0402), Convert.ToChar(0x0403), Convert.ToChar(0x201A), Convert.ToChar(0x0453), Convert.ToChar(0x201E), Convert.ToChar(0x2026), Convert.ToChar(0x2020), Convert.ToChar(0x2021), Convert.ToChar(0x20AC), Convert.ToChar(0x2030), Convert.ToChar(0x0409), Convert.ToChar(0x2039), Convert.ToChar(0x040A), Convert.ToChar(0x040C), Convert.ToChar(0x040B), Convert.ToChar(0x040F),
            Convert.ToChar(0x0452), Convert.ToChar(0x2018), Convert.ToChar(0x2019), Convert.ToChar(0x201C), Convert.ToChar(0x201D), Convert.ToChar(0x2022), Convert.ToChar(0x2013), Convert.ToChar(0x2014), Convert.ToChar(0x0098), Convert.ToChar(0x2122), Convert.ToChar(0x0459), Convert.ToChar(0x203A), Convert.ToChar(0x045A), Convert.ToChar(0x045C), Convert.ToChar(0x045B), Convert.ToChar(0x045F),
            Convert.ToChar(0x00A0), Convert.ToChar(0x040E), Convert.ToChar(0x045E), Convert.ToChar(0x0408), Convert.ToChar(0x00A4), Convert.ToChar(0x0490), Convert.ToChar(0x00A6), Convert.ToChar(0x00A7), Convert.ToChar(0x0401), Convert.ToChar(0x00A9), Convert.ToChar(0x0404), Convert.ToChar(0x00AB), Convert.ToChar(0x00AC), Convert.ToChar(0x00AD), Convert.ToChar(0x00AE), Convert.ToChar(0x0407),
            Convert.ToChar(0x00B0), Convert.ToChar(0x00B1), Convert.ToChar(0x0406), Convert.ToChar(0x0456), Convert.ToChar(0x0491), Convert.ToChar(0x00B5), Convert.ToChar(0x00B6), Convert.ToChar(0x00B7), Convert.ToChar(0x0451), Convert.ToChar(0x2116), Convert.ToChar(0x0454), Convert.ToChar(0x00BB), Convert.ToChar(0x0458), Convert.ToChar(0x0405), Convert.ToChar(0x0455), Convert.ToChar(0x0457),
            Convert.ToChar(0x0410), Convert.ToChar(0x0411), Convert.ToChar(0x0412), Convert.ToChar(0x0413), Convert.ToChar(0x0414), Convert.ToChar(0x0415), Convert.ToChar(0x0416), Convert.ToChar(0x0417), Convert.ToChar(0x0418), Convert.ToChar(0x0419), Convert.ToChar(0x041A), Convert.ToChar(0x041B), Convert.ToChar(0x041C), Convert.ToChar(0x041D), Convert.ToChar(0x041E), Convert.ToChar(0x041F),
            Convert.ToChar(0x0420), Convert.ToChar(0x0421), Convert.ToChar(0x0422), Convert.ToChar(0x0423), Convert.ToChar(0x0424), Convert.ToChar(0x0425), Convert.ToChar(0x0426), Convert.ToChar(0x0427), Convert.ToChar(0x0428), Convert.ToChar(0x0429), Convert.ToChar(0x042A), Convert.ToChar(0x042B), Convert.ToChar(0x042C), Convert.ToChar(0x042D), Convert.ToChar(0x042E), Convert.ToChar(0x042F),
            Convert.ToChar(0x0430), Convert.ToChar(0x0431), Convert.ToChar(0x0432), Convert.ToChar(0x0433), Convert.ToChar(0x0434), Convert.ToChar(0x0435), Convert.ToChar(0x0436), Convert.ToChar(0x0437), Convert.ToChar(0x0438), Convert.ToChar(0x0439), Convert.ToChar(0x043A), Convert.ToChar(0x043B), Convert.ToChar(0x043C), Convert.ToChar(0x043D), Convert.ToChar(0x043E), Convert.ToChar(0x043F),
            Convert.ToChar(0x0440), Convert.ToChar(0x0441), Convert.ToChar(0x0442), Convert.ToChar(0x0443), Convert.ToChar(0x0444), Convert.ToChar(0x0445), Convert.ToChar(0x0446), Convert.ToChar(0x0447), Convert.ToChar(0x0448), Convert.ToChar(0x0449), Convert.ToChar(0x044A), Convert.ToChar(0x044B), Convert.ToChar(0x044C), Convert.ToChar(0x044D), Convert.ToChar(0x044E), Convert.ToChar(0x044F)
        };  // cp1251

        string CharArrayToString(char[] ar)
        {
            char[] trim = { Convert.ToChar(0x0000) };
            string result = "";
            for (int i = 0; i < ar.Length; i++)
                result += ar[i];
            return result.Trim(trim);
        } //CharArrayToString

        string _1251ToUnicode(byte[] _1251)
        {
            char[] Unicode = new char[_1251.Length];

            for (int i = 0; i < _1251.Length; i++)
            {
                Unicode[i] = cp1251[(uint)_1251[i]];
            }

            return CharArrayToString(Unicode);
        }
        #endregion


        string PhoneNumber = "";

        public Form_Phone(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            Img_Phone.Image = MMC_Res.Phone_Phone;
            pictureBoxPhoneNumber.Image = MMC_Res.Phone_Number;
            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            Button_Home.BackGndImage = MMC_Res.BtnHomeOff;
            Button_Home.PressedImage = MMC_Res.BtnHomeOn;

            BtnPlayMusic.State1 = MMC_Res.Phone_PlayMusicPhoneDis;
            BtnPlayMusic.State2 = MMC_Res.Phone_PlayMusicPhoneOff;
            BtnPlayMusic.State3 = MMC_Res.Phone_PlayMusicPhoneOn;

            BtnHandsFree.State1 = MMC_Res.Phone_HandsFreeDis;
            BtnHandsFree.State2 = MMC_Res.Phone_HandsFreeOff;
            BtnHandsFree.State3 = MMC_Res.Phone_HandsFreeOn;

            BtnDial.BackGndImage = MMC_Res.Phone_DialOff;
            BtnDial.PressedImage = MMC_Res.Phone_DialOn;
            BtnDial.NotActive = MMC_Res.Phone_DialDis;

            BtnDelSymbol.BackGndImage = MMC_Res.Phone_DelSymbolOff;
            BtnDelSymbol.PressedImage = MMC_Res.Phone_DelSymbolOn;
            BtnDelSymbol.NotActive = MMC_Res.Phone_DelSymbolDis;

            BtnRedial.BackGndImage = MMC_Res.Phone_RedialOff;
            BtnRedial.PressedImage = MMC_Res.Phone_RedialOn;
            BtnRedial.NotActive = MMC_Res.Phone_RedialDis;

            BtnPhoneBook.BackGndImage = MMC_Res.Phone_PhoneBookOff;
            BtnPhoneBook.PressedImage = MMC_Res.Phone_PhoneBookOn;
            BtnPhoneBook.NotActive = MMC_Res.Phone_PhoneBookDis;

            BtnPhoneSettings.BackGndImage = MMC_Res.Phone_SettingsOff;
            BtnPhoneSettings.PressedImage = MMC_Res.Phone_SettingsOn;


            Btn1.BackGndImage = MMC_Res.Phone_1Off;
            Btn1.PressedImage = MMC_Res.Phone_1On;
            Btn1.NotActive = MMC_Res.Phone_1Dis;

            Btn2.BackGndImage = MMC_Res.Phone_2Off;
            Btn2.PressedImage = MMC_Res.Phone_2On;
            Btn2.NotActive = MMC_Res.Phone_2Dis;

            Btn3.BackGndImage = MMC_Res.Phone_3Off;
            Btn3.PressedImage = MMC_Res.Phone_3On;
            Btn3.NotActive = MMC_Res.Phone_3Dis;

            Btn4.BackGndImage = MMC_Res.Phone_4Off;
            Btn4.PressedImage = MMC_Res.Phone_4On;
            Btn4.NotActive = MMC_Res.Phone_4Dis;

            Btn5.BackGndImage = MMC_Res.Phone_5Off;
            Btn5.PressedImage = MMC_Res.Phone_5On;
            Btn5.NotActive = MMC_Res.Phone_5Dis;

            Btn6.BackGndImage = MMC_Res.Phone_6Off;
            Btn6.PressedImage = MMC_Res.Phone_6On;
            Btn6.NotActive = MMC_Res.Phone_6Dis;

            Btn7.BackGndImage = MMC_Res.Phone_7Off;
            Btn7.PressedImage = MMC_Res.Phone_7On;
            Btn7.NotActive = MMC_Res.Phone_7Dis;

            Btn8.BackGndImage = MMC_Res.Phone_8Off;
            Btn8.PressedImage = MMC_Res.Phone_8On;
            Btn8.NotActive = MMC_Res.Phone_8Dis;

            Btn9.BackGndImage = MMC_Res.Phone_9Off;
            Btn9.PressedImage = MMC_Res.Phone_9On;
            Btn9.NotActive = MMC_Res.Phone_9Dis;

            Btn0.BackGndImage = MMC_Res.Phone_0Off;
            Btn0.PressedImage = MMC_Res.Phone_0On;
            Btn0.NotActive = MMC_Res.Phone_0Dis;

            BtnPlus.BackGndImage = MMC_Res.Phone_PlusOff;
            BtnPlus.PressedImage = MMC_Res.Phone_PlusOn;
            BtnPlus.NotActive = MMC_Res.Phone_PlusDis;

            BtnReshetka.BackGndImage = MMC_Res.Phone_ReshetkaOff;
            BtnReshetka.PressedImage = MMC_Res.Phone_ReshetkaOn;
            BtnReshetka.NotActive = MMC_Res.Phone_ReshetkaDis;

            label_Time.Font = font_systime;
            label_Date.Font = font_sysdate;

            BtDll.FinishInit += new BtDll.AlertEventHandler(FinishInit_Event);
            BtDll.ChangeCallState += new BtDll.AlertEventHandlerData(ChangeCallState_Event);
            BtDll.DetectedCallNumber += new BtDll.AlertEventHandlerData(DetectedCallNumber_Event);
        }

        private void Form_Phone_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        public void FinishInit_Event(object sender, EventArgs e)
        {
            Action action = FinishInit;
            if (InvokeRequired)
                BeginInvoke(action);
        }

        public void FinishInit()
        {
            BtDll.SetVisibility(2);
        }

        public void DetectedCallNumber_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = DetectedCallNumber;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void DetectedCallNumber(int data)
        {
            Forms.Dial.label_PhoneNumber_1.Text = BtDll.GetCurrentCallNumber();
        }

        public void ChangeCallState_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = ChangeCallState;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void ChangeCallState(int data)
        {
            //switch (BtDll.m_callstate)
            switch (data)
            {
                // Входящий звонок
                case 5:
                    // Если плеер играет - ставим на паузу
                    if (Vars.StatusPlay && Vars.BASS_Stream != 0)
                    {
                        if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                        {
                            PlayerState = true;
                            Bass.BASS_ChannelPause(Vars.BASS_Stream);
                        }
                    }

                    // Сохраняем режим
                    Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();

                    BassStreamCall = Bass.BASS_StreamCreateFile("\\StaticStore\\call.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
                    if (BassStreamCall != 0)
                    {
                        SerialCOM1.Api_SetActivateMode(1);
                        // Устанавливаем громкость звука
                        SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
                        Bass.BASS_ChannelPlay(BassStreamCall, true);
                    }
                    else
                    {
                        SerialCOM1.Api_SetActivateMode(3);
                        // Устанавливаем громкость звука
                        SerialCOM1.Aud_SetVolume(0);
                    }

                    //if (Bluetooth.HandsFreeStatus)
                    if (BtDll.m_out_path == 1)
                    {
                        //BtDll.m_handsfreestatus = 1;
                        //BtDll.VoiceOutPath(1);

                        Forms.Dial.BtnHandsFree.State = false;
                    }
                    else
                    {
                        //BtDll.m_handsfreestatus = 0;

                        Forms.Dial.BtnHandsFree.State = true;
                    }

                    // Посылаем запрос номера звонящего абонента
                    //                    msgform.SendMessage(BTMessage.WM_NFORE_CORE_GET_CALLLOG_AT, 0, 0);

                    //Forms.Dial.label_PhoneNumber_1.Text = BtDll.GetCurrentCallNumber();
                    Forms.Dial.label_PhoneNumber_1.Text = "";

                    PrevFormActive = Vars.FormActivated;
                    Forms.Dial.Left = 0;
                    Forms.Dial.Top = 0;
                    Forms.Dial.Activate();
                    Forms.Dial.TopMost = true;
                    Vars.DialActive = true;
                    Main.HideWindow();

                    Vars.FormActivated = Vars.Form_Active.Dial;

                    //if (Bluetooth.AutoAnswer)
                    //    //msgform.PostMessage(BTMessage.WM_NFORE_CORE_ANSWER, 0, 0);
                    //    Bluetooth.Answer();
                    if (BtDll.m_autoanswer == 1)
                        BtDll.Answer();
                    break;

                // Исходящий звонок
                case 4:
                    // Если плеер играет - ставим на паузу
                    if (Vars.StatusPlay && Vars.BASS_Stream != 0)
                    {
                        if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                        {
                            PlayerState = true;
                            Bass.BASS_ChannelPause(Vars.BASS_Stream);
                        }
                    }

                    // Устанавливаем громкость звука
                    SerialCOM1.Aud_SetVolume(0);
                    SerialCOM1.Api_SetActivateMode(3);
                    SerialCOM1.Api_SetBTMuteState(0);

                    //if (Bluetooth.HandsFreeStatus)
                    if (BtDll.m_out_path == 1)
                    {
                        //BtDll.m_handsfreestatus = 1;
                        Forms.Dial.BtnHandsFree.State = false;
                    }
                    else
                    {
                        //BtDll.m_handsfreestatus = 0;
                        Forms.Dial.BtnHandsFree.State = true;
                    }

                    PrevFormActive = Vars.FormActivated;
                    Forms.Dial.Left = 0;
                    Forms.Dial.Top = 0;
                    Forms.Dial.Activate();
                    Forms.Dial.TopMost = true;
                    Vars.DialActive = true;
                    Forms.Dial.label_PhoneNumber_1.Text = PhoneNumber;
                    Main.HideWindow();

                    Vars.FormActivated = Vars.Form_Active.Dial;

                    Forms.Dial.BtnAnswer.Active = false;

                    // Устанавливаем громкость звука
                    SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
                    break;

                // Режим ожидания
                case 3:
                    if (Vars.FormActivated == Vars.Form_Active.Dial)
                    {
                        // Выключаем мелодию вызова
                        if (BassStreamCall != 0)
                            Bass.BASS_StreamFree(BassStreamCall);

                        // Если плеер играл и стоит на паузе - воспроизводим
                        if (Vars.StatusPlay && Vars.BASS_Stream != 0 && PlayerState)
                        {
                            if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
                            {
                                PlayerState = false;
                                Bass.BASS_ChannelPlay(Vars.BASS_Stream, false);

                            }
                        }
                        // Устанавливаем громкость звука
                        SerialCOM1.Aud_SetVolume(0);
                        SerialCOM1.Api_SetActivateMode(Vars.CurrentMode);
                        if (Vars.CurrentMode != 3)
                            SerialCOM1.Api_SetBTMuteState(1);
                        else
                        {
                            SerialCOM1.Api_SetBTMuteState(0);
                            BtDll.AVRCPCmd(1);
                        }

                        PhoneNumber = "";
                        pictureBoxPhoneNumber.Invalidate();
                        Forms.Dial.BtnAnswer.Active = true;

                        Forms.Dial.TopMost = false;

                        Vars.FormActivated = PrevFormActive;
                        if (Vars.NavigatorActive)
                        {
                            if (Vars.hWndNavigator != IntPtr.Zero)
                            {
                                SetForegroundWindow(Vars.hWndNavigator);
                            }
                        }
                        else
                        {
                            Main.ShowWindow();
                        }
                        Forms.Dial.Left = 801;
                        Forms.Dial.Top = 481;

                        Vars.DialActive = false;

                        Forms.Dial.label_PhoneNumber_1.Text = "";
                        Forms.Dial.label_Name.Text = "";

                        /*           if (Bluetooth.HandsFreeStatus)
                                   {
                                       Forms.Dial.BtnHandsFree.State = false;
                                       msgform.BtnHandsFree.State = 2;
                                   }
                                   else
                                   {
                                       Forms.Dial.BtnHandsFree.State = true;
                                       msgform.BtnHandsFree.State = 3;
                                   }*/

                        // Включаем микрофон, если он был выключен
                        //if (msgform.MicMuteState)
                        //{
                        //    msgform.PostMessage(BTMessage.WM_NFORE_CORE_MIC_MUTE, 0, 0);
                        //}

                        // Восстанавливаем звук
                        SerialCOM1.Aud_SetVolume(MMC_Data.SaveVolume);
                    }
                    break;

                // Звонок принят
                case 6:
                    Forms.Dial.BtnAnswer.Active = false;

                    Forms.Dial.TopMost = false;
                    Vars.DialActive = false;

                    // Выключаем мелодию вызова
                    if (BassStreamCall != 0)
                        Bass.BASS_StreamFree(BassStreamCall);

                    SerialCOM1.Api_SetActivateMode(3);

                    // Если навигатор включен, то переключаемся на него
                    if (Vars.NavigatorActive)
                    {
                        if (Vars.hWndNavigator != IntPtr.Zero)
                        {
                            Forms.Dial.Left = 801;
                            Forms.Dial.Top = 481;
                            SetForegroundWindow(Vars.hWndNavigator);
                        }
                    }

                    //if (Bluetooth.HandsFreeStatus)
                    if (BtDll.m_out_path == 1)
                    {
                        //BtDll.m_handsfreestatus = 1;
                        Forms.Dial.BtnHandsFree.State = false;
                        //msgform.PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 1, 0);
                        //Bluetooth.VoiceOutPath(1);
                        BtDll.VoiceOutPath(0);
                    }
                    else
                    {
                        //BtDll.m_handsfreestatus = 0;
                        Forms.Dial.BtnHandsFree.State = true;
                        //msgform.PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 0, 0);
                        //Bluetooth.VoiceOutPath(0);
                        BtDll.VoiceOutPath(1);
                    }
                    // Устанавливаем громкость звука
                    if (BassStreamCall == 0)
                    {
                        SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
                    }
                    SerialCOM1.Api_SetBTMuteState(0);
                    break;

                default:
                    break;
            }
        }

        public void Deactivate_Phone_Keyboard()
        {
            // Деактивируем клавиатуру
            Btn0.Active = false;
            Btn1.Active = false;
            Btn2.Active = false;
            Btn3.Active = false;
            Btn4.Active = false;
            Btn5.Active = false;
            Btn6.Active = false;
            Btn7.Active = false;
            Btn8.Active = false;
            Btn9.Active = false;
            BtnDelSymbol.Active = false;
            BtnDial.Active = false;
            BtnHandsFree.State = 1;
            BtnPhoneBook.Active = false;
            BtnPlayMusic.State = 1;
            BtnRedial.Active = false;
            BtnPlus.Active = false;
            BtnReshetka.Active = false;

            pictureBoxPhone.Visible = false;
            Forms.Audio.pictureBoxPhone.Visible = false;
            Main.pictureBoxPhone.Visible = false;
            Forms.Radio.pictureBoxPhone.Visible = false;
            Forms.ScreenSaver.pictureBoxPhone.Visible = false;
            Forms.Settings.pictureBoxPhone.Visible = false;
            Forms.Dial.pictureBoxPhone.Visible = false;

            pictureBoxBattCharge.Visible = false;
            Forms.Audio.pictureBoxBattCharge.Visible = false;
            Main.pictureBoxBattCharge.Visible = false;
            Forms.Radio.pictureBoxBattCharge.Visible = false;
            Forms.ScreenSaver.pictureBoxBattCharge.Visible = false;
            Forms.Settings.pictureBoxBattCharge.Visible = false;
            Forms.Dial.pictureBoxBattCharge.Visible = false;
        }

        public void Activate_Phone_Board()
        {
            // Активизируем клавиатуру
            Btn0.Active = true;
            Btn1.Active = true;
            Btn2.Active = true;
            Btn3.Active = true;
            Btn4.Active = true;
            Btn5.Active = true;
            Btn6.Active = true;
            Btn7.Active = true;
            Btn8.Active = true;
            Btn9.Active = true;
            BtnDelSymbol.Active = true;
            BtnDial.Active = true;
            BtnHandsFree.State = 2;
            BtnPhoneBook.Active = true;
            BtnPlayMusic.State = 2;
            BtnRedial.Active = true;
            BtnPlus.Active = true;
            BtnReshetka.Active = true;


            pictureBoxPhone.Visible = true;
            Forms.Audio.pictureBoxPhone.Visible = true;
            Main.pictureBoxPhone.Visible = true;
            Forms.Radio.pictureBoxPhone.Visible = true;
            Forms.ScreenSaver.pictureBoxPhone.Visible = true;
            Forms.Settings.pictureBoxPhone.Visible = true;
            Forms.Dial.pictureBoxPhone.Visible = true;

            pictureBoxBattCharge.Visible = true;
            Forms.Audio.pictureBoxBattCharge.Visible = true;
            Main.pictureBoxBattCharge.Visible = true;
            Forms.Radio.pictureBoxBattCharge.Visible = true;
            Forms.ScreenSaver.pictureBoxBattCharge.Visible = true;
            Forms.Settings.pictureBoxBattCharge.Visible = true;
            Forms.Dial.pictureBoxBattCharge.Visible = true;
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Main.Left = 0;
            Main.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Main.Activate();
            Vars.FormActivated = Vars.Form_Active.Main;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "1";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "2";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "3";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "4";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "5";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "6";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "7";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "8";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "9";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "0";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "*";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void BtnReshetka_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            PhoneNumber = PhoneNumber + "#";
            pictureBoxPhoneNumber.Invalidate();
        }

        private void pictureBoxPhoneNumber_Paint(object sender, PaintEventArgs e)
        {
            StringFormat stringformat = new StringFormat()
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };

            try
            {
                e.Graphics.DrawString(PhoneNumber, font_PhoneNumber,
                        new SolidBrush(Color.White), pictureBoxPhoneNumber.Width - 20, pictureBoxPhoneNumber.Height / 2, stringformat);

            }
            catch { }
        }

        private void BtnDelSymbol_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (PhoneNumber.Length != 0)
            {
                PhoneNumber = PhoneNumber.Remove(PhoneNumber.Length - 1, 1);
            }
            pictureBoxPhoneNumber.Invalidate();
        }

        //bool SetPhoneNumber()
        //{
        //    RegistryKey reg = Registry.CurrentUser.OpenSubKey("\\Software\\nFore\\BTAP\\DataCore", true);

        //    byte[] Num = new byte[24];

        //    Encoding.Unicode.GetBytes(PhoneNumber, 0, PhoneNumber.Length, Num, 0);

        //    reg.SetValue("Data_03", Num);
        //    reg.Close();
        //    return true;
        //}

        /*       string GetPhoneNumber()
               {
                   RegistryKey reg = Registry.CurrentUser.OpenSubKey("\\Software\\nFore\\BTAP\\DataCore", true);
                   byte[] value = (byte[])reg.GetValue("Data_03");
                   reg.Close();
                   byte[] temp = new byte[12];
                   int i = 0;
                   foreach (byte val in value)
                   {
                       if (val != 0x00)
                       {
                           temp[i] = val;
                           i++;
                       }
                   }
                   return _1251ToUnicode(temp);
               }*/

        private void Form_Phone_Closing(object sender, CancelEventArgs e)
        {
            //PostMessage(BTMessage.WM_NFORE_CORE_APP_CLOSE, 0, 0);
            //this.MsgWin.Dispose();
            BtDll.FinishInit -= new BtDll.AlertEventHandler(FinishInit_Event);
            BtDll.ChangeCallState += new BtDll.AlertEventHandlerData(ChangeCallState_Event);
            BtDll.DetectedCallNumber -= new BtDll.AlertEventHandlerData(DetectedCallNumber_Event);
        }

        // Класс приема сообщений Windows
        //public class MsgWindow : MessageWindow
        //{
        //    // Create an instance of the form.
        //    private Form_Phone msgform;

        //    bool PlayerState = false;

        //    // Save a reference to the form so it can
        //    // be notified when messages are received.
        //    public MsgWindow(Form_Phone msgform)
        //    {
        //        this.msgform = msgform;
        //    }

        //    byte[] GetCardAbonent(int Index)
        //    {
        //        RegistryKey reg = Registry.CurrentUser.OpenSubKey("\\Software\\nFore\\BTAP\\DataUI", true);
        //        byte[] value;
        //        if (Index < 10)
        //        {
        //            value = (byte[])reg.GetValue("Data_0" + Index.ToString());
        //        }
        //        else
        //        {
        //            value = (byte[])reg.GetValue("Data_" + Index.ToString());
        //        }
        //        reg.Close();

        //        return value;
        //    }

        //    // Override the default WndProc behavior to examine messages.
        //    protected override void WndProc(ref Microsoft.WindowsCE.Forms.Message msg)
        //    {
        //        // Инициализация устройства завершена
        //        //if (msg.Msg == BTMessage.WM_NFORE_UI_INITIAL_COMPLETE)
        //        //if (msg.Msg == BTMessage.WM_BT_FINISH_INIT)
        //        //{
        //        //    //msgform.SendMessage(BTMessage.WM_NFORE_CORE_SET_LOCAL_DEV_NAME, 0, 1);
        //        //    //msgform.SendMessage(BTMessage.WM_NFORE_CORE_VISIBILITY, 2, 0);
        //        //    //Bluetooth.SetVisibility(2);
        //        //    BtDll.SetVisibility(2);
        //        //    //msgform.SendMessage(BTMessage.WM_NFORE_CORE_LOG_BIN, 0, 0);
        //        //}

        //        // HFP STATE

        //        //if (msg.Msg == BTMessage.WM_NFORE_UI_HFP_STATE)
        //        //if (msg.Msg == BTMessage.WM_BT_CHANGE_CALL_STATE)
        //        //{
        //        //    //Bluetooth.HFP_STATE = msg.WParam.ToInt32();
        //        //    //switch (Bluetooth.HFP_STATE)
        //        //    switch (BtDll.m_callstate)       
        //        //    {
        //        //        // Входящий звонок
        //        //        case 5:
        //        //            // Если плеер играет - ставим на паузу
        //        //            if (Vars.StatusPlay && Vars.BASS_Stream != 0)
        //        //            {
        //        //                if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING)
        //        //                {
        //        //                    PlayerState = true;
        //        //                    Bass.BASS_ChannelPause(Vars.BASS_Stream);
        //        //                }
        //        //            }

        //        //            // Сохраняем режим
        //        //            Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();

        //        //            msgform.BassStreamCall = Bass.BASS_StreamCreateFile("\\StaticStore\\call.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
        //        //            if (msgform.BassStreamCall != 0)
        //        //            {
        //        //                SerialCOM1.Api_SetActivateMode(1);
        //        //                // Устанавливаем громкость звука
        //        //                SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
        //        //                Bass.BASS_ChannelPlay(msgform.BassStreamCall, true);
        //        //            }
        //        //            else
        //        //            {
        //        //                SerialCOM1.Api_SetActivateMode(3);
        //        //                // Устанавливаем громкость звука
        //        //                SerialCOM1.Aud_SetVolume(0);
        //        //            }

        //        //            //if (Bluetooth.HandsFreeStatus)
        //        //            if (BtDll.m_handsfreestatus == 0)
        //        //            {
        //        //                BtDll.m_handsfreestatus = 1;
        //        //                Forms.Dial.BtnHandsFree.State = false;
        //        //            }
        //        //            else
        //        //            {
        //        //                BtDll.m_handsfreestatus = 0;
        //        //                Forms.Dial.BtnHandsFree.State = true;
        //        //            }

        //        //            // Посылаем запрос номера звонящего абонента
        //        //            //                    msgform.SendMessage(BTMessage.WM_NFORE_CORE_GET_CALLLOG_AT, 0, 0);

        //        //            msgform.PrevFormActive = Vars.FormActivated;
        //        //            Forms.Dial.Left = 0;
        //        //            Forms.Dial.Top = 0;
        //        //            Forms.Dial.Activate();
        //        //            Forms.Dial.TopMost = true;
        //        //            Vars.DialActive = true;
        //        //            Main.HideWindow();

        //        //            Vars.FormActivated = Vars.Form_Active.Dial;

        //        //            //if (Bluetooth.AutoAnswer)
        //        //            //    //msgform.PostMessage(BTMessage.WM_NFORE_CORE_ANSWER, 0, 0);
        //        //            //    Bluetooth.Answer();
        //        //            if (BtDll.m_autoanswer == 1)
        //        //                BtDll.Answer();
        //        //            break;

        //        //        // Исходящий звонок
        //        //        case 4:
        //        //            // Если плеер играет - ставим на паузу
        //        //            if (Vars.StatusPlay && Vars.BASS_Stream != 0)
        //        //            {
        //        //                if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING)
        //        //                {
        //        //                    PlayerState = true;
        //        //                    Bass.BASS_ChannelPause(Vars.BASS_Stream);
        //        //                }
        //        //            }

        //        //            // Устанавливаем громкость звука
        //        //            SerialCOM1.Aud_SetVolume(0);
        //        //            SerialCOM1.Api_SetActivateMode(3);
        //        //            SerialCOM1.Api_SetBTMuteState(0);

        //        //            //if (Bluetooth.HandsFreeStatus)
        //        //            if (BtDll.m_handsfreestatus == 0)
        //        //            {
        //        //                BtDll.m_handsfreestatus = 1;
        //        //                Forms.Dial.BtnHandsFree.State = false;
        //        //            }
        //        //            else
        //        //            {
        //        //                BtDll.m_handsfreestatus = 0;
        //        //                Forms.Dial.BtnHandsFree.State = true;
        //        //            }

        //        //            msgform.PrevFormActive = Vars.FormActivated;
        //        //            Forms.Dial.Left = 0;
        //        //            Forms.Dial.Top = 0;
        //        //            Forms.Dial.Activate();
        //        //            Forms.Dial.TopMost = true;
        //        //            Vars.DialActive = true;
        //        //            Forms.Dial.label_PhoneNumber_1.Text = msgform.PhoneNumber;
        //        //            Main.HideWindow();

        //        //            Vars.FormActivated = Vars.Form_Active.Dial;

        //        //            Forms.Dial.BtnAnswer.Active = false;

        //        //            // Устанавливаем громкость звука
        //        //            SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
        //        //            break;

        //        //        // Режим ожидания
        //        //        case 3:
        //        //            if (Vars.FormActivated == Vars.Form_Active.Dial)
        //        //            {
        //        //                // Выключаем мелодию вызова
        //        //                if (msgform.BassStreamCall != 0)
        //        //                    Bass.BASS_StreamFree(msgform.BassStreamCall);

        //        //                // Если плеер играл и стоит на паузе - воспроизводим
        //        //                if (Vars.StatusPlay && Vars.BASS_Stream != 0 && PlayerState)
        //        //                {
        //        //                    if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
        //        //                    {
        //        //                        PlayerState = false;
        //        //                        Bass.BASS_ChannelPlay(Vars.BASS_Stream, false);

        //        //                    }
        //        //                }
        //        //                // Устанавливаем громкость звука
        //        //                SerialCOM1.Aud_SetVolume(0);
        //        //                SerialCOM1.Api_SetActivateMode(Vars.CurrentMode);
        //        //                SerialCOM1.Api_SetBTMuteState(1);

        //        //                msgform.PhoneNumber = "";
        //        //                msgform.pictureBoxPhoneNumber.Invalidate();
        //        //                Forms.Dial.BtnAnswer.Active = true;

        //        //                Forms.Dial.TopMost = false;

        //        //                Vars.FormActivated = msgform.PrevFormActive;
        //        //                if (Vars.NavigatorActive)
        //        //                {
        //        //                    if (Vars.hWndNavigator != IntPtr.Zero)
        //        //                    {
        //        //                        SetForegroundWindow(Vars.hWndNavigator);
        //        //                    }
        //        //                }
        //        //                else
        //        //                {
        //        //                    Main.ShowWindow();
        //        //                }
        //        //                Forms.Dial.Left = 801;
        //        //                Forms.Dial.Top = 481;

        //        //                Vars.DialActive = false;

        //        //                Forms.Dial.label_PhoneNumber_1.Text = "";
        //        //                Forms.Dial.label_Name.Text = "";

        //        //                /*           if (Bluetooth.HandsFreeStatus)
        //        //                           {
        //        //                               Forms.Dial.BtnHandsFree.State = false;
        //        //                               msgform.BtnHandsFree.State = 2;
        //        //                           }
        //        //                           else
        //        //                           {
        //        //                               Forms.Dial.BtnHandsFree.State = true;
        //        //                               msgform.BtnHandsFree.State = 3;
        //        //                           }*/

        //        //                // Включаем микрофон, если он был выключен
        //        //                //if (msgform.MicMuteState)
        //        //                //{
        //        //                //    msgform.PostMessage(BTMessage.WM_NFORE_CORE_MIC_MUTE, 0, 0);
        //        //                //}

        //        //                // Восстанавливаем звук
        //        //                SerialCOM1.Aud_SetVolume(MMC_Data.SaveVolume);
        //        //            }
        //        //            break;

        //        //        // Звонок принят
        //        //        case 6:
        //        //            Forms.Dial.BtnAnswer.Active = false;

        //        //            Forms.Dial.TopMost = false;
        //        //            Vars.DialActive = false;

        //        //            // Выключаем мелодию вызова
        //        //            if (msgform.BassStreamCall != 0)
        //        //                Bass.BASS_StreamFree(msgform.BassStreamCall);

        //        //            SerialCOM1.Api_SetActivateMode(3);

        //        //            // Если навигатор включен, то переключаемся на него
        //        //            if (Vars.NavigatorActive)
        //        //            {
        //        //                if (Vars.hWndNavigator != IntPtr.Zero)
        //        //                {
        //        //                    Forms.Dial.Left = 801;
        //        //                    Forms.Dial.Top = 481;
        //        //                    SetForegroundWindow(Vars.hWndNavigator);
        //        //                }
        //        //            }

        //        //            //if (Bluetooth.HandsFreeStatus)
        //        //            if (BtDll.m_handsfreestatus == 0)
        //        //            {
        //        //                BtDll.m_handsfreestatus = 1;
        //        //                Forms.Dial.BtnHandsFree.State = false;
        //        //                //msgform.PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 1, 0);
        //        //                //Bluetooth.VoiceOutPath(1);
        //        //                BtDll.VoiceOutPath(1);
        //        //            }
        //        //            else
        //        //            {
        //        //                BtDll.m_handsfreestatus = 0;
        //        //                Forms.Dial.BtnHandsFree.State = true;
        //        //                //msgform.PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 0, 0);
        //        //                //Bluetooth.VoiceOutPath(0);
        //        //                BtDll.VoiceOutPath(0);
        //        //            }
        //        //            // Устанавливаем громкость звука
        //        //            if (msgform.BassStreamCall == 0)
        //        //            {
        //        //                SerialCOM1.Aud_SetVolume(MMC_Data.VolumeDial);
        //        //            }
        //        //            SerialCOM1.Api_SetBTMuteState(0);
        //        //            break;

        //        //        default:
        //        //            break;
        //        //    }
        //        //}


        //        // Получение информации об абоненте
        //        //////if (msg.Msg == BTMessage.WM_NFORE_UI_CALLLOG_DATA)
        //        //////{
        //        //////    if (msg.WParam != new IntPtr(-1))
        //        //////    {
        //        //////        // Получаем данные о местонахождении карточки абонента в реестре
        //        //////        // Читаем данные из реестра
        //        //////        byte[] data = GetCardAbonent(msg.LParam.ToInt32());

        //        //////        string str = Encoding.Unicode.GetString(data, 0, data.Length);
        //        //////        string[] str_data = System.Text.RegularExpressions.Regex.Split(str, "\r\n");

        //        //////        try
        //        //////        {
        //        //////            Forms.Dial.label_PhoneNumber_1.Text = str_data[1];
        //        //////            Forms.Dial.label_Name.Text = str_data[3];
        //        //////        }
        //        //////        catch { }
        //        //////    }
        //        //////    else
        //        //////    {
        //        //////        Forms.Dial.label_PhoneNumber_1.Text = "Не определен";
        //        //////        Forms.Dial.label_Name.Text = "";
        //        //////    }
        //        //////}

        //        // Статус гарнитуры
        //        ////           if (msg.Msg == BTMessage.WM_NFORE_UI_SPK_MUTE_STATE)
        //        ////           {
        //        ////               if (Bluetooth.HFP_STATE == 6)
        //        ////               {
        //        ////                   // Если 1, гарнитура включена
        //        /////*                   if (msg.WParam == new IntPtr(1))
        //        ////                   {
        //        ////                       Bluetooth.HandsFreeStatus = true;
        //        ////                       msgform.BtnHandsFree.State = 2;
        //        ////                       Forms.Dial.BtnHandsFree.State = false;

        //        ////                       msgform.MicMuteState = false;
        //        ////                       Forms.Dial.BtnMicMute.State = 1;
        //        ////                   }
        //        ////                   else if (msg.WParam == new IntPtr(0))
        //        ////                   {
        //        ////                       Bluetooth.HandsFreeStatus = false;
        //        ////                       msgform.BtnHandsFree.State = 3;
        //        ////                       Forms.Dial.BtnHandsFree.State = true;
        //        ////                   }*/
        //        ////               }
        //        ////           }

        //        // Статус микрофона
        //        ////if (msg.Msg == BTMessage.WM_NFORE_UI_MIC_MUTE_STATE)
        //        ////{
        //        ////    // Если 1, то микрофон работает, если 0, то микрофон выключен
        //        ////    if (msg.WParam == new IntPtr(0))
        //        ////    {
        //        ////        msgform.MicMuteState = true;
        //        ////        Forms.Dial.BtnMicMute.State = 2;
        //        ////    }
        //        ////    else
        //        ////    {
        //        ////        msgform.MicMuteState = false;
        //        ////        Forms.Dial.BtnMicMute.State = 1;
        //        ////    }
        //        ////}

        //        //if (msg.Msg == BTMessage.WM_NFORE_UI_PB_DL_END)
        //        //{
        //        //    msgform.BtnPhoneBook.Active = true;
        //        //}

        //        // Call the base WndProc method
        //        // to process any messages not handled.
        //        base.WndProc(ref msg);
        //    }
        //}

        private void BtnRedial_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //PostMessage(BTMessage.WM_NFORE_CORE_REDIAL, 0, 0);
            //Bluetooth.ReDial();
            BtDll.ReDial();
        }

        private void BtnPhoneSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.PhoneSettings.Left = 0;
            Forms.PhoneSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.PhoneSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.Phone_PhoneSettings;
            //Bluetooth.ShowWndSettings();
        }

        private void BtnDial_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //SetPhoneNumber();
            //PostMessage(BTMessage.WM_NFORE_CORE_DIAL, 0, 3);
            //Bluetooth.DialA(PhoneNumber);
            BtDll.Dial(PhoneNumber);
        }

        private void BtnHandsFree_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //if (Bluetooth.HandsFreeStatus)
            //if (Bluetooth.GetOutPathState() == 1)
            if (BtDll.m_out_path == 1)
            {
                //Bluetooth.HandsFreeStatus = false;
                //BtDll.m_handsfreestatus = 0;
                BtnHandsFree.State = 3;
                //          Forms.Dial.BtnHandsFree.State = true;
                //          PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 0, 0);
                //Bluetooth.VoiceOutPath(0);
                BtDll.VoiceOutPath(0);
            }
            else
            {
                //Bluetooth.HandsFreeStatus = true;
                //BtDll.m_handsfreestatus = 1;
                BtnHandsFree.State = 2;
                //         Forms.Dial.BtnHandsFree.State = false;
                //         PostMessage(BTMessage.WM_NFORE_CORE_AUDIO_TRANSFER, 1, 0);
                //Bluetooth.VoiceOutPath(1);
                BtDll.VoiceOutPath(1);
            }
        }

        private void BtnPhoneBook_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //PostMessage(BTMessage.WM_NFORE_CORE_PB_DOWNLOAD, 0, 0);
            BtnPhoneBook.Active = false;
        }

        private void Form_Phone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void BtnPlayMusic_Click(object sender, EventArgs e)
        {
            if (BtnPlayMusic.State != 1)
            {
                Vars.timerScreenSaverTick = 0;
                Forms.PlayerPhone.Left = 0;
                Forms.PlayerPhone.Top = 0;
                this.Left = 801;
                this.Top = 481;
                Forms.PlayerPhone.Activate();
                Vars.FormActivated = Vars.Form_Active.PlayerPhone;
                //PostMessage(BTMessage.WM_NFORE_CORE_AVRCP_CMD, 3, 0);
                //Bluetooth.AVRCPCmd(3);

                SerialCOM1.Api_SetActivateMode(3);
                SerialCOM1.Api_SetBTMuteState(0);
                //Bluetooth.Mute(0);
            }
        }

        private void pictureBoxPhoneNumber_Click(object sender, EventArgs e)
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

        private void pictureBoxMute_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //BtDll.UpdateLocalDeviceStatus();
			/*if (Bluetooth.GetConnState() != 3)
            {
                Deactivate_Phone_Keyboard();
            }
            else
            {
                Activate_Phone_Board();
                if (Bluetooth.GetSoundStreamState() == 1)
                {
                    Forms.PlayerPhone.Button_Pause.Visible = true;
                    Forms.PlayerPhone.Button_Play.Visible = false;
                }
                else
                {
                    Forms.PlayerPhone.Button_Pause.Visible = false;
                    Forms.PlayerPhone.Button_Play.Visible = true;
                }
            }*/
        }
    }
}