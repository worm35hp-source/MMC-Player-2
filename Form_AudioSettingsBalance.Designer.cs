namespace MMC_Player_2
{
    partial class Form_AudioSettingsBalance
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
            System.Windows.Forms.Label label1;
            this.pictureBoxImgSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxBalance = new System.Windows.Forms.PictureBox();
            this.Button_Back = new MMC_Player_2.ImageButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(103, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 54);
            label1.Text = "Настройка баланса";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxImgSetting
            // 
            this.pictureBoxImgSetting.Location = new System.Drawing.Point(20, 17);
            this.pictureBoxImgSetting.Name = "pictureBoxImgSetting";
            this.pictureBoxImgSetting.Size = new System.Drawing.Size(39, 50);
            // 
            // pictureBoxBalance
            // 
            this.pictureBoxBalance.Location = new System.Drawing.Point(530, 115);
            this.pictureBoxBalance.Name = "pictureBoxBalance";
            this.pictureBoxBalance.Size = new System.Drawing.Size(250, 345);
            this.pictureBoxBalance.Click += new System.EventHandler(this.pictureBoxBalance_Click);
            this.pictureBoxBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBalance_MouseDown);
            this.pictureBoxBalance.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBalance_Paint);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(20, 98);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 65);
            this.Button_Back.TabIndex = 50;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form_AudioSettingsBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxBalance);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBoxImgSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AudioSettingsBalance";
            this.Text = "Form_AudioSettingsBalance";
            this.Load += new System.EventHandler(this.Form_AudioSettingsBalance_Load);
            this.Click += new System.EventHandler(this.Form_AudioSettingsBalance_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImgSetting;
        private ImageButton Button_Back;
        private System.Windows.Forms.PictureBox pictureBoxBalance;
    }
}