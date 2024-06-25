namespace WinFormsArcanoid
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenu = new Panel();
            panelButtons = new Panel();
            buttonExit = new Button();
            buttonSettings = new Button();
            buttonPlay = new Button();
            panelTitle = new Panel();
            labelTitle = new Label();
            MainMenu.SuspendLayout();
            panelButtons.SuspendLayout();
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
            MainMenu.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonExit);
            panelButtons.Controls.Add(buttonSettings);
            panelButtons.Controls.Add(buttonPlay);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0, 68);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(319, 374);
            panelButtons.TabIndex = 1;
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
            buttonExit.Text = "Выход";
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
            buttonSettings.Text = "Настройки";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.FromArgb(94, 189, 255);
            buttonPlay.Cursor = Cursors.Hand;
            buttonPlay.FlatAppearance.BorderSize = 0;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPlay.ForeColor = Color.FromArgb(19, 57, 87);
            buttonPlay.Location = new Point(0, 29);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(319, 60);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Играть\r\n";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
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
            labelTitle.Location = new Point(98, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(124, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Главная";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 57, 87);
            ClientSize = new Size(518, 666);
            Controls.Add(MainMenu);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += FormHome_Load;
            MouseDown += FormHome_MouseDown;
            MainMenu.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainMenu;
        private Panel panelTitle;
        private Label labelTitle;
        private Panel panelButtons;
        private Button buttonExit;
        private Button buttonSettings;
        private Button buttonPlay;
    }
}
