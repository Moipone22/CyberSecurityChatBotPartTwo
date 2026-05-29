namespace CybersecurityChatbotGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picAvatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();

            // Suspend layout while we build UI
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();

            // --- Form ---
            this.Text = "Cybersecurity Awareness Bot";
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.BackColor = System.Drawing.Color.FromArgb(236, 229, 221);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Load += new System.EventHandler(this.Form1_Load);

            // --- Top panel (header) ---
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 70;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(18, 140, 126);
            this.panelTop.Name = "panelTop";
            this.panelTop.TabIndex = 2;

            // --- Avatar ---
            this.picAvatar.Size = new System.Drawing.Size(52, 52);
            this.picAvatar.Location = new System.Drawing.Point(10, 9);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(37, 211, 102);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);

            // --- Title label ---
            this.lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(72, 8);
            this.lblTitle.Size = new System.Drawing.Size(780, 28);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;

            // --- Status label ---
            this.lblStatus.Text = "online";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(200, 255, 200);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(72, 40);
            this.lblStatus.Size = new System.Drawing.Size(300, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 1;

            // --- Chat box ---
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChat.BackColor = System.Drawing.Color.FromArgb(236, 229, 221);
            this.rtbChat.ForeColor = System.Drawing.Color.Black;
            this.rtbChat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbChat.ReadOnly = true;
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.WordWrap = true;
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";

            // --- Bottom panel (input area) ---
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.TabIndex = 1;

            // --- Input box ---
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Name = "txtInput";
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);

            // --- Send button ---
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Width = 90;
            this.btnSend.Text = "Send";
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(18, 140, 126);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Name = "btnSend";
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // --- Add controls ---
            this.panelTop.Controls.Add(this.picAvatar);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblStatus);

            this.panelBottom.Controls.Add(this.txtInput);
            this.panelBottom.Controls.Add(this.btnSend);

            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);

            // Resume layout
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
        }

        // Called from Form1_Load (NOT inside InitializeComponent)
        private void LoadAvatarImage()
        {
            try
            {
                string imgPath = System.IO.Path.Combine(
                    System.AppDomain.CurrentDomain.BaseDirectory,
                    "profile.jpg");

                if (System.IO.File.Exists(imgPath))
                {
                    picAvatar.Image = System.Drawing.Image.FromFile(imgPath);
                }
                else
                {
                    DrawDefaultAvatar();
                }
            }
            catch
            {
                DrawDefaultAvatar();
            }
        }

        private void DrawDefaultAvatar()
        {
            var bmp = new System.Drawing.Bitmap(52, 52);

            using (var g = System.Drawing.Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(System.Drawing.Color.FromArgb(37, 211, 102));

                using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                    g.FillEllipse(brush, 2, 2, 48, 48);

                g.DrawString(
                    "🔒",
                    new System.Drawing.Font("Segoe UI", 20),
                    System.Drawing.Brushes.DarkGreen,
                    new System.Drawing.PointF(7, 10));
            }

            picAvatar.Image = bmp;
        }
    }
}