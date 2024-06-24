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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(394, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += FormGame_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 158, 252);
            panel1.Location = new Point(183, 869);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 16);
            panel1.TabIndex = 1;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 57, 87);
            ClientSize = new Size(513, 897);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGame";
            StartPosition = FormStartPosition.Manual;
            Text = "FormGame";
            MouseDown += FormGame_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
    }
}