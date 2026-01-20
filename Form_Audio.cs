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
using Un4seen.Bass.AddOn.Tags;
using System.IO;
using Service;

using System.Threading;

namespace MMC_Player_2
{
    public partial class Form_Audio : Form
    {
        Form_Main Main;
        List<Files> ListPlay = new List<Files>();

        // Текущая папка
        public string FPath;
        // Папка родитель
        public string backPath;
        // Список папок в текщей папке
        List<string> ls = new List<string>();

        // Список папок, в которых есть файлы мр3
        public List<Files> ls_folder = new List<Files>();
        public int focusfolder = -1, focusfile = -1, focuseditem = -1;

        // Если загружена SD, то false. Если загружена USB, то true.
        bool SD = false, USB = false;

        // Установка шрифта
        Font font_playlist = new Font("Itelma_Kor", 20F, FontStyle.Regular);
        Font font_systime = new Font("Itelma_Kor", 26F, FontStyle.Regular);
        Font font_sysdate = new Font("Itelma_Kor", 14F, FontStyle.Regular);

        public Form_Audio(Form_Main _Main)
        {
            Main = _Main;
            InitializeComponent();

            Img_Audio.Image = MMC_Res.Img_Audio;
            ImgAudioBackground.Image = MMC_Res.ImgAudioBackground;
            pictureBoxRedLine.Image = MMC_Res.RedLine;
            pictureBoxMute.Image = MMC_Res.Mute;
            pictureBoxPhone.Image = MMC_Res.Phone_Connected_0;
            pictureBoxBattCharge.Image = MMC_Res.Phone_BattCharge_0;

            Button_Home.BackGndImage = MMC_Res.BtnHomeOff;
            Button_Home.PressedImage = MMC_Res.BtnHomeOn;
            Button_BackFolder.BackGndImage = MMC_Res.BtnBackOff;
            Button_BackFolder.PressedImage = MMC_Res.BtnBackOn;
            Button_BackFolder.NotActive = MMC_Res.BtnBackDis;
            Button_BackFolder.Active = false;

            BtnSDCard.State1 = MMC_Res.BtnSDDis;
            BtnSDCard.State2 = MMC_Res.BtnSDOff;
            BtnSDCard.State3 = MMC_Res.BtnSDOn;

            BtnUSBCard.State1 = MMC_Res.BtnUSBDis;
            BtnUSBCard.State2 = MMC_Res.BtnUSBOff;
            BtnUSBCard.State3 = MMC_Res.BtnUSBOn;

            Button_Random.State1 = MMC_Res.BtnRandomOff;
            Button_Random.State2 = MMC_Res.BtnRandomOn;

            Button_Repeat.State1 = MMC_Res.BtnRepeatOff;
            Button_Repeat.State2 = MMC_Res.BtnRepeatOn;

            Button_Play.BackGndImage = MMC_Res.BtnPlayOff;
            Button_Play.PressedImage = MMC_Res.BtnPlayOn;
            Button_Play.NotActive = MMC_Res.BtnPlayDis;

            BtnSelectUP.BackGndImage = MMC_Res.BtnUpOff;
            BtnSelectUP.PressedImage = MMC_Res.BtnUpOn;
            BtnSelectUP.NotActive = MMC_Res.BtnUpDis;

            BtnSelectDOWN.BackGndImage = MMC_Res.BtnDownOff;
            BtnSelectDOWN.PressedImage = MMC_Res.BtnDownOn;
            BtnSelectDOWN.NotActive = MMC_Res.BtnDownDis;

            BtnSDCard.State = 0;
            BtnUSBCard.State = 0;

            listView1.Font = font_playlist;
            label_Date.Font = font_sysdate;
            label_Time.Font = font_systime;

            if (MMC_Data.Repeat)
                Button_Repeat.State = true;
            else Button_Repeat.State = false;

            listView1.Focus();

            trackBarAudio1.TrackBarAudioValueChanged +=
               new EventHandler(trackBarAudio1_TrackBarAudioValueChanged);

// ********* ВРЕМЕННО *********************************************************************************************************
            if (Directory.Exists("SDMMC"))
            {
                BtnSDCard_Click(new object(), new EventArgs());
            }
            else if (Directory.Exists("USB Disk"))
            {
                BtnUSBCard_Click(new object(), new EventArgs());
            }
            else
            {
                BtnSDCard.State = 1;
                BtnUSBCard.State = 1;
            }
        }

        private void Form_Audio_Load(object sender, EventArgs e)
        {
            this.Left = 801;
            this.Top = 481;
        }

        // Изменение трекбара
        void trackBarAudio1_TrackBarAudioValueChanged(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            //Установка значения в бар
            TrackBarAudio ptb = (TrackBarAudio)sender;

            listView1.EnsureVisible(0);
            listView1.EnsureVisible(ptb.TrackBarValue);
            listView1.EndUpdate();

            focuseditem = ptb.TrackBarValue;
            listView1.Items[focuseditem].Focused = true;
            listView1.Items[focuseditem].Selected = true;
            listView1.Focus();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            Main.Left = 0;
            Main.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Main.Activate();
            Vars.FormActivated = Vars.Form_Active.Main;
        }

        private void Button_BackFolder_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            bool b = false;
            if (USB)
            {
                if (backPath == "\\USB Disk" || FPath == "\\USB Disk") b = true;
            }
            else if (SD)
            {
                if (backPath == "\\SDMMC" || FPath == "\\SDMMC") b = true;
            }
            

            if (backPath != null && !b)
            {
                FPath = backPath;
                GetFiles();
            }
            else
            {
                if (USB)
                {
                    FPath = "\\USB Disk";
                    backPath = "\\USB Disk";
                }
                else if (SD)
                {
                    FPath = "\\SDMMC";
                    backPath = "\\SDMMC";
                }
                GetFiles();
                Button_BackFolder.Active = false;
            }

            // Находим индекс новой текущей директории в списке папок в которых есть файлы мр3
            SearchIndexFolder(FPath);

            focusfile = -1;
            focuseditem = -1;
        }

        private void BtnSDCard_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnSDCard.State != 1)
            {
                if (Directory.Exists("SDMMC"))
                {
                    FPath = "\\SDMMC";
                    backPath = "\\SDMMC";
                    GetFiles();
                    // Очищаем список папок, в которых есть файлы мр3
                    ls_folder.Clear();
                    // Заполняем список папок, в которых есть файлы мр3
                    FindFolder_2("\\SDMMC");
                    // Находим индекс новой текущей директории в списке папок в которых есть файлы мр3
                    SearchIndexFolder(FPath);

                    BtnSDUSBCard_Service("SD");
                    // Обновляем состояние кнопки BACK_FOLDER
                    Button_BackFolder.Active = false;
                    // Выбрано SD
                    SD = true;
                    USB = false;
                }
                else
                {
                    BtnSDCard.State = 1;
                }
            }
        }

        private void BtnUSBCard_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (BtnUSBCard.State != 1)
            {
                if (Directory.Exists("USB Disk"))
                {
                    FPath = "\\USB Disk";
                    backPath = "\\USB Disk";
                    GetFiles();
                    // Очищаем список папок, в которых есть файлы мр3
                    ls_folder.Clear();
                    // Заполняем список папок, в которых есть файлы мр3
                    FindFolder_2("\\USB Disk");
                    // Находим индекс новой текущей директории в списке папок в которых есть файлы мр3
                    SearchIndexFolder(FPath);

                    BtnSDUSBCard_Service("USB");
                    // Обновляем состояние кнопки BACK_FOLDER
                    Button_BackFolder.Active = false;
                    // Выбрано USB
                    SD = false;
                    USB = true;
                }
                else
                {
                    BtnUSBCard.State = 1;
                }
            }
        }

        private void BtnSDUSBCard_Service(string data)
        {
            if (Directory.Exists("SDMMC"))
            {
                if (data == "SD")
                {
                    BtnSDCard.State = 3;
                    if (Directory.Exists("USB Disk"))
                    {
                        BtnUSBCard.State = 2;
                    }
                    else BtnUSBCard.State = 1;
                }
            }
            if (Directory.Exists("USB Disk"))
            {
                if (data == "USB")
                {
                    if (Directory.Exists("SDMMC"))
                    {
                        BtnSDCard.State = 2;
                    }
                    else BtnSDCard.State = 1;
                    BtnUSBCard.State = 3;
                }
            }
        }

        // Получаем папки и файлы в текущем каталоге и добавляем их в listView
        public void GetFiles()
        {
            listView1.BeginUpdate();
            try
            {
                // Очищаем список папок в текущей папке
                ls.Clear();

                // Получаем информацию о выбранной папке и сохраняем родителя папки
                DirectoryInfo dInfo = new DirectoryInfo(FPath);
                DirectoryInfo[] dirs = dInfo.GetDirectories();

                // Сортировка директорий
                Array.Sort(dirs, delegate(DirectoryInfo f1, DirectoryInfo f2)
                {
                    return f1.Name.CompareTo(f2.Name);
                });

                backPath = dInfo.Parent.FullName;

                listView1.Items.Clear();

                foreach (DirectoryInfo dir in dirs)
                {
                    ListViewItem it = new ListViewItem(dir.Name);

                    // Находим, есть ли в данной директории и в поддиректориях файлы мр3
                    if (FindFolder(dir.FullName))
                    {
                        // Если файлы мр3 есть, то заносим путь к папке в список
                        it.ImageIndex = 1;
                        listView1.Items.Add(it);
                        ls.Add(dir.FullName);
                    }
                }

                // Получаем информацию о файлах в текущей директории
                FileInfo[] fInfo = dInfo.GetFiles("*.mp3");
                // Сортировка файлов
                Array.Sort(fInfo, delegate(FileInfo f2, FileInfo f1)
                {
                    return f1.Name.CompareTo(f2.Name);
                });
                // Заносим в список файлы в текущей директории
                for (int i = fInfo.Length - 1; i >= 0; i--)
                {
                    ListViewItem it = new ListViewItem(fInfo[i].Name);
                    it.ImageIndex = 0;
                    listView1.Items.Add(it);
                }

                // Обновляем значение трекбара
                trackBarAudio1.TrackBarValueMax = listView1.Items.Count;

                listView1.EndUpdate();
            }
            catch (Exception ex) { MessageBox.Show("Audio: " + ex.Message); }
        }

        // Анализируем папку на предмет наличия в ней или поддиректориях файлов мр3
        private bool FindFolder(string path)
        {
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(path);
                DirectoryInfo[] dirs = dInfo.GetDirectories();

                // Сортировка директорий
                Array.Sort(dirs, delegate(DirectoryInfo f1, DirectoryInfo f2)
                {
                    return f1.Name.CompareTo(f2.Name);
                });

                FileInfo[] fInfo = dInfo.GetFiles("*.mp3");

                if (fInfo.Length != 0)
                {
                    return true;
                }

                foreach (DirectoryInfo dir in dirs)
                {
                    if (FindFolder(dir.FullName))
                        return true;
                }
                return false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        // Заполняем список папок, в которых есть файлы мр3
        private void FindFolder_2(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            DirectoryInfo[] dirs = info.GetDirectories();

            // Сортировка директорий
            Array.Sort(dirs, delegate(DirectoryInfo f1, DirectoryInfo f2)
            {
                return f1.Name.CompareTo(f2.Name);
            });

            FileInfo[] files = info.GetFiles("*.mp3");

            if (files.Length != 0)
            {
                ls_folder.Add(new Files(info.Name, info.FullName));
            }

            foreach (DirectoryInfo dir in dirs)
            {
                FindFolder_2(dir.FullName);
            }
        }

        void SearchIndexFolder(string FPath)
        {
                for (int i = 0; i < ls_folder.Count; i++)
                {
                    if (FPath.Equals(ls_folder[i].FolderPath))
                    {
                        focusfolder = i;
                        return;
                    }
                    else
                    {
                        if (FPath == "\\SDMMC" || FPath == "\\USB Disk")
                        {
                            focusfolder = -1;
                        }
                        else
                        {
                            DirectoryInfo dInfo = new DirectoryInfo(FPath);
                            DirectoryInfo[] dirs = dInfo.GetDirectories();

                            // Сортировка директорий
                            Array.Sort(dirs, delegate(DirectoryInfo f1, DirectoryInfo f2)
                            {
                                return f1.Name.CompareTo(f2.Name);
                            });

                            FileInfo[] fInfo = dInfo.GetFiles("*.mp3");

                            if (fInfo != null)
                            {
                                for (int j = 0; j < ls_folder.Count; j++)
                                {
                                    if (FPath.Equals(ls_folder[j].FolderPath))
                                    {
                                        focusfolder = j;
                                        return;
                                    }
                                }
                            }
                            SearchIndexFolder(dirs[0].FullName);
                        }
                    }
                }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            // Если ни один элемент не выбран, то выходим
            if (listView1.SelectedIndices.Count == 0)
                return;

            // Создаем объект текущего элемента
            ListViewItem item = listView1.FocusedItem;

            // Если элемент = папка
            if (item.ImageIndex == 1)
            {
                Button_BackFolder.Active = true;
                // Записываем название папки, в которую заходим
                string it = item.Text;
                // Проходим по списку папок в текущей папке
                foreach (string s in ls)
                {
                    try
                    {
                        // Ищем в списке папок в текущей папке нужную папку и назначаем ее новой текущей папкой
                        if (s.Substring(s.Length - it.Length, it.Length) == it)
                        {
                            FPath = s;
                        }
                    }
                    catch { }
                }
                // Получаем список папок и файлов в новой текущей директории
                GetFiles();

                // Находим индекс новой текущей директории в списке папок в которых есть файлы мр3
                SearchIndexFolder(FPath);

                focusfile = -1;
                focuseditem = -1;
            }

                // Если элемент = файл
            else if (item.ImageIndex == 0)
            {
                focusfile = listView1.FocusedItem.Index;
                // Активация формы плеера
                form_Activated();
                // Воспроизведение выбранного трека
                PlaySelectedTrack(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0)
                focuseditem = listView1.FocusedItem.Index;
        }

        private void form_Activated()
        {
            // Активируем форму плеера
            Forms.Player.Left = 0;
            Forms.Player.Top = 0;
            this.Left = 801;
            this.Top = 481;
            Forms.Player.Activate();
            Vars.FormActivated = Vars.Form_Active.Player;
        }

        // Воспроизведение выбранного трека
        public void PlaySelectedTrack(ListViewItem item)
        {
            if (SerialCOM1.Api_GetActivateMode() != 1)
            {
                SerialCOM1.Api_SetActivateMode(1);
                Vars.CurrentMode = SerialCOM1.Api_GetActivateMode();
            }

            // Освобождаем поток
            Bass.BASS_StreamFree(Vars.BASS_Stream);
            // Создаем новый поток
            Vars.BASS_Stream = Bass.BASS_StreamCreateFile(FPath + "\\" + item.Text, 0, 0, BASSFlag.BASS_DEFAULT);

            if (Vars.BASS_Stream != 0)
            {
                Forms.Player.progressTrackBar1.Maximum = Bass.BASS_ChannelGetLength(Vars.BASS_Stream);
                Forms.Player.timer_Progress.Enabled = true;

                // Смена состояния кнопок Пауза/Воспроизведение
                Forms.Player.Button_Pause.Visible = true;
                Forms.Player.Button_Play.Visible = false;


                #region // Чтение ID3v1 тега текущего трека
                ID3v1 tagID3v1 = new ID3v1();
                if (tagID3v1.GetID3v1Tag(FPath + "\\" + item.Text))
                {
                    if (tagID3v1.Artist != null) Forms.Player.label_artist.Text = "Исполнитель: " + tagID3v1.Artist;
                    else Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                    if (tagID3v1.Title != null) Forms.Player.label_trackname.Text = "Название: " + tagID3v1.Title;
                    else Forms.Player.label_trackname.Text = "Название: Нет названия";
                }
                else
                {
                    Forms.Player.label_trackname.Text = "Название: Нет названия";
                    Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                    Forms.Player.pictureBox_ImgTag.Image = MMC_Res.Img_TagAudio;
                }
  /*              else
                {
                    // Чтение ID3v2 тега текущего трека
                    ID3v2 tagID3v2 = new ID3v2();
                    if (tagID3v2.GetID3v2Tag(FPath + "\\" + item.Text))
                    {
                        if (tagID3v2.Artist != null) Forms.Player.label_artist.Text = "Исполнитель: " + tagID3v2.Artist;
                        else Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                        if (tagID3v2.Title != null) Forms.Player.label_trackname.Text = "Название: " + tagID3v2.Title;
                        else Forms.Player.label_trackname.Text = "Название: Нет названия";
                    }
                    else
                    {
                        Forms.Player.label_trackname.Text = "Название: Нет названия";
                        Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                        Forms.Player.pictureBox_ImgTag.Image = MMC_Res.Img_TagAudio;
                    }
                }*/
                #endregion

                // Начинаем воспроизведение
                Bass.BASS_ChannelPlay(Vars.BASS_Stream, false);
                Vars.StatusPlay = true;

                // Обновляем название папки в меню выбора папки для воспроизведения
                Forms.Player.pictureBox_FolderName.Invalidate();
            }
            else
            {
                Bass.BASS_StreamFree(Vars.BASS_Stream);
                Vars.StatusPlay = false;
                Forms.Player.timer_Progress.Enabled = false;
                MessageBox.Show("Не могу прочитать файл!");
                return;
            }
            BtnService();
        }

        // Управление состоянием кнопок ВпередТрек и НазадТрек
        public void BtnService()
        {
            // Если счетчик файлов равен общему количеству элементов в списке, то это последний трек
            if (focusfile == listView1.Items.Count - 1)
            {
                Forms.Player.Button_FwdTrack.Active = false;
            }
            else
            {
                Forms.Player.Button_FwdTrack.Active = true;
            }

            // Если счетчик файлов меньше или равен количеству папок в текущей директории, то это первый трек
            if (focusfile <= ls.Count)
            {
                Forms.Player.Button_PrevTrack.Active = false;
            }
            else
            {
                Forms.Player.Button_PrevTrack.Active = true;
            }
        }

        public void Button_Play_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (listView1.Items.Count != 0)
            {
                // Если ни один элемент не выделен
                if (listView1.SelectedIndices.Count == 0)
                {
                    if (focusfolder == -1) focusfolder = 0;
                    // Активация формы плеера
                    form_Activated();
                    // Заходим в папку и воспроизводим трек
                    InFolderPlayTrack();
                }
                // Если выделен один элемент
                else
                {
                    try
                    {
                        // Если выделена папка
                        if (listView1.Items[focuseditem].ImageIndex == 1)
                        {
                            SearchIndexFolder(FPath + "\\" + listView1.FocusedItem.Text);
                            // Активация формы плеера
                            form_Activated();
                            // Заходим в папку и воспроизводим трек
                            InFolderPlayTrack();
                        }
                        else
                        {
                            // Если выделен трек
                            if (listView1.Items[focuseditem].ImageIndex == 0)
                            {
                                focusfile = listView1.FocusedItem.Index;
                                ListViewItem item = listView1.FocusedItem;
                                // Активация формы плеера
                                form_Activated();
                                // Воспроизведение выбранного трека
                                PlaySelectedTrack(item);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("listView длина = " + listView1.Items.Count + ", обращение к индексу " + focuseditem.ToString());
                    }
                }
            }
        }

        void InFolderPlayTrack()
        {
            // Заходим в папку
            FPath = ls_folder[focusfolder].FolderPath;
            // Установка состояния кнопки Назад
            if (FPath != "SDMMC" || FPath != "USB Disk") Button_BackFolder.Active = true;
            else Button_BackFolder.Active = false;

            GetFiles();

            // Устанавливаем смещение для файлов
            focusfile = ls.Count;

            try
            {
                // Воспроизводим
                listView1.Items[focusfile].Focused = true;
                listView1.Items[focusfile].Selected = true;
                listView1.Focus();
            }
            catch
            {
                MessageBox.Show("listView длина = " + listView1.Items.Count + ", обращение к индексу " + focuseditem.ToString());
                return;
            }

            // Создаем объект текущего элемента
            ListViewItem item = listView1.FocusedItem;

            // Воспроизведение выбранного трека
            PlaySelectedTrack(item);
        }

        // Следующий трек
        public void Next_Track()
        {
            if (focusfile < listView1.Items.Count)
            {
                focusfile++;

                try
                {
                    listView1.Items[focusfile].Focused = true;
                    listView1.Items[focusfile].Selected = true;
                    listView1.Focus();
                }
                catch
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    Vars.StatusPlay = false;
                    MessageBox.Show("listView длина = " + listView1.Items.Count + ", обращение к индексу " + focuseditem.ToString());
                    return;
                }
                ListViewItem item = listView1.FocusedItem;
                // Воспроизведение выбранного трека
                PlaySelectedTrack(item);
                try
                {
                    listView1.EnsureVisible(focusfile);
                }
                catch { }
            }
            trackBarAudio1.TrackBarValue = focusfile;
        }

        // Предудыщий трек
        public void Prev_Track()
        {
            if (focusfile > ls.Count)
            {
                focusfile--;

                try
                {
                    listView1.Items[focusfile].Focused = true;
                    listView1.Items[focusfile].Selected = true;
                    listView1.Focus();
                }
                catch
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    Vars.StatusPlay = false;
                    MessageBox.Show("listView длина = " + listView1.Items.Count + ", обращение к индексу " + focuseditem.ToString());
                    return;
                }

                ListViewItem item = listView1.FocusedItem;
                // Воспроизведение выбранного трека
                PlaySelectedTrack(item);
                try
                {
                    listView1.EnsureVisible(focusfile);
                }
                catch { }
            }
            trackBarAudio1.TrackBarValue = focusfile;
        }

        public void Folder_Left()
        {
            if (focusfolder > 0)
                focusfolder--;
            else focusfolder = ls_folder.Count - 1;
            InFolderPlayTrack();
            trackBarAudio1.TrackBarValue = focuseditem;
        }

        public void Folder_Right()
        {
            if (focusfolder < ls_folder.Count - 1)
                focusfolder++;
            else focusfolder = 0;
            InFolderPlayTrack();
            trackBarAudio1.TrackBarValue = 0;
        }

        private void Folder_Next()
        {
            if (MMC_Data.Repeat)
            {
                Folder_Right();
            }
            else
            {
                if (focusfolder < ls_folder.Count - 1)
                {
                    focusfolder++;
                    InFolderPlayTrack();
                }
                else
                {
                    Vars.StatusPlay = false;
                    Forms.Player.timer_Progress.Enabled = false;
                    
                    focusfolder = 0;
                    // Заходим в папку
                    FPath = ls_folder[focusfolder].FolderPath;

                    Forms.Player.pictureBox_FolderName.Invalidate();

                    // Установка состояния кнопки Назад
                    if (FPath != "SDMMC" || FPath != "USB Disk") Button_BackFolder.Active = true;
                    else Button_BackFolder.Active = false;

                    GetFiles();

                    try
                    {
                        // Устанавливаем смещение для файлов
                        focusfile = ls.Count;
                        listView1.Items[focusfile].Focused = true;
                        listView1.Items[focusfile].Selected = true;
                        listView1.Focus();
                    }
                    catch 
                    {
                        Forms.Player.timer_Progress.Enabled = false;
                        Vars.StatusPlay = false;
                        MessageBox.Show("Не установлено смещение файлов");
                        return;
                    }

                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    // Создаем новый поток
                    Vars.BASS_Stream = Bass.BASS_StreamCreateFile(FPath + "\\" + listView1.FocusedItem.Text, 0, 0, BASSFlag.BASS_DEFAULT);

                    // Сброс времени трека и прогресстрекбара, сервис кнопок Плей/Пауза
                    Forms.Player.ResetPlayTime();

                    // Читаем тег трека
                    if (Vars.BASS_Stream != 0)
                    {
                        BassTags.ReadPictureTAGs = true;
                        TAG_INFO tagInfo = BassTags.BASS_TAG_GetFromFile(FPath + "\\" + listView1.FocusedItem.Text, false, true);

                        if (tagInfo != null)
                        {
                            if (tagInfo.artist != null) Forms.Player.label_artist.Text = "Исполнитель: " + tagInfo.artist;
                            else Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                            if (tagInfo.title != null) Forms.Player.label_trackname.Text = "Название: " + tagInfo.title;
                            else Forms.Player.label_trackname.Text = "Название: Нет названия";

                            Forms.Player.pictureBox_ImgTag.Image = tagInfo.PictureGetImage(0);
                            if (tagInfo.PictureCount != 0) Forms.Player.pictureBox_ImgTag.Image = tagInfo.PictureGetImage(0);
                            else Forms.Player.pictureBox_ImgTag.Image = MMC_Res.Img_TagAudio;
                        }
                        else
                        {
                            Forms.Player.label_trackname.Text = "Название: Нет названия";
                            Forms.Player.label_artist.Text = "Исполнитель: Нет исполнителя";
                            Forms.Player.pictureBox_ImgTag.Image = MMC_Res.Img_TagAudio;
                        }
                    }

                    BtnService();
                }
            }
            trackBarAudio1.TrackBarValue = 0;
        }

        public void AutoNextTrack()
        {
            if (Vars.StatusPlay && Bass.BASS_ChannelIsActive(Vars.BASS_Stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                // Если файлы в папке еще не кончились, иначе переход в следующую папку
                if (focusfile < listView1.Items.Count - 1)
                {
                    Next_Track();
                }
                else if (focusfile == listView1.Items.Count - 1)
                {
                    Folder_Next();
                }
            }
        }

        private void BtnSelectDOWN_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;

            if (listView1.Items.Count != 0)
            {
                if (focuseditem < listView1.Items.Count - 1)
                {
                    focuseditem++;

                    try
                    {
                        // Выделение заданного итема
                        listView1.Items[focuseditem].Focused = true;
                        listView1.Items[focuseditem].Selected = true;
                        listView1.Focus();

                        focusfile = listView1.FocusedItem.Index;
                        listView1.EnsureVisible(listView1.Items[focuseditem].Index);
                    }
                    catch { }
                }
                else
                {
                    focuseditem = listView1.Items.Count - 1;

                    try
                    {
                        // Выделение заданного итема
                        listView1.Items[focuseditem].Focused = true;
                        listView1.Items[focuseditem].Selected = true;
                        listView1.Focus();

                        focusfile = listView1.FocusedItem.Index;
                        listView1.EnsureVisible(listView1.Items[focuseditem].Index);
                    }
                    catch { }
                }
                trackBarAudio1.TrackBarValue = focuseditem;
            }
        }

        private void BtnSelectUP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (listView1.Items.Count != 0)
            {
                if (focuseditem > 0)
                {
                    focuseditem--;
                    try
                    {
                        // Выделение заданного итема
                        listView1.Items[focuseditem].Focused = true;
                        listView1.Items[focuseditem].Selected = true;
                        listView1.Focus();

                        focusfile = listView1.FocusedItem.Index;
                        listView1.EnsureVisible(listView1.Items[focuseditem].Index);
                    }
                    catch { }
                }
                else
                {
                    focuseditem = 0;

                    try
                    {
                        // Выделение заданного итема
                        listView1.Items[focuseditem].Focused = true;
                        listView1.Items[focuseditem].Selected = true;
                        listView1.Focus();

                        focusfile = listView1.FocusedItem.Index;
                        listView1.EnsureVisible(listView1.Items[focuseditem].Index);
                    }
                    catch { }
                }
                trackBarAudio1.TrackBarValue = focuseditem;
            }
        }

        private void Button_Repeat_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
            if (MMC_Data.Repeat)
            {
                MMC_Data.Repeat = false;
                Button_Repeat.State = false;
            }
            else
            {
                MMC_Data.Repeat = true;
                Button_Repeat.State = true;
            }
        }

        private void Form_Audio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0;
        }

        private void Img_TagAudio_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_Time_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_Date_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void timerSDUSB_ins_Del_Tick(object sender, EventArgs e)
        {
            if (Directory.Exists("\\SDMMC"))
            {
                if (SD) BtnSDCard.State = 3;
                else BtnSDCard.State = 2;
            }
            else
            {
                if (SD)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnSDCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    SD = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }

            if (Directory.Exists("\\USB Disk"))
            {
                if (USB) BtnUSBCard.State = 3;
                else BtnUSBCard.State = 2;
            }
            else
            {
                if (USB)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnUSBCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    USB = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }
        }
  /*      public void SDUSB_Del()
        {
            Thread.Sleep(500);
            if (Directory.Exists("\\SDMMC"))
            {
                if (SD) BtnSDCard.State = 3;
                else BtnSDCard.State = 2;
            }
            else
            {
                if (SD)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnSDCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    SD = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }

            Thread.Sleep(2500);
            if (Directory.Exists("\\USB Disk"))
            {
                if (USB) BtnUSBCard.State = 3;
                else BtnUSBCard.State = 2;
            }
            else
            {
                if (USB)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnUSBCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    USB = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }
        }

        public void SDUSB_ins()
        {
            Thread.Sleep(500);
            if (Directory.Exists("\\SDMMC"))
            {
                if (SD) BtnSDCard.State = 3;
                else BtnSDCard.State = 2;
            }
            else
            {
                if (SD)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnSDCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    SD = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }

            Thread.Sleep(2500);
            if (Directory.Exists("\\USB Disk"))
            {
                if (USB) BtnUSBCard.State = 3;
                else BtnUSBCard.State = 2;
            }
            else
            {
                if (USB)
                {
                    Forms.Player.timer_Progress.Enabled = false;
                    BtnUSBCard.State = 1;
                    Button_BackFolder.Active = false;
                    ls_folder.Clear();
                    listView1.Items.Clear();
                    // Освобождаем поток
                    Bass.BASS_StreamFree(Vars.BASS_Stream);
                    Vars.StatusPlay = false;
                    USB = false;

                    this.Left = 0;
                    this.Top = 0;
                    Forms.Player.Left = 801;
                    Forms.Player.Top = 481;
                    this.Activate();
                    Vars.FormActivated = Vars.Form_Active.Audio;
                }
            }
        }*/

        private void pictureBoxPhone_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }

        private void label_tempAKPP_Click(object sender, EventArgs e)
        {
            Vars.timerScreenSaverTick = 0; 
        }
    }
}