namespace MMC_Player_2
{
    partial class Form_Player
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
            this.pictureBox_FolderName = new System.Windows.Forms.PictureBox();
            this.label_trackname = new System.Windows.Forms.Label();
            this.label_artist = new System.Windows.Forms.Label();
            this.pictureBox_ImgTag = new System.Windows.Forms.PictureBox();
            this.Label_TimeEnd = new System.Windows.Forms.Label();
            this.Label_TimeStart = new System.Windows.Forms.Label();
            this.Img_LineButton = new System.Windows.Forms.PictureBox();
            this.Img_Border = new System.Windows.Forms.PictureBox();
            this.timer_Progress = new System.Windows.Forms.Timer();
            this.timerRewind = new System.Windows.Forms.Timer();
            this.BtnAudioSet2 = new MMC_Player_2.ImageButton();
            this.BtnFolderRight = new MMC_Player_2.ImageButton();
            this.BtnFolderLeft = new MMC_Player_2.ImageButton();
            this.Button_Pause = new MMC_Player_2.ImageButton();
            this.Button_FwdTrack = new MMC_Player_2.ImageButton();
            this.Button_RewindFwd = new MMC_Player_2.ImageButton();
            this.Button_Play = new MMC_Player_2.ImageButton();
            this.Button_RewindRev = new MMC_Player_2.ImageButton();
            this.Button_PrevTrack = new MMC_Player_2.ImageButton();
            this.Button_Back = new MMC_Player_2.ImageButton();
            this.progressTrackBar1 = new MMC_Player_2.ProgressTrackBar();
            this.ima45 = new MMC_Player_2.ImageButton();
            this.imageButton1 = new MMC_Player_2.ImageButton();
            this.SuspendLayout();
            // 
            // pictureBox_FolderName
            // 
            this.pictureBox_FolderName.Location = new System.Drawing.Point(150, 7);
            this.pictureBox_FolderName.Name = "pictureBox_FolderName";
            this.pictureBox_FolderName.Size = new System.Drawing.Size(210, 45);
            this.pictureBox_FolderName.Click += new System.EventHandler(this.pictureBox_FolderName_Click);
            this.pictureBox_FolderName.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_FolderName_Paint);
            // 
            // label_trackname
            // 
            this.label_trackname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label_trackname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_trackname.Location = new System.Drawing.Point(29, 303);
            this.label_trackname.Name = "label_trackname";
            this.label_trackname.Size = new System.Drawing.Size(742, 30);
            this.label_trackname.Text = "Название";
            this.label_trackname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_trackname.ParentChanged += new System.EventHandler(this.label_trackname_ParentChanged);
            // 
            // label_artist
            // 
            this.label_artist.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label_artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.label_artist.Location = new System.Drawing.Point(29, 270);
            this.label_artist.Name = "label_artist";
            this.label_artist.Size = new System.Drawing.Size(742, 30);
            this.label_artist.Text = "Исполнитель";
            this.label_artist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_artist.ParentChanged += new System.EventHandler(this.label_artist_ParentChanged);
            // 
            // pictureBox_ImgTag
            // 
            this.pictureBox_ImgTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ImgTag.Location = new System.Drawing.Point(320, 100);
            this.pictureBox_ImgTag.Name = "pictureBox_ImgTag";
            this.pictureBox_ImgTag.Size = new System.Drawing.Size(160, 150);
            this.pictureBox_ImgTag.Click += new System.EventHandler(this.pictureBox_ImgTag_Click);
            // 
            // Label_TimeEnd
            // 
            this.Label_TimeEnd.BackColor = System.Drawing.Color.Black;
            this.Label_TimeEnd.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.Label_TimeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.Label_TimeEnd.Location = new System.Drawing.Point(706, 356);
            this.Label_TimeEnd.Name = "Label_TimeEnd";
            this.Label_TimeEnd.Size = new System.Drawing.Size(80, 30);
            this.Label_TimeEnd.Text = "00:00";
            this.Label_TimeEnd.ParentChanged += new System.EventHandler(this.Label_TimeEnd_ParentChanged);
            // 
            // Label_TimeStart
            // 
            this.Label_TimeStart.BackColor = System.Drawing.Color.Black;
            this.Label_TimeStart.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.Label_TimeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.Label_TimeStart.Location = new System.Drawing.Point(14, 356);
            this.Label_TimeStart.Name = "Label_TimeStart";
            this.Label_TimeStart.Size = new System.Drawing.Size(80, 30);
            this.Label_TimeStart.Text = "00:00";
            this.Label_TimeStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_TimeStart.ParentChanged += new System.EventHandler(this.Label_TimeStart_ParentChanged);
            // 
            // Img_LineButton
            // 
            this.Img_LineButton.Location = new System.Drawing.Point(0, 420);
            this.Img_LineButton.Name = "Img_LineButton";
            this.Img_LineButton.Size = new System.Drawing.Size(800, 20);
            this.Img_LineButton.Click += new System.EventHandler(this.Img_LineButton_Click);
            // 
            // Img_Border
            // 
            this.Img_Border.Location = new System.Drawing.Point(0, 0);
            this.Img_Border.Name = "Img_Border";
            this.Img_Border.Size = new System.Drawing.Size(800, 60);
            this.Img_Border.Click += new System.EventHandler(this.Img_Border_Click);
            // 
            // timer_Progress
            // 
            this.timer_Progress.Interval = 500;
            this.timer_Progress.Tick += new System.EventHandler(this.timer_Progress_Tick);
            // 
            // timerRewind
            // 
            this.timerRewind.Interval = 400;
            this.timerRewind.Tick += new System.EventHandler(this.timerRewind_Tick);
            // 
            // BtnAudioSet2
            // 
            this.BtnAudioSet2.Location = new System.Drawing.Point(686, 400);
            this.BtnAudioSet2.Name = "BtnAudioSet2";
            this.BtnAudioSet2.Size = new System.Drawing.Size(100, 60);
            this.BtnAudioSet2.TabIndex = 64;
            this.BtnAudioSet2.Click += new System.EventHandler(this.BtnAudioSet_Click);
            // 
            // BtnFolderRight
            // 
            this.BtnFolderRight.Location = new System.Drawing.Point(374, 7);
            this.BtnFolderRight.Name = "BtnFolderRight";
            this.BtnFolderRight.Size = new System.Drawing.Size(80, 45);
            this.BtnFolderRight.TabIndex = 45;
            this.BtnFolderRight.Click += new System.EventHandler(this.BtnFolderRight_Click);
            // 
            // BtnFolderLeft
            // 
            this.BtnFolderLeft.Location = new System.Drawing.Point(55, 7);
            this.BtnFolderLeft.Name = "BtnFolderLeft";
            this.BtnFolderLeft.Size = new System.Drawing.Size(80, 45);
            this.BtnFolderLeft.TabIndex = 44;
            this.BtnFolderLeft.Click += new System.EventHandler(this.BtnFolderLeft_Click);
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
            // Button_RewindFwd
            // 
            this.Button_RewindFwd.Location = new System.Drawing.Point(460, 400);
            this.Button_RewindFwd.Name = "Button_RewindFwd";
            this.Button_RewindFwd.Size = new System.Drawing.Size(100, 60);
            this.Button_RewindFwd.TabIndex = 33;
            this.Button_RewindFwd.Click += new System.EventHandler(this.Button_RewindFwd_Click);
            this.Button_RewindFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_RewindFwd_MouseDown);
            this.Button_RewindFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_RewindFwd_MouseUp);
            // 
            // Button_Play
            // 
            this.Button_Play.Location = new System.Drawing.Point(348, 400);
            this.Button_Play.Name = "Button_Play";
            this.Button_Play.Size = new System.Drawing.Size(100, 60);
            this.Button_Play.TabIndex = 32;
            this.Button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // Button_RewindRev
            // 
            this.Button_RewindRev.Location = new System.Drawing.Point(236, 400);
            this.Button_RewindRev.Name = "Button_RewindRev";
            this.Button_RewindRev.Size = new System.Drawing.Size(100, 60);
            this.Button_RewindRev.TabIndex = 31;
            this.Button_RewindRev.Click += new System.EventHandler(this.Button_RewindRev_Click);
            this.Button_RewindRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_RewindRev_MouseDown);
            this.Button_RewindRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_RewindRev_MouseUp);
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
            // 
            // progressTrackBar1
            // 
            this.progressTrackBar1.Location = new System.Drawing.Point(100, 356);
            this.progressTrackBar1.Name = "progressTrackBar1";
            this.progressTrackBar1.Size = new System.Drawing.Size(600, 30);
            this.progressTrackBar1.TabIndex = 28;
            this.progressTrackBar1.Click += new System.EventHandler(this.progressTrackBar1_Click);
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
            // Form_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAudioSet2);
            this.Controls.Add(this.BtnFolderRight);
            this.Controls.Add(this.BtnFolderLeft);
            this.Controls.Add(this.Button_Pause);
            this.Controls.Add(this.Button_FwdTrack);
            this.Controls.Add(this.Button_RewindFwd);
            this.Controls.Add(this.Button_Play);
            this.Controls.Add(this.Button_RewindRev);
            this.Controls.Add(this.Button_PrevTrack);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.progressTrackBar1);
            this.Controls.Add(this.pictureBox_FolderName);
            this.Controls.Add(this.label_trackname);
            this.Controls.Add(this.label_artist);
            this.Controls.Add(this.pictureBox_ImgTag);
            this.Controls.Add(this.Label_TimeEnd);
            this.Controls.Add(this.Label_TimeStart);
            this.Controls.Add(this.Img_LineButton);
            this.Controls.Add(this.Img_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Player";
            this.Text = "MMC Player 2";
            this.Load += new System.EventHandler(this.Form_Player_Load);
            this.Click += new System.EventHandler(this.Form_Player_Click);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Player_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_TimeEnd;
        private System.Windows.Forms.Label Label_TimeStart;
        private System.Windows.Forms.PictureBox Img_LineButton;
        private System.Windows.Forms.PictureBox Img_Border;
        private ImageButton ima45;
        private ImageButton imageButton1;
        private ImageButton Button_Back;
        private ImageButton Button_RewindRev;
        private ImageButton Button_RewindFwd;
        public System.Windows.Forms.Timer timer_Progress;
        public ProgressTrackBar progressTrackBar1;
        private ImageButton BtnFolderLeft;
        private ImageButton BtnFolderRight;
        public System.Windows.Forms.PictureBox pictureBox_FolderName;
        public ImageButton Button_PrevTrack;
        public ImageButton Button_FwdTrack;
        public ImageButton Button_Play;
        public ImageButton Button_Pause;
        public System.Windows.Forms.Label label_trackname;
        public System.Windows.Forms.Label label_artist;
        public System.Windows.Forms.PictureBox pictureBox_ImgTag;
        private System.Windows.Forms.Timer timerRewind;
        public ImageButton BtnAudioSet2;
    }
}