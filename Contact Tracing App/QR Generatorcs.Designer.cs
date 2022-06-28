namespace Contact_Tracing_App
{
    partial class QR_Generatorcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Generatorcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QrgPanelSaveQr = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TbQcgName = new System.Windows.Forms.TextBox();
            this.PbQcgQrcode = new System.Windows.Forms.PictureBox();
            this.LblCtfSubTitle = new System.Windows.Forms.Label();
            this.LblCtfTitle = new System.Windows.Forms.Label();
            this.GbQcgReference = new System.Windows.Forms.GroupBox();
            this.TbQcgReference = new System.Windows.Forms.TextBox();
            this.TbCtfName = new System.Windows.Forms.TextBox();
            this.TbCtfAddress = new System.Windows.Forms.TextBox();
            this.TbCtfAge = new System.Windows.Forms.TextBox();
            this.GbQcgSexChoices = new System.Windows.Forms.GroupBox();
            this.RbCtfSexMale = new System.Windows.Forms.RadioButton();
            this.RbCtfSexFemale = new System.Windows.Forms.RadioButton();
            this.TbCtfContactNo = new System.Windows.Forms.TextBox();
            this.LblCtfName = new System.Windows.Forms.Label();
            this.LblCtfAddress = new System.Windows.Forms.Label();
            this.LblCtfAge = new System.Windows.Forms.Label();
            this.LblCtfSex = new System.Windows.Forms.Label();
            this.LblCtfContactNo = new System.Windows.Forms.Label();
            this.GbQcgAnswers3 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer3Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer3No = new System.Windows.Forms.RadioButton();
            this.GbQcgAnswers2 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer2Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer2No = new System.Windows.Forms.RadioButton();
            this.GbQcgAnswers1 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer1Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer1No = new System.Windows.Forms.RadioButton();
            this.LblCtfQ3 = new System.Windows.Forms.Label();
            this.LblCtfQ2 = new System.Windows.Forms.Label();
            this.LblCtfQ1 = new System.Windows.Forms.Label();
            this.BtnQcgGenerate = new System.Windows.Forms.Button();
            this.BtnQcgSaveQr = new System.Windows.Forms.Button();
            this.BtnQcgBack = new System.Windows.Forms.Button();
            this.QrgPanelSaveQr.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbQcgQrcode)).BeginInit();
            this.GbQcgReference.SuspendLayout();
            this.GbQcgSexChoices.SuspendLayout();
            this.GbQcgAnswers3.SuspendLayout();
            this.GbQcgAnswers2.SuspendLayout();
            this.GbQcgAnswers1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 12);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-5, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Location = new System.Drawing.Point(334, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 467);
            this.panel3.TabIndex = 2;
            // 
            // QrgPanelSaveQr
            // 
            this.QrgPanelSaveQr.BackColor = System.Drawing.Color.MistyRose;
            this.QrgPanelSaveQr.Controls.Add(this.panel5);
            this.QrgPanelSaveQr.Location = new System.Drawing.Point(358, 17);
            this.QrgPanelSaveQr.Name = "QrgPanelSaveQr";
            this.QrgPanelSaveQr.Size = new System.Drawing.Size(307, 402);
            this.QrgPanelSaveQr.TabIndex = 3;
            this.QrgPanelSaveQr.Paint += new System.Windows.Forms.PaintEventHandler(this.QrgPanelSaveQr_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MistyRose;
            this.panel5.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.TbQcgName);
            this.panel5.Controls.Add(this.PbQcgQrcode);
            this.panel5.Controls.Add(this.LblCtfSubTitle);
            this.panel5.Controls.Add(this.LblCtfTitle);
            this.panel5.Controls.Add(this.GbQcgReference);
            this.panel5.Location = new System.Drawing.Point(8, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 387);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // TbQcgName
            // 
            this.TbQcgName.BackColor = System.Drawing.Color.MistyRose;
            this.TbQcgName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbQcgName.Location = new System.Drawing.Point(21, 341);
            this.TbQcgName.Name = "TbQcgName";
            this.TbQcgName.ReadOnly = true;
            this.TbQcgName.Size = new System.Drawing.Size(250, 30);
            this.TbQcgName.TabIndex = 33;
            this.TbQcgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbQcgName.TextChanged += new System.EventHandler(this.TbQcgName_TextChanged);
            // 
            // PbQcgQrcode
            // 
            this.PbQcgQrcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbQcgQrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbQcgQrcode.ImageLocation = "";
            this.PbQcgQrcode.Location = new System.Drawing.Point(16, 74);
            this.PbQcgQrcode.Name = "PbQcgQrcode";
            this.PbQcgQrcode.Size = new System.Drawing.Size(260, 260);
            this.PbQcgQrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbQcgQrcode.TabIndex = 32;
            this.PbQcgQrcode.TabStop = false;
            this.PbQcgQrcode.Click += new System.EventHandler(this.PbQcgQrcode_Click);
            // 
            // LblCtfSubTitle
            // 
            this.LblCtfSubTitle.AutoSize = true;
            this.LblCtfSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfSubTitle.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblCtfSubTitle.Location = new System.Drawing.Point(60, 45);
            this.LblCtfSubTitle.Name = "LblCtfSubTitle";
            this.LblCtfSubTitle.Size = new System.Drawing.Size(160, 24);
            this.LblCtfSubTitle.TabIndex = 31;
            this.LblCtfSubTitle.Text = "Contact Tracing";
            // 
            // LblCtfTitle
            // 
            this.LblCtfTitle.AutoSize = true;
            this.LblCtfTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfTitle.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTitle.Location = new System.Drawing.Point(15, 11);
            this.LblCtfTitle.Name = "LblCtfTitle";
            this.LblCtfTitle.Size = new System.Drawing.Size(260, 32);
            this.LblCtfTitle.TabIndex = 30;
            this.LblCtfTitle.Text = "ROD\'s COMPANY";
            // 
            // GbQcgReference
            // 
            this.GbQcgReference.Controls.Add(this.TbQcgReference);
            this.GbQcgReference.Location = new System.Drawing.Point(59, 119);
            this.GbQcgReference.Name = "GbQcgReference";
            this.GbQcgReference.Size = new System.Drawing.Size(184, 168);
            this.GbQcgReference.TabIndex = 52;
            this.GbQcgReference.TabStop = false;
            this.GbQcgReference.Text = "GbQcgReference";
            // 
            // TbQcgReference
            // 
            this.TbQcgReference.BackColor = System.Drawing.Color.MistyRose;
            this.TbQcgReference.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbQcgReference.Location = new System.Drawing.Point(31, 29);
            this.TbQcgReference.Multiline = true;
            this.TbQcgReference.Name = "TbQcgReference";
            this.TbQcgReference.Size = new System.Drawing.Size(289, 201);
            this.TbQcgReference.TabIndex = 34;
            this.TbQcgReference.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbCtfName
            // 
            this.TbCtfName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfName.Location = new System.Drawing.Point(12, 43);
            this.TbCtfName.Name = "TbCtfName";
            this.TbCtfName.Size = new System.Drawing.Size(310, 25);
            this.TbCtfName.TabIndex = 35;
            this.TbCtfName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbCtfAddress
            // 
            this.TbCtfAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfAddress.Location = new System.Drawing.Point(12, 95);
            this.TbCtfAddress.Name = "TbCtfAddress";
            this.TbCtfAddress.Size = new System.Drawing.Size(310, 25);
            this.TbCtfAddress.TabIndex = 36;
            this.TbCtfAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbCtfAddress.TextChanged += new System.EventHandler(this.TbQrgAddress_TextChanged);
            // 
            // TbCtfAge
            // 
            this.TbCtfAge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfAge.Location = new System.Drawing.Point(12, 148);
            this.TbCtfAge.Name = "TbCtfAge";
            this.TbCtfAge.Size = new System.Drawing.Size(111, 25);
            this.TbCtfAge.TabIndex = 37;
            this.TbCtfAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GbQcgSexChoices
            // 
            this.GbQcgSexChoices.BackColor = System.Drawing.Color.Transparent;
            this.GbQcgSexChoices.Controls.Add(this.RbCtfSexMale);
            this.GbQcgSexChoices.Controls.Add(this.RbCtfSexFemale);
            this.GbQcgSexChoices.Location = new System.Drawing.Point(159, 131);
            this.GbQcgSexChoices.Name = "GbQcgSexChoices";
            this.GbQcgSexChoices.Size = new System.Drawing.Size(165, 48);
            this.GbQcgSexChoices.TabIndex = 38;
            this.GbQcgSexChoices.TabStop = false;
            // 
            // RbCtfSexMale
            // 
            this.RbCtfSexMale.AutoSize = true;
            this.RbCtfSexMale.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfSexMale.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfSexMale.Location = new System.Drawing.Point(9, 19);
            this.RbCtfSexMale.Name = "RbCtfSexMale";
            this.RbCtfSexMale.Size = new System.Drawing.Size(56, 20);
            this.RbCtfSexMale.TabIndex = 9;
            this.RbCtfSexMale.TabStop = true;
            this.RbCtfSexMale.Text = "Male";
            this.RbCtfSexMale.UseVisualStyleBackColor = false;
            // 
            // RbCtfSexFemale
            // 
            this.RbCtfSexFemale.AutoSize = true;
            this.RbCtfSexFemale.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfSexFemale.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfSexFemale.Location = new System.Drawing.Point(87, 18);
            this.RbCtfSexFemale.Name = "RbCtfSexFemale";
            this.RbCtfSexFemale.Size = new System.Drawing.Size(71, 20);
            this.RbCtfSexFemale.TabIndex = 10;
            this.RbCtfSexFemale.TabStop = true;
            this.RbCtfSexFemale.Text = "Female";
            this.RbCtfSexFemale.UseVisualStyleBackColor = false;
            // 
            // TbCtfContactNo
            // 
            this.TbCtfContactNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfContactNo.Location = new System.Drawing.Point(11, 201);
            this.TbCtfContactNo.Name = "TbCtfContactNo";
            this.TbCtfContactNo.Size = new System.Drawing.Size(310, 25);
            this.TbCtfContactNo.TabIndex = 39;
            this.TbCtfContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfName
            // 
            this.LblCtfName.AutoSize = true;
            this.LblCtfName.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfName.Location = new System.Drawing.Point(15, 23);
            this.LblCtfName.Name = "LblCtfName";
            this.LblCtfName.Size = new System.Drawing.Size(273, 17);
            this.LblCtfName.TabIndex = 40;
            this.LblCtfName.Text = "Enter Name: (First Name Last Name)";
            // 
            // LblCtfAddress
            // 
            this.LblCtfAddress.AutoSize = true;
            this.LblCtfAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAddress.Location = new System.Drawing.Point(16, 75);
            this.LblCtfAddress.Name = "LblCtfAddress";
            this.LblCtfAddress.Size = new System.Drawing.Size(284, 17);
            this.LblCtfAddress.TabIndex = 41;
            this.LblCtfAddress.Text = "Enter Address: (Street/Barangay/City)";
            // 
            // LblCtfAge
            // 
            this.LblCtfAge.AutoSize = true;
            this.LblCtfAge.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAge.Location = new System.Drawing.Point(15, 128);
            this.LblCtfAge.Name = "LblCtfAge";
            this.LblCtfAge.Size = new System.Drawing.Size(115, 17);
            this.LblCtfAge.TabIndex = 42;
            this.LblCtfAge.Text = "Age: (In years)";
            // 
            // LblCtfSex
            // 
            this.LblCtfSex.AutoSize = true;
            this.LblCtfSex.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfSex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfSex.Location = new System.Drawing.Point(166, 129);
            this.LblCtfSex.Name = "LblCtfSex";
            this.LblCtfSex.Size = new System.Drawing.Size(40, 17);
            this.LblCtfSex.TabIndex = 43;
            this.LblCtfSex.Text = "Sex:";
            // 
            // LblCtfContactNo
            // 
            this.LblCtfContactNo.AutoSize = true;
            this.LblCtfContactNo.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfContactNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfContactNo.Location = new System.Drawing.Point(14, 181);
            this.LblCtfContactNo.Name = "LblCtfContactNo";
            this.LblCtfContactNo.Size = new System.Drawing.Size(256, 17);
            this.LblCtfContactNo.TabIndex = 44;
            this.LblCtfContactNo.Text = "Enter Contact No.: (09123456789)";
            // 
            // GbQcgAnswers3
            // 
            this.GbQcgAnswers3.BackColor = System.Drawing.Color.Transparent;
            this.GbQcgAnswers3.Controls.Add(this.RbCtfAnswer3Yes);
            this.GbQcgAnswers3.Controls.Add(this.RbCtfAnswer3No);
            this.GbQcgAnswers3.Location = new System.Drawing.Point(21, 391);
            this.GbQcgAnswers3.Name = "GbQcgAnswers3";
            this.GbQcgAnswers3.Size = new System.Drawing.Size(138, 48);
            this.GbQcgAnswers3.TabIndex = 50;
            this.GbQcgAnswers3.TabStop = false;
            // 
            // RbCtfAnswer3Yes
            // 
            this.RbCtfAnswer3Yes.AutoSize = true;
            this.RbCtfAnswer3Yes.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer3Yes.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer3Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer3Yes.Name = "RbCtfAnswer3Yes";
            this.RbCtfAnswer3Yes.Size = new System.Drawing.Size(50, 20);
            this.RbCtfAnswer3Yes.TabIndex = 9;
            this.RbCtfAnswer3Yes.TabStop = true;
            this.RbCtfAnswer3Yes.Text = "Yes";
            this.RbCtfAnswer3Yes.UseVisualStyleBackColor = false;
            // 
            // RbCtfAnswer3No
            // 
            this.RbCtfAnswer3No.AutoSize = true;
            this.RbCtfAnswer3No.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer3No.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer3No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer3No.Name = "RbCtfAnswer3No";
            this.RbCtfAnswer3No.Size = new System.Drawing.Size(47, 21);
            this.RbCtfAnswer3No.TabIndex = 10;
            this.RbCtfAnswer3No.TabStop = true;
            this.RbCtfAnswer3No.Text = "No";
            this.RbCtfAnswer3No.UseVisualStyleBackColor = false;
            // 
            // GbQcgAnswers2
            // 
            this.GbQcgAnswers2.BackColor = System.Drawing.Color.Transparent;
            this.GbQcgAnswers2.Controls.Add(this.RbCtfAnswer2Yes);
            this.GbQcgAnswers2.Controls.Add(this.RbCtfAnswer2No);
            this.GbQcgAnswers2.Location = new System.Drawing.Point(21, 316);
            this.GbQcgAnswers2.Name = "GbQcgAnswers2";
            this.GbQcgAnswers2.Size = new System.Drawing.Size(138, 48);
            this.GbQcgAnswers2.TabIndex = 49;
            this.GbQcgAnswers2.TabStop = false;
            // 
            // RbCtfAnswer2Yes
            // 
            this.RbCtfAnswer2Yes.AutoSize = true;
            this.RbCtfAnswer2Yes.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer2Yes.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer2Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer2Yes.Name = "RbCtfAnswer2Yes";
            this.RbCtfAnswer2Yes.Size = new System.Drawing.Size(50, 20);
            this.RbCtfAnswer2Yes.TabIndex = 9;
            this.RbCtfAnswer2Yes.TabStop = true;
            this.RbCtfAnswer2Yes.Text = "Yes";
            this.RbCtfAnswer2Yes.UseVisualStyleBackColor = false;
            // 
            // RbCtfAnswer2No
            // 
            this.RbCtfAnswer2No.AutoSize = true;
            this.RbCtfAnswer2No.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer2No.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer2No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer2No.Name = "RbCtfAnswer2No";
            this.RbCtfAnswer2No.Size = new System.Drawing.Size(44, 20);
            this.RbCtfAnswer2No.TabIndex = 10;
            this.RbCtfAnswer2No.TabStop = true;
            this.RbCtfAnswer2No.Text = "No";
            this.RbCtfAnswer2No.UseVisualStyleBackColor = false;
            // 
            // GbQcgAnswers1
            // 
            this.GbQcgAnswers1.BackColor = System.Drawing.Color.Transparent;
            this.GbQcgAnswers1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbQcgAnswers1.Controls.Add(this.RbCtfAnswer1Yes);
            this.GbQcgAnswers1.Controls.Add(this.RbCtfAnswer1No);
            this.GbQcgAnswers1.Location = new System.Drawing.Point(20, 242);
            this.GbQcgAnswers1.Name = "GbQcgAnswers1";
            this.GbQcgAnswers1.Size = new System.Drawing.Size(138, 48);
            this.GbQcgAnswers1.TabIndex = 48;
            this.GbQcgAnswers1.TabStop = false;
            // 
            // RbCtfAnswer1Yes
            // 
            this.RbCtfAnswer1Yes.AutoSize = true;
            this.RbCtfAnswer1Yes.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer1Yes.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer1Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer1Yes.Name = "RbCtfAnswer1Yes";
            this.RbCtfAnswer1Yes.Size = new System.Drawing.Size(50, 20);
            this.RbCtfAnswer1Yes.TabIndex = 9;
            this.RbCtfAnswer1Yes.TabStop = true;
            this.RbCtfAnswer1Yes.Text = "Yes";
            this.RbCtfAnswer1Yes.UseVisualStyleBackColor = false;
            // 
            // RbCtfAnswer1No
            // 
            this.RbCtfAnswer1No.AutoSize = true;
            this.RbCtfAnswer1No.BackColor = System.Drawing.Color.Transparent;
            this.RbCtfAnswer1No.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer1No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer1No.Name = "RbCtfAnswer1No";
            this.RbCtfAnswer1No.Size = new System.Drawing.Size(44, 20);
            this.RbCtfAnswer1No.TabIndex = 10;
            this.RbCtfAnswer1No.TabStop = true;
            this.RbCtfAnswer1No.Text = "No";
            this.RbCtfAnswer1No.UseVisualStyleBackColor = false;
            // 
            // LblCtfQ3
            // 
            this.LblCtfQ3.AutoSize = true;
            this.LblCtfQ3.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfQ3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ3.Location = new System.Drawing.Point(11, 361);
            this.LblCtfQ3.Name = "LblCtfQ3";
            this.LblCtfQ3.Size = new System.Drawing.Size(270, 34);
            this.LblCtfQ3.TabIndex = 47;
            this.LblCtfQ3.Text = "3. Did you travel outside the country\r\n for the past 2 weeks?";
            // 
            // LblCtfQ2
            // 
            this.LblCtfQ2.AutoSize = true;
            this.LblCtfQ2.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfQ2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ2.Location = new System.Drawing.Point(12, 292);
            this.LblCtfQ2.Name = "LblCtfQ2";
            this.LblCtfQ2.Size = new System.Drawing.Size(248, 34);
            this.LblCtfQ2.TabIndex = 46;
            this.LblCtfQ2.Text = "2. Did you come into contact with\r\n anyone that feels unwell?";
            // 
            // LblCtfQ1
            // 
            this.LblCtfQ1.AutoSize = true;
            this.LblCtfQ1.BackColor = System.Drawing.Color.Transparent;
            this.LblCtfQ1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ1.Location = new System.Drawing.Point(13, 232);
            this.LblCtfQ1.Name = "LblCtfQ1";
            this.LblCtfQ1.Size = new System.Drawing.Size(150, 17);
            this.LblCtfQ1.TabIndex = 45;
            this.LblCtfQ1.Text = "1. Do you feel sick?";
            // 
            // BtnQcgGenerate
            // 
            this.BtnQcgGenerate.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcgGenerate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQcgGenerate.Location = new System.Drawing.Point(73, 437);
            this.BtnQcgGenerate.Name = "BtnQcgGenerate";
            this.BtnQcgGenerate.Size = new System.Drawing.Size(158, 27);
            this.BtnQcgGenerate.TabIndex = 51;
            this.BtnQcgGenerate.Text = "Generate QR Code";
            this.BtnQcgGenerate.UseVisualStyleBackColor = false;
            this.BtnQcgGenerate.Click += new System.EventHandler(this.BtnQcgGenerate_Click);
            // 
            // BtnQcgSaveQr
            // 
            this.BtnQcgSaveQr.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcgSaveQr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQcgSaveQr.Location = new System.Drawing.Point(358, 435);
            this.BtnQcgSaveQr.Name = "BtnQcgSaveQr";
            this.BtnQcgSaveQr.Size = new System.Drawing.Size(139, 27);
            this.BtnQcgSaveQr.TabIndex = 52;
            this.BtnQcgSaveQr.Text = "Save QR Code";
            this.BtnQcgSaveQr.UseVisualStyleBackColor = false;
            this.BtnQcgSaveQr.Click += new System.EventHandler(this.BtnQcgSaveQr_Click);
            // 
            // BtnQcgBack
            // 
            this.BtnQcgBack.BackColor = System.Drawing.Color.MistyRose;
            this.BtnQcgBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQcgBack.Location = new System.Drawing.Point(523, 435);
            this.BtnQcgBack.Name = "BtnQcgBack";
            this.BtnQcgBack.Size = new System.Drawing.Size(139, 27);
            this.BtnQcgBack.TabIndex = 53;
            this.BtnQcgBack.Text = "Back To Menu";
            this.BtnQcgBack.UseVisualStyleBackColor = false;
            this.BtnQcgBack.Click += new System.EventHandler(this.BtnQcgBack_Click);
            // 
            // QR_Generatorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.png_20220608_155255_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 476);
            this.Controls.Add(this.BtnQcgBack);
            this.Controls.Add(this.BtnQcgSaveQr);
            this.Controls.Add(this.BtnQcgGenerate);
            this.Controls.Add(this.LblCtfQ3);
            this.Controls.Add(this.LblCtfQ2);
            this.Controls.Add(this.LblCtfQ1);
            this.Controls.Add(this.LblCtfContactNo);
            this.Controls.Add(this.LblCtfSex);
            this.Controls.Add(this.LblCtfAge);
            this.Controls.Add(this.LblCtfAddress);
            this.Controls.Add(this.LblCtfName);
            this.Controls.Add(this.TbCtfContactNo);
            this.Controls.Add(this.TbCtfAge);
            this.Controls.Add(this.TbCtfAddress);
            this.Controls.Add(this.TbCtfName);
            this.Controls.Add(this.QrgPanelSaveQr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GbQcgSexChoices);
            this.Controls.Add(this.GbQcgAnswers3);
            this.Controls.Add(this.GbQcgAnswers2);
            this.Controls.Add(this.GbQcgAnswers1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QR_Generatorcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.QR_Generatorcs_Load);
            this.QrgPanelSaveQr.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbQcgQrcode)).EndInit();
            this.GbQcgReference.ResumeLayout(false);
            this.GbQcgReference.PerformLayout();
            this.GbQcgSexChoices.ResumeLayout(false);
            this.GbQcgSexChoices.PerformLayout();
            this.GbQcgAnswers3.ResumeLayout(false);
            this.GbQcgAnswers3.PerformLayout();
            this.GbQcgAnswers2.ResumeLayout(false);
            this.GbQcgAnswers2.PerformLayout();
            this.GbQcgAnswers1.ResumeLayout(false);
            this.GbQcgAnswers1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel QrgPanelSaveQr;
        private Panel panel5;
        private Label LblCtfTitle;
        private TextBox TbQcgName;
        private PictureBox PbQcgQrcode;
        private Label LblCtfSubTitle;
        private TextBox TbQcgReference;
        private TextBox TbCtfName;
        private TextBox TbCtfAddress;
        private TextBox TbCtfAge;
        private GroupBox GbQcgSexChoices;
        private RadioButton RbCtfSexMale;
        private RadioButton RbCtfSexFemale;
        private TextBox TbCtfContactNo;
        private Label LblCtfName;
        private Label LblCtfAddress;
        private Label LblCtfAge;
        private Label LblCtfSex;
        private Label LblCtfContactNo;
        private GroupBox GbQcgAnswers3;
        private RadioButton RbCtfAnswer3Yes;
        private RadioButton RbCtfAnswer3No;
        private GroupBox GbQcgAnswers2;
        private RadioButton RbCtfAnswer2Yes;
        private RadioButton RbCtfAnswer2No;
        private GroupBox GbQcgAnswers1;
        private RadioButton RbCtfAnswer1Yes;
        private RadioButton RbCtfAnswer1No;
        private Label LblCtfQ3;
        private Label LblCtfQ2;
        private Label LblCtfQ1;
        public Button BtnQcgGenerate;
        private GroupBox GbQcgReference;
        public Button BtnQcgSaveQr;
        public Button BtnQcgBack;
    }
}