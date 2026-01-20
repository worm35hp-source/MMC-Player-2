namespace MMC_Player_2
{
    partial class Form_PlayerPhone
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
            this.pictureBox_ImgTag = new System.Windows.Forms.PictureBox();
            this.Img_LineButton = new System.Windows.Forms.PictureBox();
            this.Img_Border = new System.Windows.Forms.PictureBox();
            this.Button_Pause = new MMC_Player_2.ImageButton();
            this.Button_FwdTrack = new MMC_Player_2.ImageButton();
            this.Button_Play = new MMC_Player_2.ImageButton();
            this.Button_PrevTrack = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            this.ima45 = new MMC_Player_2.ImageButton();
            this.imageButton1 = new MMC_Player_2.ImageButton();
            this.BtnAudioSet2 = new MMC_Player_2.ImageButton();
            this.timer_Exit = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // pictureBox_ImgTag
            // 
            this.pictureBox_ImgTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ImgTag.Location = new System.Drawing.Point(320, 100);
            this.pictureBox_ImgTag.Name = "pictureBox_ImgTag";
            this.pictureBox_ImgTag.Size = new System.Drawing.Size(160, 150);
            // 
            // Img_LineButton
            // 
            this.Img_LineButton.Location = new System.Drawing.Point(0, 420);
            this.Img_LineButton.Name = "Img_LineButton";
            this.Img_LineButton.Size = new System.Drawing.Size(800, 20);
            // 
            // Img_Border
            // 
            this.Img_Border.Location = new System.Drawing.Point(0, 0);
            this.Img_Border.Name = "Img_Border";
            this.Img_Border.Size = new System.Drawing.Size(800, 60);
            // 
            // Button_Pause
            // 
            this.Button_Pause.Location = new System.Drawing.Point(348, 400);
            this.Button_Pause.Name = "Button_Pause";
            this.Button_Pause.Size = new System.Drawing.Size(100, 60);
            this.Button_Pause.TabIndex = 35;
            this.Button_Pause.Visible = false;
            this.Button_Pause.Click += new System.EventHandler(this.Button_Pause_Click);
            // 
            // Button_FwdTrack
            // 
            this.Button_FwdTrack.Location = new System.Drawing.Point(572, 400);
            this.Button_FwdTrack.Name = "Button_FwdTrack";
            this.Button_FwdTrack.Size = new System.Drawing.Size(100, 60);
            this.Button_FwdTrack.TabIndex = 34;
            this.Button_FwdTrack.Click += new System.EventHandler(this.Button_FwdTrack_Click);
            // 
            // Button_Play
            // 
            this.Button_Play.Location = new System.Drawing.Point(348, 400);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(100, 60);
            this.Button_Play.TabIndex = 32;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // Button_PrevTrack
            // 
            this.Button_PrevTrack.Location = new System.Drawing.Point(124, 400);
            this.Button_PrevTrack.Name = "Button_PrevTrack";
            this.Button_PrevTrack.Size = new System.Drawing.Size(100, 60);
            this.Button_PrevTrack.TabIndex = 30;
            this.Button_PrevTrack.Click += new System.EventHandler(this.Button_PrevTrack_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(12, 400);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 60);
            this.Button_Back.TabIndex = 29;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            this.Button_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Back_MouseDown);
            // 
            // ima45
            // 
            this.ima45.Location = new System.Drawing.Point(137, 124);
            this.ima45.Name = "ima45";
            this.ima45.Size = new System.Drawing.Size(150, 150);
            this.ima45.TabIndex = 29;
            // 
            // imageButton1
            // 
            this.imageButton1.Location = new System.Drawing.Point(137, 124);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(150, 150);
            this.imageButton1.TabIndex = 29;
            // 
            // BtnAudioSet2
            // 
            this.BtnAudioSet2.Location = new System.Drawing.Point(686, 400);
            this.BtnAudioSet2.Name = "BtnAudioSet2";
            this.BtnAudioSet2.Size = new System.Drawing.Size(100, 60);
            this.BtnAudioSet2.TabIndex = 50;
            this.BtnAudioSet2.Click += new System.EventHandler(this.BtnAudioSet_Click);
            // 
            // timer_Exit
            // 
            this.timer_Exit.Interval = 3000;
            this.timer_Exit.Tick += new System.EventHandler(this.timer_Exit_Tick);
            // 
            // Form_PlayerPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAudioSet2);
            this.Controls.Add(this.Button_Pause);
            this.Controls.Add(this.Button_FwdTrack);
            this.Controls.Add(this.Button_Play);
            this.Controls.Add(this.Button_PrevTrack);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.pictureBox_ImgTag);
            this.Controls.Add(this.Img_LineButton);
            this.Controls.Add(this.Img_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PlayerPhone";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_PlayerPhone_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_LineButton;
        private System.Windows.Forms.PictureBox Img_Border;
        private ImageButton ima45;
        private ImageButton imageButton1;
        private ImageButton Button_Back;
        public ImageButton Button_PrevTrack;
        public ImageButton Button_FwdTrack;
        public ImageButton Button_Play;
        public ImageButton Button_Pause;
        public System.Windows.Forms.PictureBox pictureBox_ImgTag;
        public ImageButton BtnAudioSet2;
        private System.Windows.Forms.Timer timer_Exit;
    }
}