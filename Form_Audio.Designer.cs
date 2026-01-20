namespace MMC_Player_2
{
    partial class Form_Audio
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Audio));
            this.pictureBoxMute = new System.Windows.Forms.PictureBox();
            this.ImgAudioBackground = new System.Windows.Forms.PictureBox();
            this.Img_TagAudio = new System.Windows.Forms.PictureBox();
            this.Img_Audio = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.timerSDUSB_ins_Del = new System.Windows.Forms.Timer();
            this.trackBarAudio1 = new MMC_Player_2.TrackBarAudio();
            this.label_LevelFuel = new MMC_Player_2.Label_();
            this.label_temp_coolingwater = new MMC_Player_2.Label_();
            this.BtnUSBCard = new MMC_Player_2.TriggerButton_4state();
            this.BtnSDCard = new MMC_Player_2.TriggerButton_4state();
            this.Button_Repeat = new MMC_Player_2.TriggerButton();
            this.Button_Random = new MMC_Player_2.TriggerButton();
            this.label_Date = new MMC_Player_2.Label_();
            this.label_Time = new MMC_Player_2.Label_();
            this.Button_Play = new MMC_Player_2.ImageButton();
            this.BtnSelectDOWN = new MMC_Player_2.ImageButton();
            this.BtnSelectUP = new MMC_Player_2.ImageButton();
            this.Button_BackFolder = new MMC_Player_2.ImageButton();
            this.Button_Home = new MMC_Player_2.ImageButton();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattCharge = new System.Windows.Forms.PictureBox();
            this.label_tempAKPP = new MMC_Player_2.Label_();
            label_Audio = new System.Windows.Forms.Label();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label_Audio
            // 
            label_Audio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label_Audio.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label_Audio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label_Audio.Location = new System.Drawing.Point(53, 22);
            label_Audio.Name = "label_Audio";
            label_Audio.Size = new System.Drawing.Size(67, 28);
            label_Audio.Text = "Аудио";
            label_Audio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ColumnHeader";
            columnHeader1.Width = 380;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            pictureBox1.Location = new System.Drawing.Point(524, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 353);
            // 
            // pictureBoxMute
            // 
            this.pictureBoxMute.Location = new System.Drawing.Point(20, 430);
            this.pictureBoxMute.Name = "pictureBoxMute";
            this.pictureBoxMute.Size = new System.Drawing.Size(26, 35);
            this.pictureBoxMute.Visible = false;
            // 
            // ImgAudioBackground
            // 
            this.ImgAudioBackground.Location = new System.Drawing.Point(125, 14);
            this.ImgAudioBackground.Name = "ImgAudioBackground";
            this.ImgAudioBackground.Size = new System.Drawing.Size(430, 375);
            // 
            // Img_TagAudio
            // 
            this.Img_TagAudio.Location = new System.Drawing.Point(625, 7);
            this.Img_TagAudio.Name = "Img_TagAudio";
            this.Img_TagAudio.Size = new System.Drawing.Size(160, 150);
            this.Img_TagAudio.Click += new System.EventHandler(this.Img_TagAudio_Click);
            // 
            // Img_Audio
            // 
            this.Img_Audio.Location = new System.Drawing.Point(20, 9);
            this.Img_Audio.Name = "Img_Audio";
            this.Img_Audio.Size = new System.Drawing.Size(27, 50);
            // 
            // pictureBoxRedLine
            // 
            this.pictureBoxRedLine.Location = new System.Drawing.Point(0, 410);
            this.pictureBoxRedLine.Name = "pictureBoxRedLine";
            this.pictureBoxRedLine.Size = new System.Drawing.Size(800, 4);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listView1.Columns.Add(columnHeader1);
            this.listView1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(135, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 355);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 100;
            this.listView1.TabStop = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            // 
            // timerSDUSB_ins_Del
            // 
            this.timerSDUSB_ins_Del.Enabled = true;
            this.timerSDUSB_ins_Del.Interval = 1000;
            this.timerSDUSB_ins_Del.Tick += new System.EventHandler(this.timerSDUSB_ins_Del_Tick);
            // 
            // trackBarAudio1
            // 
            this.trackBarAudio1.Location = new System.Drawing.Point(557, 78);
            this.trackBarAudio1.Name = "trackBarAudio1";
            this.trackBarAudio1.Size = new System.Drawing.Size(61, 247);
            this.trackBarAudio1.TabIndex = 220;
            // 
            // label_LevelFuel
            // 
            this.label_LevelFuel.BackColor = System.Drawing.Color.Black;
            this.label_LevelFuel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.label_LevelFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_LevelFuel.Location = new System.Drawing.Point(145, 430);
            this.label_LevelFuel.Name = "label_LevelFuel";
            this.label_LevelFuel.Size = new System.Drawing.Size(60, 35);
            this.label_LevelFuel.TabIndex = 212;
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
            this.label_temp_coolingwater.TabIndex = 204;
            this.label_temp_coolingwater.TabStop = false;
            // 
            // BtnUSBCard
            // 
            this.BtnUSBCard.Location = new System.Drawing.Point(20, 331);
            this.BtnUSBCard.Name = "BtnUSBCard";
            this.BtnUSBCard.Size = new System.Drawing.Size(100, 65);
            this.BtnUSBCard.TabIndex = 196;
            this.BtnUSBCard.Click += new System.EventHandler(this.BtnUSBCard_Click);
            // 
            // BtnSDCard
            // 
            this.BtnSDCard.Location = new System.Drawing.Point(20, 254);
            this.BtnSDCard.Name = "BtnSDCard";
            this.BtnSDCard.Size = new System.Drawing.Size(100, 65);
            this.BtnSDCard.TabIndex = 195;
            this.BtnSDCard.Click += new System.EventHandler(this.BtnSDCard_Click);
            // 
            // Button_Repeat
            // 
            this.Button_Repeat.Location = new System.Drawing.Point(625, 254);
            this.Button_Repeat.Name = "Button_Repeat";
            this.Button_Repeat.Size = new System.Drawing.Size(160, 65);
            this.Button_Repeat.TabIndex = 179;
            this.Button_Repeat.Click += new System.EventHandler(this.Button_Repeat_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Location = new System.Drawing.Point(625, 176);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(160, 65);
            this.Button_Random.TabIndex = 178;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // label_Date
            // 
            this.label_Date.Align = System.Drawing.ContentAlignment.TopCenter;
            this.label_Date.BackColor = System.Drawing.Color.Black;
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(250, 453);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(300, 26);
            this.label_Date.TabIndex = 170;
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
            this.label_Time.TabIndex = 169;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // Button_Play
            // 
            this.Button_Play.Location = new System.Drawing.Point(625, 332);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(160, 65);
            this.Button_Play.TabIndex = 51;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // BtnSelectDOWN
            // 
            this.BtnSelectDOWN.Location = new System.Drawing.Point(557, 331);
            this.BtnSelectDOWN.Name = "BtnSelectDOWN";
            this.BtnSelectDOWN.Size = new System.Drawing.Size(61, 58);
            this.BtnSelectDOWN.TabIndex = 48;
            this.BtnSelectDOWN.Click += new System.EventHandler(this.BtnSelectDOWN_Click);
            // 
            // BtnSelectUP
            // 
            this.BtnSelectUP.Location = new System.Drawing.Point(557, 14);
            this.BtnSelectUP.Name = "BtnSelectUP";
            this.BtnSelectUP.Size = new System.Drawing.Size(61, 58);
            this.BtnSelectUP.TabIndex = 47;
            this.BtnSelectUP.Click += new System.EventHandler(this.BtnSelectUP_Click);
            // 
            // Button_BackFolder
            // 
            this.Button_BackFolder.Location = new System.Drawing.Point(20, 176);
            this.Button_BackFolder.Name = "Button_BackFolder";
            this.Button_BackFolder.Size = new System.Drawing.Size(100, 65);
            this.Button_BackFolder.TabIndex = 44;
            this.Button_BackFolder.Click += new System.EventHandler(this.Button_BackFolder_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.Location = new System.Drawing.Point(20, 98);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(100, 65);
            this.Button_Home.TabIndex = 43;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
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
            this.label_tempAKPP.TabIndex = 228;
            this.label_tempAKPP.TabStop = false;
            this.label_tempAKPP.Click += new System.EventHandler(this.label_tempAKPP_Click);
            // 
            // Form_Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label_tempAKPP);
            this.Controls.Add(this.pictureBoxBattCharge);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.trackBarAudio1);
            this.Controls.Add(this.label_LevelFuel);
            this.Controls.Add(this.label_temp_coolingwater);
            this.Controls.Add(this.BtnUSBCard);
            this.Controls.Add(this.BtnSDCard);
            this.Controls.Add(this.Button_Repeat);
            this.Controls.Add(this.Button_Random);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Button_Play);
            this.Controls.Add(this.BtnSelectDOWN);
            this.Controls.Add(this.BtnSelectUP);
            this.Controls.Add(this.Button_BackFolder);
            this.Controls.Add(this.Button_Home);
            this.Controls.Add(this.pictureBoxMute);
            this.Controls.Add(this.ImgAudioBackground);
            this.Controls.Add(this.Img_TagAudio);
            this.Controls.Add(label_Audio);
            this.Controls.Add(this.Img_Audio);
            this.Controls.Add(this.pictureBoxRedLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Audio";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Audio_Load);
            this.Click += new System.EventHandler(this.Form_Audio_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgAudioBackground;
        private System.Windows.Forms.PictureBox Img_TagAudio;
        private System.Windows.Forms.PictureBox Img_Audio;
        private System.Windows.Forms.PictureBox pictureBoxRedLine;
        private ImageButton Button_Home;
        private ImageButton Button_BackFolder;
        private ImageButton BtnSelectUP;
        private ImageButton BtnSelectDOWN;
        private System.Windows.Forms.ImageList imageList1;
        public ImageButton Button_Play;
        private TriggerButton Button_Random;
        private TriggerButton Button_Repeat;
        public System.Windows.Forms.ListView listView1;
        private TriggerButton_4state BtnSDCard;
        private TriggerButton_4state BtnUSBCard;
        public Label_ label_temp_coolingwater;
        public Label_ label_LevelFuel;
        private TrackBarAudio trackBarAudio1;
        private System.Windows.Forms.Timer timerSDUSB_ins_Del;
        public System.Windows.Forms.PictureBox pictureBoxMute;
        public System.Windows.Forms.PictureBox pictureBoxPhone;
        public Label_ label_Date;
        public Label_ label_Time;
        public System.Windows.Forms.PictureBox pictureBoxBattCharge;
        public Label_ label_tempAKPP;
    }
}