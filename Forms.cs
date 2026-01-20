using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MMC_Player_2
{
    class Forms
    {
        public static Form_Audio Audio;
        public static Form_Settings Settings;
        public static Form_Radio Radio;
        public static Form_ScreenSaver ScreenSaver;
        public static Form_Volume Volume;
        public static Form_Phone Phone;
        public static Form_Player Player;
        public static Form_Dial Dial;
        public static Form_RadioSettings RadioSettings;
        public static Form_DisplaySettings DisplaySettings;
        public static Form_AudioSettings AudioSettings;
		public static Form_AudioSettingsBalance AudioSettingsBalance;
        public static Form_GeneralSettings GeneralSettings;
        public static Form_PhoneSettings PhoneSettings;
        public static Form_PlayerPhone PlayerPhone;
        public static Form_Main Main;

        public static void LoadForms(Form_Main Main)
        {
            // Загрузка форм
            Audio = new Form_Audio(Main);
            Audio.Show();
            Settings = new Form_Settings(Main);
            Settings.Show();
            Radio = new Form_Radio(Main);
            Radio.Show();
            ScreenSaver = new Form_ScreenSaver(Main);
            ScreenSaver.Show();
            Phone = new Form_Phone(Main);
            Phone.Show();
            Volume = new Form_Volume(Main);
            Volume.Show();
            Player = new Form_Player(Main);
            Player.Show();
            Dial = new Form_Dial(Main);
            Dial.Show();
            RadioSettings = new Form_RadioSettings(Main);
            RadioSettings.Show();
            DisplaySettings = new Form_DisplaySettings(Main);
            DisplaySettings.Show();
            AudioSettings = new Form_AudioSettings(Main);
            AudioSettings.Show();
			AudioSettingsBalance = new Form_AudioSettingsBalance(Main);
            AudioSettingsBalance.Show();
            GeneralSettings = new Form_GeneralSettings(Main);
            GeneralSettings.Show();
            PhoneSettings = new Form_PhoneSettings(Main);
            PhoneSettings.Show();
            PlayerPhone = new Form_PlayerPhone(Main);
            PlayerPhone.Show();
        }

        public static void UnLoadForms()
        {
            // Закрываем все формы
            Audio.Close();
            Settings.Close();
            Radio.Close();
            ScreenSaver.Close();
            //Volume.Close();
            Phone.Close();
            Volume.Close();
            Player.Close();
            Dial.Close();
            RadioSettings.Close();
            DisplaySettings.Close();
            AudioSettings.Close();
			AudioSettingsBalance.Close();
            GeneralSettings.Close();
            PhoneSettings.Close();
            PlayerPhone.Close();
        }
    }
}
