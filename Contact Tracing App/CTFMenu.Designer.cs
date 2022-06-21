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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.LblCtfSubTitle.Location = new System.Drawing.Point(81, 86);
            this.LblCtfSubTitle.Name = "LblCtfSubTitle";
            this.LblCtfSubTitle.Size = new System.Drawing.Size(288, 32);
            this.LblCtfSubTitle.TabIndex = 30;
            this.LblCtfSubTitle.Text = "Contact Tracing App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-1, 535);
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
            this.pictureBox1.Location = new System.Drawing.Point(149, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 152);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Location = new System.Drawing.Point(135, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 175);
            this.panel3.TabIndex = 32;
            // 
            // BtnCtfStart
            // 
            this.BtnCtfStart.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfStart.Location = new System.Drawing.Point(88, 333);
            this.BtnCtfStart.Name = "BtnCtfStart";
            this.BtnCtfStart.Size = new System.Drawing.Size(279, 51);
            this.BtnCtfStart.TabIndex = 34;
            this.BtnCtfStart.Text = "Start Contact Tracing!";
            this.BtnCtfStart.UseVisualStyleBackColor = false;
            this.BtnCtfStart.Click += new System.EventHandler(this.BtnCtfStart_Click);
            // 
            // BtnCtfViewRecords
            // 
            this.BtnCtfViewRecords.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfViewRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfViewRecords.Location = new System.Drawing.Point(135, 400);
            this.BtnCtfViewRecords.Name = "BtnCtfViewRecords";
            this.BtnCtfViewRecords.Size = new System.Drawing.Size(178, 51);
            this.BtnCtfViewRecords.TabIndex = 35;
            this.BtnCtfViewRecords.Text = "View Records";
            this.BtnCtfViewRecords.UseVisualStyleBackColor = false;
            this.BtnCtfViewRecords.Click += new System.EventHandler(this.BtnCtfViewRecords_Click);
            // 
            // BtnCtfExit
            // 
            this.BtnCtfExit.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfExit.Location = new System.Drawing.Point(164, 470);
            this.BtnCtfExit.Name = "BtnCtfExit";
            this.BtnCtfExit.Size = new System.Drawing.Size(123, 38);
            this.BtnCtfExit.TabIndex = 36;
            this.BtnCtfExit.Text = "Exit";
            this.BtnCtfExit.UseVisualStyleBackColor = false;
            this.BtnCtfExit.Click += new System.EventHandler(this.BtnCtfExit_Click);
            // 
            // CTFMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 543);
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
    }
}