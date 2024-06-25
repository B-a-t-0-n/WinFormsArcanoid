using System.Drawing.Configuration;
using System.Runtime.InteropServices;
using WinFormsArcanoid.Forms;

namespace WinFormsArcanoid
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);

        private void FormHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var form = new FormSettings
            {
                Left = this.Left,
                Top = this.Top
            };

            this.Hide();
            form.ShowDialog();

            this.Top = form.Top;
            this.Left = form.Left;

            this.Show();

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var form = new FormGame
            {
                Left = this.Left,
                Top = this.Top
            };

            this.Hide();
            form.ShowDialog();

            this.Top = form.Top;
            this.Left = form.Left;

            this.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
