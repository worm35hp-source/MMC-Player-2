namespace MMC_Player_2
{
    partial class Form_Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.Button_PhoneSettings = new MMC_Player_2.ImageButton();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.Button_DisplaySet = new MMC_Player_2.ImageButton();
            this.Button_AudioSet = new MMC_Player_2.ImageButton();
            this.Button_RadioSet = new MMC_Player_2.ImageButton();
            this.Button_GeneralSet = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.Button_RearCam = new MMC_Player_2.ImageButton();
            this.imageButton1 = new MMC_Player_2.ImageButton();
            this.SuspendLayout();
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "Настройки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
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
            // Button_PhoneSettings
            // 
            this.Button_PhoneSettings.Location = new System.Drawing.Point(215, 20);
            this.Button_PhoneSettings.Name = "Button_PhoneSettings";
            this.Button_PhoneSettings.Size = new System.Drawing.Size(175, 160);
            this.Button_PhoneSettings.TabIndex = 212;
            this.Button_PhoneSettings.Click += new System.EventHandler(this.Button_PhoneSettings_Click);
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 208;
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
            this.label_temp_coolingwater.TabIndex = 205;
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
            this.label_Date.TabIndex = 172;
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
            this.label_Time.TabIndex = 171;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // Button_DisplaySet
            // 
            this.Button_DisplaySet.Location = new System.Drawing.Point(605, 200);
            this.Button_DisplaySet.Name = "Button_DisplaySet";
            this.Button_DisplaySet.Size = new System.Drawing.Size(175, 160);
            this.Button_DisplaySet.TabIndex = 11;
            this.Button_DisplaySet.Click += new System.EventHandler(this.Button_DisplaySet_Click);
            // 
            // Button_AudioSet
            // 
            this.Button_AudioSet.Location = new System.Drawing.Point(410, 200);
            this.Button_AudioSet.Name = "Button_AudioSet";
            this.Button_AudioSet.Size = new System.Drawing.Size(175, 160);
            this.Button_AudioSet.TabIndex = 10;
            this.Button_AudioSet.Click += new System.EventHandler(this.Button_AudioSet_Click);
            // 
            // Button_RadioSet
            // 
            this.Button_RadioSet.Location = new System.Drawing.Point(215, 200);
            this.Button_RadioSet.Name = "Button_RadioSet";
            this.Button_RadioSet.Size = new System.Drawing.Size(175, 160);
            this.Button_RadioSet.TabIndex = 9;
            this.Button_RadioSet.Click += new System.EventHandler(this.Button_RadioSet_Click);
            // 
            // Button_GeneralSet
            // 
            this.Button_GeneralSet.Location = new System.Drawing.Point(20, 200);
            this.Button_GeneralSet.Name = "Button_GeneralSet";
            this.Button_GeneralSet.Size = new System.Drawing.Size(175, 160);
            this.Button_GeneralSet.TabIndex = 8;
            this.Button_GeneralSet.Click += new System.EventHandler(this.Button_GeneralSet_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 7;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // label_tempAKPP
            // 
            this.label_tempAKPP.BackColor = System.Drawing.Color.Black;
            this.label_tempAKPP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_tempAKPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_tempAKPP.Location = new System.Drawing.Point(610, 430);
            this.label_tempAKPP.Name = "label_tempAKPP";
            this.label_tempAKPP.Size = new System.Drawing.Size(87, 35);
            this.label_tempAKPP.TabIndex = 216;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // Button_RearCam
            // 
            this.Button_RearCam.Location = new System.Drawing.Point(410, 20);
            this.Button_RearCam.Name = "Button_RearCam";
            this.Button_RearCam.Size = new System.Drawing.Size(175, 160);
            this.Button_RearCam.TabIndex = 222;
            this.Button_RearCam.Click += new System.EventHandler(this.Button_RearCam_Click);
            // 
            // imageButton1
            // 
            this.imageButton1.Location = new System.Drawing.Point(605, 20);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(175, 160);
            this.imageButton1.TabIndex = 228;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.Button_RearCam);
            this.Controls.Add(this.label_tempAKPP);
            this.Controls.Add(this.pictureBoxBattCharge);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.Button_PhoneSettings);
            this.Controls.Add(this.label_LevelFuel);
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.label_temp_coolingwater);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.Button_DisplaySet);
            this.Controls.Add(this.Button_AudioSet);
            this.Controls.Add(this.Button_RadioSet);
            this.Controls.Add(this.Button_GeneralSet);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.pictureBoxRedLine);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.Click += new System.EventHandler(this.Form_Settings_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        private System.Windows.Forms.Label label1;
        private ImageButton Button_Back;
        private ImageButton Button_GeneralSet;
        private ImageButton Button_RadioSet;
        private ImageButton Button_AudioSet;
        private ImageButton Button_DisplaySet;
        public Label_ label_temp_coolingwater;
        public System.Windows.Forms.PictureBox pictureBoxMute;
        public Label_ label_LevelFuel;
        private ImageButton Button_PhoneSettings;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public Label_ label_Date;
        public Label_ label_Time;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
        private ImageButton Button_RearCam;
        private ImageButton imageButton1;
    }
}