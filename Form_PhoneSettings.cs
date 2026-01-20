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
using System.IO;
using BluetoothDll;

namespace MMC_Player_2
{
    public partial class Form_PhoneSettings : Form
    {
        Form_Main Main;
        //public MsgWindow MsgWin;

        public Form_PhoneSettings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();
            //this.MsgWin = new MsgWindow(this);

            pictureBoxImgSetting.Image = MMC_Res.Img_PhoneSettings;
            pictureBoxFindPhone.Image = MMC_Res.Img_PhoneSet;
            pictureBoxAutoConnect.Image = MMC_Res.Img_PhoneSet;
            pictureBoxAutoAnswer.Image = MMC_Res.Img_PhoneSet;
            pictureBoxPhoneMemory.Image = MMC_Res.Img_PhoneSet;
            Img_VolumeDial.Image = MMC_Res.IMG_Time;


            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;

            BtnFindPhone.BackGndImage = MMC_Res.Btn_SelectOff;
            BtnFindPhone.PressedImage = MMC_Res.Btn_SelectOn;
            BtnFindPhone.NotActive = MMC_Res.Radio_BtnFreqDisOff;

            BtnPhoneMemory.BackGndImage = MMC_Res.Btn_SelectOff;
            BtnPhoneMemory.PressedImage = MMC_Res.Btn_SelectOn;
            BtnPhoneMemory.NotActive = MMC_Res.Radio_BtnFreqDisOff;

            BtnAutoConnect.State1 = MMC_Res.Btn_SelectOff;
            BtnAutoConnect.State2 = MMC_Res.Btn_SelectOn;

            BtnAutoAnswer.State1 = MMC_Res.Btn_SelectOff;
            BtnAutoAnswer.State2 = MMC_Res.Btn_SelectOn;

            BtnVolumeLow.BackGndImage = MMC_Res.BtnLeftOff;
            BtnVolumeLow.PressedImage = MMC_Res.BtnLeftOn;

            BtnVolumeHigh.BackGndImage = MMC_Res.BtnRightOff;
            BtnVolumeHigh.PressedImage = MMC_Res.BtnRightOn;

            BtDll.BTSignalPower += new BtDll.AlertEventHandlerData(BTSignalPower_Event);
            BtDll.BatCharge += new BtDll.AlertEventHandlerData(BatCharge_Event);
            BtDll.ChangeConnState += new BtDll.AlertEventHandlerData(ChangeConnState_Event);
            BtDll.ChangeSoundStream += new BtDll.AlertEventHandlerData(ChangeSoundStream_Event);
            BtDll.Disconnect += new BtDll.AlertEventHandler(Disconnect_Event);
            BtDll.SearchDevices_E += new BtDll.AlertEventHandlerData(SearchDevices_Event);
            BtDll.ReqDeviceInfo += new BtDll.AlertEventHandlerData2(ReqDeviceInfo_Event);
            BtDll.PairDev += new BtDll.AlertEventHandlerData(PairDev_Event);
            BtDll.SetPinCode_E += new BtDll.AlertEventHandlerData(SetPinCode_Event);
            BtDll.FinishReadDevices += new BtDll.AlertEventHandlerData(FinishReadDevices_Event);

        }

        private void Form_PhoneSettings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
            BtnAutoAnswer.State = Convert.ToBoolean(BtDll.m_autoanswer);
            BtnAutoConnect.State = Convert.ToBoolean(BtDll.m_autoconnect);
        }

        public void BTSignalPower_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = BTSignalPower;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void BTSignalPower(int data)
        {
            switch (data)
            {
                case 1:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
                    break;
                case 2:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    break;
                case 3:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
                    break;
                case 4:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    break;
                case 5:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
                    break;
                default:
                    Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
                    break;
            }
        }

        public void BatCharge_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = BatCharge;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void BatCharge(int data)
        {
            switch (data)
            {
                case 1:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
                    break;
                case 2:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
                    break;
                case 3:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
                    break;
                case 4:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
                    break;
                case 5:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
                    break;
                default:
                    Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
                    break;
            }
        }

        public void ChangeConnState_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = ChangeConnState;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void ChangeConnState(int data)
        {
            //textBox1.Invoke(new EventHandler(delegate { textBox1.Text += "\r\n BTSignal: " + data; }));
            if (data == 3)
            {
                // Активация кнопок клавиатуры
                Forms.Phone.Activate_Phone_Board();
                //Bluetooth.ConnectedTelephone = true;
                //BtnFindPhone.Active = true;
            }
        }

        public void ChangeSoundStream_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = ChangeSoundStream;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void ChangeSoundStream(int data)
        {
            if (data == 1)
            {
                Forms.PlayerPhone.Button_Pause.Visible = true;
                Forms.PlayerPhone.Button_Play.Visible = false;
            }
            else
            {
                Forms.PlayerPhone.Button_Pause.Visible = false;
                Forms.PlayerPhone.Button_Play.Visible = true;
            }
        }

        public void Disconnect_Event(object sender, EventArgs e)
        {
            Action action = Disconnect;
            if (InvokeRequired)
                BeginInvoke(action);
        }

        public void Disconnect()
        {
            //Bluetooth.ConnectedTelephone = false;
            // Деактивируем клавиатуру
            Forms.Phone.Deactivate_Phone_Keyboard();
        }

        public void SearchDevices_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = SearchDevices;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void SearchDevices(int data)
        {
            if (data == 1)
            {
                Request();
            }
        }

        int NumRequest = 0;
        void Request()
        {
            if (NumRequest >= BtDll.m_num_of_finded_devices)
            {
                NumRequest = 0;
                //for (int i = 0; i < (BtDll.m_num_of_finded_devices -1); i++)
                for (int i = 0; i < BtDll.m_num_of_finded_devices; i++)
                {
                    //BtDll.GetFindedDeviceName(i);
                    listBox1.Items.Add(BtDll.GetFindedDeviceName(i));
                }
                BtnFindPhone.Active = true;
            }
            else
            {
                BtDll.RequestFindedDeviceInfo(NumRequest);
                NumRequest = NumRequest + 1;
            }
        }

        public void ReqDeviceInfo_Event(object sender, EventArgs e, int data, int data2)
        {
            Action<int, int> action = ReqDeviceInfo;
            if (InvokeRequired)
                BeginInvoke(action, data, data2);
        }

        public void ReqDeviceInfo(int data, int data2)
        {
            if (data == 0)
            {
                Request();
            }
        }

        public void PairDev_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = PairDev;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void PairDev(int data)
        {
            if (data == 0)
            {
                // Запрос установка пин кода ММС
                BtDll.SetPinCodeAuto();
            }
        }

        public void SetPinCode_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = SetPinCode;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void SetPinCode(int data)
        {
            if (data == 0)
            {
                BtDll.PinCodeRequirement();
            }
        }

        public void FinishReadDevices_Event(object sender, EventArgs e, int data)
        {
            Action<int> action = FinishReadDevices;
            if (InvokeRequired)
                BeginInvoke(action, data);
        }

        public void FinishReadDevices(int data)
        {
            //if (data == 0)
            //{
                //for (int i = 0; i < BtDll.m_num_of_readed_devices; i++)
                for (int i = 0; i < data; i++)
                {
                    listBox1.Items.Add(BtDll.GetReadedDeviceName(i));
                }
                BtnPhoneMemory.Active = true;
            //}
            //else
            //{
            //    BtnPhoneMemory.Active = true;
            //}
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

            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Phone_PhoneSettings:
                    Forms.Phone.Left = 0;
                    Forms.Phone.Top = 0;
                    Forms.Phone.Activate();
                    Vars.FormActivated = Vars.Form_Active.Phone;
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

        // Класс приема сообщений Windows
 //       public class MsgWindow : MessageWindow
 //       {
 //           // Количество найденных устройств
 //           int NumOfFindedDevices;

 //           int RequestFindedDevice = 0;

 //           // Create an instance of the form.
            private Form_PhoneSettings msgform;

 //           // Буфер приема данных
 //           public List<byte> BufferData = new List<byte>();

 //           // Идет поиск телефонов
 //           public bool FindTelephone = false;

 //           // Save a reference to the form so it can
 //           // be notified when messages are received.
            //public MsgWindow(Form_PhoneSettings msgform)
            //{
            //    this.msgform = msgform;
            //}

 //           // Override the default WndProc behavior to examine messages.
 //           protected override void WndProc(ref Microsoft.WindowsCE.Forms.Message msg)
 //           {
 //               // Уровень сигнала сети
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_HFP_SIGNAL)
 //               //if (msg.Msg == BTMessage.WM_BT_CHANGE_SIGNAL_POWER)
 //               //{
 //               //    switch (msg.WParam.ToInt32())
 //               //    {
 //               //        case 1:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_1;
 //               //            break;
 //               //        case 2:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            break;
 //               //        case 3:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_2_3;
 //               //            break;
 //               //        case 4:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            break;
 //               //        case 5:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_4_5;
 //               //            break;
 //               //        default:
 //               //            msgform.Main.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.Phone.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.Audio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.Radio.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.ScreenSaver.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.Settings.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            Forms.Dial.pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
 //               //            break;
 //               //    }
 //               //}

 //               //// Уровень заряда батареи
 //               //if (msg.Msg == BTMessage.WM_BT_CHANGE_BATTERY_CHG)
 //               ////if (msg.Msg == Bluetooth.GetBatteryCharge())
 //               //{
 //               //    //switch (msg.LParam.ToInt32())
 //               //    switch (msg.WParam.ToInt32())
 //               //    {
 //               //        case 1:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_1;
 //               //            break;
 //               //        case 2:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_2;
 //               //            break;
 //               //        case 3:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_3;
 //               //            break;
 //               //        case 4:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_4;
 //               //            break;
 //               //        case 5:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_5;
 //               //            break;
 //               //        default:
 //               //            msgform.Main.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.Phone.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.Audio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.Radio.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.ScreenSaver.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.Settings.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            Forms.Dial.pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;
 //               //            break;
 //               //    }
 //               //}

 //               // Поиск
 //               //if (msg.Msg == BTMessage.WM_BT_SEARCH_DEVICES)
 //               //{
 //               //    switch (msg.WParam.ToInt32())
 //               //    {
 //               //        //case 0: //Идет поиск устройств
 //               //        //    FindTelephone = true;
 //               //        //    msgform.BtnFindPhone.Active = false;
 //               //        //    MessageBox.Show("Идёт поиск");
 //               //        //    break;
 //               //        //case 1: // Поиск устройств завершен
 //               //        //    FindTelephone = false;
 //               //        //    msgform.BtnFindPhone.Active = true;

 //               //        //    //foreach (Bluetooth.Phone phone in Bluetooth.ListPhone)
 //               //        //    //{
 //               //        //    //    msgform.listBox1.Items.Add(phone.GetPhoneName());
 //               //        //    //}

 //               //        //    NumOfFindedDevices = Bluetooth.GetNumOfFindedDevices();
 //               //        //    for (int i = 0; i < NumOfFindedDevices - 1;)
 //               //        //    {
 //               //        //        RequestFindedDevice = 0;
 //               //        //        Bluetooth.RequestFindedDeviceInfo(i);
 //               //        //        if (RequestFindedDevice == 1)
 //               //        //        {
 //               //        //            //msgform.listBox1.Items.Add(Bluetooth.GetFindedDeviceNameA(i));
 //               //        //            MessageBox.Show(Bluetooth.GetFindedDeviceNameA(i));
 //               //        //            i++;
 //               //        //        }
 //               //        //    }
 //               //        //    break;
 //               //    }
 //               //}

 //               // Ответ запроса об устройствах
 //               //if (msg.Msg == BTMessage.WM_BT_REQ_DEVICE_INFO)
 //               //{
 //               //    if (msg.WParam == IntPtr.Zero)
 //               //        RequestFindedDevice = 1;
 //               //}

 //               //// Прием имени найденного устройства
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_TEMP_INT)
 //               //{
 //               //    if (FindTelephone)
 //               //        Bluetooth.indexFindedPhone = msg.WParam.ToInt32();
 //               //}

 //               //// Имя найденного устройства принято
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_INQUIRY_NAME)
 //               //{
 //               //    Bluetooth.ListPhone.Add(new Bluetooth.Phone(Bluetooth.indexFindedPhone, Encoding.ASCII.GetString(BufferData.ToArray(), 0, BufferData.Count)));
 //               //}

 //               //// Идет поиск устройств
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_INQUIRY)
 //               //{
 //               //    // Процесс в состоянии поиска телефонов
 //               //    FindTelephone = true;
 //               //    msgform.BtnFindPhone.Active = false;
 //               //}

 //               // Поиск устройств завершен
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_INQUIRY_END)
 //               //{
 //               //    FindTelephone = false;
 //               //    msgform.BtnFindPhone.Active = true;
 //               //    foreach (Bluetooth.Phone phone in Bluetooth.ListPhone)
 //               //    {
 //               //        msgform.listBox1.Items.Add(phone.GetPhoneName());
 //               //    }
 //               //}

 //               // Стирание буфера приема
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_BUFFER_CLEAR)
 //               //{
 //               //    BufferData.Clear();
 //               //}

 //               // Прием символа в приемный буфер
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_BUFFER_DATA)
 //               //{
 //               //    BufferData.Insert(msg.WParam.ToInt32(), BitConverter.GetBytes(msg.LParam.ToInt32())[0]);
 //               //}

 //               // Статус сопряжения
 //        //       if (msg.Msg == BTMessage.WM_NFORE_UI_PAIRED_STATUS)
 //        //       {
 //        //           if (msg.WParam == IntPtr.Zero && msg.LParam == IntPtr.Zero)
 //        //           {
 //        //               // Сохраняем имя сопряженного телефона
 //        //               Bluetooth.NamePairedPhone = msgform.listBox1.SelectedItem.ToString();
 //        //               Bluetooth.indexPairedPhone = msgform.listBox1.SelectedIndex + 1;
 //        //               msgform.PostMessage(BTMessage.WM_NFORE_CORE_PAIRED_ESTABLISH_SLC, 0, 1);
 //        //           }

 //        //           // Сопряжение выполнено полностью
 //        ////           if (msg.WParam == new IntPtr(1) && msg.LParam == IntPtr.Zero)
 //        // //          {
                        
 //        ////           }
                    
 //        //           // Сопряжение не выполнено
 //        //           if (msg.WParam == new IntPtr(2) && msg.LParam == IntPtr.Zero)
 //        //           {
 //        //               msgform.listBox1.SelectedIndex = -1;
 //        //           }
 //        //       }
                
 //               // Устройство подключено и сопряжено 
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_CONNECTED_DEV)
 //  //             if (msg.Msg == BTMessage.WM_BT_CHANGE_CONN_STATE)
 //  //             {
 //  //                 if (msg.WParam == new IntPtr(3))
 //  //                 {
 //  //                     // Активация кнопок клавиатуры
 //  //                     Forms.Phone.Activate_Phone_Board();
 //  //                     Bluetooth.ConnectedTelephone = true;
 //  //                 }
 //  //                 /*else
 //  //                 {
 //  //                     Forms.Phone.Deactivate_Phone_Keyboard();
 //  //                     Bluetooth.ConnectedTelephone = false;
 //  //                 }*/
 //  //// //                try
 //  //////                 {
 //  ////                     msgform.listBox1.SelectedIndexChanged -= new System.EventHandler(msgform.listBox1_SelectedIndexChanged);
 //  ////                     msgform.listBox1.SelectedIndex = Bluetooth.indexPairedPhone - 1;
 //  ////                     msgform.listBox1.SelectedIndexChanged += new System.EventHandler(msgform.listBox1_SelectedIndexChanged);
 //  /////*                 }
 //  ////                 catch { }*/
                    
 //  //             }

 //               //if (msg.Msg == BTMessage.WM_BT_CHANGE_SOUND_STREAM)
 //               //{
 //               //    if (msg.WParam == new IntPtr(1))
 //               //    {
 //               //        Forms.PlayerPhone.Button_Pause.Visible = true;
 //               //        Forms.PlayerPhone.Button_Play.Visible = false;
 //               //    }
 //               //    else
 //               //    {
 //               //        Forms.PlayerPhone.Button_Pause.Visible = false;
 //               //        Forms.PlayerPhone.Button_Play.Visible = true;
 //               //    }
 //               //}
 //               //if (msg.Msg == BTMessage.WM_NFORE_UI_DISCONNECT_DEV)
 //       //        if (msg.Msg == BTMessage.WM_BT_DISCONNECT_ACTION)
 //       //        {
 //       //            Bluetooth.ConnectedTelephone = false;
 //       //            // Деактивируем клавиатуру
 //       //            Forms.Phone.Deactivate_Phone_Keyboard();
 //       //            //msgform.listBox1.SelectedIndex = -1;

 //       ///*            if (msg.WParam == IntPtr.Zero && msg.LParam == IntPtr.Zero)
 //       //            {
 //       //                msgform.listBox1.SelectedIndex = -1;
 //       //            }

 //       //            if (msg.WParam == new IntPtr(2))
 //       //            {
 //       //                msgform.listBox1.SelectedIndex = -1;
 //       //            }

 //       //            if (msg.WParam == new IntPtr(1) && (msg.LParam == new IntPtr(10) || msg.LParam == new IntPtr(9)))
 //       //            {
 //       //                if (Bluetooth.indexPairedPhone == 0)
 //       //                {
 //       //                    msgform.SendMessage(BTMessage.WM_NFORE_CORE_DELETE_PAIRED_DEVICE, 0, 0);

 //       //                    if (msgform.listBox1.SelectedIndex != -1)
 //       //                    {
 //       //                        // Запрос установка пин кода ММС
 //       //                        msgform.SendMessage(BTMessage.WM_NFORE_CORE_SET_AUTO_PIN_CODE, 1, 0);
 //       //                        // Запрос на сопряжение устройства из списка
 //       //                        msgform.SendMessage(BTMessage.WM_NFORE_CORE_PAIR_REMOTE_DEVICE, msgform.listBox1.SelectedIndex, 0);
 //       //                    }
 //       //                }
 //       //            }*/
 //       //        }
                
 //               // Сигнал потерян
 //  //             if (msg.Msg == BTMessage.WM_NFORE_UI_LINK_LOSS)
 //  //             {
 //  ///*                 if (msg.WParam == new IntPtr(2) && msg.LParam == new IntPtr(1))
 //  //                 {
 //  //                     // Деактивируем клавиатуру
 //  //                     Forms.Phone.Deactivate_Phone_Keyboard();
 //  //                     Vars.ConnectedTelephone = false;
 //  //                     msgform.listBox1.SelectedItem = null;
 //  //                 }*/
 //  //             }

 //               // Имя подключенного устройства (индекс)
 ////               if (msg.Msg == BTMessage.WM_NFORE_UI_PAIRED_NAME)
 ////               {
 //////                   Vars.indexPairedPhone = msg.WParam.ToInt32();
 ////               }



 //               // Call the base WndProc method
 //               // to process any messages not handled.
 //               base.WndProc(ref msg);
 //           }
 //       }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //if (listBox1.SelectedIndex != -1)
            //{
            //    // Если что-то подключено, то отключаем
            //    if (BtDll.m_connstate == 3)
            //    {
            //        //Bluetooth.indexPairedPhone = 0;
            //        //PostMessage(BTMessage.WM_NFORE_CORE_DISCONNECT_SLC, 255, 0);
            //        BtDll.DisconnectDevice(255);
            //    }
            //    else
            //    {
            //        //// Запрос установка пин кода ММС
            //        ////PostMessage(BTMessage.WM_NFORE_CORE_SET_AUTO_PIN_CODE, 1, 0);
            //        //BtDll.SetPinCodeAuto();
            //        // Запрос на сопряжение устройства из списка
            //        //PostMessage(BTMessage.WM_NFORE_CORE_PAIR_REMOTE_DEVICE, listBox1.SelectedIndex, 0);
            //        BtDll.PairDevice(listBox1.SelectedIndex);
            //    }
            //}
        }

        private void BtnFindPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            // Очищаем список телефонов
            //Bluetooth.ListPhone.Clear();
            listBox1.Items.Clear();

            BtDll.DisconnectDevice(255);
            BtDll.ClearFindedDevices();
            BtDll.SetVisibility(3);
            BtDll.SearchDevices();

            //BtnFindPhone.Active = false;

            //// Если что-то подключено, то удаляем
            //if (Bluetooth.indexPairedPhone != 0)
            //{
            //    PostMessage(BTMessage.WM_NFORE_CORE_DISCONNECT_SLC, 255, 0);

            //    Bluetooth.ConnectedTelephone = false;
            //    Bluetooth.indexPairedPhone = 0;
            //    Bluetooth.NamePairedPhone = "";
            //}

            //// Запрос поиска устройств
            //PostMessage(BTMessage.WM_NFORE_CORE_INQUIRY, 0, 0);

            //Bluetooth.DisconnectDevice(255);
            // Bluetooth.DeletePairedDeviceAt(1); //необязательно
            //Bluetooth.SetVisibility(3);
            //Bluetooth.SearchDevices();
        }

        private void BtnAutoConnect_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //Bluetooth.AutoConnect = BtnAutoConnect.State;
            BtDll.SetAutoconnect(Convert.ToInt32(BtnAutoConnect.State));
            //if (Bluetooth.AutoConnect)
            //    Bluetooth.SetAutoconnect(1);
            //else
            //    Bluetooth.SetAutoconnect(0);
        }

        private void BtnAutoAnswer_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            //Bluetooth.AutoAnswer = BtnAutoAnswer.State;
            BtDll.SetAutoanswer(Convert.ToInt32(BtnAutoAnswer.State));
        }

        private void Form_PhoneSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxImgSetting_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxFindPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxAutoConnect_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBoxAutoAnswer_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void BtnVolumeLow_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.VolumeDial > 0)
                MMC_Data.VolumeDial--;
            else MMC_Data.VolumeDial = 0;
            Img_VolumeDial.Invalidate();
        }

        private void BtnVolumeHigh_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.VolumeDial < 100)
                MMC_Data.VolumeDial++;
            else MMC_Data.VolumeDial = 100;
            Img_VolumeDial.Invalidate();
        }

        private void Img_VolumeDial_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
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
        private void Img_VolumeDial_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(MMC_Data.VolumeDial.ToString(), font, brush, 40, 30, stringformat);
        }

        private void Form_PhoneSettings_Closing(object sender, CancelEventArgs e)
        {
            BtDll.BTSignalPower -= new BtDll.AlertEventHandlerData(BTSignalPower_Event);
            BtDll.BatCharge -= new BtDll.AlertEventHandlerData(BatCharge_Event);
            BtDll.ChangeConnState -= new BtDll.AlertEventHandlerData(ChangeConnState_Event);
            BtDll.ChangeSoundStream -= new BtDll.AlertEventHandlerData(ChangeSoundStream_Event);
            BtDll.Disconnect -= new BtDll.AlertEventHandler(Disconnect_Event);
            BtDll.SearchDevices_E -= new BtDll.AlertEventHandlerData(SearchDevices_Event);
            BtDll.ReqDeviceInfo -= new BtDll.AlertEventHandlerData2(ReqDeviceInfo_Event);
            BtDll.PairDev -= new BtDll.AlertEventHandlerData(PairDev_Event);
            BtDll.SetPinCode_E -= new BtDll.AlertEventHandlerData(SetPinCode_Event);
            BtDll.FinishReadDevices -= new BtDll.AlertEventHandlerData(FinishReadDevices_Event);
        }

        private void BtnPhoneMemory_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            listBox1.Items.Clear();

            BtDll.ClearReadedDevices();

            BtDll.ReadPairedDevices();

            //BtnPhoneMemory.Active = false;
        }

        private void pictureBoxPhoneMemory_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (listBox1.SelectedIndex != -1)
                BtDll.PairDevice(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (listBox1.SelectedIndex != -1)
                BtDll.DeletePairedDeviceAt(listBox1.SelectedIndex + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            BtDll.DisconnectDevice(255);
        }
    }
}