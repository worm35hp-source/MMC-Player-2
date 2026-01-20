using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MMC_Resources;
using Un4seen.Bass;
using Service;

namespace MMC_Player_2
{
    public partial class Form_Player : Form
    {
        Form_Main Main;
        Font font_folder = new Font("Kor_Itelma", 14F, FontStyle.Regular);

        public Form_Player(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            Img_Border.Image = MMC_Res.Border;
            pictureBox_ImgTag.Image = MMC_Res.Img_TagAudio;
            Img_LineButton.Image = MMC_Res.LineButton;
            pictureBox_FolderName.Image = MMC_Res.AudFolderName;

            Button_Back.BackGndImage = MMC_Res.AudBtnBackOff;
            Button_Back.PressedImage = MMC_Res.AudBtnBackOn;

            Button_PrevTrack.BackGndImage = MMC_Res.AudBtnPrevTrackOff;
            Button_PrevTrack.PressedImage = MMC_Res.AudBtnPrevTrackOn;
            Button_PrevTrack.NotActive = MMC_Res.AudBtnPrevTrackDis;

            Button_RewindRev.BackGndImage = MMC_Res.AudBtnRewindRevTrackOff;
            Button_RewindRev.PressedImage = MMC_Res.AudBtnRewindRevTrackOn;
            Button_RewindRev.NotActive = MMC_Res.AudBtnRewindRevTrackDis;

            Button_Play.BackGndImage = MMC_Res.AudBtnPlayOff;
            Button_Play.PressedImage = MMC_Res.AudBtnPlayOn;

            Button_Pause.BackGndImage = MMC_Res.AudBtnPauseOff;
            Button_Pause.PressedImage = MMC_Res.AudBtnPauseOn;

            Button_RewindFwd.BackGndImage = MMC_Res.AudBtnRewindFwdTrackOff;
            Button_RewindFwd.PressedImage = MMC_Res.AudBtnRewindFwdTrackOn;
            Button_RewindFwd.NotActive = MMC_Res.AudBtnRewindFwdTrackDis;

            Button_FwdTrack.BackGndImage = MMC_Res.AudBtnFwdTrackOff;
            Button_FwdTrack.PressedImage = MMC_Res.AudBtnFwdTrackOn;
            Button_FwdTrack.NotActive = MMC_Res.AudBtnFwdTrackDis;

            //BtnAudioSet.BackGndImage = MMC_Res.AudBtnPlayerAudioSet;
            //BtnAudioSet.PressedImage = MMC_Res.AudBtnPlayerAudioSet;

            BtnAudioSet2.BackGndImage = MMC_Res.EQBtnOff;
            BtnAudioSet2.PressedImage = MMC_Res.EQBtnOn;

            BtnFolderLeft.BackGndImage = MMC_Res.AudBtnFolderLeftOff;
            BtnFolderLeft.PressedImage = MMC_Res.AudBtnFolderLeftOn;

            BtnFolderRight.BackGndImage = MMC_Res.AudBtnFolderRightOff;
            BtnFolderRight.PressedImage = MMC_Res.AudBtnFolderRightOn;
            
            
            progressTrackBar1.TrackBarValueChanged +=
                new EventHandler(progressTrackBar1_TrackBarValueChanged);
        }

        private void Form_Player_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        // Изменение прогресстрекбара
        void progressTrackBar1_TrackBarValueChanged(object sender, EventArgs e)
        {
            if (Vars.BASS_Stream != 0)
            {
                //Установка значения в прогрессбар
                ProgressTrackBar ptb = (ProgressTrackBar)sender;
                Bass.BASS_ChannelSetPosition(Vars.BASS_Stream, ptb.TrackBarValue);
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            if (Vars.StatusPlay && Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                // Освобождаем поток
                Bass.BASS_StreamFree(Vars.BASS_Stream);
                timer_Progress.Enabled = false;
                Vars.StatusPlay = false;

                Vars.timerScreenSaverTick = 0;
                Forms.Audio.Left = 0;
                Forms.Audio.Top = 0;
                this.Left = 801;
                this.Top = 481;
                Forms.Audio.Activate();
                Vars.FormActivated = Vars.Form_Active.Audio;
            }
            else
            {
                Vars.timerScreenSaverTick = 0;
                Main.Left = 0;
                Main.Top = 0;
                this.Left = 801;
                this.Top = 481;
                Main.Activate();
                Vars.FormActivated = Vars.Form_Active.Main;
            }
        }

        // Управление плеером
        private void Button_Pause_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Vars.BASS_Stream);
            Button_Pause.Visible = false;
            Button_Play.Visible = true;
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_ChannelPlay(Vars.BASS_Stream, false);

                Button_Pause.Visible = true;
                Button_Play.Visible = false;

                if (Vars.BASS_Stream != 0)
                {
                    progressTrackBar1.Maximum = Bass.BASS_ChannelGetLength(Vars.BASS_Stream);
                }
            }
            else if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                ListViewItem item = Forms.Audio.listView1.FocusedItem;
                Forms.Audio.PlaySelectedTrack(item);
            }
        }

        bool RewindVector = false;
        private void Button_RewindRev_MouseDown(object sender, MouseEventArgs e)
        {
            RewindVector = false;
            timerRewind.Enabled = true;
        }

        private void Button_RewindFwd_MouseDown(object sender, MouseEventArgs e)
        {
            RewindVector = true;
            timerRewind.Enabled = true;
        }

        private void Button_RewindRev_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

        private void Button_RewindFwd_MouseUp(object sender, MouseEventArgs e)
        {
            timerRewind.Enabled = false;
        }

        // ПЕРЕМОТКА НАЗАД
        private void Button_RewindRev_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            RewindReverse();
        }

        // ПЕРЕМОТКА ВПЕРЕД
        private void Button_RewindFwd_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            RewindForward();
        }

        // ПЕРЕМОТКА НАЗАД
        public void RewindReverse()
        {
            int NewTrackPos = 0;
            int TrackPos = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetPosition(Vars.BASS_Stream));
            if (TrackPos <= 10)
            {
                NewTrackPos = 0;
                Bass.BASS_ChannelSetPosition(Vars.BASS_Stream, (double)NewTrackPos);
            }
            else if (TrackPos > 10)
            {
                NewTrackPos = TrackPos - 10;
                Bass.BASS_ChannelSetPosition(Vars.BASS_Stream, (double)NewTrackPos);
            }
        }

        // ПЕРЕМОТКА ВПЕРЕД
        public void RewindForward()
        {
            int NewTrackPos = 0;
            int TrackPos = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetPosition(Vars.BASS_Stream));
            int TrackLen = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetLength(Vars.BASS_Stream));
            if (TrackPos < (TrackLen - 10))
            {
                NewTrackPos = TrackPos + 10;
                Bass.BASS_ChannelSetPosition(Vars.BASS_Stream, (double)NewTrackPos);
            }
            else
            {
                NewTrackPos = TrackLen;
                Bass.BASS_ChannelSetPosition(Vars.BASS_Stream, (double)NewTrackPos);
            }
        }

        private void timerRewind_Tick(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (RewindVector)
                RewindForward();
            else RewindReverse();
        }

        // Предыдущий трек
        private void Button_PrevTrack_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Audio.Prev_Track();
        }

        // Следующий трек
        private void Button_FwdTrack_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Audio.Next_Track();
        }

        // Предыдущая папка
        private void BtnFolderLeft_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Audio.Folder_Left();
        }

        // Следующая папка
        private void BtnFolderRight_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            Forms.Audio.Folder_Right();
        }

        int TrackPos, TrackLen, m, s, TrackBack;
        private void timer_Progress_Tick(object sender, EventArgs e)
        {
            // Установка времени трека и прогрессбара
            if (Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PLAYING
                || Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                progressTrackBar1.Value = (int)Bass.BASS_ChannelGetPosition(Vars.BASS_Stream);

                TrackPos = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetPosition(Vars.BASS_Stream));
                TrackLen = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetLength(Vars.BASS_Stream));

                s = TrackPos % 60;
                m = TrackPos / 60;
                if (m < 10 && s < 10) Label_TimeStart.Text = Convert.ToString("0" + m + ":0" + s);
                else if (m < 10 && s > 9) Label_TimeStart.Text = Convert.ToString("0" + m + ":" + s);
                else if (m > 9 && s < 10) Label_TimeStart.Text = Convert.ToString(m + ":0" + s);
                else if (m > 9 && s > 9) Label_TimeStart.Text = Convert.ToString(m + ":" + s);

                TrackBack = TrackLen - TrackPos;
                s = TrackBack % 60;
                m = TrackBack / 60;
                if (m < 10 && s < 10) Label_TimeEnd.Text = Convert.ToString("0" + m + ":0" + s);
                else if (m < 10 && s > 9) Label_TimeEnd.Text = Convert.ToString("0" + m + ":" + s);
                else if (m > 9 && s < 10) Label_TimeEnd.Text = Convert.ToString(m + ":0" + s);
                else if (m > 9 && s > 9) Label_TimeEnd.Text = Convert.ToString(m + ":" + s);
            }
            else
            {
                Label_TimeStart.Text = "00:00";
                Label_TimeEnd.Text = "00:00";
                progressTrackBar1.Value = 0;
            }

            // Автопереход на следующий трек
            Forms.Audio.AutoNextTrack();
        }

        // Сброс времени трека и прогресстрекбара, сервис кнопок Плей/Пауза
        public void ResetPlayTime()
        {
            if (Vars.BASS_Stream != 0)
            {
                TrackPos = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetPosition(Vars.BASS_Stream));
                TrackLen = (int)Bass.BASS_ChannelBytes2Seconds(Vars.BASS_Stream, Bass.BASS_ChannelGetLength(Vars.BASS_Stream));

                s = TrackPos % 60;
                m = TrackPos / 60;
                if (m < 10 && s < 10) Label_TimeStart.Text = Convert.ToString("0" + m + ":0" + s);
                else if (m < 10 && s > 9) Label_TimeStart.Text = Convert.ToString("0" + m + ":" + s);
                else if (m > 9 && s < 10) Label_TimeStart.Text = Convert.ToString(m + ":0" + s);
                else if (m > 9 && s > 9) Label_TimeStart.Text = Convert.ToString(m + ":" + s);

                TrackBack = TrackLen - TrackPos;
                s = TrackBack % 60;
                m = TrackBack / 60;
                if (m < 10 && s < 10) Label_TimeEnd.Text = Convert.ToString("0" + m + ":0" + s);
                else if (m < 10 && s > 9) Label_TimeEnd.Text = Convert.ToString("0" + m + ":" + s);
                else if (m > 9 && s < 10) Label_TimeEnd.Text = Convert.ToString(m + ":0" + s);
                else if (m > 9 && s > 9) Label_TimeEnd.Text = Convert.ToString(m + ":" + s);
            }

            progressTrackBar1.Value = 0;
            Button_Pause.Visible = false;
            Button_Play.Visible = true;
        }

        private void Form_Player_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_Border_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBox_ImgTag_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_artist_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void label_trackname_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void progressTrackBar1_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Label_TimeStart_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Label_TimeEnd_ParentChanged(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void Img_LineButton_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
            
        }

        private void pictureBox_FolderName_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void pictureBox_FolderName_Paint(object sender, PaintEventArgs e)
        {
            StringFormat stringformat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            try
            {
                if (Forms.Audio.ls_folder != null)
                {
                    e.Graphics.DrawString(Forms.Audio.ls_folder[Forms.Audio.focusfolder].FolderName, font_folder,
                        new SolidBrush(Color.FromArgb(174, 255, 199)), pictureBox_FolderName.Width / 2, pictureBox_FolderName.Height / 2, stringformat);
                }
            }
            catch { MessageBox.Show("Не удалось отобразить название папки"); }
        }

        private void BtnAudioSet_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            Forms.AudioSettings.Left = 0;
            Forms.AudioSettings.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.AudioSettings.Activate();
            Vars.FormActivated = Vars.Form_Active.Player_AudioSettings;
        }

        private void Form_Player_Closing(object sender, CancelEventArgs e)
        {
            progressTrackBar1.TrackBarValueChanged -=
                new EventHandler(progressTrackBar1_TrackBarValueChanged);
        }
    }
}