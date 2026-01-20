namespace MMC_Player_2
{
    partial class Form_Radio
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_Radio;
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.label_Mhz_kHz = new System.Windows.Forms.Label();
            this.pictureBoxWhiteLine = new System.Windows.Forms.PictureBox();
            this.Img_Radio = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.timer_Search = new System.Windows.Forms.Timer();
            this.label_RDS = new System.Windows.Forms.Label();
            this.label_PTY = new System.Windows.Forms.Label();
            this.panel_StereoStatus = new System.Windows.Forms.Panel();
            this.label_infoRDS = new System.Windows.Forms.Label();
            this.label_infoTP = new System.Windows.Forms.Label();
            this.label_infoAF = new System.Windows.Forms.Label();
            this.label_infoTA = new System.Windows.Forms.Label();
            this.label_infoCT = new System.Windows.Forms.Label();
            this.timerSaveStation = new System.Windows.Forms.Timer();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.label_Freq = new MMC_Player_2.Label_();
            this.BtnStereoStatus = new MMC_Player_2.TriggerButton_4state();
            this.Button_FM4 = new MMC_Player_2.TriggerButton();
            this.Button_FM3 = new MMC_Player_2.TriggerButton();
            this.Button_FM2 = new MMC_Player_2.TriggerButton();
            this.Button_FM1 = new MMC_Player_2.TriggerButton();
            this.Button_AM = new MMC_Player_2.TriggerButton();
            this.Button_Freq_2 = new MMC_Player_2.TriggerButton_4state();
            this.Button_Freq_3 = new MMC_Player_2.TriggerButton_4state();
            this.Button_Freq_4 = new MMC_Player_2.TriggerButton_4state();
            this.Button_Freq_5 = new MMC_Player_2.TriggerButton_4state();
            this.Button_Freq_6 = new MMC_Player_2.TriggerButton_4state();
            this.Button_Freq_1 = new MMC_Player_2.TriggerButton_4state();
            this.Button_SearchUP = new MMC_Player_2.ImageButton();
            this.Button_SearchDOWN = new MMC_Player_2.ImageButton();
            this.Button_SetAudio = new MMC_Player_2.ImageButton();
            this.Button_SetRadio = new MMC_Player_2.ImageButton();
            this.Button_Home = new MMC_Player_2.ImageButton();
            this.timer_Exit = new System.Windows.Forms.Timer();
            label_Radio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Radio
            // 
            label_Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label_Radio.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label_Radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label_Radio.Location = new System.Drawing.Point(55, 28);
            label_Radio.Name = "label_Radio";
            label_Radio.Size = new System.Drawing.Size(67, 28);
            label_Radio.Text = "Радио";
            label_Radio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            // 
            // label_Mhz_kHz
            // 
            this.label_Mhz_kHz.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.label_Mhz_kHz.ForeColor = System.Drawing.Color.Gray;
            this.label_Mhz_kHz.Location = new System.Drawing.Point(595, 302);
            this.label_Mhz_kHz.Name = "label_Mhz_kHz";
            this.label_Mhz_kHz.Size = new System.Drawing.Size(75, 39);
            // 
            // pictureBoxWhiteLine
            // 
            this.pictureBoxWhiteLine.Location = new System.Drawing.Point(130, 200);
            this.pictureBoxWhiteLine.Name = "pictureBoxWhiteLine";
            this.pictureBoxWhiteLine.Size = new System.Drawing.Size(540, 2);
            // 
            // Img_Radio
            // 
            this.Img_Radio.Location = new System.Drawing.Point(20, 15);
            this.Img_Radio.Name = "Img_Radio";
            this.Img_Radio.Size = new System.Drawing.Size(34, 69);
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // timer_Search
            // 
            this.timer_Search.Interval = 1000;
            this.timer_Search.Tick += new System.EventHandler(this.timer_Search_Tick);
            // 
            // label_RDS
            // 
            this.label_RDS.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label_RDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_RDS.Location = new System.Drawing.Point(268, 157);
            this.label_RDS.Name = "label_RDS";
            this.label_RDS.Size = new System.Drawing.Size(265, 29);
            this.label_RDS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_RDS.ParentChanged += new System.EventHandler(this.label_RDS_ParentChanged);
            // 
            // label_PTY
            // 
            this.label_PTY.BackColor = System.Drawing.Color.Black;
            this.label_PTY.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular);
            this.label_PTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_PTY.Location = new System.Drawing.Point(390, 210);
            this.label_PTY.Name = "label_PTY";
            this.label_PTY.Size = new System.Drawing.Size(230, 25);
            this.label_PTY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel_StereoStatus
            // 
            this.panel_StereoStatus.BackColor = System.Drawing.Color.Black;
            this.panel_StereoStatus.Location = new System.Drawing.Point(624, 186);
            this.panel_StereoStatus.Name = "panel_StereoStatus";
            this.panel_StereoStatus.Size = new System.Drawing.Size(50, 73);
            this.panel_StereoStatus.Click += new System.EventHandler(this.panel_StereoStatus_Click);
            // 
            // label_infoRDS
            // 
            this.label_infoRDS.BackColor = System.Drawing.Color.Black;
            this.label_infoRDS.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_infoRDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            this.label_infoRDS.Location = new System.Drawing.Point(130, 210);
            this.label_infoRDS.Name = "label_infoRDS";
            this.label_infoRDS.Size = new System.Drawing.Size(50, 25);
            this.label_infoRDS.Text = "RDS";
            this.label_infoRDS.ParentChanged += new System.EventHandler(this.label_infoRDS_ParentChanged);
            // 
            // label_infoTP
            // 
            this.label_infoTP.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_infoTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(74)))));
            this.label_infoTP.Location = new System.Drawing.Point(186, 210);
            this.label_infoTP.Name = "label_infoTP";
            this.label_infoTP.Size = new System.Drawing.Size(35, 25);
            this.label_infoTP.Text = "TP";
            this.label_infoTP.ParentChanged += new System.EventHandler(this.label_infoTP_ParentChanged);
            // 
            // label_infoAF
            // 
            this.label_infoAF.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_infoAF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            this.label_infoAF.Location = new System.Drawing.Point(268, 210);
            this.label_infoAF.Name = "label_infoAF";
            this.label_infoAF.Size = new System.Drawing.Size(35, 25);
            this.label_infoAF.Text = "AF";
            this.label_infoAF.ParentChanged += new System.EventHandler(this.label_infoAF_ParentChanged);
            // 
            // label_infoTA
            // 
            this.label_infoTA.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_infoTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(74)))));
            this.label_infoTA.Location = new System.Drawing.Point(227, 210);
            this.label_infoTA.Name = "label_infoTA";
            this.label_infoTA.Size = new System.Drawing.Size(35, 25);
            this.label_infoTA.Text = "TA";
            this.label_infoTA.ParentChanged += new System.EventHandler(this.label_infoTA_ParentChanged);
            // 
            // label_infoCT
            // 
            this.label_infoCT.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_infoCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            this.label_infoCT.Location = new System.Drawing.Point(309, 210);
            this.label_infoCT.Name = "label_infoCT";
            this.label_infoCT.Size = new System.Drawing.Size(35, 25);
            this.label_infoCT.Text = "CT";
            this.label_infoCT.ParentChanged += new System.EventHandler(this.label_infoCT_ParentChanged);
            // 
            // timerSaveStation
            // 
            this.timerSaveStation.Interval = 500;
            this.timerSaveStation.Tick += new System.EventHandler(this.timerSaveStation_Tick);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Location = new System.Drawing.Point(753, 426);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxPhone.Visible = false;
            // 
            // pictureBoxBattCharge
            // 
            this.pictureBoxBattCharge.Location = new System.Drawing.Point(720, 426);
            this.pictureBoxBattCharge.Name = "pictureBoxBattCharge";
            this.pictureBoxBattCharge.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxBattCharge.Visible = false;
            // 
            // label_tempAKPP
            // 
            this.label_tempAKPP.BackColor = System.Drawing.Color.Black;
            this.label_tempAKPP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_tempAKPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_tempAKPP.Location = new System.Drawing.Point(610, 430);
            this.label_tempAKPP.Name = "label_tempAKPP";
            this.label_tempAKPP.Size = new System.Drawing.Size(87, 35);
            this.label_tempAKPP.TabIndex = 244;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 229;
            this.label_LevelFuel.TabStop = false;
            // 
            // label_temp_coolingwater
            // 
            this.label_temp_coolingwater.BackColor = System.Drawing.Color.Black;
            this.label_temp_coolingwater.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_temp_coolingwater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_temp_coolingwater.Location = new System.Drawing.Point(52, 430);
            this.label_temp_coolingwater.Name = "label_temp_coolingwater";
            this.label_temp_coolingwater.Size = new System.Drawing.Size(87, 35);
            this.label_temp_coolingwater.TabIndex = 214;
            this.label_temp_coolingwater.TabStop = false;
            // 
            // label_Date
            // 
            this.label_Date.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Date.BackColor = System.Drawing.Color.Black;
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(250, 453);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(300, 26);
            this.label_Date.TabIndex = 168;
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // label_Time
            // 
            this.label_Time.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Time.BackColor = System.Drawing.Color.Black;
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(250, 416);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(300, 37);
            this.label_Time.TabIndex = 167;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // label_Freq
            // 
            this.label_Freq.Align = System.Drawing.ContentAlignment.TopRight;
            this.label_Freq.BackColor = System.Drawing.Color.Black;
            this.label_Freq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_Freq.Location = new System.Drawing.Point(130, 245);
            this.label_Freq.Name = "label_Freq";
            this.label_Freq.Size = new System.Drawing.Size(459, 96);
            this.label_Freq.TabIndex = 120;
            this.label_Freq.TabStop = false;
            this.label_Freq.Click += new System.EventHandler(this.label_Freq_Click);
            // 
            // BtnStereoStatus
            // 
            this.BtnStereoStatus.Location = new System.Drawing.Point(634, 213);
            this.BtnStereoStatus.Name = "BtnStereoStatus";
            this.BtnStereoStatus.Size = new System.Drawing.Size(36, 20);
            this.BtnStereoStatus.TabIndex = 108;
            this.BtnStereoStatus.TabStop = false;
            this.BtnStereoStatus.Click += new System.EventHandler(this.BtnStereoStatus_Click);
            // 
            // Button_FM4
            // 
            this.Button_FM4.Location = new System.Drawing.Point(680, 254);
            this.Button_FM4.Name = "Button_FM4";
            this.Button_FM4.Size = new System.Drawing.Size(100, 65);
            this.Button_FM4.TabIndex = 97;
            this.Button_FM4.Visible = false;
            this.Button_FM4.Click += new System.EventHandler(this.Button_FM4_Click);
            // 
            // Button_FM3
            // 
            this.Button_FM3.Location = new System.Drawing.Point(680, 254);
            this.Button_FM3.Name = "Button_FM3";
            this.Button_FM3.Size = new System.Drawing.Size(100, 65);
            this.Button_FM3.TabIndex = 96;
            this.Button_FM3.Visible = false;
            this.Button_FM3.Click += new System.EventHandler(this.Button_FM3_Click);
            // 
            // Button_FM2
            // 
            this.Button_FM2.Location = new System.Drawing.Point(680, 254);
            this.Button_FM2.Name = "Button_FM2";
            this.Button_FM2.Size = new System.Drawing.Size(100, 65);
            this.Button_FM2.TabIndex = 95;
            this.Button_FM2.Click += new System.EventHandler(this.Button_FM2_Click);
            // 
            // Button_FM1
            // 
            this.Button_FM1.Location = new System.Drawing.Point(680, 176);
            this.Button_FM1.Name = "Button_FM1";
            this.Button_FM1.Size = new System.Drawing.Size(100, 65);
            this.Button_FM1.TabIndex = 93;
            this.Button_FM1.Click += new System.EventHandler(this.Button_FM1_Click);
            // 
            // Button_AM
            // 
            this.Button_AM.Location = new System.Drawing.Point(680, 98);
            this.Button_AM.Name = "Button_AM";
            this.Button_AM.Size = new System.Drawing.Size(100, 65);
            this.Button_AM.TabIndex = 92;
            this.Button_AM.Click += new System.EventHandler(this.Button_AM_Click);
            // 
            // Button_Freq_2
            // 
            this.Button_Freq_2.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_2.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_2.Location = new System.Drawing.Point(240, 357);
            this.Button_Freq_2.Name = "Button_Freq_2";
            this.Button_Freq_2.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_2.TabIndex = 82;
            this.Button_Freq_2.Click += new System.EventHandler(this.Button_Freq_2_Click);
            this.Button_Freq_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_2_MouseDown);
            // 
            // Button_Freq_3
            // 
            this.Button_Freq_3.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_3.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_3.Location = new System.Drawing.Point(350, 357);
            this.Button_Freq_3.Name = "Button_Freq_3";
            this.Button_Freq_3.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_3.TabIndex = 81;
            this.Button_Freq_3.Click += new System.EventHandler(this.Button_Freq_3_Click);
            this.Button_Freq_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_3_MouseDown);
            // 
            // Button_Freq_4
            // 
            this.Button_Freq_4.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_4.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_4.Location = new System.Drawing.Point(460, 357);
            this.Button_Freq_4.Name = "Button_Freq_4";
            this.Button_Freq_4.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_4.TabIndex = 80;
            this.Button_Freq_4.Click += new System.EventHandler(this.Button_Freq_4_Click);
            this.Button_Freq_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_4_MouseDown);
            // 
            // Button_Freq_5
            // 
            this.Button_Freq_5.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_5.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_5.Location = new System.Drawing.Point(570, 357);
            this.Button_Freq_5.Name = "Button_Freq_5";
            this.Button_Freq_5.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_5.TabIndex = 79;
            this.Button_Freq_5.Click += new System.EventHandler(this.Button_Freq_5_Click);
            this.Button_Freq_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_5_MouseDown);
            // 
            // Button_Freq_6
            // 
            this.Button_Freq_6.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_6.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_6.Location = new System.Drawing.Point(680, 357);
            this.Button_Freq_6.Name = "Button_Freq_6";
            this.Button_Freq_6.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_6.TabIndex = 78;
            this.Button_Freq_6.Click += new System.EventHandler(this.Button_Freq_6_Click);
            this.Button_Freq_6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_6_MouseDown);
            // 
            // Button_Freq_1
            // 
            this.Button_Freq_1.Align = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Freq_1.ForeColor = System.Drawing.Color.White;
            this.Button_Freq_1.Location = new System.Drawing.Point(130, 357);
            this.Button_Freq_1.Name = "Button_Freq_1";
            this.Button_Freq_1.Size = new System.Drawing.Size(100, 40);
            this.Button_Freq_1.TabIndex = 77;
            this.Button_Freq_1.Click += new System.EventHandler(this.Button_Freq_1_Click);
            this.Button_Freq_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Freq_1_MouseDown);
            // 
            // Button_SearchUP
            // 
            this.Button_SearchUP.Location = new System.Drawing.Point(20, 176);
            this.Button_SearchUP.Name = "Button_SearchUP";
            this.Button_SearchUP.Size = new System.Drawing.Size(100, 65);
            this.Button_SearchUP.TabIndex = 59;
            this.Button_SearchUP.Click += new System.EventHandler(this.Button_SearchUP_Click);
            this.Button_SearchUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_SearchUP_MouseDown);
            this.Button_SearchUP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_SearchUP_MouseUp);
            // 
            // Button_SearchDOWN
            // 
            this.Button_SearchDOWN.Location = new System.Drawing.Point(20, 254);
            this.Button_SearchDOWN.Name = "Button_SearchDOWN";
            this.Button_SearchDOWN.Size = new System.Drawing.Size(100, 65);
            this.Button_SearchDOWN.TabIndex = 58;
            this.Button_SearchDOWN.Click += new System.EventHandler(this.Button_SearchDOWN_Click);
            this.Button_SearchDOWN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_SearchDOWN_MouseDown);
            this.Button_SearchDOWN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_SearchDOWN_MouseUp);
            // 
            // Button_SetAudio
            // 
            this.Button_SetAudio.Location = new System.Drawing.Point(570, 20);
            this.Button_SetAudio.Name = "Button_SetAudio";
            this.Button_SetAudio.Size = new System.Drawing.Size(100, 65);
            this.Button_SetAudio.TabIndex = 55;
            this.Button_SetAudio.Click += new System.EventHandler(this.Button_SetAudio_Click);
            // 
            // Button_SetRadio
            // 
            this.Button_SetRadio.Location = new System.Drawing.Point(680, 20);
            this.Button_SetRadio.Name = "Button_SetRadio";
            this.Button_SetRadio.Size = new System.Drawing.Size(100, 65);
            this.Button_SetRadio.TabIndex = 54;
            this.Button_SetRadio.Click += new System.EventHandler(this.Button_SetRadio_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.Location = new System.Drawing.Point(20, 98);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(100, 65);
            this.Button_Home.TabIndex = 50;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            this.Button_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Home_MouseDown);
            // 
            // timer_Exit
            // 
            this.timer_Exit.Interval = 3000;
            this.timer_Exit.Tick += new System.EventHandler(this.timer_Exit_Tick);
            // 
            // Form_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label_tempAKPP);
            this.Controls.Add(this.pictureBoxBattCharge);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.label_LevelFuel);
            this.Controls.Add(this.label_temp_coolingwater);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Freq);
            this.Controls.Add(this.label_infoCT);
            this.Controls.Add(this.label_infoTA);
            this.Controls.Add(this.label_infoAF);
            this.Controls.Add(this.label_infoTP);
            this.Controls.Add(this.label_infoRDS);
            this.Controls.Add(this.BtnStereoStatus);
            this.Controls.Add(this.label_PTY);
            this.Controls.Add(this.Button_FM4);
            this.Controls.Add(this.Button_FM3);
            this.Controls.Add(this.Button_FM2);
            this.Controls.Add(this.Button_FM1);
            this.Controls.Add(this.Button_AM);
            this.Controls.Add(this.label_RDS);
            this.Controls.Add(this.Button_Freq_2);
            this.Controls.Add(this.Button_Freq_3);
            this.Controls.Add(this.Button_Freq_4);
            this.Controls.Add(this.Button_Freq_5);
            this.Controls.Add(this.Button_Freq_6);
            this.Controls.Add(this.Button_Freq_1);
            this.Controls.Add(this.Button_SearchUP);
            this.Controls.Add(this.Button_SearchDOWN);
            this.Controls.Add(this.Button_SetAudio);
            this.Controls.Add(this.Button_SetRadio);
            this.Controls.Add(this.Button_Home);
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.label_Mhz_kHz);
            this.Controls.Add(this.pictureBoxWhiteLine);
            this.Controls.Add(label_Radio);
            this.Controls.Add(this.Img_Radio);
            this.Controls.Add(this.pictureBoxRedLine);
            this.Controls.Add(this.panel_StereoStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Radio";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Radio_Load);
            this.Activated += new System.EventHandler(this.Form_Radio_Activated);
            this.Click += new System.EventHandler(this.Form_Radio_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Radio_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxMute;
        private System.Windows.Forms.Label label_Mhz_kHz;
        private System.Windows.Forms.PictureBox pictureBoxWhiteLine;
        private System.Windows.Forms.PictureBox Img_Radio;
        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        private ImageButton Button_Home;
        private ImageButton Button_SetRadio;
        private ImageButton Button_SetAudio;
        private ImageButton Button_SearchDOWN;
        private ImageButton Button_SearchUP;
        private TriggerButton_4state Button_Freq_1;
        private TriggerButton_4state Button_Freq_6;
        private TriggerButton_4state Button_Freq_5;
        private TriggerButton_4state Button_Freq_4;
        private TriggerButton_4state Button_Freq_3;
        private TriggerButton_4state Button_Freq_2;
        private System.Windows.Forms.Timer timer_Search;
        private System.Windows.Forms.Label label_RDS;
        private TriggerButton Button_AM;
        private TriggerButton Button_FM1;
        private TriggerButton Button_FM2;
        private TriggerButton Button_FM3;
        private TriggerButton Button_FM4;
        private System.Windows.Forms.Label label_PTY;
        private TriggerButton_4state BtnStereoStatus;
        private System.Windows.Forms.Panel panel_StereoStatus;
        private Label_ label_Freq;
        private System.Windows.Forms.Label label_infoRDS;
        private System.Windows.Forms.Label label_infoTP;
        private System.Windows.Forms.Label label_infoAF;
        private System.Windows.Forms.Label label_infoTA;
        private System.Windows.Forms.Label label_infoCT;
        private System.Windows.Forms.Timer timerSaveStation;
        public Label_ label_temp_coolingwater;
        public Label_ label_LevelFuel;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public Label_ label_Date;
        public Label_ label_Time;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
        private System.Windows.Forms.Timer timer_Exit;
    }
}