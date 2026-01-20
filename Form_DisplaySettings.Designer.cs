namespace MMC_Player_2
{
    partial class Form_DisplaySettings
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.pictureBoxImgSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalibration = new System.Windows.Forms.PictureBox();
            this.pictureBoxDayNight = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorSet = new System.Windows.Forms.PictureBox();
            this.trackBarDisplaySettings3 = new MMC_Player_2.TrackBarDisplaySettings();
            this.trackBarDisplaySettings2 = new MMC_Player_2.TrackBarDisplaySettings();
            this.trackBarDisplaySettings1 = new MMC_Player_2.TrackBarDisplaySettings();
            this.BtnSelectAuto = new MMC_Player_2.TriggerButton();
            this.BtnSelectNight = new MMC_Player_2.TriggerButton();
            this.BtnSelectDay = new MMC_Player_2.TriggerButton();
            this.BtnContrastLeft = new MMC_Player_2.ImageButton();
            this.BtnColorLeft = new MMC_Player_2.ImageButton();
            this.BtnBrightRight = new MMC_Player_2.ImageButton();
            this.BtnContrastRight = new MMC_Player_2.ImageButton();
            this.BtnColorRight = new MMC_Player_2.ImageButton();
            this.BtnBrightLeft = new MMC_Player_2.ImageButton();
            this.ButtonCalibration = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(37, 395);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 30);
            label8.Text = "Авто";
            label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(37, 310);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 30);
            label7.Text = "Ночь";
            label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(37, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 30);
            label6.Text = "День";
            label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(577, 395);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 30);
            label5.Text = "Насыщенность";
            label5.ParentChanged += new System.EventHandler(this.label5_ParentChanged);
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(577, 310);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 30);
            label4.Text = "Контрастность";
            label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(577, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 30);
            label3.Text = "Яркость";
            label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(510, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 30);
            label2.Text = "Калибровка экрана";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(103, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 54);
            label1.Text = "Настройка экрана";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxImgSetting
            // 
            this.pictureBoxImgSetting.Location = new System.Drawing.Point(20, 15);
            this.pictureBoxImgSetting.Name = "pictureBoxImgSetting";
            this.pictureBoxImgSetting.Size = new System.Drawing.Size(77, 55);
            // 
            // pictureBoxColorTable
            // 
            this.pictureBoxColorTable.Location = new System.Drawing.Point(250, 20);
            this.pictureBoxColorTable.Name = "pictureBoxColorTable";
            this.pictureBoxColorTable.Size = new System.Drawing.Size(210, 150);
            this.pictureBoxColorTable.Click += new System.EventHandler(this.pictureBoxColorTable_Click);
            // 
            // pictureBoxCalibration
            // 
            this.pictureBoxCalibration.Location = new System.Drawing.Point(500, 20);
            this.pictureBoxCalibration.Name = "pictureBoxCalibration";
            this.pictureBoxCalibration.Size = new System.Drawing.Size(280, 150);
            // 
            // pictureBoxDayNight
            // 
            this.pictureBoxDayNight.Location = new System.Drawing.Point(20, 190);
            this.pictureBoxDayNight.Name = "pictureBoxDayNight";
            this.pictureBoxDayNight.Size = new System.Drawing.Size(210, 270);
            this.pictureBoxDayNight.Click += new System.EventHandler(this.pictureBoxDayNight_Click);
            // 
            // pictureBoxColorSet
            // 
            this.pictureBoxColorSet.Location = new System.Drawing.Point(250, 190);
            this.pictureBoxColorSet.Name = "pictureBoxColorSet";
            this.pictureBoxColorSet.Size = new System.Drawing.Size(530, 270);
            this.pictureBoxColorSet.Click += new System.EventHandler(this.pictureBoxColorSet_Click);
            // 
            // trackBarDisplaySettings3
            // 
            this.trackBarDisplaySettings3.Location = new System.Drawing.Point(322, 379);
            this.trackBarDisplaySettings3.Name = "trackBarDisplaySettings3";
            this.trackBarDisplaySettings3.Size = new System.Drawing.Size(180, 60);
            this.trackBarDisplaySettings3.TabIndex = 78;
            this.trackBarDisplaySettings3.Click += new System.EventHandler(this.trackBarDisplaySettings3_Click);
            // 
            // trackBarDisplaySettings2
            // 
            this.trackBarDisplaySettings2.Location = new System.Drawing.Point(323, 294);
            this.trackBarDisplaySettings2.Name = "trackBarDisplaySettings2";
            this.trackBarDisplaySettings2.Size = new System.Drawing.Size(180, 60);
            this.trackBarDisplaySettings2.TabIndex = 77;
            this.trackBarDisplaySettings2.Click += new System.EventHandler(this.trackBarDisplaySettings2_Click);
            // 
            // trackBarDisplaySettings1
            // 
            this.trackBarDisplaySettings1.Location = new System.Drawing.Point(323, 209);
            this.trackBarDisplaySettings1.Name = "trackBarDisplaySettings1";
            this.trackBarDisplaySettings1.Size = new System.Drawing.Size(180, 60);
            this.trackBarDisplaySettings1.TabIndex = 76;
            this.trackBarDisplaySettings1.Click += new System.EventHandler(this.trackBarDisplaySettings1_Click);
            // 
            // BtnSelectAuto
            // 
            this.BtnSelectAuto.Location = new System.Drawing.Point(116, 385);
            this.BtnSelectAuto.Name = "BtnSelectAuto";
            this.BtnSelectAuto.Size = new System.Drawing.Size(100, 40);
            this.BtnSelectAuto.TabIndex = 75;
            this.BtnSelectAuto.Click += new System.EventHandler(this.BtnSelectAuto_Click);
            // 
            // BtnSelectNight
            // 
            this.BtnSelectNight.Location = new System.Drawing.Point(116, 300);
            this.BtnSelectNight.Name = "BtnSelectNight";
            this.BtnSelectNight.Size = new System.Drawing.Size(100, 40);
            this.BtnSelectNight.TabIndex = 74;
            this.BtnSelectNight.Click += new System.EventHandler(this.BtnSelectNight_Click);
            // 
            // BtnSelectDay
            // 
            this.BtnSelectDay.Location = new System.Drawing.Point(116, 215);
            this.BtnSelectDay.Name = "BtnSelectDay";
            this.BtnSelectDay.Size = new System.Drawing.Size(100, 40);
            this.BtnSelectDay.TabIndex = 73;
            this.BtnSelectDay.Click += new System.EventHandler(this.BtnSelectDay_Click);
            // 
            // BtnContrastLeft
            // 
            this.BtnContrastLeft.Location = new System.Drawing.Point(255, 295);
            this.BtnContrastLeft.Name = "BtnContrastLeft";
            this.BtnContrastLeft.Size = new System.Drawing.Size(61, 58);
            this.BtnContrastLeft.TabIndex = 59;
            this.BtnContrastLeft.Click += new System.EventHandler(this.BtnContrastLeft_Click);
            // 
            // BtnColorLeft
            // 
            this.BtnColorLeft.Location = new System.Drawing.Point(255, 380);
            this.BtnColorLeft.Name = "BtnColorLeft";
            this.BtnColorLeft.Size = new System.Drawing.Size(61, 58);
            this.BtnColorLeft.TabIndex = 58;
            this.BtnColorLeft.Click += new System.EventHandler(this.BtnColorLeft_Click);
            // 
            // BtnBrightRight
            // 
            this.BtnBrightRight.Location = new System.Drawing.Point(510, 210);
            this.BtnBrightRight.Name = "BtnBrightRight";
            this.BtnBrightRight.Size = new System.Drawing.Size(61, 58);
            this.BtnBrightRight.TabIndex = 56;
            this.BtnBrightRight.Click += new System.EventHandler(this.BtnBrightRight_Click);
            // 
            // BtnContrastRight
            // 
            this.BtnContrastRight.Location = new System.Drawing.Point(510, 295);
            this.BtnContrastRight.Name = "BtnContrastRight";
            this.BtnContrastRight.Size = new System.Drawing.Size(61, 58);
            this.BtnContrastRight.TabIndex = 55;
            this.BtnContrastRight.Click += new System.EventHandler(this.BtnContrastRight_Click);
            // 
            // BtnColorRight
            // 
            this.BtnColorRight.Location = new System.Drawing.Point(510, 380);
            this.BtnColorRight.Name = "BtnColorRight";
            this.BtnColorRight.Size = new System.Drawing.Size(61, 58);
            this.BtnColorRight.TabIndex = 54;
            this.BtnColorRight.Click += new System.EventHandler(this.BtnColorRight_Click);
            // 
            // BtnBrightLeft
            // 
            this.BtnBrightLeft.Location = new System.Drawing.Point(255, 210);
            this.BtnBrightLeft.Name = "BtnBrightLeft";
            this.BtnBrightLeft.Size = new System.Drawing.Size(61, 58);
            this.BtnBrightLeft.TabIndex = 53;
            this.BtnBrightLeft.Click += new System.EventHandler(this.BtnBrightLeft_Click);
            // 
            // ButtonCalibration
            // 
            this.ButtonCalibration.Location = new System.Drawing.Point(590, 85);
            this.ButtonCalibration.Name = "ButtonCalibration";
            this.ButtonCalibration.Size = new System.Drawing.Size(100, 65);
            this.ButtonCalibration.TabIndex = 49;
            this.ButtonCalibration.Click += new System.EventHandler(this.ButtonCalibration_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 48;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form_DisplaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.trackBarDisplaySettings3);
            this.Controls.Add(this.trackBarDisplaySettings2);
            this.Controls.Add(this.trackBarDisplaySettings1);
            this.Controls.Add(this.BtnSelectAuto);
            this.Controls.Add(this.BtnSelectNight);
            this.Controls.Add(this.BtnSelectDay);
            this.Controls.Add(this.BtnContrastLeft);
            this.Controls.Add(this.BtnColorLeft);
            this.Controls.Add(this.BtnBrightRight);
            this.Controls.Add(this.BtnContrastRight);
            this.Controls.Add(this.BtnColorRight);
            this.Controls.Add(this.BtnBrightLeft);
            this.Controls.Add(this.ButtonCalibration);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBoxImgSetting);
            this.Controls.Add(this.pictureBoxColorTable);
            this.Controls.Add(this.pictureBoxCalibration);
            this.Controls.Add(this.pictureBoxDayNight);
            this.Controls.Add(this.pictureBoxColorSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DisplaySettings";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_DisplaySettings_Load);
            this.Click += new System.EventHandler(this.Form_DisplaySettings_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_DisplaySettings_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImgSetting;
        private System.Windows.Forms.PictureBox pictureBoxColorTable;
        private System.Windows.Forms.PictureBox pictureBoxCalibration;
        private System.Windows.Forms.PictureBox pictureBoxDayNight;
        private System.Windows.Forms.PictureBox pictureBoxColorSet;
        private ImageButton Button_Back;
        private ImageButton ButtonCalibration;
        private ImageButton BtnBrightLeft;
        private ImageButton BtnColorRight;
        private ImageButton BtnContrastRight;
        private ImageButton BtnBrightRight;
        private ImageButton BtnColorLeft;
        private ImageButton BtnContrastLeft;
        private TriggerButton BtnSelectDay;
        private TriggerButton BtnSelectNight;
        private TriggerButton BtnSelectAuto;
        private TrackBarDisplaySettings trackBarDisplaySettings1;
        private TrackBarDisplaySettings trackBarDisplaySettings2;
        private TrackBarDisplaySettings trackBarDisplaySettings3;

    }
}