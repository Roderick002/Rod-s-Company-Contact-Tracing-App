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
            this.GbCtfListReference = new System.Windows.Forms.GroupBox();
            this.LbCtfReferenceList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCtfViewAll = new System.Windows.Forms.Button();
            this.BtnCtfBack = new System.Windows.Forms.Button();
            this.BtnCtfViewDetails = new System.Windows.Forms.Button();
            this.DtpCtfDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCtfFilter = new System.Windows.Forms.Button();
            this.GbCtfListReference.SuspendLayout();
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
            this.LbCtfRecordList.SelectedIndexChanged += new System.EventHandler(this.LbCtfRecordList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(27, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 296);
            this.panel1.TabIndex = 1;
            // 
            // GbCtfListReference
            // 
            this.GbCtfListReference.Controls.Add(this.LbCtfReferenceList);
            this.GbCtfListReference.Location = new System.Drawing.Point(683, 105);
            this.GbCtfListReference.Name = "GbCtfListReference";
            this.GbCtfListReference.Size = new System.Drawing.Size(444, 285);
            this.GbCtfListReference.TabIndex = 43;
            this.GbCtfListReference.TabStop = false;
            this.GbCtfListReference.Text = "Reference List";
            this.GbCtfListReference.Enter += new System.EventHandler(this.GbCtfListReference_Enter);
            // 
            // LbCtfReferenceList
            // 
            this.LbCtfReferenceList.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCtfReferenceList.FormattingEnabled = true;
            this.LbCtfReferenceList.ItemHeight = 16;
            this.LbCtfReferenceList.Location = new System.Drawing.Point(29, 40);
            this.LbCtfReferenceList.Name = "LbCtfReferenceList";
            this.LbCtfReferenceList.Size = new System.Drawing.Size(379, 212);
            this.LbCtfReferenceList.TabIndex = 0;
            this.LbCtfReferenceList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.panel3.Location = new System.Drawing.Point(-5, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 12);
            this.panel3.TabIndex = 3;
            // 
            // BtnCtfViewAll
            // 
            this.BtnCtfViewAll.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfViewAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfViewAll.Location = new System.Drawing.Point(62, 52);
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
            this.BtnCtfBack.Location = new System.Drawing.Point(234, 458);
            this.BtnCtfBack.Name = "BtnCtfBack";
            this.BtnCtfBack.Size = new System.Drawing.Size(177, 32);
            this.BtnCtfBack.TabIndex = 42;
            this.BtnCtfBack.Text = "Back to Menu";
            this.BtnCtfBack.UseVisualStyleBackColor = false;
            this.BtnCtfBack.Click += new System.EventHandler(this.BtnCtfBack_Click);
            // 
            // BtnCtfViewDetails
            // 
            this.BtnCtfViewDetails.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfViewDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfViewDetails.Location = new System.Drawing.Point(234, 416);
            this.BtnCtfViewDetails.Name = "BtnCtfViewDetails";
            this.BtnCtfViewDetails.Size = new System.Drawing.Size(177, 32);
            this.BtnCtfViewDetails.TabIndex = 44;
            this.BtnCtfViewDetails.Text = "VIew Details";
            this.BtnCtfViewDetails.UseVisualStyleBackColor = false;
            this.BtnCtfViewDetails.Click += new System.EventHandler(this.BtnCtfViewDetails_Click);
            // 
            // DtpCtfDate
            // 
            this.DtpCtfDate.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtpCtfDate.CustomFormat = "dd/MM/yyyy";
            this.DtpCtfDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCtfDate.Location = new System.Drawing.Point(440, 55);
            this.DtpCtfDate.Name = "DtpCtfDate";
            this.DtpCtfDate.Size = new System.Drawing.Size(130, 27);
            this.DtpCtfDate.TabIndex = 50;
            // 
            // BtnCtfFilter
            // 
            this.BtnCtfFilter.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfFilter.Location = new System.Drawing.Point(285, 52);
            this.BtnCtfFilter.Name = "BtnCtfFilter";
            this.BtnCtfFilter.Size = new System.Drawing.Size(151, 32);
            this.BtnCtfFilter.TabIndex = 51;
            this.BtnCtfFilter.Text = "Filter By Date:";
            this.BtnCtfFilter.UseVisualStyleBackColor = false;
            this.BtnCtfFilter.Click += new System.EventHandler(this.BtnCtfFilter_Click);
            // 
            // ContactTracingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 514);
            this.Controls.Add(this.BtnCtfFilter);
            this.Controls.Add(this.DtpCtfDate);
            this.Controls.Add(this.GbCtfListReference);
            this.Controls.Add(this.BtnCtfViewDetails);
            this.Controls.Add(this.BtnCtfBack);
            this.Controls.Add(this.BtnCtfViewAll);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LbCtfRecordList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactTracingRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactTracingRecords";
            this.Load += new System.EventHandler(this.ContactTracingRecords_Load);
            this.GbCtfListReference.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LbCtfRecordList;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        public Button BtnCtfViewAll;
        public Button BtnCtfBack;
        private GroupBox GbCtfListReference;
        private ListBox LbCtfReferenceList;
        public Button BtnCtfViewDetails;
        private DateTimePicker DtpCtfDate;
        public Button BtnCtfFilter;
    }
}