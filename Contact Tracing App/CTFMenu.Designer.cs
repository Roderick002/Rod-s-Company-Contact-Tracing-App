namespace Contact_Tracing_App
{
    partial class CTFMenu
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
            System.Windows.Forms.Button BtnCtfScanQRcode;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTFMenu));
            this.LblCtfTitle = new System.Windows.Forms.Label();
            this.LblCtfSubTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCtfStart = new System.Windows.Forms.Button();
            this.BtnCtfViewRecords = new System.Windows.Forms.Button();
            this.BtnCtfExit = new System.Windows.Forms.Button();
            this.LblCtfStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            BtnCtfScanQRcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCtfScanQRcode
            // 
            BtnCtfScanQRcode.BackColor = System.Drawing.Color.MistyRose;
            BtnCtfScanQRcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCtfScanQRcode.Location = new System.Drawing.Point(239, 379);
            BtnCtfScanQRcode.Name = "BtnCtfScanQRcode";
            BtnCtfScanQRcode.Size = new System.Drawing.Size(200, 42);
            BtnCtfScanQRcode.TabIndex = 37;
            BtnCtfScanQRcode.Text = "Scan QR Code";
            BtnCtfScanQRcode.UseVisualStyleBackColor = false;
            BtnCtfScanQRcode.Click += new System.EventHandler(this.BtnCtfScanQRcode_Click);
            // 
            // LblCtfTitle
            // 
            this.LblCtfTitle.AutoSize = true;
            this.LblCtfTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfTitle.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTitle.Location = new System.Drawing.Point(10, 25);
            this.LblCtfTitle.Name = "LblCtfTitle";
            this.LblCtfTitle.Size = new System.Drawing.Size(439, 54);
            this.LblCtfTitle.TabIndex = 29;
            this.LblCtfTitle.Text = "ROD\'s COMPANY";
            // 
            // LblCtfSubTitle
            // 
            this.LblCtfSubTitle.AutoSize = true;
            this.LblCtfSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfSubTitle.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblCtfSubTitle.Location = new System.Drawing.Point(81, 81);
            this.LblCtfSubTitle.Name = "LblCtfSubTitle";
            this.LblCtfSubTitle.Size = new System.Drawing.Size(288, 32);
            this.LblCtfSubTitle.TabIndex = 30;
            this.LblCtfSubTitle.Text = "Contact Tracing App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-1, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 15);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-1, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 15);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(149, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 152);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Location = new System.Drawing.Point(135, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 175);
            this.panel3.TabIndex = 32;
            // 
            // BtnCtfStart
            // 
            this.BtnCtfStart.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfStart.Location = new System.Drawing.Point(19, 379);
            this.BtnCtfStart.Name = "BtnCtfStart";
            this.BtnCtfStart.Size = new System.Drawing.Size(207, 42);
            this.BtnCtfStart.TabIndex = 34;
            this.BtnCtfStart.Text = "Fill Up Form";
            this.BtnCtfStart.UseVisualStyleBackColor = false;
            this.BtnCtfStart.Click += new System.EventHandler(this.BtnCtfStart_Click);
            // 
            // BtnCtfViewRecords
            // 
            this.BtnCtfViewRecords.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfViewRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfViewRecords.Location = new System.Drawing.Point(132, 441);
            this.BtnCtfViewRecords.Name = "BtnCtfViewRecords";
            this.BtnCtfViewRecords.Size = new System.Drawing.Size(178, 43);
            this.BtnCtfViewRecords.TabIndex = 35;
            this.BtnCtfViewRecords.Text = "View Records";
            this.BtnCtfViewRecords.UseVisualStyleBackColor = false;
            this.BtnCtfViewRecords.Click += new System.EventHandler(this.BtnCtfViewRecords_Click);
            // 
            // BtnCtfExit
            // 
            this.BtnCtfExit.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfExit.Location = new System.Drawing.Point(160, 501);
            this.BtnCtfExit.Name = "BtnCtfExit";
            this.BtnCtfExit.Size = new System.Drawing.Size(123, 38);
            this.BtnCtfExit.TabIndex = 36;
            this.BtnCtfExit.Text = "Exit";
            this.BtnCtfExit.UseVisualStyleBackColor = false;
            this.BtnCtfExit.Click += new System.EventHandler(this.BtnCtfExit_Click);
            // 
            // LblCtfStart
            // 
            this.LblCtfStart.AutoSize = true;
            this.LblCtfStart.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfStart.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfStart.ForeColor = System.Drawing.Color.Black;
            this.LblCtfStart.Location = new System.Drawing.Point(35, 325);
            this.LblCtfStart.Name = "LblCtfStart";
            this.LblCtfStart.Size = new System.Drawing.Size(386, 51);
            this.LblCtfStart.TabIndex = 39;
            this.LblCtfStart.Text = "Start Contact Tracing!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(83, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Click logo to generate your QR code!";
            // 
            // CTFMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCtfStart);
            this.Controls.Add(BtnCtfScanQRcode);
            this.Controls.Add(this.BtnCtfExit);
            this.Controls.Add(this.BtnCtfViewRecords);
            this.Controls.Add(this.BtnCtfStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCtfSubTitle);
            this.Controls.Add(this.LblCtfTitle);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CTFMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rod\'s Company Contact Tracing Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTFMenu_FormClosing);
            this.Load += new System.EventHandler(this.CTFMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCtfTitle;
        private Label LblCtfSubTitle;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button BtnCtfStart;
        private Button BtnCtfViewRecords;
        private Button BtnCtfExit;
        private Label LblCtfStart;
        private Label label1;
    }
}