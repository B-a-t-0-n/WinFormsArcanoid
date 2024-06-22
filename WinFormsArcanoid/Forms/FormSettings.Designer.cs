namespace WinFormsArcanoid.Forms
{
    partial class FormSettings
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
            MainMenu = new Panel();
            panelButtons = new Panel();
            panelVolume = new Panel();
            panelIcon = new Panel();
            pictureBox1 = new PictureBox();
            trackBarMusic = new TrackBar();
            buttonExit = new Button();
            buttonSettings = new Button();
            panelTitle = new Panel();
            labelTitle = new Label();
            MainMenu.SuspendLayout();
            panelButtons.SuspendLayout();
            panelVolume.SuspendLayout();
            panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Controls.Add(panelButtons);
            MainMenu.Controls.Add(panelTitle);
            MainMenu.Location = new Point(96, 101);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(319, 442);
            MainMenu.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(panelVolume);
            panelButtons.Controls.Add(buttonExit);
            panelButtons.Controls.Add(buttonSettings);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0, 68);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(319, 374);
            panelButtons.TabIndex = 1;
            // 
            // panelVolume
            // 
            panelVolume.BackColor = Color.FromArgb(94, 189, 255);
            panelVolume.Controls.Add(panelIcon);
            panelVolume.Controls.Add(trackBarMusic);
            panelVolume.Location = new Point(0, 29);
            panelVolume.Name = "panelVolume";
            panelVolume.Size = new Size(319, 60);
            panelVolume.TabIndex = 3;
            // 
            // panelIcon
            // 
            panelIcon.Controls.Add(pictureBox1);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(60, 60);
            panelIcon.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.free_icon_font_volume;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trackBarMusic
            // 
            trackBarMusic.Location = new Point(66, 15);
            trackBarMusic.Name = "trackBarMusic";
            trackBarMusic.Size = new Size(250, 45);
            trackBarMusic.TabIndex = 0;
            trackBarMusic.TickStyle = TickStyle.None;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(94, 189, 255);
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.FromArgb(19, 57, 87);
            buttonExit.Location = new Point(0, 238);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(319, 60);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Назад";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(94, 189, 255);
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSettings.ForeColor = Color.FromArgb(19, 57, 87);
            buttonSettings.Location = new Point(0, 133);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(319, 60);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "Как играть?";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(19, 57, 87);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Padding = new Padding(1);
            panelTitle.Size = new Size(319, 68);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(86, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(161, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Настройки";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 57, 87);
            ClientSize = new Size(518, 666);
            Controls.Add(MainMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSettings";
            StartPosition = FormStartPosition.Manual;
            Text = "FormSettings";
            MouseDown += FormSettings_MouseDown;
            MainMenu.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelVolume.ResumeLayout(false);
            panelVolume.PerformLayout();
            panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainMenu;
        private Panel panelButtons;
        private Button buttonExit;
        private Panel panelTitle;
        private Label labelTitle;
        private Panel panelVolume;
        private Panel panelIcon;
        private TrackBar trackBarMusic;
        private Button buttonSettings;
        private PictureBox pictureBox1;
    }
}