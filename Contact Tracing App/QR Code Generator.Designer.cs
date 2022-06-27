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
            System.Windows.Forms.TextBox TbQcsData;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Code_Scanner));
            this.LblQrsCamera = new System.Windows.Forms.Label();
            this.CbQcsCamera = new System.Windows.Forms.ComboBox();
            this.BtnQcsStart = new System.Windows.Forms.Button();
            this.PbQcsScanner = new System.Windows.Forms.PictureBox();
            this.TimerQcs = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnQcsBack = new System.Windows.Forms.Button();
            TbQcsData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbQcsScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // TbQcsData
            // 
            TbQcsData.Location = new System.Drawing.Point(512, 86);
            TbQcsData.Multiline = true;
            TbQcsData.Name = "TbQcsData";
            TbQcsData.Size = new System.Drawing.Size(261, 221);
            TbQcsData.TabIndex = 4;
            TbQcsData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblQrsCamera
            // 
            this.LblQrsCamera.AutoSize = true;
            this.LblQrsCamera.BackColor = System.Drawing.Color.Transparent;
            this.LblQrsCamera.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQrsCamera.Location = new System.Drawing.Point(96, 403);
            this.LblQrsCamera.Name = "LblQrsCamera";
            this.LblQrsCamera.Size = new System.Drawing.Size(85, 21);
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
            this.BtnQcsStart.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnQcsStart.Location = new System.Drawing.Point(592, 327);
            this.BtnQcsStart.Name = "BtnQcsStart";
            this.BtnQcsStart.Size = new System.Drawing.Size(104, 37);
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
            this.panel3.Location = new System.Drawing.Point(503, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 239);
            this.panel3.TabIndex = 6;
            // 
            // BtnQcsBack
            // 
            this.BtnQcsBack.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcsBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnQcsBack.Location = new System.Drawing.Point(570, 392);
            this.BtnQcsBack.Name = "BtnQcsBack";
            this.BtnQcsBack.Size = new System.Drawing.Size(149, 36);
            this.BtnQcsBack.TabIndex = 7;
            this.BtnQcsBack.Text = "Back to Menu";
            this.BtnQcsBack.UseVisualStyleBackColor = false;
            this.BtnQcsBack.Click += new System.EventHandler(this.BtnQcsBack_Click);
            // 
            // QR_Code_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQcsBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(TbQcsData);
            this.Controls.Add(this.PbQcsScanner);
            this.Controls.Add(this.BtnQcsStart);
            this.Controls.Add(this.CbQcsCamera);
            this.Controls.Add(this.LblQrsCamera);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QR_Code_Scanner";
            this.Text = "QR_Code_Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_Code_Scanner_FormClosing);
            this.Load += new System.EventHandler(this.QR_Code_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbQcsScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblQrsCamera;
        private ComboBox CbQcsCamera;
        private Button BtnQcsStart;
        private PictureBox PbQcsScanner;
        private TextBox TbQcsData;
        private System.Windows.Forms.Timer TimerQcs;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button BtnQcsBack;
    }
}