using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using MMC_Resources;
using System.IO;
using Service;
using Un4seen.Bass;

namespace MMC_Player_2
{
    public partial class Form_Radio : Form
    {
        Form_Main Main;

        [DllImport("coredll.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);
        [DllImport("coredll.dll")]
        private extern static uint SetLocalTime(ref SYSTEMTIME lpSystemTime);

        Font font_freq = new Font("Kor_Itelma", 72F, FontStyle.Regular);
        Font font_MHz_kHz = new Font("Kor_Itelma", 20F, FontStyle.Regular);
        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);
        Font font_rds = new Font("Kor_Itelma", 20F, FontStyle.Regular);
        Font font_Button_Freq = new Font("Kor_Itelma", 12F, FontStyle.Regular);
        

        public Form_Radio(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            SerialCOM1.FreqAMFM += new SerialCOM1.AlertEventHandlerData(Rx_FM);
            SerialCOM1.FreqFM1 += new SerialCOM1.AlertEventHandlerData(Rx_FM1);
            SerialCOM1.RDS += new SerialCOM1.AlertEventHandlerString(SerialCOM1_RDS);
            SerialCOM1.PTY += new SerialCOM1.AlertEventHandlerData(SerialCOM1_PTY);
            SerialCOM1.StereoMessage += new SerialCOM1.AlertEventHandlerData(SerialCOM1_StereoMsg);
            SerialCOM1.TpMsg+=new SerialCOM1.AlertEventHandlerData(SerialCOM1_TpMsg);
            SerialCOM1.Time_RDS += new SerialCOM1.AlertEventHandlerByte(SerialCOM1_TimeRDS);

            // Загрузка изображений в кнопки
            Img_Radio.Image = MMC_Res.Radio_IMG;
            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxWhiteLine.Image = MMC_Res.WhiteLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            BtnStereoStatus.State1 = MMC_Res.Mono_On;
            BtnStereoStatus.State2 = MMC_Res.Stereo_Off;
            BtnStereoStatus.State3 = MMC_Res.Stereo_Off_On;
            BtnStereoStatus.State4 = MMC_Res.Stereo_On;

            Button_Home.BackGndImage = MMC_Res.Radio_BtnBackOff;
            Button_Home.PressedImage = MMC_Res.Radio_BtnBackOn;
            Button_SearchUP.BackGndImage = MMC_Res.Radio_BtnUpOff;
            Button_SearchUP.PressedImage = MMC_Res.Radio_BtnUpOn;
            Button_SearchDOWN.BackGndImage = MMC_Res.Radio_BtnDownOff;
            Button_SearchDOWN.PressedImage = MMC_Res.Radio_BtnDownOn;
            Button_SetAudio.BackGndImage = MMC_Res.Radio_BtnSetAudioOff;
            Button_SetAudio.PressedImage = MMC_Res.Radio_BtnSetAudioOn;
            Button_SetRadio.BackGndImage = MMC_Res.Radio_BtnSetRadioOff;
            Button_SetRadio.PressedImage = MMC_Res.Radio_BtnSetRadioOn;

            Button_Freq_1.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_1.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_1.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_1.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_1.Font = font_Button_Freq;

            Button_Freq_2.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_2.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_2.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_2.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_2.Font = font_Button_Freq;

            Button_Freq_3.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_3.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_3.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_3.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_3.Font = font_Button_Freq;

            Button_Freq_4.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_4.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_4.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_4.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_4.Font = font_Button_Freq;

            Button_Freq_5.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_5.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_5.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_5.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_5.Font = font_Button_Freq;

            Button_Freq_6.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Button_Freq_6.State2 = MMC_Res.Radio_BtnFreqDisOn;
            Button_Freq_6.State3 = MMC_Res.Radio_BtnFreqOff;
            Button_Freq_6.State4 = MMC_Res.Radio_BtnFreqOn;
            Button_Freq_6.Font = font_Button_Freq;

            Button_AM.State1 = MMC_Res.Radio_BtnAMOff;
            Button_AM.State2 = MMC_Res.Radio_BtnAMOn;
            Button_FM1.State1 = MMC_Res.Radio_BtnFM1Off;
            Button_FM1.State2 = MMC_Res.Radio_BtnFM1On;
            Button_FM2.State1 = MMC_Res.Radio_BtnFM2Off;
            Button_FM2.State2 = MMC_Res.Radio_BtnFM2On;
            Button_FM3.State1 = MMC_Res.Radio_BtnFM3Off;
            Button_FM3.State2 = MMC_Res.Radio_BtnFM3On;
            Button_FM4.State1 = MMC_Res.Radio_BtnFM4Off;
            Button_FM4.State2 = MMC_Res.Radio_BtnFM4On;

            // Установка шрифтов
            label_Freq.Font = font_freq;
            label_Mhz_kHz.Font = font_MHz_kHz;
            label_Date.Font = font_sysdate;
            label_Time.Font = font_systime;
            label_RDS.Font = font_rds;

            // Настройка радио
            label_Mhz_kHz.Text = "МГц";
        }

        private void Form_Radio_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;

            if (MMC_Data.Current_Freq >= 522 && MMC_Data.Current_Freq <= 1620)
            {
                Button_AM.State = true;
            }
            else if (MMC_Data.Current_Freq >= 6500 && MMC_Data.Current_Freq <= 7400)
            {
                Button_FM1.State = true;
            }
            else if (MMC_Data.Current_Freq >= 8750 && MMC_Data.Current_Freq <= 10800)
            {
                Button_FM2.Visible = true;
                Button_FM2.State = true;
                Button_FM3.Visible = false;
                Button_FM4.Visible = false;
            }

            SetRDSinfo();

            if (SerialCOM1.Radio_GetStereoStatus())
                BtnStereoStatus.State = 3;
            else BtnStereoStatus.State = 1;

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Установка состояний кнопок пресетов
            RecStateFreqButton();
        }

        private void Form_Radio_Activated(object sender, EventArgs e)
        {
            SetRDSinfo();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            timer_Exit.Enabled = false;

            Main.Left = 0;
            Main.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Main.Activate();
            Vars.FormActivated = Vars.Form_Active.Main;
        }

        public void SetRDSinfo()
        {
            // Отображение настроек RDS
            if (MMC_Data.RDS && SerialCOM1.Radio_GetCurrentBand() == 1)
            {
                if (MMC_Data.RDS) label_infoRDS.Visible = true;
                else label_infoRDS.Visible = false;
                if (MMC_Data.TP) label_infoTP.Visible = true;
                else label_infoTP.Visible = false;
                if (MMC_Data.TA) label_infoTA.Visible = true;
                else label_infoTA.Visible = false;
                if (MMC_Data.AF) label_infoAF.Visible = true;
                else label_infoAF.Visible = false;
                if (MMC_Data.Time_RDS) label_infoCT.Visible = true;
                else label_infoCT.Visible = false;
            }
            else
            {
                label_infoRDS.Visible = false;
                label_infoTP.Visible = false;
                label_infoTA.Visible = false;
                label_infoAF.Visible = false;
                label_infoCT.Visible = false;
            }
        }



        #region Управление поиском радиостанций

        bool timerSearch = false;
        bool searchUp = false;
        bool searchDown = false;
        private void Button_SearchUP_MouseDown(object sender, MouseEventArgs e)
        {
            searchUp = true;
            timer_Search.Enabled = true;
        }

        private void Button_SearchUP_MouseUp(object sender, MouseEventArgs e)
        {
            searchUp = false;
            timer_Search.Enabled = false;
            timerSearch = false;
        }

        private void Button_SearchDOWN_MouseDown(object sender, MouseEventArgs e)
        {
            searchDown = true;
            timer_Search.Enabled = true;
        }

        private void Button_SearchDOWN_MouseUp(object sender, MouseEventArgs e)
        {
            searchDown = false;
            timer_Search.Enabled = false;
            timerSearch = false;
        }

        private void timer_Search_Tick(object sender, EventArgs e)
        {
            timerSearch = true;
            if (searchUp)
            {
                SerialCOM1.Radio_AutoSearch(0);
            }
            if (searchDown)
            {
                SerialCOM1.Radio_AutoSearch(1);
            }
            searchUp = false;
            searchDown = false;
        }

        private void Button_SearchUP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (!timerSearch)
            {
                timerSearch = false;
                SerialCOM1.Radio_ManSearch(0);
            }
        }

        private void Button_SearchDOWN_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (!timerSearch)
            {
                timerSearch = false;
                SerialCOM1.Radio_ManSearch(1);
            }
        }
        #endregion

        #region Отображение частоты, которую выдает радиочип
        private void Rx_FM(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewFreq;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void Rx_FM1(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewFreq;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ViewFreq(int data)
        {
            MMC_Data.Current_Freq = data;
            if (data >= 6500)
            {
                label_Mhz_kHz.Text = "МГц";

                int int_freq = data / 100;
                int mod_freq = data % 100;
                label_Freq.Text = int_freq + "." + String.Format("{0:00}", mod_freq);
            }
            else
            {
                label_Mhz_kHz.Text = "кГц";
                label_Freq.Text = data.ToString();
            }

            RecStateFreqButton();
        }
        #endregion


        private void SerialCOM1_RDS(object sender, EventArgs e, string data)
        {
            Action<string> action = ViewRDS;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ViewRDS(string data)
        {
            if (MMC_Data.RDS)
                label_RDS.Text = data;
            else label_RDS.Text = "";
        }

        private void SerialCOM1_PTY(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewPTY;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ViewPTY(int value)
        {            
            if (MMC_Data.RDS)
            {
                switch (value)
                {
                    case 0:
                        label_PTY.Text = "";
                        break;
                    case 1:
                        label_PTY.Text = "Новости";
                        break;
                    case 2:
                        label_PTY.Text = "Текущие события";
                        break;
                    case 3:
                        label_PTY.Text = "Информация";
                        break;
                    case 4:
                        label_PTY.Text = "Спорт";
                        break;
                    case 5:
                        label_PTY.Text = "Образование";
                        break;
                    case 6:
                        label_PTY.Text = "Пьесы";
                        break;
                    case 7:
                        label_PTY.Text = "Культура";
                        break;
                    case 8:
                        label_PTY.Text = "Наука";
                        break;
                    case 9:
                        label_PTY.Text = "Разное";
                        break;
                    case 10:
                        label_PTY.Text = "Поп-музыка";
                        break;
                    case 11:
                        label_PTY.Text = "Рок-музыка";
                        break;
                    case 12:
                        label_PTY.Text = "Легкая музыка";
                        break;
                    case 13:
                        label_PTY.Text = "Легкая классическая";
                        break;
                    case 14:
                        label_PTY.Text = "Серьезная классическая";
                        break;
                    case 15:
                        label_PTY.Text = "Другая музыка";
                        break;
                    case 16:
                        label_PTY.Text = "Погода";
                        break;
                    case 17:
                        label_PTY.Text = "Финансы";
                        break;
                    case 18:
                        label_PTY.Text = "Детские программы";
                        break;
                    case 19:
                        label_PTY.Text = "Общественные события";
                        break;
                    case 20:
                        label_PTY.Text = "Религия";
                        break;
                    case 21:
                        label_PTY.Text = "Звонок в студию";
                        break;
                    case 22:
                        label_PTY.Text = "Путешествия";
                        break;
                    case 23:
                        label_PTY.Text = "Отдых";
                        break;
                    case 24:
                        label_PTY.Text = "Джазовая музыка";
                        break;
                    case 25:
                        label_PTY.Text = "Музыка кантри";
                        break;
                    case 26:
                        label_PTY.Text = "Национальная музыка";
                        break;
                    case 27:
                        label_PTY.Text = "Старые хиты";
                        break;
                    case 28:
                        label_PTY.Text = "Народная музыка";
                        break;
                    case 29:
                        label_PTY.Text = "Документальные программы";
                        break;
                    default:
                        label_PTY.Text = "";
                        break;
                }
            }
            else
                label_PTY.Text = "";
        }

        private void SerialCOM1_StereoMsg(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewStereoMsg;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ViewStereoMsg(int data)
        {
            // Если стерео включено
            if (SerialCOM1.Radio_GetStereoStatus() && MMC_Data.Current_Band != 2)
            {
                if (data == 0)
                {
                    BtnStereoStatus.State = 3;
                }
                else
                {
                    BtnStereoStatus.State = 4;
                }
            }
            else
            {
                BtnStereoStatus.State = 1;
            }
        }

        private void panel_StereoStatus_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Current_Band != 2)
            {
                if (SerialCOM1.Radio_GetStereoStatus())
                {
                    SerialCOM1.Radio_SetStereoStatus(false);
                    BtnStereoStatus.State = 1;
                }
                else
                {
                    SerialCOM1.Radio_SetStereoStatus(true);
                    BtnStereoStatus.State = 3;
                }
            }
        }

        private void BtnStereoStatus_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Current_Band != 2)
            {
                if (SerialCOM1.Radio_GetStereoStatus())
                {
                    SerialCOM1.Radio_SetStereoStatus(false);
                    BtnStereoStatus.State = 1;
                }
                else
                {
                    SerialCOM1.Radio_SetStereoStatus(true);
                    BtnStereoStatus.State = 3;
                }
            }
        }

        private void SerialCOM1_TpMsg(object sender, EventArgs e, int data)
        {
            Action<int> action = ViewTPMsg;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private void ViewTPMsg(int data)
        {
            if (MMC_Data.RDS && MMC_Data.Current_Band == 1 && data != 0)
            {
                label_infoTP.ForeColor = Color.FromArgb(206, 255, 206);
            }
            else
            {
                label_infoTP.ForeColor = Color.FromArgb(57, 93, 74);
            }
        }

        private void ViewTAMsg(int data)
        {
            if (MMC_Data.RDS && MMC_Data.Current_Band == 1)
            {
                label_infoTA.ForeColor = Color.FromArgb(206, 255, 206);
            }
            else
            {
                label_infoTA.ForeColor = Color.FromArgb(57, 93, 74);
            }
        }

        void SerialCOM1_TimeRDS(object sender, EventArgs e, byte[] data)
        {
            Action<byte[]> action = ViewTimeRDS;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        private struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }

        private void ViewTimeRDS(byte[] data)
        {
            if (MMC_Data.Time_RDS)
            {
                try
                {
                    byte[] JulianDay = { data[4], data[3], 0x00, 0x00 };
                    uint modifiedJulianDay = BitConverter.ToUInt32(JulianDay, 0);
                    uint Year;
                    uint Month;
                    uint Day;
                    uint i;

                    Year = (uint)Math.Floor((modifiedJulianDay - 15078.2) / 365.25);
                    Month = (char)Math.Floor((modifiedJulianDay - 14956.1 - Math.Floor(Year * 365.25)) / 30.6001);
                    Day = (char)(modifiedJulianDay - 14956 - Math.Floor(Year * 365.25) - Math.Floor(Month * 30.6001));

                    if (Month == 14 || Month == 15)
                        i = 1;
                    else
                        i = 0;

                    Year = Year + i + 1900;
                    Month = Month - 1 - (i * 12);

                    SYSTEMTIME settime = new SYSTEMTIME();
                    settime.wHour = Convert.ToUInt16(data[0]);
                    settime.wMinute = Convert.ToUInt16(data[1]);
                    settime.wDay = Convert.ToUInt16(Day);
                    settime.wMonth = Convert.ToUInt16(Month);
                    settime.wYear = Convert.ToUInt16(Year);

                    SetLocalTime(ref settime);

                    DateTime centuryBegin = new DateTime(1970, 1, 1);
                    DateTime currentDate = new DateTime((int)Year, (int)Month, (int)Day, data[0], data[1], 0);
                    long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
                    TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

                    SerialCOM1.Api_SetCurrentTime((uint)elapsedSpan.TotalSeconds);
                }
                catch { }
            }
        }

        private void Button_AM_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            label_RDS.Text = "";
            Button_AM.State = true;
            Button_FM1.State = false;
            if (Button_FM2.Visible) Button_FM2.State = false;
            if (Button_FM3.Visible) Button_FM3.State = false;
            if (Button_FM4.Visible) Button_FM4.State = false;
            SerialCOM1.Radio_SetBand(2);
            SetRDSinfo();

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Запись состояний кнопок пресетов
            RecStateFreqButton();

            // AM всегда моно
            BtnStereoStatus.State = 1;
        }

        private void Button_FM1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            label_RDS.Text = "";
            Button_AM.State = false;
            Button_FM1.State = true;
            if (Button_FM2.Visible) Button_FM2.State = false;
            if (Button_FM3.Visible) Button_FM3.State = false;
            if (Button_FM4.Visible) Button_FM4.State = false;
            SerialCOM1.Radio_SetBand(0);
            SetRDSinfo();

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Запись состояний кнопок пресетов
            RecStateFreqButton();

            // Восстановление стереостатуса
            if (SerialCOM1.Radio_GetStereoStatus())
            {
                SerialCOM1.Radio_SetStereoStatus(true);
                BtnStereoStatus.State = 3;
            }
            else
            {
                SerialCOM1.Radio_SetStereoStatus(false);
                BtnStereoStatus.State = 1;
            }
        }

        private void Button_FM2_Click(object sender, EventArgs e)
        {
            if (SerialCOM1.Radio_GetCurrentBand() != 1) SerialCOM1.Radio_SetBand(1);
            SetRDSinfo();
            Button_AM.State = false;
            Button_FM1.State = false;
            if (Button_FM2.State)
            {
                Button_FM2.State = true;
                Button_FM3.State = false;
                Button_FM4.State = false;
            }
            else
            {
                Button_FM2.Visible = false;
                Button_FM2.State = false;
                Button_FM3.Visible = true;
                Button_FM3.State = true;
                MMC_Data.FM2_Gamm = MMC_Data.FM2_3;
            }

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Запись состояний кнопок пресетов
            RecStateFreqButton();

            // Восстановление стереостатуса
            if (SerialCOM1.Radio_GetStereoStatus())
            {
                SerialCOM1.Radio_SetStereoStatus(true);
                BtnStereoStatus.State = 3;
            }
            else
            {
                SerialCOM1.Radio_SetStereoStatus(false);
                BtnStereoStatus.State = 1;
            }
        }

        private void Button_FM3_Click(object sender, EventArgs e)
        {
            if (SerialCOM1.Radio_GetCurrentBand() != 1) SerialCOM1.Radio_SetBand(1);
            SetRDSinfo();
            Button_AM.State = false;
            Button_FM1.State = false;
            if (Button_FM3.State)
            {
                Button_FM3.State = true;
                Button_FM2.State = false;
                Button_FM4.State = false;
            }
            else
            {
                Button_FM3.Visible = false;
                Button_FM3.State = false;
                Button_FM4.Visible = true;
                Button_FM4.State = true;
                MMC_Data.FM2_Gamm = MMC_Data.FM2_4;
            }

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Запись состояний кнопок пресетов
            RecStateFreqButton();

            // Восстановление стереостатуса
            if (SerialCOM1.Radio_GetStereoStatus())
            {
                SerialCOM1.Radio_SetStereoStatus(true);
                BtnStereoStatus.State = 3;
            }
            else
            {
                SerialCOM1.Radio_SetStereoStatus(false);
                BtnStereoStatus.State = 1;
            }
        }

        private void Button_FM4_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (SerialCOM1.Radio_GetCurrentBand() != 1) SerialCOM1.Radio_SetBand(1);
            SetRDSinfo();
            Button_AM.State = false;
            Button_FM1.State = false;
            if (Button_FM4.State)
            {
                Button_FM4.State = true;
                Button_FM2.State = false;
                Button_FM3.State = false;
            }
            else
            {
                Button_FM4.Visible = false;
                Button_FM4.State = false;
                Button_FM2.Visible = true;
                Button_FM2.State = true;
                MMC_Data.FM2_Gamm = MMC_Data.FM2_2;
            }

            // Запись частот в кнопки пресетов
            RecFreqButton();
            // Запись состояний кнопок пресетов
            RecStateFreqButton();

            // Восстановление стереостатуса
            if (SerialCOM1.Radio_GetStereoStatus())
            {
                SerialCOM1.Radio_SetStereoStatus(true);
                BtnStereoStatus.State = 3;
            }
            else
            {
                SerialCOM1.Radio_SetStereoStatus(false);
                BtnStereoStatus.State = 1;
            }
        }

        private void Button_SetRadio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.RadioSettings.Left = 0;
            Forms.RadioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.RadioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.Radio_RadioSettings;
        }

        private void Button_SetAudio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.AudioSettings.Left = 0;
            Forms.AudioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.Radio_AudioSettings;
        }

        // Управление кнопками
        #region Запись частот в кнопки пресетов

        private string ConvertFreqToString(int value)
        {
            int int_freq = value / 100;
            int mod_freq = value % 100;
            return int_freq + "." + String.Format("{0:00}", mod_freq);
        }

        private void RecFreqButton()
        {
            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                // FM2
                case MMC_Data.FM2:

                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_1_FM2 != 0)
                                Button_Freq_1.Text = ConvertFreqToString(MMC_Data.RadioStation_1_FM2);
                            else
                                Button_Freq_1.Text = "";
                            if (MMC_Data.RadioStation_2_FM2 != 0)
                                Button_Freq_2.Text = ConvertFreqToString(MMC_Data.RadioStation_2_FM2);
                            else
                                Button_Freq_2.Text = "";
                            if (MMC_Data.RadioStation_3_FM2 != 0)
                                Button_Freq_3.Text = ConvertFreqToString(MMC_Data.RadioStation_3_FM2);
                            else
                                Button_Freq_3.Text = "";
                            if (MMC_Data.RadioStation_4_FM2 != 0)
                                Button_Freq_4.Text = ConvertFreqToString(MMC_Data.RadioStation_4_FM2);
                            else
                                Button_Freq_4.Text = "";
                            if (MMC_Data.RadioStation_5_FM2 != 0)
                                Button_Freq_5.Text = ConvertFreqToString(MMC_Data.RadioStation_5_FM2);
                            else
                                Button_Freq_5.Text = "";
                            if (MMC_Data.RadioStation_6_FM2 != 0)
                                Button_Freq_6.Text = ConvertFreqToString(MMC_Data.RadioStation_6_FM2);
                            else
                                Button_Freq_6.Text = "";
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_1_FM3 != 0)
                                Button_Freq_1.Text = ConvertFreqToString(MMC_Data.RadioStation_1_FM3);
                            else
                                Button_Freq_1.Text = "";
                            if (MMC_Data.RadioStation_2_FM3 != 0)
                                Button_Freq_2.Text = ConvertFreqToString(MMC_Data.RadioStation_2_FM3);
                            else
                                Button_Freq_2.Text = "";
                            if (MMC_Data.RadioStation_3_FM3 != 0)
                                Button_Freq_3.Text = ConvertFreqToString(MMC_Data.RadioStation_3_FM3);
                            else
                                Button_Freq_3.Text = "";
                            if (MMC_Data.RadioStation_4_FM3 != 0)
                                Button_Freq_4.Text = ConvertFreqToString(MMC_Data.RadioStation_4_FM3);
                            else
                                Button_Freq_4.Text = "";
                            if (MMC_Data.RadioStation_5_FM3 != 0)
                                Button_Freq_5.Text = ConvertFreqToString(MMC_Data.RadioStation_5_FM3);
                            else
                                Button_Freq_5.Text = "";
                            if (MMC_Data.RadioStation_6_FM3 != 0)
                                Button_Freq_6.Text = ConvertFreqToString(MMC_Data.RadioStation_6_FM3);
                            else
                                Button_Freq_6.Text = "";
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_1_FM4 != 0)
                                Button_Freq_1.Text = ConvertFreqToString(MMC_Data.RadioStation_1_FM4);
                            else
                                Button_Freq_1.Text = "";
                            if (MMC_Data.RadioStation_2_FM4 != 0)
                                Button_Freq_2.Text = ConvertFreqToString(MMC_Data.RadioStation_2_FM4);
                            else
                                Button_Freq_2.Text = "";
                            if (MMC_Data.RadioStation_3_FM4 != 0)
                                Button_Freq_3.Text = ConvertFreqToString(MMC_Data.RadioStation_3_FM4);
                            else
                                Button_Freq_3.Text = "";
                            if (MMC_Data.RadioStation_4_FM4 != 0)
                                Button_Freq_4.Text = ConvertFreqToString(MMC_Data.RadioStation_4_FM4);
                            else
                                Button_Freq_4.Text = "";
                            if (MMC_Data.RadioStation_5_FM4 != 0)
                                Button_Freq_5.Text = ConvertFreqToString(MMC_Data.RadioStation_5_FM4);
                            else
                                Button_Freq_5.Text = "";
                            if (MMC_Data.RadioStation_6_FM4 != 0)
                                Button_Freq_6.Text = ConvertFreqToString(MMC_Data.RadioStation_6_FM4);
                            else
                                Button_Freq_6.Text = "";
                            break;
                        default:
                            break;
                    }

                    break;
                // FM1
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_1_FM1 != 0)
                        Button_Freq_1.Text = ConvertFreqToString(MMC_Data.RadioStation_1_FM1);
                    else
                        Button_Freq_1.Text = "";
                    if (MMC_Data.RadioStation_2_FM1 != 0)
                        Button_Freq_2.Text = ConvertFreqToString(MMC_Data.RadioStation_2_FM1);
                    else
                        Button_Freq_2.Text = "";
                    if (MMC_Data.RadioStation_3_FM1 != 0)
                        Button_Freq_3.Text = ConvertFreqToString(MMC_Data.RadioStation_3_FM1);
                    else
                        Button_Freq_3.Text = "";
                    if (MMC_Data.RadioStation_4_FM1 != 0)
                        Button_Freq_4.Text = ConvertFreqToString(MMC_Data.RadioStation_4_FM1);
                    else
                        Button_Freq_4.Text = "";
                    if (MMC_Data.RadioStation_5_FM1 != 0)
                        Button_Freq_5.Text = ConvertFreqToString(MMC_Data.RadioStation_5_FM1);
                    else
                        Button_Freq_5.Text = "";
                    if (MMC_Data.RadioStation_6_FM1 != 0)
                        Button_Freq_6.Text = ConvertFreqToString(MMC_Data.RadioStation_6_FM1);
                    else
                        Button_Freq_6.Text = "";
                    break;
                // AM
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_1_AM != 0)
                        Button_Freq_1.Text = MMC_Data.RadioStation_1_AM.ToString();
                    else
                        Button_Freq_1.Text = "";
                    if (MMC_Data.RadioStation_2_AM != 0)
                        Button_Freq_2.Text = MMC_Data.RadioStation_2_AM.ToString();
                    else
                        Button_Freq_2.Text = "";
                    if (MMC_Data.RadioStation_3_AM != 0)
                        Button_Freq_3.Text = MMC_Data.RadioStation_3_AM.ToString();
                    else
                        Button_Freq_3.Text = "";
                    if (MMC_Data.RadioStation_4_AM != 0)
                        Button_Freq_4.Text = MMC_Data.RadioStation_4_AM.ToString();
                    else
                        Button_Freq_4.Text = "";
                    if (MMC_Data.RadioStation_5_AM != 0)
                        Button_Freq_5.Text = MMC_Data.RadioStation_5_AM.ToString();
                    else
                        Button_Freq_5.Text = "";
                    if (MMC_Data.RadioStation_6_AM != 0)
                        Button_Freq_6.Text = MMC_Data.RadioStation_6_AM.ToString();
                    else
                        Button_Freq_6.Text = "";
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Запись состояний кнопок пресетов
        private void RecStateFreqButton()
        {
            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                // FM2
                case MMC_Data.FM2:

                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_1_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_1_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_1.State = 4;
                                else Button_Freq_1.State = 3;
                            }
                            else Button_Freq_1.State = 1;

                            if (MMC_Data.RadioStation_2_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_2_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_2.State = 4;
                                else Button_Freq_2.State = 3;
                            }
                            else Button_Freq_2.State = 1;

                            if (MMC_Data.RadioStation_3_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_3_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_3.State = 4;
                                else Button_Freq_3.State = 3;
                            }
                            else Button_Freq_3.State = 1;

                            if (MMC_Data.RadioStation_4_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_4_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_4.State = 4;
                                else Button_Freq_4.State = 3;
                            }
                            else Button_Freq_4.State = 1;

                            if (MMC_Data.RadioStation_5_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_5_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_5.State = 4;
                                else Button_Freq_5.State = 3;
                            }
                            else Button_Freq_5.State = 1;

                            if (MMC_Data.RadioStation_6_FM2 != 0)
                            {
                                if (MMC_Data.RadioStation_6_FM2 == MMC_Data.Current_Freq)
                                    Button_Freq_6.State = 4;
                                else Button_Freq_6.State = 3;
                            }
                            else Button_Freq_6.State = 1;
                            break;
                        // FM3
                        case MMC_Data.FM2_3:

                            if (MMC_Data.RadioStation_1_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_1_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_1.State = 4;
                                else Button_Freq_1.State = 3;
                            }
                            else Button_Freq_1.State = 1;

                            if (MMC_Data.RadioStation_2_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_2_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_2.State = 4;
                                else Button_Freq_2.State = 3;
                            }
                            else Button_Freq_2.State = 1;

                            if (MMC_Data.RadioStation_3_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_3_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_3.State = 4;
                                else Button_Freq_3.State = 3;
                            }
                            else Button_Freq_3.State = 1;

                            if (MMC_Data.RadioStation_4_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_4_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_4.State = 4;
                                else Button_Freq_4.State = 3;
                            }
                            else Button_Freq_4.State = 1;

                            if (MMC_Data.RadioStation_5_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_5_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_5.State = 4;
                                else Button_Freq_5.State = 3;
                            }
                            else Button_Freq_5.State = 1;

                            if (MMC_Data.RadioStation_6_FM3 != 0)
                            {
                                if (MMC_Data.RadioStation_6_FM3 == MMC_Data.Current_Freq)
                                    Button_Freq_6.State = 4;
                                else Button_Freq_6.State = 3;
                            }
                            else Button_Freq_6.State = 1;
                            break;
                        // FM4
                        case MMC_Data.FM2_4:

                            if (MMC_Data.RadioStation_1_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_1_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_1.State = 4;
                                else Button_Freq_1.State = 3;
                            }
                            else Button_Freq_1.State = 1;

                            if (MMC_Data.RadioStation_2_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_2_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_2.State = 4;
                                else Button_Freq_2.State = 3;
                            }
                            else Button_Freq_2.State = 1;

                            if (MMC_Data.RadioStation_3_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_3_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_3.State = 4;
                                else Button_Freq_3.State = 3;
                            }
                            else Button_Freq_3.State = 1;

                            if (MMC_Data.RadioStation_4_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_4_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_4.State = 4;
                                else Button_Freq_4.State = 3;
                            }
                            else Button_Freq_4.State = 1;

                            if (MMC_Data.RadioStation_5_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_5_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_5.State = 4;
                                else Button_Freq_5.State = 3;
                            }
                            else Button_Freq_5.State = 1;

                            if (MMC_Data.RadioStation_6_FM4 != 0)
                            {
                                if (MMC_Data.RadioStation_6_FM4 == MMC_Data.Current_Freq)
                                    Button_Freq_6.State = 4;
                                else Button_Freq_6.State = 3;
                            }
                            else Button_Freq_6.State = 1;
                            break;
                        default:
                            break;
                    }

                    break;
                // FM1
                case MMC_Data.FM1:

                    if (MMC_Data.RadioStation_1_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_1_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_1.State = 4;
                        else Button_Freq_1.State = 3;
                    }
                    else Button_Freq_1.State = 1;

                    if (MMC_Data.RadioStation_2_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_2_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_2.State = 4;
                        else Button_Freq_2.State = 3;
                    }
                    else Button_Freq_2.State = 1;

                    if (MMC_Data.RadioStation_3_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_3_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_3.State = 4;
                        else Button_Freq_3.State = 3;
                    }
                    else Button_Freq_3.State = 1;

                    if (MMC_Data.RadioStation_4_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_4_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_4.State = 4;
                        else Button_Freq_4.State = 3;
                    }
                    else Button_Freq_4.State = 1;

                    if (MMC_Data.RadioStation_5_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_5_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_5.State = 4;
                        else Button_Freq_5.State = 3;
                    }
                    else Button_Freq_5.State = 1;

                    if (MMC_Data.RadioStation_6_FM1 != 0)
                    {
                        if (MMC_Data.RadioStation_6_FM1 == MMC_Data.Current_Freq)
                            Button_Freq_6.State = 4;
                        else Button_Freq_6.State = 3;
                    }
                    else Button_Freq_6.State = 1;

                    break;
                // AM
                case MMC_Data.AM:

                    if (MMC_Data.RadioStation_1_AM != 0)
                    {
                        if (MMC_Data.RadioStation_1_AM == MMC_Data.Current_Freq)
                            Button_Freq_1.State = 4;
                        else Button_Freq_1.State = 3;
                    }
                    else Button_Freq_1.State = 1;

                    if (MMC_Data.RadioStation_2_AM != 0)
                    {
                        if (MMC_Data.RadioStation_2_AM == MMC_Data.Current_Freq)
                            Button_Freq_2.State = 4;
                        else Button_Freq_2.State = 3;
                    }
                    else Button_Freq_2.State = 1;

                    if (MMC_Data.RadioStation_3_AM != 0)
                    {
                        if (MMC_Data.RadioStation_3_AM == MMC_Data.Current_Freq)
                            Button_Freq_3.State = 4;
                        else Button_Freq_3.State = 3;
                    }
                    else Button_Freq_3.State = 1;

                    if (MMC_Data.RadioStation_4_AM != 0)
                    {
                        if (MMC_Data.RadioStation_4_AM == MMC_Data.Current_Freq)
                            Button_Freq_4.State = 4;
                        else Button_Freq_4.State = 3;
                    }
                    else Button_Freq_4.State = 1;

                    if (MMC_Data.RadioStation_5_AM != 0)
                    {
                        if (MMC_Data.RadioStation_5_AM == MMC_Data.Current_Freq)
                            Button_Freq_5.State = 4;
                        else Button_Freq_5.State = 3;
                    }
                    else Button_Freq_5.State = 1;

                    if (MMC_Data.RadioStation_6_AM != 0)
                    {
                        if (MMC_Data.RadioStation_6_AM == MMC_Data.Current_Freq)
                            Button_Freq_6.State = 4;
                        else Button_Freq_6.State = 3;
                    }
                    else Button_Freq_6.State = 1;
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void Button_Freq_1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_1_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_1_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_1_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_1_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_1_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_1_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_1_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_1_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_1_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_1_AM);
                    break;
                default:
                    break;
            }
        }

        private void Button_Freq_2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_2_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_2_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_2_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_2_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_2_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_2_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_2_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_2_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_2_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_2_AM);
                    break;
                default:
                    break;
            }
        }

        private void Button_Freq_3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_3_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_3_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_3_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_3_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_3_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_3_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_3_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_3_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_3_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_3_AM);
                    break;
                default:
                    break;
            }
        }

        private void Button_Freq_4_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_4_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_4_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_4_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_4_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_4_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_4_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_4_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_4_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_4_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_4_AM);
                    break;
                default:
                    break;
            }
        }

        private void Button_Freq_5_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_5_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_5_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_5_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_5_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_5_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_5_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_5_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_5_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_5_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_5_AM);
                    break;
                default:
                    break;
            }
        }

        private void Button_Freq_6_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            // Отмена записи частоты
            timerSaveStation.Enabled = false;
            Flag_ButtonFreq = 0;
            // Установка состояний кнопок пресетов
            if (timerSaveStation_tick != 0) RecStateFreqButton();
            timerSaveStation_tick = 0;

            switch (SerialCOM1.Radio_GetCurrentBand())
            {
                case MMC_Data.FM2:
                    switch (MMC_Data.FM2_Gamm)
                    {
                        // FM2
                        case MMC_Data.FM2_2:
                            if (MMC_Data.RadioStation_6_FM2 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_6_FM2);
                            break;
                        // FM3
                        case MMC_Data.FM2_3:
                            if (MMC_Data.RadioStation_6_FM3 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_6_FM3);
                            break;
                        // FM4
                        case MMC_Data.FM2_4:
                            if (MMC_Data.RadioStation_6_FM4 != 0)
                                SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_6_FM4);
                            break;
                        default:
                            break;
                    }
                    break;
                case MMC_Data.FM1:
                    if (MMC_Data.RadioStation_6_FM1 != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_6_FM1);
                    break;
                case MMC_Data.AM:
                    if (MMC_Data.RadioStation_6_AM != 0)
                        SerialCOM1.Radio_SetFreq(MMC_Data.RadioStation_6_AM);
                    break;
                default:
                    break;
            }
        }

        // Флаги зажатия кнопок выбора частот
        int Flag_ButtonFreq = 0;

        private void Button_Freq_1_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 1;
        }

        private void Button_Freq_2_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 2;
        }

        private void Button_Freq_3_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 3;
        }

        private void Button_Freq_4_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 4;
        }

        private void Button_Freq_5_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 5;
        }

        private void Button_Freq_6_MouseDown(object sender, MouseEventArgs e)
        {
            timerSaveStation.Enabled = true;
            Flag_ButtonFreq = 6;
        }


        int timerSaveStation_tick = 0;
        private void timerSaveStation_Tick(object sender, EventArgs e)
        {
            if (timerSaveStation_tick < 5)
            {
                timerSaveStation_tick++;

                // Моргание кнопки 1 при сохранении станции
                if (Flag_ButtonFreq == 1)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_1.State = 2;
                    else Button_Freq_1.State = 1;
                }

                // Моргание кнопки 2 при сохранении станции
                if (Flag_ButtonFreq == 2)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_2.State = 2;
                    else Button_Freq_2.State = 1;
                }

                // Моргание кнопки 3 при сохранении станции
                if (Flag_ButtonFreq == 3)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_3.State = 2;
                    else Button_Freq_3.State = 1;
                }

                // Моргание кнопки 4 при сохранении станции
                if (Flag_ButtonFreq == 4)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_4.State = 2;
                    else Button_Freq_4.State = 1;
                }

                // Моргание кнопки 5 при сохранении станции
                if (Flag_ButtonFreq == 5)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_5.State = 2;
                    else Button_Freq_5.State = 1;
                }

                // Моргание кнопки 6 при сохранении станции
                if (Flag_ButtonFreq == 6)
                {
                    if (timerSaveStation_tick % 2 == 0) Button_Freq_6.State = 2;
                    else Button_Freq_6.State = 1;
                }
            }
            else
            {
                // Сохранение станции в память 1
                if (Flag_ButtonFreq == 1)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_1_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_1_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_1_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_1_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_1_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }

                }
                // Сохранение станции в память 2
                if (Flag_ButtonFreq == 2)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_2_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_2_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_2_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_2_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_2_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }
                }
                // Сохранение станции в память 3
                if (Flag_ButtonFreq == 3)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_3_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_3_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_3_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_3_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_3_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }
                }
                // Сохранение станции в память 4
                if (Flag_ButtonFreq == 4)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_4_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_4_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_4_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_4_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_4_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }
                }
                // Сохранение станции в память 5
                if (Flag_ButtonFreq == 5)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_5_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_5_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_5_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_5_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_5_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }
                }
                // Сохранение станции в память 6
                if (Flag_ButtonFreq == 6)
                {
                    switch (SerialCOM1.Radio_GetCurrentBand())
                    {
                        case MMC_Data.FM2:
                            switch (MMC_Data.FM2_Gamm)
                            {
                                // FM2
                                case MMC_Data.FM2_2:
                                    MMC_Data.RadioStation_6_FM2 = MMC_Data.Current_Freq;
                                    break;
                                // FM3
                                case MMC_Data.FM2_3:
                                    MMC_Data.RadioStation_6_FM3 = MMC_Data.Current_Freq;
                                    break;
                                // FM4
                                case MMC_Data.FM2_4:
                                    MMC_Data.RadioStation_6_FM4 = MMC_Data.Current_Freq;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case MMC_Data.FM1:
                            MMC_Data.RadioStation_6_FM1 = MMC_Data.Current_Freq;
                            break;
                        case MMC_Data.AM:
                            MMC_Data.RadioStation_6_AM = MMC_Data.Current_Freq;
                            break;
                        default:
                            break;
                    }
                }
                timerSaveStation.Enabled = false;
                Flag_ButtonFreq = 0;
                timerSaveStation_tick = 0;
                // Запись частот в кнопки пресетов
                RecFreqButton();
                // Установка состояний кнопок пресетов
                RecStateFreqButton();

                // Запись настроек
                MMC_Data.WriteSetting();
            }
        }

        private void Form_Radio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_RDS_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_infoRDS_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_infoTP_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_infoTA_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_infoAF_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_infoCT_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_Freq_Click(object sender, EventArgs e)
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

        private void Form_Radio_Closing(object sender, CancelEventArgs e)
        {
            SerialCOM1.FreqAMFM -= new SerialCOM1.AlertEventHandlerData(Rx_FM);
            SerialCOM1.FreqFM1 -= new SerialCOM1.AlertEventHandlerData(Rx_FM1);
            SerialCOM1.RDS -= new SerialCOM1.AlertEventHandlerString(SerialCOM1_RDS);
            SerialCOM1.PTY -= new SerialCOM1.AlertEventHandlerData(SerialCOM1_PTY);
            SerialCOM1.StereoMessage -= new SerialCOM1.AlertEventHandlerData(SerialCOM1_StereoMsg);
            SerialCOM1.TpMsg -= new SerialCOM1.AlertEventHandlerData(SerialCOM1_TpMsg);
            SerialCOM1.Time_RDS -= new SerialCOM1.AlertEventHandlerByte(SerialCOM1_TimeRDS);
        }

        private void pictureBoxPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void timer_Exit_Tick(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            timer_Exit.Enabled = false;

            //if (Vars.BASS_Stream != 0) Bass.BASS_ChannelPause(Vars.BASS_Stream);
            //Bass.BASS_StreamFree(Vars.BASS_Stream);
            SerialCOM1.Api_SetActivateMode(1);
            Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
            Button_Home_Click(sender, e);
        }

        private void Button_Home_MouseDown(object sender, MouseEventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            timer_Exit.Enabled = true;
        }

    }
}