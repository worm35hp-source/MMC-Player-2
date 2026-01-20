namespace MMC_Player_2
{
    partial class Form_AudioSettings
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTembr = new System.Windows.Forms.PictureBox();
            this.pictureBoxToncompensation = new System.Windows.Forms.PictureBox();
            this.pictureBoxImgSetting = new System.Windows.Forms.PictureBox();
            this.BtnBassQ = new MMC_Player_2.ImageButton();
            this.BtnMiddleQ = new MMC_Player_2.ImageButton();
            this.BtnBassCFre = new MMC_Player_2.ImageButton();
            this.BtnMiddleCFre = new MMC_Player_2.ImageButton();
            this.BtnTrebleCFre = new MMC_Player_2.ImageButton();
            this.Button_Balance = new MMC_Player_2.ImageButton();
            this.BtnLoud = new MMC_Player_2.TriggerButton();
            this.BtnTembr2 = new MMC_Player_2.TriggerButton();
            this.BtnTembr3 = new MMC_Player_2.TriggerButton();
            this.BtnTembr4 = new MMC_Player_2.TriggerButton();
            this.BtnTembr5 = new MMC_Player_2.TriggerButton();
            this.BtnTembr6 = new MMC_Player_2.TriggerButton();
            this.BtnTembr1 = new MMC_Player_2.TriggerButton();
            this.BtnMiddleUp = new MMC_Player_2.ImageButton();
            this.BtnTrebleUp = new MMC_Player_2.ImageButton();
            this.BtnBassDown = new MMC_Player_2.ImageButton();
            this.BtnMiddleDown = new MMC_Player_2.ImageButton();
            this.BtnTrebleDown = new MMC_Player_2.ImageButton();
            this.BtnBassUp = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            this.trackBarAudioSettings3 = new MMC_Player_2.TrackBarAudioSettings();
            this.trackBarAudioSettings2 = new MMC_Player_2.TrackBarAudioSettings();
            this.trackBarAudioSettings1 = new MMC_Player_2.TrackBarAudioSettings();
            this.BtnLoudTone = new MMC_Player_2.ImageButton();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(443, 104);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 24);
            label5.Text = "ВЧ";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(361, 104);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 24);
            label4.Text = "СЧ";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(281, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 24);
            label3.Text = "НЧ";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(103, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 54);
            label1.Text = "Настройка звука";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 35);
            this.label2.Text = "Тонкомпенсация";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // pictureBoxTembr
            // 
            this.pictureBoxTembr.Location = new System.Drawing.Point(250, 115);
            this.pictureBoxTembr.Name = "pictureBoxTembr";
            this.pictureBoxTembr.Size = new System.Drawing.Size(250, 345);
            this.pictureBoxTembr.Click += new System.EventHandler(this.pictureBoxTembr_Click);
            // 
            // pictureBoxToncompensation
            // 
            this.pictureBoxToncompensation.Location = new System.Drawing.Point(250, 20);
            this.pictureBoxToncompensation.Name = "pictureBoxToncompensation";
            this.pictureBoxToncompensation.Size = new System.Drawing.Size(530, 65);
            this.pictureBoxToncompensation.Click += new System.EventHandler(this.pictureBoxToncompensation_Click);
            // 
            // pictureBoxImgSetting
            // 
            this.pictureBoxImgSetting.Location = new System.Drawing.Point(20, 17);
            this.pictureBoxImgSetting.Name = "pictureBoxImgSetting";
            this.pictureBoxImgSetting.Size = new System.Drawing.Size(39, 50);
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(505, 105);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 50);
            label6.Text = "Частотные полосы ВЧ";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(505, 175);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 50);
            label7.Text = "Частотные полосы СЧ";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(505, 245);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(120, 50);
            label8.Text = "Частотные полосы НЧ";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(505, 385);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(120, 50);
            label9.Text = "Ширина захвата НЧ";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(505, 315);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(120, 50);
            label10.Text = "Ширина захвата СЧ";
            label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnBassQ
            // 
            this.BtnBassQ.Location = new System.Drawing.Point(650, 395);
            this.BtnBassQ.Name = "BtnBassQ";
            this.BtnBassQ.Size = new System.Drawing.Size(100, 40);
            this.BtnBassQ.TabIndex = 118;
            this.BtnBassQ.Click += new System.EventHandler(this.BtnBassQ_Click);
            // 
            // BtnMiddleQ
            // 
            this.BtnMiddleQ.Location = new System.Drawing.Point(650, 325);
            this.BtnMiddleQ.Name = "BtnMiddleQ";
            this.BtnMiddleQ.Size = new System.Drawing.Size(100, 40);
            this.BtnMiddleQ.TabIndex = 117;
            this.BtnMiddleQ.Click += new System.EventHandler(this.BtnMiddleQ_Click);
            // 
            // BtnBassCFre
            // 
            this.BtnBassCFre.Location = new System.Drawing.Point(650, 255);
            this.BtnBassCFre.Name = "BtnBassCFre";
            this.BtnBassCFre.Size = new System.Drawing.Size(100, 40);
            this.BtnBassCFre.TabIndex = 112;
            this.BtnBassCFre.Click += new System.EventHandler(this.BtnBassCFre_Click);
            // 
            // BtnMiddleCFre
            // 
            this.BtnMiddleCFre.Location = new System.Drawing.Point(650, 185);
            this.BtnMiddleCFre.Name = "BtnMiddleCFre";
            this.BtnMiddleCFre.Size = new System.Drawing.Size(100, 40);
            this.BtnMiddleCFre.TabIndex = 111;
            this.BtnMiddleCFre.Click += new System.EventHandler(this.BtnMiddleCFre_Click);
            // 
            // BtnTrebleCFre
            // 
            this.BtnTrebleCFre.Location = new System.Drawing.Point(650, 115);
            this.BtnTrebleCFre.Name = "BtnTrebleCFre";
            this.BtnTrebleCFre.Size = new System.Drawing.Size(100, 40);
            this.BtnTrebleCFre.TabIndex = 110;
            this.BtnTrebleCFre.Click += new System.EventHandler(this.BtnTrebleCFre_Click);
            // 
            // Button_Balance
            // 
            this.Button_Balance.Location = new System.Drawing.Point(130, 98);
            this.Button_Balance.Name = "Button_Balance";
            this.Button_Balance.Size = new System.Drawing.Size(100, 65);
            this.Button_Balance.TabIndex = 92;
            this.Button_Balance.Click += new System.EventHandler(this.Button_Balance_Click);
            // 
            // BtnLoud
            // 
            this.BtnLoud.Location = new System.Drawing.Point(650, 32);
            this.BtnLoud.Name = "BtnLoud";
            this.BtnLoud.Size = new System.Drawing.Size(100, 40);
            this.BtnLoud.TabIndex = 72;
            this.BtnLoud.Click += new System.EventHandler(this.BtnLoud_Click);
            // 
            // BtnTembr2
            // 
            this.BtnTembr2.Location = new System.Drawing.Point(130, 245);
            this.BtnTembr2.Name = "BtnTembr2";
            this.BtnTembr2.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr2.TabIndex = 62;
            this.BtnTembr2.Click += new System.EventHandler(this.BtnTembr2_Click);
            // 
            // BtnTembr3
            // 
            this.BtnTembr3.Location = new System.Drawing.Point(20, 320);
            this.BtnTembr3.Name = "BtnTembr3";
            this.BtnTembr3.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr3.TabIndex = 61;
            this.BtnTembr3.Click += new System.EventHandler(this.BtnTembr3_Click);
            // 
            // BtnTembr4
            // 
            this.BtnTembr4.Location = new System.Drawing.Point(130, 320);
            this.BtnTembr4.Name = "BtnTembr4";
            this.BtnTembr4.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr4.TabIndex = 60;
            this.BtnTembr4.Click += new System.EventHandler(this.BtnTembr4_Click);
            // 
            // BtnTembr5
            // 
            this.BtnTembr5.Location = new System.Drawing.Point(20, 395);
            this.BtnTembr5.Name = "BtnTembr5";
            this.BtnTembr5.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr5.TabIndex = 59;
            this.BtnTembr5.Click += new System.EventHandler(this.BtnTembr5_Click);
            // 
            // BtnTembr6
            // 
            this.BtnTembr6.Location = new System.Drawing.Point(130, 395);
            this.BtnTembr6.Name = "BtnTembr6";
            this.BtnTembr6.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr6.TabIndex = 58;
            this.BtnTembr6.Click += new System.EventHandler(this.BtnTembr6_Click);
            // 
            // BtnTembr1
            // 
            this.BtnTembr1.Location = new System.Drawing.Point(20, 245);
            this.BtnTembr1.Name = "BtnTembr1";
            this.BtnTembr1.Size = new System.Drawing.Size(100, 65);
            this.BtnTembr1.TabIndex = 57;
            this.BtnTembr1.Click += new System.EventHandler(this.BtnTembr1_Click);
            // 
            // BtnMiddleUp
            // 
            this.BtnMiddleUp.Location = new System.Drawing.Point(344, 131);
            this.BtnMiddleUp.Name = "BtnMiddleUp";
            this.BtnMiddleUp.Size = new System.Drawing.Size(61, 58);
            this.BtnMiddleUp.TabIndex = 56;
            this.BtnMiddleUp.Click += new System.EventHandler(this.BtnMiddleUp_Click);
            // 
            // BtnTrebleUp
            // 
            this.BtnTrebleUp.Location = new System.Drawing.Point(423, 131);
            this.BtnTrebleUp.Name = "BtnTrebleUp";
            this.BtnTrebleUp.Size = new System.Drawing.Size(61, 58);
            this.BtnTrebleUp.TabIndex = 55;
            this.BtnTrebleUp.Click += new System.EventHandler(this.BtnTrebleUp_Click);
            // 
            // BtnBassDown
            // 
            this.BtnBassDown.Location = new System.Drawing.Point(265, 400);
            this.BtnBassDown.Name = "BtnBassDown";
            this.BtnBassDown.Size = new System.Drawing.Size(61, 58);
            this.BtnBassDown.TabIndex = 54;
            this.BtnBassDown.Click += new System.EventHandler(this.BtnBassDown_Click);
            // 
            // BtnMiddleDown
            // 
            this.BtnMiddleDown.Location = new System.Drawing.Point(344, 400);
            this.BtnMiddleDown.Name = "BtnMiddleDown";
            this.BtnMiddleDown.Size = new System.Drawing.Size(61, 58);
            this.BtnMiddleDown.TabIndex = 53;
            this.BtnMiddleDown.Click += new System.EventHandler(this.BtnMiddleDown_Click);
            // 
            // BtnTrebleDown
            // 
            this.BtnTrebleDown.Location = new System.Drawing.Point(423, 400);
            this.BtnTrebleDown.Name = "BtnTrebleDown";
            this.BtnTrebleDown.Size = new System.Drawing.Size(61, 58);
            this.BtnTrebleDown.TabIndex = 52;
            this.BtnTrebleDown.Click += new System.EventHandler(this.BtnTrebleDown_Click);
            // 
            // BtnBassUp
            // 
            this.BtnBassUp.Location = new System.Drawing.Point(265, 131);
            this.BtnBassUp.Name = "BtnBassUp";
            this.BtnBassUp.Size = new System.Drawing.Size(61, 58);
            this.BtnBassUp.TabIndex = 51;
            this.BtnBassUp.Click += new System.EventHandler(this.BtnBassUp_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 49;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // trackBarAudioSettings3
            // 
            this.trackBarAudioSettings3.Location = new System.Drawing.Point(429, 195);
            this.trackBarAudioSettings3.Name = "trackBarAudioSettings3";
            this.trackBarAudioSettings3.Size = new System.Drawing.Size(49, 200);
            this.trackBarAudioSettings3.TabIndex = 48;
            this.trackBarAudioSettings3.Click += new System.EventHandler(this.trackBarAudioSettings3_Click);
            // 
            // trackBarAudioSettings2
            // 
            this.trackBarAudioSettings2.Location = new System.Drawing.Point(350, 195);
            this.trackBarAudioSettings2.Name = "trackBarAudioSettings2";
            this.trackBarAudioSettings2.Size = new System.Drawing.Size(49, 200);
            this.trackBarAudioSettings2.TabIndex = 47;
            this.trackBarAudioSettings2.Click += new System.EventHandler(this.trackBarAudioSettings2_Click);
            // 
            // trackBarAudioSettings1
            // 
            this.trackBarAudioSettings1.Location = new System.Drawing.Point(271, 195);
            this.trackBarAudioSettings1.Name = "trackBarAudioSettings1";
            this.trackBarAudioSettings1.Size = new System.Drawing.Size(49, 200);
            this.trackBarAudioSettings1.TabIndex = 46;
            this.trackBarAudioSettings1.Click += new System.EventHandler(this.trackBarAudioSettings1_Click);
            // 
            // BtnLoudTone
            // 
            this.BtnLoudTone.Location = new System.Drawing.Point(519, 32);
            this.BtnLoudTone.Name = "BtnLoudTone";
            this.BtnLoudTone.Size = new System.Drawing.Size(100, 40);
            this.BtnLoudTone.TabIndex = 119;
            this.BtnLoudTone.Click += new System.EventHandler(this.BtnLoudTone_Click);
            // 
            // Form_AudioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLoudTone);
            this.Controls.Add(this.BtnBassQ);
            this.Controls.Add(this.BtnMiddleQ);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(this.BtnBassCFre);
            this.Controls.Add(this.BtnMiddleCFre);
            this.Controls.Add(this.BtnTrebleCFre);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.Button_Balance);
            this.Controls.Add(this.BtnLoud);
            this.Controls.Add(this.BtnTembr2);
            this.Controls.Add(this.BtnTembr3);
            this.Controls.Add(this.BtnTembr4);
            this.Controls.Add(this.BtnTembr5);
            this.Controls.Add(this.BtnTembr6);
            this.Controls.Add(this.BtnTembr1);
            this.Controls.Add(this.BtnMiddleUp);
            this.Controls.Add(this.BtnTrebleUp);
            this.Controls.Add(this.BtnBassDown);
            this.Controls.Add(this.BtnMiddleDown);
            this.Controls.Add(this.BtnTrebleDown);
            this.Controls.Add(this.BtnBassUp);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.trackBarAudioSettings3);
            this.Controls.Add(this.trackBarAudioSettings2);
            this.Controls.Add(this.trackBarAudioSettings1);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxTembr);
            this.Controls.Add(this.pictureBoxToncompensation);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBoxImgSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AudioSettings";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_AudioSettings_Load);
            this.Click += new System.EventHandler(this.Form_AudioSettings_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_AudioSettings_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxTembr;
        private System.Windows.Forms.PictureBox pictureBoxToncompensation;
        private System.Windows.Forms.PictureBox pictureBoxImgSetting;
        private TrackBarAudioSettings trackBarAudioSettings1;
        private TrackBarAudioSettings trackBarAudioSettings2;
        private TrackBarAudioSettings trackBarAudioSettings3;
        private ImageButton Button_Back;
        private ImageButton BtnBassUp;
        private ImageButton BtnTrebleDown;
        private ImageButton BtnMiddleDown;
        private ImageButton BtnBassDown;
        private ImageButton BtnTrebleUp;
        private ImageButton BtnMiddleUp;
        private TriggerButton BtnTembr1;
        private TriggerButton BtnTembr6;
        private TriggerButton BtnTembr5;
        private TriggerButton BtnTembr4;
        private TriggerButton BtnTembr3;
        private TriggerButton BtnTembr2;
        private TriggerButton BtnLoud;
        private ImageButton Button_Balance;
        private ImageButton BtnTrebleCFre;
        private ImageButton BtnMiddleCFre;
        private ImageButton BtnBassCFre;
        private ImageButton BtnBassQ;
        private ImageButton BtnMiddleQ;
        private ImageButton BtnLoudTone;

    }
}