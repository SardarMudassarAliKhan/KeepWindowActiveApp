using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeepWindowActiveApp
{
    public partial class MainForm : Form
    {
        private int remainingSeconds;

        public MainForm()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            // Form
            this.BackColor = Color.FromArgb(32, 32, 32); // Dark gray (modern)
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Label
            lblMessage.ForeColor = Color.White;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // Textboxes
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox txt)
                {
                    txt.BackColor = Color.FromArgb(45, 45, 48); // VS Code style dark
                    txt.ForeColor = Color.White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            // Buttons
            StyleButton(btnStart, Color.FromArgb(0, 122, 204));   // Blue
            StyleButton(btnCancel, Color.FromArgb(204, 0, 0));   // Red
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(6);
            btn.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10));
        }

        // Rounded corners support
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void btnStart_Click(object sender, EventArgs e)
        {
            int hours = int.TryParse(txtHours.Text, out var h) ? h : 0;
            int minutes = int.TryParse(txtMinutes.Text, out var m) ? m : 0;
            int seconds = int.TryParse(txtSeconds.Text, out var s) ? s : 0;

            remainingSeconds = (hours * 3600) + (minutes * 60) + seconds;

            if (remainingSeconds <= 0)
            {
                MessageBox.Show("Please enter a valid time!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblMessage.Text = $"⏳ Countdown started: {remainingSeconds} seconds";
            countdownTimer.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            lblMessage.Text = "❌ Countdown cancelled!";
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                TimeSpan ts = TimeSpan.FromSeconds(remainingSeconds);
                lblMessage.Text = $"⏳ Remaining: {ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}";
            }
            else
            {
                countdownTimer.Stop();
                lblMessage.Text = "✅ Countdown finished!";
            }
        }
    }
}
