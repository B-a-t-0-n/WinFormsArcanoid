namespace WinFormsArcanoid.Forms
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxWallpaper = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallpaper).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxWallpaper
            // 
            pictureBoxWallpaper.Image = Properties.Resources._1;
            pictureBoxWallpaper.Location = new Point(394, 169);
            pictureBoxWallpaper.Name = "pictureBoxWallpaper";
            pictureBoxWallpaper.Size = new Size(94, 496);
            pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWallpaper.TabIndex = 0;
            pictureBoxWallpaper.TabStop = false;
            pictureBoxWallpaper.MouseDown += FormGame_MouseDown;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 57, 87);
            ClientSize = new Size(513, 897);
            Controls.Add(pictureBoxWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGame";
            StartPosition = FormStartPosition.Manual;
            Text = "FormGame";
            KeyDown += FormGame_KeyDown;
            KeyUp += FormGame_KeyUp;
            MouseDown += FormGame_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallpaper).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxWallpaper;
    }
}