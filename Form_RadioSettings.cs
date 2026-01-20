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
    public partial class Form_RadioSettings : Form
    {
        Form_Main Main;

        Font Setting = new Font("Itelma_Kor", 14F, FontStyle.Bold);

        public Form_RadioSettings(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            pictureBoxImgSetting.Image = MMC_Res.RadioSet;
            pictureBoxChannelSet.Image = MMC_Res.Img_ChannelSet;
            pictureBoxRadioSet.Image = MMC_Res.Img_RadioSet;
            Button_Back.BackGndImage = MMC_Res.SetBtnBackOff;
            Button_Back.PressedImage = MMC_Res.SetBtnBackOn;

            label1.Font = Setting;
            label2.Font = Setting;
            label3.Font = Setting;
            label4.Font = Setting;
            label5.Font = Setting;
            label6.Font = Setting;
            label7.Font = Setting;


            Btn_Local_DX.State1 = MMC_Res.Radio_BtnFreqOff;
            Btn_Local_DX.State2 = MMC_Res.Btn_SelectOn;
            Btn_RDS.State1 = MMC_Res.Radio_BtnFreqOff;
            Btn_RDS.State2 = MMC_Res.Btn_SelectOn;

            Btn_AF.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Btn_AF.State2 = MMC_Res.Radio_BtnFreqOff;
            Btn_AF.State3 = MMC_Res.Btn_SelectOn;
            Btn_TP.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Btn_TP.State2 = MMC_Res.Radio_BtnFreqOff;
            Btn_TP.State3 = MMC_Res.Btn_SelectOn;
            Btn_TA.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Btn_TA.State2 = MMC_Res.Radio_BtnFreqOff;
            Btn_TA.State3 = MMC_Res.Btn_SelectOn;
            Btn_TimeRDS.State1 = MMC_Res.Radio_BtnFreqDisOff;
            Btn_TimeRDS.State2 = MMC_Res.Radio_BtnFreqOff;
            Btn_TimeRDS.State3 = MMC_Res.Btn_SelectOn;
        }

        private void Form_RadioSettings_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;

            if (SerialCOM1.Radio_GetSearchLevel()) Btn_Local_DX.State = true;
            else Btn_Local_DX.State = false;
            if (MMC_Data.RDS)
            {
                Btn_RDS.State = true;
                if (MMC_Data.AF) Btn_AF.State = 3;
                else Btn_AF.State = 2;
                if (MMC_Data.TP) Btn_TP.State = 3;
                else Btn_TP.State = 2;
                if (MMC_Data.TA) Btn_TA.State = 3;
                else Btn_TA.State = 2;
                if (MMC_Data.Time_RDS) Btn_TimeRDS.State = 3;
                else Btn_TimeRDS.State = 2;
            }
            else
            {
                Btn_RDS.State = false;
                Btn_AF.State = 1;
                Btn_TP.State = 1;
                Btn_TA.State = 1;
                Btn_TimeRDS.State = 1;
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            switch (Vars.FormActivated)
            {
                case Vars.Form_Active.Radio_RadioSettings:
                    Forms.Radio.Left = 0;
                    Forms.Radio.Top = 0;
                    Forms.Radio.Activate();
                    Vars.FormActivated = Vars.Form_Active.Radio;
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

        private void Btn_Local_DX_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (SerialCOM1.Radio_GetSearchLevel())
            {
                if (SerialCOM1.Radio_SetSearchLevel(false))
                {
                    Btn_Local_DX.State = false;
                }
            }
            else
            {
                if (SerialCOM1.Radio_SetSearchLevel(true))
                {
                    Btn_Local_DX.State = true;
                }
            }
            MMC_Data.WriteSetting();
        }

        private void Btn_RDS_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.RDS)
            {
                Btn_RDS.State = false;
                MMC_Data.RDS = false;
                Btn_AF.State = 1;
                Btn_TP.State = 1;
                Btn_TA.State = 1;
                Btn_TimeRDS.State = 1;
            }
            else
            {
                Btn_RDS.State = true;
                MMC_Data.RDS = true;
                if (MMC_Data.AF) Btn_AF.State = 3;
                else Btn_AF.State = 2;
                if (MMC_Data.TP) Btn_TP.State = 3;
                else Btn_TP.State = 2;
                if (MMC_Data.TA) Btn_TA.State = 3;
                else Btn_TA.State = 2;
                if (MMC_Data.Time_RDS) Btn_TimeRDS.State = 3;
                else Btn_TimeRDS.State = 2;
            }
            MMC_Data.WriteSetting();
        }

        private void Btn_AF_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (Btn_AF.State != 1)
            {
                if (MMC_Data.AF)
                {
                    Btn_AF.State = 2;
                    SerialCOM1.Rds_SetAFMsg(false);
                }
                else
                {
                    Btn_AF.State = 3;
                    SerialCOM1.Rds_SetAFMsg(true);
                }
            }
            MMC_Data.WriteSetting();
        }

        private void Btn_TP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (Btn_TP.State != 1)
            {
                if (MMC_Data.TP)
                {
                    Btn_TP.State = 2;
                    MMC_Data.TP = false;
                }
                else
                {
                    Btn_TP.State = 3;
                    MMC_Data.TP = true;
                }
            }
            MMC_Data.WriteSetting();
        }

        private void Btn_TA_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (Btn_TA.State != 1)
            {
                if (MMC_Data.TA)
                {
                    Btn_TA.State = 2;
                    MMC_Data.TA = false;
                }
                else
                {
                    Btn_TA.State = 3;
                    MMC_Data.TA = true;
                }
            }
            MMC_Data.WriteSetting();
        }

        private void Btn_TimeRDS_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (Btn_TimeRDS.State != 1)
            {
                if (MMC_Data.Time_RDS)
                {
                    Btn_TimeRDS.State = 2;
                    MMC_Data.Time_RDS = false;
                }
                else
                {
                    Btn_TimeRDS.State = 3;
                    MMC_Data.Time_RDS = true;
                }
            }
            MMC_Data.WriteSetting();
        }

        private void Form_RadioSettings_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxChannelSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBoxRadioSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label6_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label5_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }
    }
}