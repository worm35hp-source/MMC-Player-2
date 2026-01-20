namespace MMC_Player_2
{
    partial class Form_Main
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
            this.pictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.timer_Init = new System.Windows.Forms.Timer();
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.timer_ScreenSaver = new System.Windows.Forms.Timer();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.Button_Phone = new MMC_Player_2.ImageButton();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.Button_Navi = new MMC_Player_2.ImageButton();
            this.Button_Settings = new MMC_Player_2.ImageButton();
            this.Button_Audio = new MMC_Player_2.ImageButton();
            this.Button_Radio = new MMC_Player_2.ImageButton();
            this.Button_Exit = new MMC_Player_2.ImageButton();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.timer_CanData = new System.Windows.Forms.Timer();
            this.label_consumption = new MMC_Player_2.Label_();
            this.SuspendLayout();
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // timer_Init
            // 
            this.timer_Init.Tick += new System.EventHandler(this.timer_Init_Tick);
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            // 
            // timer_ScreenSaver
            // 
            this.timer_ScreenSaver.Enabled = true;
            this.timer_ScreenSaver.Interval = 1000;
            this.timer_ScreenSaver.Tick += new System.EventHandler(this.timer_ScreenSaver_Tick);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Location = new System.Drawing.Point(753, 426);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxPhone.Visible = false;
            // 
            // Button_Phone
            // 
            this.Button_Phone.Location = new System.Drawing.Point(280, 200);
            this.Button_Phone.Name = "Button_Phone";
            this.Button_Phone.Size = new System.Drawing.Size(240, 160);
            this.Button_Phone.TabIndex = 28;
            this.Button_Phone.TabStop = false;
            this.Button_Phone.Click += new System.EventHandler(this.Button_Phone_Click);
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 25;
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
            this.label_temp_coolingwater.TabIndex = 21;
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
            this.label_Date.TabIndex = 19;
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
            this.label_Time.TabIndex = 18;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // Button_Navi
            // 
            this.Button_Navi.Location = new System.Drawing.Point(20, 200);
            this.Button_Navi.Name = "Button_Navi";
            this.Button_Navi.Size = new System.Drawing.Size(240, 160);
            this.Button_Navi.TabIndex = 12;
            this.Button_Navi.TabStop = false;
            this.Button_Navi.Click += new System.EventHandler(this.Button_Navi_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.Location = new System.Drawing.Point(540, 20);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(240, 160);
            this.Button_Settings.TabIndex = 11;
            this.Button_Settings.TabStop = false;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Button_Audio
            // 
            this.Button_Audio.Location = new System.Drawing.Point(280, 20);
            this.Button_Audio.Name = "Button_Audio";
            this.Button_Audio.Size = new System.Drawing.Size(240, 160);
            this.Button_Audio.TabIndex = 10;
            this.Button_Audio.TabStop = false;
            this.Button_Audio.Click += new System.EventHandler(this.Button_Audio_Click);
            // 
            // Button_Radio
            // 
            this.Button_Radio.Location = new System.Drawing.Point(20, 20);
            this.Button_Radio.Name = "Button_Radio";
            this.Button_Radio.Size = new System.Drawing.Size(240, 160);
            this.Button_Radio.TabIndex = 9;
            this.Button_Radio.TabStop = false;
            this.Button_Radio.Click += new System.EventHandler(this.Button_Radio_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(540, 200);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(240, 160);
            this.Button_Exit.TabIndex = 7;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
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
            this.label_tempAKPP.TabIndex = 31;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // timer_CanData
            // 
            this.timer_CanData.Enabled = true;
            this.timer_CanData.Interval = 250;
            this.timer_CanData.Tick += new System.EventHandler(this.timer_CanData_Tick);
            // 
            // label_consumption
            // 
            this.label_consumption.BackColor = System.Drawing.Color.Black;
            this.label_consumption.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_consumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_consumption.Location = new System.Drawing.Point(540, 430);
            this.label_consumption.Name = "label_consumption";
            this.label_consumption.Size = new System.Drawing.Size(64, 35);
            this.label_consumption.TabIndex = 36;
            this.label_consumption.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label_consumption);
            this.Controls.Add(this.label_tempAKPP);
            this.Controls.Add(this.pictureBoxBattCharge);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.Button_Phone);
            this.Controls.Add(this.label_LevelFuel);
            this.Controls.Add(this.label_temp_coolingwater);
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.Button_Navi);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.Button_Audio);
            this.Controls.Add(this.Button_Radio);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.pictureBoxRedLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Click += new System.EventHandler(this.Form_Main_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        private ImageButton Button_Exit;
        private ImageButton Button_Radio;
        private ImageButton Button_Audio;
        private ImageButton Button_Settings;
        private ImageButton Button_Navi;
        private System.Windows.Forms.Timer timer_Init;
        private Label_ label_Time;
        private Label_ label_Date;
        private System.Windows.Forms.PictureBox pictureBoxMute;
        private System.Windows.Forms.Timer timer_ScreenSaver;
        public Label_ label_temp_coolingwater;
        public Label_ label_LevelFuel;
        private ImageButton Button_Phone;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
        private System.Windows.Forms.Timer timer_CanData;
        public Label_ label_consumption;

    }
}

