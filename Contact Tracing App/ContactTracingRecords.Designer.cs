namespace Contact_Tracing_App
{
    partial class ContactTracingRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingRecords));
            this.LbCtfRecordList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCtfViewAll = new System.Windows.Forms.Button();
            this.BtnCtfBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbCtfRecordList
            // 
            this.LbCtfRecordList.BackColor = System.Drawing.Color.Snow;
            this.LbCtfRecordList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCtfRecordList.FormattingEnabled = true;
            this.LbCtfRecordList.ItemHeight = 23;
            this.LbCtfRecordList.Location = new System.Drawing.Point(36, 110);
            this.LbCtfRecordList.Name = "LbCtfRecordList";
            this.LbCtfRecordList.Size = new System.Drawing.Size(569, 280);
            this.LbCtfRecordList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(27, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 296);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-2, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 12);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Location = new System.Drawing.Point(-5, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 12);
            this.panel3.TabIndex = 3;
            // 
            // BtnCtfViewAll
            // 
            this.BtnCtfViewAll.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfViewAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfViewAll.Location = new System.Drawing.Point(27, 52);
            this.BtnCtfViewAll.Name = "BtnCtfViewAll";
            this.BtnCtfViewAll.Size = new System.Drawing.Size(177, 32);
            this.BtnCtfViewAll.TabIndex = 41;
            this.BtnCtfViewAll.Text = "View All Records";
            this.BtnCtfViewAll.UseVisualStyleBackColor = false;
            this.BtnCtfViewAll.Click += new System.EventHandler(this.BtnCtfViewAll_Click);
            // 
            // BtnCtfBack
            // 
            this.BtnCtfBack.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfBack.Location = new System.Drawing.Point(234, 435);
            this.BtnCtfBack.Name = "BtnCtfBack";
            this.BtnCtfBack.Size = new System.Drawing.Size(177, 32);
            this.BtnCtfBack.TabIndex = 42;
            this.BtnCtfBack.Text = "Back to Menu";
            this.BtnCtfBack.UseVisualStyleBackColor = false;
            this.BtnCtfBack.Click += new System.EventHandler(this.BtnCtfBack_Click);
            // 
            // ContactTracingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 490);
            this.Controls.Add(this.BtnCtfBack);
            this.Controls.Add(this.BtnCtfViewAll);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LbCtfRecordList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactTracingRecords";
            this.Load += new System.EventHandler(this.ContactTracingRecords_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LbCtfRecordList;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        public Button BtnCtfViewAll;
        public Button BtnCtfBack;
    }
}