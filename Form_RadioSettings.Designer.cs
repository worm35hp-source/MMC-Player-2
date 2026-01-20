namespace MMC_Player_2
{
    partial class Form_RadioSettings
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
            this.pictureBoxImgSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxRadioSet = new System.Windows.Forms.PictureBox();
            this.pictureBoxChannelSet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_AF = new MMC_Player_2.TriggerButton_4state();
            this.Btn_TP = new MMC_Player_2.TriggerButton_4state();
            this.Btn_TA = new MMC_Player_2.TriggerButton_4state();
            this.Btn_TimeRDS = new MMC_Player_2.TriggerButton_4state();
            this.Btn_RDS = new MMC_Player_2.TriggerButton();
            this.Btn_Local_DX = new MMC_Player_2.TriggerButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
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
            label_Radio.Location = new System.Drawing.Point(73, 27);
            label_Radio.Name = "label_Radio";
            label_Radio.Size = new System.Drawing.Size(109, 52);
            label_Radio.Text = "Настройка радио";
            label_Radio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxImgSetting
            // 
            this.pictureBoxImgSetting.Location = new System.Drawing.Point(20, 15);
            this.pictureBoxImgSetting.Name = "pictureBoxImgSetting";
            this.pictureBoxImgSetting.Size = new System.Drawing.Size(47, 64);
            // 
            // pictureBoxRadioSet
            // 
            this.pictureBoxRadioSet.Location = new System.Drawing.Point(20, 170);
            this.pictureBoxRadioSet.Name = "pictureBoxRadioSet";
            this.pictureBoxRadioSet.Size = new System.Drawing.Size(760, 290);
            this.pictureBoxRadioSet.Click += new System.EventHandler(this.pictureBoxRadioSet_Click);
            // 
            // pictureBoxChannelSet
            // 
            this.pictureBoxChannelSet.Location = new System.Drawing.Point(230, 20);
            this.pictureBoxChannelSet.Name = "pictureBoxChannelSet";
            this.pictureBoxChannelSet.Size = new System.Drawing.Size(550, 140);
            this.pictureBoxChannelSet.Click += new System.EventHandler(this.pictureBoxChannelSet_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 35);
            this.label1.Text = "Включение RDS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 35);
            this.label2.Text = "Переключение на альтернативную частоту (AF):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 35);
            this.label3.Text = "Прием информации об организации движения (TP):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(602, 35);
            this.label4.Text = "Прием дорожной информации (TA):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(602, 35);
            this.label5.Text = "Синхронизация часов по сигналам RDS:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.ParentChanged += new System.EventHandler(this.label5_ParentChanged);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(232, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 35);
            this.label6.Text = "Местные / Удаленные:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.ParentChanged += new System.EventHandler(this.label6_ParentChanged);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(234, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 35);
            this.label7.Text = "Настройка каналов";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.ParentChanged += new System.EventHandler(this.label7_ParentChanged);
            // 
            // Btn_AF
            // 
            this.Btn_AF.Location = new System.Drawing.Point(630, 245);
            this.Btn_AF.Name = "Btn_AF";
            this.Btn_AF.Size = new System.Drawing.Size(100, 40);
            this.Btn_AF.TabIndex = 81;
            this.Btn_AF.Click += new System.EventHandler(this.Btn_AF_Click);
            // 
            // Btn_TP
            // 
            this.Btn_TP.Location = new System.Drawing.Point(630, 300);
            this.Btn_TP.Name = "Btn_TP";
            this.Btn_TP.Size = new System.Drawing.Size(100, 40);
            this.Btn_TP.TabIndex = 80;
            this.Btn_TP.Click += new System.EventHandler(this.Btn_TP_Click);
            // 
            // Btn_TA
            // 
            this.Btn_TA.Location = new System.Drawing.Point(630, 355);
            this.Btn_TA.Name = "Btn_TA";
            this.Btn_TA.Size = new System.Drawing.Size(100, 40);
            this.Btn_TA.TabIndex = 79;
            this.Btn_TA.Click += new System.EventHandler(this.Btn_TA_Click);
            // 
            // Btn_TimeRDS
            // 
            this.Btn_TimeRDS.Location = new System.Drawing.Point(630, 410);
            this.Btn_TimeRDS.Name = "Btn_TimeRDS";
            this.Btn_TimeRDS.Size = new System.Drawing.Size(100, 40);
            this.Btn_TimeRDS.TabIndex = 78;
            this.Btn_TimeRDS.Click += new System.EventHandler(this.Btn_TimeRDS_Click);
            // 
            // Btn_RDS
            // 
            this.Btn_RDS.Location = new System.Drawing.Point(630, 190);
            this.Btn_RDS.Name = "Btn_RDS";
            this.Btn_RDS.Size = new System.Drawing.Size(100, 40);
            this.Btn_RDS.TabIndex = 64;
            this.Btn_RDS.Click += new System.EventHandler(this.Btn_RDS_Click);
            // 
            // Btn_Local_DX
            // 
            this.Btn_Local_DX.Location = new System.Drawing.Point(630, 98);
            this.Btn_Local_DX.Name = "Btn_Local_DX";
            this.Btn_Local_DX.Size = new System.Drawing.Size(100, 40);
            this.Btn_Local_DX.TabIndex = 60;
            this.Btn_Local_DX.Click += new System.EventHandler(this.Btn_Local_DX_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 56;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form_RadioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_AF);
            this.Controls.Add(this.Btn_TP);
            this.Controls.Add(this.Btn_TA);
            this.Controls.Add(this.Btn_TimeRDS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_RDS);
            this.Controls.Add(this.Btn_Local_DX);
            this.Controls.Add(this.pictureBoxChannelSet);
            this.Controls.Add(this.pictureBoxRadioSet);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(label_Radio);
            this.Controls.Add(this.pictureBoxImgSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RadioSettings";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_RadioSettings_Load);
            this.Click += new System.EventHandler(this.Form_RadioSettings_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImgSetting;
        private ImageButton Button_Back;
        private System.Windows.Forms.PictureBox pictureBoxRadioSet;
        private System.Windows.Forms.PictureBox pictureBoxChannelSet;
        private TriggerButton Btn_Local_DX;
        private TriggerButton Btn_RDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private TriggerButton_4state Btn_TimeRDS;
        private TriggerButton_4state Btn_TA;
        private TriggerButton_4state Btn_TP;
        private TriggerButton_4state Btn_AF;
    }
}