namespace MMC_Player_2
{
    partial class Form_Phone
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
            System.Windows.Forms.Label label_Audio;
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.Img_Phone = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoneNumber = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.BtnHandsFree = new MMC_Player_2.TriggerButton_4state();
            this.BtnPlayMusic = new MMC_Player_2.TriggerButton_4state();
            this.BtnDelSymbol = new MMC_Player_2.ImageButton();
            this.BtnRedial = new MMC_Player_2.ImageButton();
            this.BtnPhoneBook = new MMC_Player_2.ImageButton();
            this.BtnPhoneSettings = new MMC_Player_2.ImageButton();
            this.BtnReshetka = new MMC_Player_2.ImageButton();
            this.Btn2 = new MMC_Player_2.ImageButton();
            this.Btn3 = new MMC_Player_2.ImageButton();
            this.Btn4 = new MMC_Player_2.ImageButton();
            this.Btn8 = new MMC_Player_2.ImageButton();
            this.Btn7 = new MMC_Player_2.ImageButton();
            this.Btn9 = new MMC_Player_2.ImageButton();
            this.BtnPlus = new MMC_Player_2.ImageButton();
            this.Btn0 = new MMC_Player_2.ImageButton();
            this.Btn6 = new MMC_Player_2.ImageButton();
            this.Btn5 = new MMC_Player_2.ImageButton();
            this.Btn1 = new MMC_Player_2.ImageButton();
            this.BtnDial = new MMC_Player_2.ImageButton();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.Button_Home = new MMC_Player_2.ImageButton();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            this.timer1 = new System.Windows.Forms.Timer();
            label_Audio = new System.Windows.Forms.Label();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_Audio
            // 
            label_Audio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label_Audio.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label_Audio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label_Audio.Location = new System.Drawing.Point(53, 43);
            label_Audio.Name = "label_Audio";
            label_Audio.Size = new System.Drawing.Size(86, 28);
            label_Audio.Text = "Телефон";
            label_Audio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ColumnHeader";
            columnHeader1.Width = 380;
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            this.pictureBoxMute.Click += new System.EventHandler(this.pictureBoxMute_Click);
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // Img_Phone
            // 
            this.Img_Phone.Location = new System.Drawing.Point(20, 30);
            this.Img_Phone.Name = "Img_Phone";
            this.Img_Phone.Size = new System.Drawing.Size(28, 50);
            // 
            // pictureBoxPhoneNumber
            // 
            this.pictureBoxPhoneNumber.Location = new System.Drawing.Point(240, 15);
            this.pictureBoxPhoneNumber.Name = "pictureBoxPhoneNumber";
            this.pictureBoxPhoneNumber.Size = new System.Drawing.Size(540, 75);
            this.pictureBoxPhoneNumber.Click += new System.EventHandler(this.pictureBoxPhoneNumber_Click);
            this.pictureBoxPhoneNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPhoneNumber_Paint);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Location = new System.Drawing.Point(753, 426);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxPhone.Visible = false;
            this.pictureBoxPhone.Click += new System.EventHandler(this.pictureBoxPhone_Click);
            // 
            // pictureBoxBattCharge
            // 
            this.pictureBoxBattCharge.Location = new System.Drawing.Point(720, 426);
            this.pictureBoxBattCharge.Name = "pictureBoxBattCharge";
            this.pictureBoxBattCharge.Size = new System.Drawing.Size(27, 42);
            this.pictureBoxBattCharge.Visible = false;
            // 
            // BtnHandsFree
            // 
            this.BtnHandsFree.Location = new System.Drawing.Point(20, 248);
            this.BtnHandsFree.Name = "BtnHandsFree";
            this.BtnHandsFree.Size = new System.Drawing.Size(160, 65);
            this.BtnHandsFree.TabIndex = 255;
            this.BtnHandsFree.Click += new System.EventHandler(this.BtnHandsFree_Click);
            // 
            // BtnPlayMusic
            // 
            this.BtnPlayMusic.Location = new System.Drawing.Point(20, 173);
            this.BtnPlayMusic.Name = "BtnPlayMusic";
            this.BtnPlayMusic.Size = new System.Drawing.Size(160, 65);
            this.BtnPlayMusic.TabIndex = 254;
            this.BtnPlayMusic.Click += new System.EventHandler(this.BtnPlayMusic_Click);
            // 
            // BtnDelSymbol
            // 
            this.BtnDelSymbol.Active = false;
            this.BtnDelSymbol.Location = new System.Drawing.Point(620, 98);
            this.BtnDelSymbol.Name = "BtnDelSymbol";
            this.BtnDelSymbol.Size = new System.Drawing.Size(160, 65);
            this.BtnDelSymbol.TabIndex = 248;
            this.BtnDelSymbol.Click += new System.EventHandler(this.BtnDelSymbol_Click);
            // 
            // BtnRedial
            // 
            this.BtnRedial.Active = false;
            this.BtnRedial.Location = new System.Drawing.Point(620, 173);
            this.BtnRedial.Name = "BtnRedial";
            this.BtnRedial.Size = new System.Drawing.Size(160, 65);
            this.BtnRedial.TabIndex = 247;
            this.BtnRedial.Click += new System.EventHandler(this.BtnRedial_Click);
            // 
            // BtnPhoneBook
            // 
            this.BtnPhoneBook.Active = false;
            this.BtnPhoneBook.Location = new System.Drawing.Point(620, 248);
            this.BtnPhoneBook.Name = "BtnPhoneBook";
            this.BtnPhoneBook.Size = new System.Drawing.Size(160, 65);
            this.BtnPhoneBook.TabIndex = 246;
            this.BtnPhoneBook.Click += new System.EventHandler(this.BtnPhoneBook_Click);
            // 
            // BtnPhoneSettings
            // 
            this.BtnPhoneSettings.Active = true;
            this.BtnPhoneSettings.Location = new System.Drawing.Point(620, 323);
            this.BtnPhoneSettings.Name = "BtnPhoneSettings";
            this.BtnPhoneSettings.Size = new System.Drawing.Size(160, 65);
            this.BtnPhoneSettings.TabIndex = 245;
            this.BtnPhoneSettings.Click += new System.EventHandler(this.BtnPhoneSettings_Click);
            // 
            // BtnReshetka
            // 
            this.BtnReshetka.Active = false;
            this.BtnReshetka.Location = new System.Drawing.Point(460, 323);
            this.BtnReshetka.Name = "BtnReshetka";
            this.BtnReshetka.Size = new System.Drawing.Size(100, 65);
            this.BtnReshetka.TabIndex = 244;
            this.BtnReshetka.Click += new System.EventHandler(this.BtnReshetka_Click);
            // 
            // Btn2
            // 
            this.Btn2.Active = false;
            this.Btn2.Location = new System.Drawing.Point(350, 98);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 65);
            this.Btn2.TabIndex = 243;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Active = false;
            this.Btn3.Location = new System.Drawing.Point(460, 98);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(100, 65);
            this.Btn3.TabIndex = 242;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Active = false;
            this.Btn4.Location = new System.Drawing.Point(240, 173);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(100, 65);
            this.Btn4.TabIndex = 241;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn8
            // 
            this.Btn8.Active = false;
            this.Btn8.Location = new System.Drawing.Point(350, 248);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(100, 65);
            this.Btn8.TabIndex = 240;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Active = false;
            this.Btn7.Location = new System.Drawing.Point(240, 248);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(100, 65);
            this.Btn7.TabIndex = 239;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn9
            // 
            this.Btn9.Active = false;
            this.Btn9.Location = new System.Drawing.Point(460, 248);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(100, 65);
            this.Btn9.TabIndex = 238;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Active = false;
            this.BtnPlus.Location = new System.Drawing.Point(240, 323);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(100, 65);
            this.BtnPlus.TabIndex = 237;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // Btn0
            // 
            this.Btn0.Active = false;
            this.Btn0.Location = new System.Drawing.Point(350, 323);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(100, 65);
            this.Btn0.TabIndex = 236;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn6
            // 
            this.Btn6.Active = false;
            this.Btn6.Location = new System.Drawing.Point(460, 173);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(100, 65);
            this.Btn6.TabIndex = 235;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Active = false;
            this.Btn5.Location = new System.Drawing.Point(350, 173);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(100, 65);
            this.Btn5.TabIndex = 234;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn1
            // 
            this.Btn1.Active = false;
            this.Btn1.Location = new System.Drawing.Point(240, 98);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(100, 65);
            this.Btn1.TabIndex = 233;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnDial
            // 
            this.BtnDial.Active = false;
            this.BtnDial.Location = new System.Drawing.Point(20, 323);
            this.BtnDial.Name = "BtnDial";
            this.BtnDial.Size = new System.Drawing.Size(160, 65);
            this.BtnDial.TabIndex = 231;
            this.BtnDial.Click += new System.EventHandler(this.BtnDial_Click);
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 224;
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
            this.label_temp_coolingwater.TabIndex = 223;
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
            this.label_Date.TabIndex = 220;
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
            this.label_Time.TabIndex = 219;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.Location = new System.Drawing.Point(20, 98);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(100, 65);
            this.Button_Home.TabIndex = 217;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // label_tempAKPP
            // 
            this.label_tempAKPP.BackColor = System.Drawing.Color.Black;
            this.label_tempAKPP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_tempAKPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_tempAKPP.Location = new System.Drawing.Point(610, 430);
            this.label_tempAKPP.Name = "label_tempAKPP";
            this.label_tempAKPP.Size = new System.Drawing.Size(87, 35);
            this.label_tempAKPP.TabIndex = 262;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label_tempAKPP);
            this.Controls.Add(this.pictureBoxBattCharge);
            this.Controls.Add(this.BtnHandsFree);
            this.Controls.Add(this.BtnPlayMusic);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.BtnDelSymbol);
            this.Controls.Add(this.BtnRedial);
            this.Controls.Add(this.BtnPhoneBook);
            this.Controls.Add(this.BtnPhoneSettings);
            this.Controls.Add(this.BtnReshetka);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.pictureBoxPhoneNumber);
            this.Controls.Add(this.BtnDial);
            this.Controls.Add(this.label_LevelFuel);
            this.Controls.Add(this.label_temp_coolingwater);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.Button_Home);
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(label_Audio);
            this.Controls.Add(this.pictureBoxRedLine);
            this.Controls.Add(this.Img_Phone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Phone";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Phone_Load);
            this.Click += new System.EventHandler(this.Form_Phone_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Phone_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        public Label_ label_LevelFuel;
        public Label_ label_temp_coolingwater;
        private ImageButton Button_Home;
        public System.Windows.Forms.PictureBox pictureBoxMute;
        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        private System.Windows.Forms.PictureBox Img_Phone;
        private System.Windows.Forms.PictureBox pictureBoxPhoneNumber;
        private ImageButton BtnPhoneSettings;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public TriggerButton_4state BtnHandsFree;
        public ImageButton BtnDial;
        public ImageButton Btn1;
        public ImageButton Btn5;
        public ImageButton Btn6;
        public ImageButton Btn0;
        public ImageButton BtnPlus;
        public ImageButton Btn9;
        public ImageButton Btn7;
        public ImageButton Btn8;
        public ImageButton Btn4;
        public ImageButton Btn3;
        public ImageButton Btn2;
        public ImageButton BtnReshetka;
        public ImageButton BtnPhoneBook;
        public ImageButton BtnRedial;
        public ImageButton BtnDelSymbol;
        public TriggerButton_4state BtnPlayMusic;
        public Label_ label_Date;
        public Label_ label_Time;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
        private System.Windows.Forms.Timer timer1;
    }
}