using System.Runtime.InteropServices;

namespace KeepWindowActiveApp
{
    public partial class MainForm : Form
    {
        // Bring window to front
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        // For rounded corners
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // For dragging the borderless window
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();

            // events for dragging from the top panel and title label
            this.pnlTop.MouseDown += Form_MouseDown;
            this.lblTitle.MouseDown += Form_MouseDown;

            // if the user resizes (unlikely since borderless), keep rounded corners
            this.SizeChanged += (s, e) => ApplyRoundedCorners();
            this.Load += (s, e) => ApplyRoundedCorners();
        }

        private void ApplyRoundedCorners()
        {
            // Dispose previous region if any
            var rgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            this.Region = Region.FromHrgn(rgn);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTime.Text.Trim(), out int seconds) || seconds <= 0)
            {
                MessageBox.Show("Please enter a positive integer for seconds.", "Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnStart.Enabled = false;
            txtTime.Enabled = false;
            btnStart.Text = "Keeping Active...";

            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            // loop and keep bringing window to foreground until time expires
            while (DateTime.Now < endTime)
            {
                SetForegroundWindow(this.Handle);
                await Task.Delay(500);
                Application.DoEvents(); // keep UI responsive
            }

            btnStart.Enabled = true;
            txtTime.Enabled = true;
            btnStart.Text = "▶ Start";

            MessageBox.Show($"Done! Window stayed focused for {seconds} seconds.",
                "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
