using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsArcanoid.Game;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Maps;

namespace WinFormsArcanoid.Forms
{
    public partial class FormGame : Form
    {
        Arcanoid arcanoidGame;

        public FormGame()
        {
            InitializeComponent();
            pictureBoxWallpaper.Height = this.Height;
            pictureBoxWallpaper.Width = this.Width;
            pictureBoxWallpaper.Location = new Point(0, 0);
            arcanoidGame = new Arcanoid(this, MapDefaults.FILL);
            arcanoidGame.Start();

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);

        private void FormGame_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    arcanoidGame.Platform.IsRight = true;
                    break;
                case Keys.A:
                    arcanoidGame.Platform.IsLeft = true;
                    break;
            }
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    arcanoidGame.Platform.IsRight = false;
                    break;
                case Keys.A:
                    arcanoidGame.Platform.IsLeft = false;
                    break;
            }
        }

       
    }
}
