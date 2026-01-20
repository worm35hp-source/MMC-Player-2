namespace MMC_Player_2
{
    partial class ProgressTrackBar
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.Img_WhiteLine = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Red;
            this.ProgressBar.Location = new System.Drawing.Point(0, 10);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1, 10);
            this.ProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseDown);
            // 
            // Img_WhiteLine
            // 
            this.Img_WhiteLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Img_WhiteLine.Location = new System.Drawing.Point(0, 27);
            this.Img_WhiteLine.Name = "Img_WhiteLine";
            this.Img_WhiteLine.Size = new System.Drawing.Size(600, 3);
            // 
            // ProgressTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Img_WhiteLine);
            this.Controls.Add(this.ProgressBar);
            this.Name = "ProgressTrackBar";
            this.Size = new System.Drawing.Size(600, 30);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressTrackBar_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProgressBar;
        private System.Windows.Forms.PictureBox Img_WhiteLine;

    }
}
