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

namespace MMC_Player_2
{
    public partial class Form_GeneralSettings : Form
    {
        Form_Main Main;

        [DllImport("coredll.dll")]
        private extern static uint SetLocalTime(ref SYSTEMTIME lpSystemTime);

        Font font_text = new Font("Itelma_Kor", 14F, FontStyle.Regular);

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

        string hour = "";
        string minute = "";
        string second = "";
        string dayOfWeek = "";
        string month = "";
        string year = "";


        public Form_GeneralSettings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxImgSetting.Image = MMC_Res.Setting_IMG;
            pictureBox210x100.Image = MMC_Res.Set210x100;
            pictureBoxTime.Image = MMC_Res.Set210x100;
            pictureBox540x100.Image = MMC_Res.Set540x100;
            pictureBox760x60.Image = MMC_Res.Set760x60;

            Img_Hour.Image = MMC_Res.IMG_Time;
            Img_Minute.Image = MMC_Res.IMG_Time;
            Img_Day.Image = MMC_Res.IMG_Time;
            Img_Month.Image = MMC_Res.IMG_Time;
            Img_Year.Image = MMC_Res.IMG_Time;
            Img_ScreenTime.Image = MMC_Res.IMG_Time;

            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;

            BtnSetScreenSaver.State1 = MMC_Res.Btn_SelectOff;
            BtnSetScreenSaver.State2 = MMC_Res.Btn_SelectOn;

            BtnSetSeconds.State1 = MMC_Res.Btn_SelectOff;
            BtnSetSeconds.State2 = MMC_Res.Btn_SelectOn;

            BtnHourUP.BackGndImage = MMC_Res.BtnUpOff;
            BtnMinuteUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnDayUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnMonthUp.BackGndImage = MMC_Res.BtnUpOff;
            BtnYearUp.BackGndImage = MMC_Res.BtnUpOff;

            BtnHourUP.PressedImage = MMC_Res.BtnUpOn;
            BtnMinuteUp.PressedImage = MMC_Res.BtnUpOn;
            BtnDayUp.PressedImage = MMC_Res.BtnUpOn;
            BtnMonthUp.PressedImage = MMC_Res.BtnUpOn;
            BtnYearUp.PressedImage = MMC_Res.BtnUpOn;

            BtnHourDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnMinuteDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnDayDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnMonthDown.BackGndImage = MMC_Res.BtnDownOff;
            BtnYearDown.BackGndImage = MMC_Res.BtnDownOff;

            BtnHourDown.PressedImage = MMC_Res.BtnDownOn;
            BtnMinuteDown.PressedImage = MMC_Res.BtnDownOn;
            BtnDayDown.PressedImage = MMC_Res.BtnDownOn;
            BtnMonthDown.PressedImage = MMC_Res.BtnDownOn;
            BtnYearDown.PressedImage = MMC_Res.BtnDownOn;

            BtnScreenLeft.BackGndImage = MMC_Res.BtnLeftOff;
            BtnScreenLeft.PressedImage = MMC_Res.BtnLeftOn;
            BtnScreenRight.BackGndImage = MMC_Res.BtnRightOff;
            BtnScreenRight.PressedImage = MMC_Res.BtnRightOn;

            BtnSetScreenSaver.State = MMC_Data.ScreenSaver;

            label2.Font = font_text;
            label3.Font = font_text;
        }

        private void Form_GeneralSettings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
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

        private void GetSysTime()
        {
            TimeSpan ts = TimeSpan.FromSeconds(SerialCOM1.Api_GetCurrentTime());
            DateTime dt = new DateTime(1970, 1, 1);
            dt += ts;

            if (dt.Hour < 10) hour = "0" + dt.Hour.ToString();
            else hour = dt.Hour.ToString();
            if (dt.Minute < 10) minute = "0" + dt.Minute.ToString();
            else minute = dt.Minute.ToString();
            if (dt.Second < 10) second = "0" + dt.Second.ToString();
            else second = dt.Second.ToString();

            // Системная дата
            if (dt.Day < 10) dayOfWeek = "0" + dt.Day.ToString();
            else dayOfWeek = dt.Day.ToString();
            if (dt.Month < 10) month = "0" + dt.Month.ToString();
            else month = dt.Month.ToString();

            int yea = dt.Year % 100;
            if (yea < 10) year = "0" + yea.ToString();
            else year = yea.ToString();

            Img_Hour.Invalidate();
            Img_Minute.Invalidate();
            Img_Day.Invalidate();
            Img_Month.Invalidate();
            Img_Year.Invalidate();
        }

        private void SetSysTime()
        {
            SYSTEMTIME settime = new SYSTEMTIME();
            settime.wHour = Convert.ToUInt16(hour);
            settime.wMinute = Convert.ToUInt16(minute);
            settime.wDay = Convert.ToUInt16(dayOfWeek);
            settime.wMonth = Convert.ToUInt16(month);
            uint yearfull = Convert.ToUInt16(year) + (uint)2000;
            settime.wYear = Convert.ToUInt16(yearfull);
            settime.wSecond = 0;
            settime.wMilliseconds = 0;

            SetLocalTime(ref settime);

            DateTime centuryBegin = new DateTime(1970, 1, 1);
            DateTime currentDate = new DateTime(settime.wYear, settime.wMonth, settime.wDay, settime.wHour, settime.wMinute, 0);
            long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

            SerialCOM1.Api_SetCurrentTime((uint)elapsedSpan.TotalSeconds);
        }

        private void BtnSetScreenSaver_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.ScreenSaver) MMC_Data.ScreenSaver = false;
            else MMC_Data.ScreenSaver = true;
            BtnSetScreenSaver.State = MMC_Data.ScreenSaver;

            // Запись настроек
            MMC_Data.WriteSetting();
        }

        private void BtnHourUP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            hour = (Convert.ToInt32(hour) + 1).ToString();
            if (Convert.ToInt32(hour) < 24)
            {
                if (Convert.ToInt32(hour) < 10) hour = "0" + hour;
            }
            else hour = "00";

            Img_Hour.Invalidate();
            SetSysTime();
        }

        private void BtnHourDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            hour = (Convert.ToInt32(hour) - 1).ToString();
            if (Convert.ToInt32(hour) >= 0)
            {
                if (Convert.ToInt32(hour) < 10) hour = "0" + hour;
            }
            else hour = "23";

            Img_Hour.Invalidate();
            SetSysTime();
        }

        private void BtnMinuteUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            minute = (Convert.ToInt32(minute) + 1).ToString();
            if (Convert.ToInt32(minute) < 60)
            {
                if (Convert.ToInt32(minute) < 10) minute = "0" + minute;
            }
            else minute = "00";

            Img_Minute.Invalidate();
            SetSysTime();
        }

        private void BtnMinuteDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            minute = (Convert.ToInt32(minute) - 1).ToString();
            if (Convert.ToInt32(minute) >= 0)
            {
                if (Convert.ToInt32(minute) < 10) minute = "0" + minute;
            }
            else minute = "59";

            Img_Minute.Invalidate();
            SetSysTime();
        }

        private void BtnDayUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            dayOfWeek = (Convert.ToInt32(dayOfWeek) + 1).ToString();
            switch (month)
            {
                case "01":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "02":
                    if (Convert.ToInt32(year) % 4 == 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) <= 29)
                        {
                            if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                        }
                        else dayOfWeek = "01";
                    }
                    else
                    {
                        if (Convert.ToInt32(dayOfWeek) <= 28)
                        {
                            if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                        }
                        else dayOfWeek = "01";
                    }
                    break;
                case "03":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "04":
                    if (Convert.ToInt32(dayOfWeek) <= 30)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "05":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "06":
                    if (Convert.ToInt32(dayOfWeek) <= 30)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "07":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "08":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "09":
                    if (Convert.ToInt32(dayOfWeek) <= 30)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "10":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "11":
                    if (Convert.ToInt32(dayOfWeek) <= 30)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                case "12":
                    if (Convert.ToInt32(dayOfWeek) <= 31)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "01";
                    break;
                default:
                    break;
            }

            Img_Day.Invalidate();
            SetSysTime();
        }

        private void BtnDayDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            dayOfWeek = (Convert.ToInt32(dayOfWeek) - 1).ToString();

            switch (month)
            {
                case "01":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "02":
                    if (Convert.ToInt32(year) % 4 == 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) > 0)
                        {
                            if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                        }
                        else dayOfWeek = "29";
                    }
                    else
                    {
                        if (Convert.ToInt32(dayOfWeek) > 0)
                        {
                            if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                        }
                        else dayOfWeek = "28";
                    }
                    break;
                case "03":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "04":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "30";
                    break;
                case "05":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "06":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "30";
                    break;
                case "07":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "08":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "09":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "30";
                    break;
                case "10":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                case "11":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "30";
                    break;
                case "12":
                    if (Convert.ToInt32(dayOfWeek) > 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) < 10) dayOfWeek = "0" + dayOfWeek;
                    }
                    else dayOfWeek = "31";
                    break;
                default:
                    break;
            }

            Img_Day.Invalidate();
            SetSysTime();
        }

        private void BtnMonthUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            month = (Convert.ToInt32(month) + 1).ToString();
            if (Convert.ToInt32(month) < 13)
            {
                if (Convert.ToInt32(month) < 10) month = "0" + month;
            }
            else month = "01";

            switch (month)
            {
                case "02":
                    if (Convert.ToInt32(year) % 4 == 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) > 29) dayOfWeek = "29";
                    }
                    else
                    {
                        if (Convert.ToInt32(dayOfWeek) > 28) dayOfWeek = "28";
                    }
                    Img_Day.Invalidate();
                    break;
                case "04":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "06":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "09":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "11":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                default:
                    break;
            }

            Img_Month.Invalidate();
            SetSysTime();
        }

        private void BtnMonthDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            month = (Convert.ToInt32(month) - 1).ToString();
            if (Convert.ToInt32(month) > 0)
            {
                if (Convert.ToInt32(month) < 10) month = "0" + month;
            }
            else month = "12";

            switch (month)
            {
                case "02":
                    if (Convert.ToInt32(year) % 4 == 0)
                    {
                        if (Convert.ToInt32(dayOfWeek) > 29) dayOfWeek = "29";
                    }
                    else
                    {
                        if (Convert.ToInt32(dayOfWeek) > 28) dayOfWeek = "28";
                    }
                    Img_Day.Invalidate();
                    break;
                case "04":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "06":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "09":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                case "11":
                    if (Convert.ToInt32(dayOfWeek) > 30) dayOfWeek = "30";
                    Img_Day.Invalidate();
                    break;
                default:
                    break;
            }

            Img_Month.Invalidate();
            SetSysTime();
        }

        private void BtnYearUp_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            year = (Convert.ToInt32(year) + 1).ToString();
            if (Convert.ToInt32(year) < 100)
            {
                if (Convert.ToInt32(year) < 10) year = "0" + year;
            }
            else year = "00";

            // Если год не високосный
            if (Convert.ToInt32(year) % 4 != 0)
            {
                if (Convert.ToInt32(dayOfWeek) > 28) dayOfWeek = "28";
                Img_Day.Invalidate();
            }

            Img_Year.Invalidate();
            SetSysTime();
        }

        private void BtnYearDown_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            year = (Convert.ToInt32(year) - 1).ToString();
            if (Convert.ToInt32(year) >= 0)
            {
                if (Convert.ToInt32(year) < 10) year = "0" + year;
            }
            else year = "99";

            // Если год не високосный
            if (Convert.ToInt32(year) % 4 != 0)
            {
                if (Convert.ToInt32(dayOfWeek) > 28) dayOfWeek = "28";
                Img_Day.Invalidate();
            }

            Img_Year.Invalidate();
            SetSysTime();
        }

        // Шрифт
        Font font = new Font("Itelma_Kor", 18F, FontStyle.Regular);
        // Кисть
        Brush brush = new SolidBrush(Color.White);

        StringFormat stringformat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        private void pictureBox210x100_Paint(object sender, PaintEventArgs e)
        {
            Font _font = new Font("Itelma_Kor", 12F, FontStyle.Bold);
            e.Graphics.DrawString("Заставка", _font, brush, 105, 13, stringformat);
            e.Graphics.DrawString("экрана:", _font, brush, 105, 35, stringformat);
        }

        private void Img_Hour_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(hour, font, brush, 40, 30, stringformat);
        }

        private void Img_Minute_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(minute, font, brush, 40, 30, stringformat);
        }

        private void Img_Day_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(dayOfWeek, font, brush, 40, 30, stringformat);
        }

        private void Img_Month_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(month, font, brush, 40, 30, stringformat);
        }

        private void Img_Year_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(year, font, brush, 40, 30, stringformat);
        }

        private void Form_GeneralSettings_Activated(object sender, EventArgs e)
        {
            GetSysTime();
        }

        private void Form_GeneralSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBox210x100_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBox540x100_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBox760x60_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Hour_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Minute_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Day_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Month_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Year_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_ScreenTime_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(MMC_Data.ScreenSaverTime.ToString(), font, brush, 40, 30, stringformat);
        }

        private void BtnScreenLeft_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.ScreenSaverTime > 5)
            {
                MMC_Data.ScreenSaverTime--;
            }
            else MMC_Data.ScreenSaverTime = 5;

            Img_ScreenTime.Invalidate();
        }

        private void BtnScreenRight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (MMC_Data.ScreenSaverTime < 60)
            {
                MMC_Data.ScreenSaverTime++;
            }
            else MMC_Data.ScreenSaverTime = 60;

            Img_ScreenTime.Invalidate();
        }

        private void pictureBoxTime_Paint(object sender, PaintEventArgs e)
        {
            Font _font = new Font("Itelma_Kor", 12F, FontStyle.Bold);
            e.Graphics.DrawString("Секунды:", _font, brush, 105, 13, stringformat);
        }

        private void BtnSetSeconds_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Seconds) MMC_Data.Seconds = false;
            else MMC_Data.Seconds = true;
            BtnSetSeconds.State = MMC_Data.Seconds;

            // Запись настроек
            MMC_Data.WriteSetting();
        }
    }
}