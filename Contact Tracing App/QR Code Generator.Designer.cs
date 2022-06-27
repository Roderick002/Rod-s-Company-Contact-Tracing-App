namespace Contact_Tracing_App
{
    partial class QR_Code_Scanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Code_Scanner));
            this.LblQrsCamera = new System.Windows.Forms.Label();
            this.CbQcsCamera = new System.Windows.Forms.ComboBox();
            this.BtnQcsStart = new System.Windows.Forms.Button();
            this.PbQcsScanner = new System.Windows.Forms.PictureBox();
            this.TimerQcs = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbQcsReferenceList = new System.Windows.Forms.ListBox();
            this.BtnQcsBack = new System.Windows.Forms.Button();
            this.DtpQcsDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnQcsSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbQcsScanner)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblQrsCamera
            // 
            this.LblQrsCamera.AutoSize = true;
            this.LblQrsCamera.BackColor = System.Drawing.Color.MistyRose;
            this.LblQrsCamera.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQrsCamera.Location = new System.Drawing.Point(98, 405);
            this.LblQrsCamera.Name = "LblQrsCamera";
            this.LblQrsCamera.Size = new System.Drawing.Size(75, 19);
            this.LblQrsCamera.TabIndex = 0;
            this.LblQrsCamera.Text = "Camera:";
            this.LblQrsCamera.Click += new System.EventHandler(this.LblQrsCamera_Click);
            // 
            // CbQcsCamera
            // 
            this.CbQcsCamera.BackColor = System.Drawing.Color.MistyRose;
            this.CbQcsCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbQcsCamera.FormattingEnabled = true;
            this.CbQcsCamera.Location = new System.Drawing.Point(179, 400);
            this.CbQcsCamera.Name = "CbQcsCamera";
            this.CbQcsCamera.Size = new System.Drawing.Size(229, 28);
            this.CbQcsCamera.TabIndex = 1;
            // 
            // BtnQcsStart
            // 
            this.BtnQcsStart.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcsStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnQcsStart.Location = new System.Drawing.Point(592, 323);
            this.BtnQcsStart.Name = "BtnQcsStart";
            this.BtnQcsStart.Size = new System.Drawing.Size(104, 33);
            this.BtnQcsStart.TabIndex = 2;
            this.BtnQcsStart.Text = "Start";
            this.BtnQcsStart.UseVisualStyleBackColor = false;
            this.BtnQcsStart.Click += new System.EventHandler(this.BtnQcsStart_Click);
            // 
            // PbQcsScanner
            // 
            this.PbQcsScanner.BackColor = System.Drawing.Color.MistyRose;
            this.PbQcsScanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbQcsScanner.Location = new System.Drawing.Point(19, 28);
            this.PbQcsScanner.Name = "PbQcsScanner";
            this.PbQcsScanner.Size = new System.Drawing.Size(467, 356);
            this.PbQcsScanner.TabIndex = 3;
            this.PbQcsScanner.TabStop = false;
            this.PbQcsScanner.Click += new System.EventHandler(this.PbQcsScanner_Click);
            // 
            // TimerQcs
            // 
            this.TimerQcs.Interval = 1000;
            this.TimerQcs.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-3, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 16);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-3, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 16);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.LbQcsReferenceList);
            this.panel3.Location = new System.Drawing.Point(503, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 239);
            this.panel3.TabIndex = 6;
            // 
            // LbQcsReferenceList
            // 
            this.LbQcsReferenceList.FormattingEnabled = true;
            this.LbQcsReferenceList.ItemHeight = 20;
            this.LbQcsReferenceList.Location = new System.Drawing.Point(7, 7);
            this.LbQcsReferenceList.Name = "LbQcsReferenceList";
            this.LbQcsReferenceList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LbQcsReferenceList.Size = new System.Drawing.Size(264, 224);
            this.LbQcsReferenceList.TabIndex = 8;
            // 
            // BtnQcsBack
            // 
            this.BtnQcsBack.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcsBack.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnQcsBack.Location = new System.Drawing.Point(570, 400);
            this.BtnQcsBack.Name = "BtnQcsBack";
            this.BtnQcsBack.Size = new System.Drawing.Size(149, 34);
            this.BtnQcsBack.TabIndex = 7;
            this.BtnQcsBack.Text = "Back to Menu";
            this.BtnQcsBack.UseVisualStyleBackColor = false;
            this.BtnQcsBack.Click += new System.EventHandler(this.BtnQcsBack_Click);
            // 
            // DtpQcsDate
            // 
            this.DtpQcsDate.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtpQcsDate.Location = new System.Drawing.Point(517, 35);
            this.DtpQcsDate.Name = "DtpQcsDate";
            this.DtpQcsDate.Size = new System.Drawing.Size(250, 27);
            this.DtpQcsDate.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Location = new System.Drawing.Point(510, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 40);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MistyRose;
            this.panel5.Location = new System.Drawing.Point(91, 394);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 40);
            this.panel5.TabIndex = 10;
            // 
            // BtnQcsSubmit
            // 
            this.BtnQcsSubmit.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcsSubmit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnQcsSubmit.Location = new System.Drawing.Point(566, 361);
            this.BtnQcsSubmit.Name = "BtnQcsSubmit";
            this.BtnQcsSubmit.Size = new System.Drawing.Size(160, 33);
            this.BtnQcsSubmit.TabIndex = 11;
            this.BtnQcsSubmit.Text = "Submit Record";
            this.BtnQcsSubmit.UseVisualStyleBackColor = false;
            this.BtnQcsSubmit.Click += new System.EventHandler(this.BtnQcsSubmit_Click);
            // 
            // QR_Code_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.BtnQcsSubmit);
            this.Controls.Add(this.DtpQcsDate);
            this.Controls.Add(this.BtnQcsBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PbQcsScanner);
            this.Controls.Add(this.BtnQcsStart);
            this.Controls.Add(this.CbQcsCamera);
            this.Controls.Add(this.LblQrsCamera);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QR_Code_Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_Code_Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_Code_Scanner_FormClosing);
            this.Load += new System.EventHandler(this.QR_Code_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbQcsScanner)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblQrsCamera;
        private ComboBox CbQcsCamera;
        private Button BtnQcsStart;
        private PictureBox PbQcsScanner;
        private System.Windows.Forms.Timer TimerQcs;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button BtnQcsBack;
        private ListBox LbQcsReferenceList;
        private DateTimePicker DtpQcsDate;
        private Panel panel4;
        private Panel panel5;
        private Button BtnQcsSubmit;
    }
}