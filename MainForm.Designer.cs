namespace KeepWindowActiveApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            // 
            // MainForm (container)
            // 
            this.SuspendLayout();
            this.BackColor = System.Drawing.Color.FromArgb(40, 40, 55);
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep Window Active";

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(450, 48);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Keep Window Active";

            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInstruction.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInstruction.Location = new System.Drawing.Point(40, 80);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(160, 20);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Enter time in seconds:";

            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(40, 110);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 22);
            this.txtTime.TabIndex = 3;

            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(40, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "▶ Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(404, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // Add controls to the form
            // 
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
