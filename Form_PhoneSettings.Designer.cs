namespace MMC_Player_2
{
    partial class Form_PhoneSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxImgSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxFindPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxAutoConnect = new System.Windows.Forms.PictureBox();
            this.pictureBoxAutoAnswer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Img_VolumeDial = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxPhoneMemory = new System.Windows.Forms.PictureBox();
            this.BtnPhoneMemory = new MMC_Player_2.ImageButton();
            this.BtnVolumeHigh = new MMC_Player_2.ImageButton();
            this.BtnVolumeLow = new MMC_Player_2.ImageButton();
            this.BtnAutoAnswer = new MMC_Player_2.TriggerButton();
            this.BtnAutoConnect = new MMC_Player_2.TriggerButton();
            this.BtnFindPhone = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 54);
            this.label1.Text = "Настройки телефона";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxImgSetting
            // 
            this.pictureBoxImgSetting.Location = new System.Drawing.Point(20, 21);
            this.pictureBoxImgSetting.Name = "pictureBoxImgSetting";
            this.pictureBoxImgSetting.Size = new System.Drawing.Size(57, 66);
            this.pictureBoxImgSetting.Click += new System.EventHandler(this.pictureBoxImgSetting_Click);
            // 
            // pictureBoxFindPhone
            // 
            this.pictureBoxFindPhone.Location = new System.Drawing.Point(20, 268);
            this.pictureBoxFindPhone.Name = "pictureBoxFindPhone";
            this.pictureBoxFindPhone.Size = new System.Drawing.Size(370, 60);
            this.pictureBoxFindPhone.Click += new System.EventHandler(this.pictureBoxFindPhone_Click);
            // 
            // pictureBoxAutoConnect
            // 
            this.pictureBoxAutoConnect.Location = new System.Drawing.Point(20, 334);
            this.pictureBoxAutoConnect.Name = "pictureBoxAutoConnect";
            this.pictureBoxAutoConnect.Size = new System.Drawing.Size(370, 60);
            this.pictureBoxAutoConnect.Click += new System.EventHandler(this.pictureBoxAutoConnect_Click);
            // 
            // pictureBoxAutoAnswer
            // 
            this.pictureBoxAutoAnswer.Location = new System.Drawing.Point(20, 400);
            this.pictureBoxAutoAnswer.Name = "pictureBoxAutoAnswer";
            this.pictureBoxAutoAnswer.Size = new System.Drawing.Size(370, 60);
            this.pictureBoxAutoAnswer.Click += new System.EventHandler(this.pictureBoxAutoAnswer_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.Text = "Поиск устройств:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 47);
            this.label3.Text = "Автоматическое соединение:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.Text = "Автоответ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.Location = new System.Drawing.Point(410, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 338);
            this.listBox1.TabIndex = 64;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(493, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 53);
            this.label5.Text = "Список найденных устройств";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Img_VolumeDial
            // 
            this.Img_VolumeDial.Location = new System.Drawing.Point(232, 116);
            this.Img_VolumeDial.Name = "Img_VolumeDial";
            this.Img_VolumeDial.Size = new System.Drawing.Size(80, 60);
            this.Img_VolumeDial.Click += new System.EventHandler(this.Img_VolumeDial_Click);
            this.Img_VolumeDial.Paint += new System.Windows.Forms.PaintEventHandler(this.Img_VolumeDial_Paint);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(165, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 29);
            this.label6.Text = "Громкость звонка:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 47);
            this.label7.Text = "Устройства в памяти:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxPhoneMemory
            // 
            this.pictureBoxPhoneMemory.Location = new System.Drawing.Point(20, 202);
            this.pictureBoxPhoneMemory.Name = "pictureBoxPhoneMemory";
            this.pictureBoxPhoneMemory.Size = new System.Drawing.Size(370, 60);
            this.pictureBoxPhoneMemory.Click += new System.EventHandler(this.pictureBoxPhoneMemory_Click);
            // 
            // BtnPhoneMemory
            // 
            this.BtnPhoneMemory.Location = new System.Drawing.Point(279, 212);
            this.BtnPhoneMemory.Name = "BtnPhoneMemory";
            this.BtnPhoneMemory.Size = new System.Drawing.Size(100, 40);
            this.BtnPhoneMemory.TabIndex = 86;
            this.BtnPhoneMemory.Click += new System.EventHandler(this.BtnPhoneMemory_Click);
            // 
            // BtnVolumeHigh
            // 
            this.BtnVolumeHigh.Location = new System.Drawing.Point(318, 118);
            this.BtnVolumeHigh.Name = "BtnVolumeHigh";
            this.BtnVolumeHigh.Size = new System.Drawing.Size(61, 58);
            this.BtnVolumeHigh.TabIndex = 74;
            this.BtnVolumeHigh.Click += new System.EventHandler(this.BtnVolumeHigh_Click);
            // 
            // BtnVolumeLow
            // 
            this.BtnVolumeLow.Location = new System.Drawing.Point(165, 118);
            this.BtnVolumeLow.Name = "BtnVolumeLow";
            this.BtnVolumeLow.Size = new System.Drawing.Size(61, 58);
            this.BtnVolumeLow.TabIndex = 73;
            this.BtnVolumeLow.Click += new System.EventHandler(this.BtnVolumeLow_Click);
            // 
            // BtnAutoAnswer
            // 
            this.BtnAutoAnswer.Location = new System.Drawing.Point(279, 410);
            this.BtnAutoAnswer.Name = "BtnAutoAnswer";
            this.BtnAutoAnswer.Size = new System.Drawing.Size(100, 40);
            this.BtnAutoAnswer.TabIndex = 63;
            this.BtnAutoAnswer.Click += new System.EventHandler(this.BtnAutoAnswer_Click);
            // 
            // BtnAutoConnect
            // 
            this.BtnAutoConnect.Location = new System.Drawing.Point(279, 344);
            this.BtnAutoConnect.Name = "BtnAutoConnect";
            this.BtnAutoConnect.Size = new System.Drawing.Size(100, 40);
            this.BtnAutoConnect.TabIndex = 62;
            this.BtnAutoConnect.Click += new System.EventHandler(this.BtnAutoConnect_Click);
            // 
            // BtnFindPhone
            // 
            this.BtnFindPhone.Location = new System.Drawing.Point(279, 278);
            this.BtnFindPhone.Name = "BtnFindPhone";
            this.BtnFindPhone.Size = new System.Drawing.Size(100, 40);
            this.BtnFindPhone.TabIndex = 61;
            this.BtnFindPhone.Click += new System.EventHandler(this.BtnFindPhone_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 48;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 100;
            this.button1.Text = "Спаривание";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 101;
            this.button2.Text = "Удалить";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 102;
            this.button3.Text = "Отключить";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_PhoneSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPhoneMemory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxPhoneMemory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Img_VolumeDial);
            this.Controls.Add(this.BtnVolumeHigh);
            this.Controls.Add(this.BtnVolumeLow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAutoAnswer);
            this.Controls.Add(this.BtnAutoConnect);
            this.Controls.Add(this.BtnFindPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxAutoAnswer);
            this.Controls.Add(this.pictureBoxAutoConnect);
            this.Controls.Add(this.pictureBoxFindPhone);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxImgSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PhoneSettings";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_PhoneSettings_Load);
            this.Click += new System.EventHandler(this.Form_PhoneSettings_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PhoneSettings_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton Button_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxImgSetting;
        private System.Windows.Forms.PictureBox pictureBoxFindPhone;
        private System.Windows.Forms.PictureBox pictureBoxAutoConnect;
        private System.Windows.Forms.PictureBox pictureBoxAutoAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ImageButton BtnFindPhone;
        private TriggerButton BtnAutoConnect;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBox1;
        private TriggerButton BtnAutoAnswer;
        private ImageButton BtnVolumeHigh;
        private ImageButton BtnVolumeLow;
        private System.Windows.Forms.PictureBox Img_VolumeDial;
        private System.Windows.Forms.Label label6;
        private ImageButton BtnPhoneMemory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxPhoneMemory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}