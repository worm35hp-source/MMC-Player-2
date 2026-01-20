namespace MMC_Player_2
{
    partial class Form_Dial
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
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxDial_backgnd = new System.Windows.Forms.PictureBox();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.BtnMicMute = new MMC_Player_2.TriggerButton_4state();
            this.label_Name = new MMC_Player_2.Label_();
            this.BtnReject = new MMC_Player_2.ImageButton();
            this.BtnAnswer = new MMC_Player_2.ImageButton();
            this.BtnHandsFree = new MMC_Player_2.TriggerButton();
            this.label_PhoneNumber_1 = new MMC_Player_2.Label_();
            this.label_PhoneNumber_2 = new MMC_Player_2.Label_();
            this.label_PhoneNumber_3 = new MMC_Player_2.Label_();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.SuspendLayout();
            // 
            // pictureBoxBattCharge
            // 
            this.pictureBoxBattCharge.Location = new System.Drawing.Point(720, 426);
            this.pictureBoxBattCharge.Name = "pictureBoxBattCharge";
            this.pictureBoxBattCharge.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxBattCharge.Visible = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Location = new System.Drawing.Point(753, 426);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxPhone.Visible = false;
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // pictureBoxDial_backgnd
            // 
            this.pictureBoxDial_backgnd.Location = new System.Drawing.Point(170, 72);
            this.pictureBoxDial_backgnd.Name = "pictureBoxDial_backgnd";
            this.pictureBoxDial_backgnd.Size = new System.Drawing.Size(460, 335);
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 232;
            this.label_LevelFuel.TabStop = false;
            this.label_LevelFuel.Click += new System.EventHandler(this.label_LevelFuel_Click);
            // 
            // label_temp_coolingwater
            // 
            this.label_temp_coolingwater.BackColor = System.Drawing.Color.Black;
            this.label_temp_coolingwater.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_temp_coolingwater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_temp_coolingwater.Location = new System.Drawing.Point(52, 430);
            this.label_temp_coolingwater.Name = "label_temp_coolingwater";
            this.label_temp_coolingwater.Size = new System.Drawing.Size(87, 35);
            this.label_temp_coolingwater.TabIndex = 231;
            this.label_temp_coolingwater.TabStop = false;
            this.label_temp_coolingwater.Click += new System.EventHandler(this.label_temp_coolingwater_Click);
            // 
            // label_Date
            // 
            this.label_Date.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Date.BackColor = System.Drawing.Color.Black;
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(250, 453);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(300, 26);
            this.label_Date.TabIndex = 230;
            this.label_Date.TabStop = false;
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
            this.label_Time.TabIndex = 229;
            this.label_Time.TabStop = false;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // BtnMicMute
            // 
            this.BtnMicMute.Location = new System.Drawing.Point(185, 87);
            this.BtnMicMute.Name = "BtnMicMute";
            this.BtnMicMute.Size = new System.Drawing.Size(160, 65);
            this.BtnMicMute.TabIndex = 11;
            this.BtnMicMute.TabStop = false;
            this.BtnMicMute.Click += new System.EventHandler(this.BtnMicMute_Click);
            // 
            // label_Name
            // 
            this.label_Name.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(94)))), ((int)(((byte)(72)))));
            this.label_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(185, 257);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(430, 39);
            this.label_Name.TabIndex = 10;
            this.label_Name.TabStop = false;
            // 
            // BtnReject
            // 
            this.BtnReject.Location = new System.Drawing.Point(455, 327);
            this.BtnReject.Name = "BtnReject";
            this.BtnReject.Size = new System.Drawing.Size(160, 65);
            this.BtnReject.TabIndex = 3;
            this.BtnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(185, 327);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(160, 65);
            this.BtnAnswer.TabIndex = 2;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // BtnHandsFree
            // 
            this.BtnHandsFree.Location = new System.Drawing.Point(185, 167);
            this.BtnHandsFree.Name = "BtnHandsFree";
            this.BtnHandsFree.Size = new System.Drawing.Size(160, 65);
            this.BtnHandsFree.TabIndex = 1;
            this.BtnHandsFree.Click += new System.EventHandler(this.BtnHandsFree_Click);
            // 
            // label_PhoneNumber_1
            // 
            this.label_PhoneNumber_1.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_PhoneNumber_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(94)))), ((int)(((byte)(72)))));
            this.label_PhoneNumber_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PhoneNumber_1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular);
            this.label_PhoneNumber_1.ForeColor = System.Drawing.Color.White;
            this.label_PhoneNumber_1.Location = new System.Drawing.Point(372, 87);
            this.label_PhoneNumber_1.Name = "label_PhoneNumber_1";
            this.label_PhoneNumber_1.Size = new System.Drawing.Size(243, 39);
            this.label_PhoneNumber_1.TabIndex = 7;
            this.label_PhoneNumber_1.TabStop = false;
            // 
            // label_PhoneNumber_2
            // 
            this.label_PhoneNumber_2.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_PhoneNumber_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(94)))), ((int)(((byte)(72)))));
            this.label_PhoneNumber_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PhoneNumber_2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular);
            this.label_PhoneNumber_2.ForeColor = System.Drawing.Color.White;
            this.label_PhoneNumber_2.Location = new System.Drawing.Point(372, 140);
            this.label_PhoneNumber_2.Name = "label_PhoneNumber_2";
            this.label_PhoneNumber_2.Size = new System.Drawing.Size(243, 39);
            this.label_PhoneNumber_2.TabIndex = 9;
            this.label_PhoneNumber_2.TabStop = false;
            // 
            // label_PhoneNumber_3
            // 
            this.label_PhoneNumber_3.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_PhoneNumber_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(94)))), ((int)(((byte)(72)))));
            this.label_PhoneNumber_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_PhoneNumber_3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular);
            this.label_PhoneNumber_3.ForeColor = System.Drawing.Color.White;
            this.label_PhoneNumber_3.Location = new System.Drawing.Point(372, 193);
            this.label_PhoneNumber_3.Name = "label_PhoneNumber_3";
            this.label_PhoneNumber_3.Size = new System.Drawing.Size(243, 39);
            this.label_PhoneNumber_3.TabIndex = 8;
            this.label_PhoneNumber_3.TabStop = false;
            // 
            // label_tempAKPP
            // 
            this.label_tempAKPP.BackColor = System.Drawing.Color.Black;
            this.label_tempAKPP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_tempAKPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_tempAKPP.Location = new System.Drawing.Point(610, 430);
            this.label_tempAKPP.Name = "label_tempAKPP";
            this.label_tempAKPP.Size = new System.Drawing.Size(87, 35);
            this.label_tempAKPP.TabIndex = 236;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // Form_Dial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
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
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.pictureBoxRedLine);
            this.Controls.Add(this.BtnMicMute);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.BtnReject);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.BtnHandsFree);
            this.Controls.Add(this.label_PhoneNumber_1);
            this.Controls.Add(this.label_PhoneNumber_2);
            this.Controls.Add(this.label_PhoneNumber_3);
            this.Controls.Add(this.pictureBoxDial_backgnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dial";
            this.Text = "Form_Dial";
            this.Load += new System.EventHandler(this.Form_Dial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton BtnReject;
        public Label_ label_PhoneNumber_1;
        public Label_ label_PhoneNumber_3;
        public Label_ label_PhoneNumber_2;
        public ImageButton BtnAnswer;
        public TriggerButton BtnHandsFree;
        public Label_ label_Name;
        public TriggerButton_4state BtnMicMute;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public Label_ label_LevelFuel;
        public Label_ label_temp_coolingwater;
        public Label_ label_Date;
        public System.Windows.Forms.PictureBox pictureBoxMute;
        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        public Label_ label_Time;
        private System.Windows.Forms.PictureBox pictureBoxDial_backgnd;
        public Label_ label_tempAKPP;
    }
}