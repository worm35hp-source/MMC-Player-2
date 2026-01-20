namespace MMC_Player_2
{
    partial class Form_ScreenSaver
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
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.SuspendLayout();
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Location = new System.Drawing.Point(294, 235);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(212, 5);
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
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 26;
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
            this.label_temp_coolingwater.TabIndex = 14;
            this.label_temp_coolingwater.TabStop = false;
            // 
            // label_Date
            // 
            this.label_Date.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Date.BackColor = System.Drawing.Color.Black;
            this.label_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_Date.Location = new System.Drawing.Point(3, 257);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(794, 56);
            this.label_Date.TabIndex = 9;
            this.label_Date.TabStop = false;
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // label_Time
            // 
            this.label_Time.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Time.BackColor = System.Drawing.Color.Black;
            this.label_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_Time.Location = new System.Drawing.Point(3, 167);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(794, 65);
            this.label_Time.TabIndex = 8;
            this.label_Time.TabStop = false;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // label_tempAKPP
            // 
            this.label_tempAKPP.BackColor = System.Drawing.Color.Black;
            this.label_tempAKPP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_tempAKPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_tempAKPP.Location = new System.Drawing.Point(610, 430);
            this.label_tempAKPP.Name = "label_tempAKPP";
            this.label_tempAKPP.Size = new System.Drawing.Size(87, 35);
            this.label_tempAKPP.TabIndex = 32;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // Form_ScreenSaver
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
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.pictureBoxLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ScreenSaver";
            this.Text = "Form_ScreenSaver";
            this.Load += new System.EventHandler(this.Form_ScreenSaver_Load);
            this.Click += new System.EventHandler(this.Form_ScreenSaver_Click);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxMute;
        public Label_ label_temp_coolingwater;
        public Label_ label_LevelFuel;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public Label_ label_Time;
        public Label_ label_Date;
        public System.Windows.Forms.PictureBox pictureBoxLine;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
    }
}