using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace MMC_Player_2
{
    public class Vars
    {
        public static int BASS_Stream = 0;              // Хендл аудиопотока
        
        public static int BASS_CurrentTrack = -1;       // Текущий трек

        // Хранение значения активной текущей формы, для возврата из форм Навигация, Скринсейвер, Звук, Звонок
        public static Form_Active FormActivated;

        public static bool ScreenSaverActive = false;
        public static bool NavigatorActive = false;
        public static bool DialActive = false;
        public static bool PlayerPhoneActive = false;

        public static IntPtr hWndNavigator;

        public enum Form_Active
        {
            Main,
            Radio,
            Audio,
            Settings,
            Player,
            AudioSettings,
			AudioSettingsBalance,
            DisplaySettings,
            GeneralSettings,
            RadioSettings,
            PhoneSettings,
            Dial,
            Phone,
            ScreenSaver,
            Volume,
            Navigation,
            Radio_RadioSettings,
            Radio_AudioSettings,
            Player_AudioSettings,
            Phone_PhoneSettings,
            PlayerPhone,
            PlayerPhone_AudioSettings
        };


        public static Process Navigation;

        public static int timerScreenSaverTick = 0;

        public static int timerCanDataTick = 0;

        public static bool CanActive = false;

        public static bool StatusPlay = false;


        // Статусы CAN шины
        // Ближний свет
        public static bool Passing_Light = false;
        // Дальний свет
        public static bool Distant_Light = false;

        // Сохрененный режим для возврата из режима Звонка
        public static int CurrentMode = 1;
    }
}
