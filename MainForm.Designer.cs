namespace KeepWindowActiveApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMinutes;

        // ✅ Declare all input fields here
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMinutes = new System.Windows.Forms.Label();

            // ========= Form =========
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46); // Dark Modern Background
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep Window Active";

            // ========= lblMessage =========
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(120, 30);
            this.lblMessage.Text = "Enter Time and Start";

            // ========= Hours =========
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtHours.Location = new System.Drawing.Point(60, 90);
            this.txtHours.Size = new System.Drawing.Size(60, 30);
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHours.PlaceholderText = "HH";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // ========= Minutes =========
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtMinutes.Location = new System.Drawing.Point(140, 90);
            this.txtMinutes.Size = new System.Drawing.Size(60, 30);
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMinutes.PlaceholderText = "MM";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // ========= Seconds =========
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtSeconds.Location = new System.Drawing.Point(220, 90);
            this.txtSeconds.Size = new System.Drawing.Size(60, 30);
            this.txtSeconds.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSeconds.PlaceholderText = "SS";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // ========= Start Button =========
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(58, 130, 247);
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(60, 150);
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // ========= Cancel Button =========
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(200, 60, 70);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(230, 150);
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ========= Add Controls =========
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
