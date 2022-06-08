namespace Contact_Tracing_App
{
    partial class ContactTracing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCtfPersonlInfo = new System.Windows.Forms.Label();
            this.LblCtfInstruction1 = new System.Windows.Forms.Label();
            this.LblCtfName = new System.Windows.Forms.Label();
            this.LblCtfNameFormat = new System.Windows.Forms.Label();
            this.TbCtfName = new System.Windows.Forms.TextBox();
            this.LblCtfAddress = new System.Windows.Forms.Label();
            this.LblCtfAddressFormat = new System.Windows.Forms.Label();
            this.TbCtfAddress = new System.Windows.Forms.TextBox();
            this.LblCtfSex = new System.Windows.Forms.Label();
            this.RbCtfSexMale = new System.Windows.Forms.RadioButton();
            this.RbCtfSexFemale = new System.Windows.Forms.RadioButton();
            this.LblCtfAge = new System.Windows.Forms.Label();
            this.LblCtfAgeFormat = new System.Windows.Forms.Label();
            this.TbCtfAge = new System.Windows.Forms.TextBox();
            this.LblCtfContactNo = new System.Windows.Forms.Label();
            this.LblCtfContactNoFormat = new System.Windows.Forms.Label();
            this.TbCtfContactNo = new System.Windows.Forms.TextBox();
            this.LblCtfTimeIn = new System.Windows.Forms.Label();
            this.LblCtfTimeInFormat = new System.Windows.Forms.Label();
            this.LblCtfTimeOut = new System.Windows.Forms.Label();
            this.LblCtfTimeOutFormat = new System.Windows.Forms.Label();
            this.TbCtfTImeIn = new System.Windows.Forms.TextBox();
            this.TbCtfTimeOut = new System.Windows.Forms.TextBox();
            this.LblCtfHealthStatus = new System.Windows.Forms.Label();
            this.LblCtfInstruction2 = new System.Windows.Forms.Label();
            this.LblCtfQ1 = new System.Windows.Forms.Label();
            this.LblCtfQ2 = new System.Windows.Forms.Label();
            this.LblCtfQ3 = new System.Windows.Forms.Label();
            this.LblCtfTitle = new System.Windows.Forms.Label();
            this.LblCtfSubTitle = new System.Windows.Forms.Label();
            this.GbCtfSexChoices = new System.Windows.Forms.GroupBox();
            this.GbCtfAnswers1 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer1Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer1No = new System.Windows.Forms.RadioButton();
            this.GbCtfAnswers2 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer2Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer2No = new System.Windows.Forms.RadioButton();
            this.GbCtfAnswers3 = new System.Windows.Forms.GroupBox();
            this.RbCtfAnswer3Yes = new System.Windows.Forms.RadioButton();
            this.RbCtfAnswer3No = new System.Windows.Forms.RadioButton();
            this.BtnCtfSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GbCtfSexChoices.SuspendLayout();
            this.GbCtfAnswers1.SuspendLayout();
            this.GbCtfAnswers2.SuspendLayout();
            this.GbCtfAnswers3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCtfPersonlInfo
            // 
            this.LblCtfPersonlInfo.AutoSize = true;
            this.LblCtfPersonlInfo.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfPersonlInfo.Location = new System.Drawing.Point(39, 116);
            this.LblCtfPersonlInfo.Name = "LblCtfPersonlInfo";
            this.LblCtfPersonlInfo.Size = new System.Drawing.Size(344, 35);
            this.LblCtfPersonlInfo.TabIndex = 0;
            this.LblCtfPersonlInfo.Text = "Personal Information";
            this.LblCtfPersonlInfo.Click += new System.EventHandler(this.LblCtfPersonlInfo_Click);
            // 
            // LblCtfInstruction1
            // 
            this.LblCtfInstruction1.AutoSize = true;
            this.LblCtfInstruction1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfInstruction1.Location = new System.Drawing.Point(16, 158);
            this.LblCtfInstruction1.Name = "LblCtfInstruction1";
            this.LblCtfInstruction1.Size = new System.Drawing.Size(336, 20);
            this.LblCtfInstruction1.TabIndex = 1;
            this.LblCtfInstruction1.Text = "Follow the format written in the parenthesis.";
            // 
            // LblCtfName
            // 
            this.LblCtfName.AutoSize = true;
            this.LblCtfName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfName.Location = new System.Drawing.Point(26, 183);
            this.LblCtfName.Name = "LblCtfName";
            this.LblCtfName.Size = new System.Drawing.Size(110, 20);
            this.LblCtfName.TabIndex = 2;
            this.LblCtfName.Text = "Enter Name:";
            this.LblCtfName.Click += new System.EventHandler(this.LblCtfName_Click);
            // 
            // LblCtfNameFormat
            // 
            this.LblCtfNameFormat.AutoSize = true;
            this.LblCtfNameFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfNameFormat.Location = new System.Drawing.Point(129, 184);
            this.LblCtfNameFormat.Name = "LblCtfNameFormat";
            this.LblCtfNameFormat.Size = new System.Drawing.Size(167, 17);
            this.LblCtfNameFormat.TabIndex = 3;
            this.LblCtfNameFormat.Text = "(First Name Last Name)";
            // 
            // TbCtfName
            // 
            this.TbCtfName.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfName.Location = new System.Drawing.Point(30, 209);
            this.TbCtfName.Name = "TbCtfName";
            this.TbCtfName.Size = new System.Drawing.Size(355, 25);
            this.TbCtfName.TabIndex = 4;
            this.TbCtfName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfAddress
            // 
            this.LblCtfAddress.AutoSize = true;
            this.LblCtfAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAddress.Location = new System.Drawing.Point(26, 245);
            this.LblCtfAddress.Name = "LblCtfAddress";
            this.LblCtfAddress.Size = new System.Drawing.Size(131, 20);
            this.LblCtfAddress.TabIndex = 5;
            this.LblCtfAddress.Text = "Enter Address:";
            // 
            // LblCtfAddressFormat
            // 
            this.LblCtfAddressFormat.AutoSize = true;
            this.LblCtfAddressFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAddressFormat.Location = new System.Drawing.Point(151, 246);
            this.LblCtfAddressFormat.Name = "LblCtfAddressFormat";
            this.LblCtfAddressFormat.Size = new System.Drawing.Size(154, 17);
            this.LblCtfAddressFormat.TabIndex = 6;
            this.LblCtfAddressFormat.Text = "(Street/Barangay/City)";
            // 
            // TbCtfAddress
            // 
            this.TbCtfAddress.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfAddress.Location = new System.Drawing.Point(30, 268);
            this.TbCtfAddress.Name = "TbCtfAddress";
            this.TbCtfAddress.Size = new System.Drawing.Size(355, 25);
            this.TbCtfAddress.TabIndex = 7;
            this.TbCtfAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfSex
            // 
            this.LblCtfSex.AutoSize = true;
            this.LblCtfSex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfSex.Location = new System.Drawing.Point(28, 308);
            this.LblCtfSex.Name = "LblCtfSex";
            this.LblCtfSex.Size = new System.Drawing.Size(44, 20);
            this.LblCtfSex.TabIndex = 8;
            this.LblCtfSex.Text = "Sex:";
            this.LblCtfSex.Click += new System.EventHandler(this.LblCtfSex_Click);
            // 
            // RbCtfSexMale
            // 
            this.RbCtfSexMale.AutoSize = true;
            this.RbCtfSexMale.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfSexMale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfSexMale.Location = new System.Drawing.Point(9, 19);
            this.RbCtfSexMale.Name = "RbCtfSexMale";
            this.RbCtfSexMale.Size = new System.Drawing.Size(59, 21);
            this.RbCtfSexMale.TabIndex = 9;
            this.RbCtfSexMale.TabStop = true;
            this.RbCtfSexMale.Text = "Male";
            this.RbCtfSexMale.UseVisualStyleBackColor = false;
            this.RbCtfSexMale.CheckedChanged += new System.EventHandler(this.RbCtfSexMale_CheckedChanged);
            // 
            // RbCtfSexFemale
            // 
            this.RbCtfSexFemale.AutoSize = true;
            this.RbCtfSexFemale.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfSexFemale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfSexFemale.Location = new System.Drawing.Point(87, 18);
            this.RbCtfSexFemale.Name = "RbCtfSexFemale";
            this.RbCtfSexFemale.Size = new System.Drawing.Size(78, 21);
            this.RbCtfSexFemale.TabIndex = 10;
            this.RbCtfSexFemale.TabStop = true;
            this.RbCtfSexFemale.Text = "Female";
            this.RbCtfSexFemale.UseVisualStyleBackColor = false;
            this.RbCtfSexFemale.CheckedChanged += new System.EventHandler(this.RbCtfSexFemale_CheckedChanged);
            // 
            // LblCtfAge
            // 
            this.LblCtfAge.AutoSize = true;
            this.LblCtfAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAge.Location = new System.Drawing.Point(226, 308);
            this.LblCtfAge.Name = "LblCtfAge";
            this.LblCtfAge.Size = new System.Drawing.Size(47, 20);
            this.LblCtfAge.TabIndex = 11;
            this.LblCtfAge.Text = "Age:";
            // 
            // LblCtfAgeFormat
            // 
            this.LblCtfAgeFormat.AutoSize = true;
            this.LblCtfAgeFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfAgeFormat.Location = new System.Drawing.Point(267, 310);
            this.LblCtfAgeFormat.Name = "LblCtfAgeFormat";
            this.LblCtfAgeFormat.Size = new System.Drawing.Size(72, 17);
            this.LblCtfAgeFormat.TabIndex = 12;
            this.LblCtfAgeFormat.Text = "(In Years)";
            this.LblCtfAgeFormat.Click += new System.EventHandler(this.LblCtfAgeFormat_Click);
            // 
            // TbCtfAge
            // 
            this.TbCtfAge.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfAge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfAge.Location = new System.Drawing.Point(230, 336);
            this.TbCtfAge.Name = "TbCtfAge";
            this.TbCtfAge.Size = new System.Drawing.Size(114, 25);
            this.TbCtfAge.TabIndex = 13;
            this.TbCtfAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfContactNo
            // 
            this.LblCtfContactNo.AutoSize = true;
            this.LblCtfContactNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfContactNo.Location = new System.Drawing.Point(26, 385);
            this.LblCtfContactNo.Name = "LblCtfContactNo";
            this.LblCtfContactNo.Size = new System.Drawing.Size(159, 20);
            this.LblCtfContactNo.TabIndex = 14;
            this.LblCtfContactNo.Text = "Enter Contact No.:";
            // 
            // LblCtfContactNoFormat
            // 
            this.LblCtfContactNoFormat.AutoSize = true;
            this.LblCtfContactNoFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfContactNoFormat.Location = new System.Drawing.Point(181, 386);
            this.LblCtfContactNoFormat.Name = "LblCtfContactNoFormat";
            this.LblCtfContactNoFormat.Size = new System.Drawing.Size(106, 17);
            this.LblCtfContactNoFormat.TabIndex = 15;
            this.LblCtfContactNoFormat.Text = "(09123456789)";
            this.LblCtfContactNoFormat.Click += new System.EventHandler(this.LblCtfContactNoFormat_Click);
            // 
            // TbCtfContactNo
            // 
            this.TbCtfContactNo.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfContactNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfContactNo.Location = new System.Drawing.Point(30, 406);
            this.TbCtfContactNo.Name = "TbCtfContactNo";
            this.TbCtfContactNo.Size = new System.Drawing.Size(355, 25);
            this.TbCtfContactNo.TabIndex = 16;
            this.TbCtfContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfTimeIn
            // 
            this.LblCtfTimeIn.AutoSize = true;
            this.LblCtfTimeIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTimeIn.Location = new System.Drawing.Point(26, 448);
            this.LblCtfTimeIn.Name = "LblCtfTimeIn";
            this.LblCtfTimeIn.Size = new System.Drawing.Size(74, 20);
            this.LblCtfTimeIn.TabIndex = 17;
            this.LblCtfTimeIn.Text = "Time In:";
            // 
            // LblCtfTimeInFormat
            // 
            this.LblCtfTimeInFormat.AutoSize = true;
            this.LblCtfTimeInFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTimeInFormat.Location = new System.Drawing.Point(98, 449);
            this.LblCtfTimeInFormat.Name = "LblCtfTimeInFormat";
            this.LblCtfTimeInFormat.Size = new System.Drawing.Size(80, 17);
            this.LblCtfTimeInFormat.TabIndex = 18;
            this.LblCtfTimeInFormat.Text = "(00:00 AM)";
            // 
            // LblCtfTimeOut
            // 
            this.LblCtfTimeOut.AutoSize = true;
            this.LblCtfTimeOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTimeOut.Location = new System.Drawing.Point(220, 448);
            this.LblCtfTimeOut.Name = "LblCtfTimeOut";
            this.LblCtfTimeOut.Size = new System.Drawing.Size(88, 20);
            this.LblCtfTimeOut.TabIndex = 19;
            this.LblCtfTimeOut.Text = "Time Out:";
            // 
            // LblCtfTimeOutFormat
            // 
            this.LblCtfTimeOutFormat.AutoSize = true;
            this.LblCtfTimeOutFormat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTimeOutFormat.Location = new System.Drawing.Point(302, 449);
            this.LblCtfTimeOutFormat.Name = "LblCtfTimeOutFormat";
            this.LblCtfTimeOutFormat.Size = new System.Drawing.Size(80, 17);
            this.LblCtfTimeOutFormat.TabIndex = 20;
            this.LblCtfTimeOutFormat.Text = "(00:00 AM)";
            // 
            // TbCtfTImeIn
            // 
            this.TbCtfTImeIn.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfTImeIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfTImeIn.Location = new System.Drawing.Point(29, 471);
            this.TbCtfTImeIn.Name = "TbCtfTImeIn";
            this.TbCtfTImeIn.Size = new System.Drawing.Size(134, 25);
            this.TbCtfTImeIn.TabIndex = 21;
            this.TbCtfTImeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbCtfTImeIn.TextChanged += new System.EventHandler(this.TbCtfTImeIn_TextChanged);
            // 
            // TbCtfTimeOut
            // 
            this.TbCtfTimeOut.BackColor = System.Drawing.Color.MistyRose;
            this.TbCtfTimeOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbCtfTimeOut.Location = new System.Drawing.Point(227, 473);
            this.TbCtfTimeOut.Name = "TbCtfTimeOut";
            this.TbCtfTimeOut.Size = new System.Drawing.Size(134, 25);
            this.TbCtfTimeOut.TabIndex = 22;
            this.TbCtfTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCtfHealthStatus
            // 
            this.LblCtfHealthStatus.AutoSize = true;
            this.LblCtfHealthStatus.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfHealthStatus.Location = new System.Drawing.Point(85, 519);
            this.LblCtfHealthStatus.Name = "LblCtfHealthStatus";
            this.LblCtfHealthStatus.Size = new System.Drawing.Size(223, 35);
            this.LblCtfHealthStatus.TabIndex = 23;
            this.LblCtfHealthStatus.Text = "Health Status";
            // 
            // LblCtfInstruction2
            // 
            this.LblCtfInstruction2.AutoSize = true;
            this.LblCtfInstruction2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblCtfInstruction2.Location = new System.Drawing.Point(22, 559);
            this.LblCtfInstruction2.Name = "LblCtfInstruction2";
            this.LblCtfInstruction2.Size = new System.Drawing.Size(311, 20);
            this.LblCtfInstruction2.TabIndex = 24;
            this.LblCtfInstruction2.Text = "Answer the following questions honestly.";
            // 
            // LblCtfQ1
            // 
            this.LblCtfQ1.AutoSize = true;
            this.LblCtfQ1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ1.Location = new System.Drawing.Point(26, 585);
            this.LblCtfQ1.Name = "LblCtfQ1";
            this.LblCtfQ1.Size = new System.Drawing.Size(167, 20);
            this.LblCtfQ1.TabIndex = 25;
            this.LblCtfQ1.Text = "1. Do you feel sick?";
            // 
            // LblCtfQ2
            // 
            this.LblCtfQ2.AutoSize = true;
            this.LblCtfQ2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ2.Location = new System.Drawing.Point(28, 655);
            this.LblCtfQ2.Name = "LblCtfQ2";
            this.LblCtfQ2.Size = new System.Drawing.Size(279, 40);
            this.LblCtfQ2.TabIndex = 26;
            this.LblCtfQ2.Text = "2. Did you come into contact with\r\n anyone that feels unwell?";
            // 
            // LblCtfQ3
            // 
            this.LblCtfQ3.AutoSize = true;
            this.LblCtfQ3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfQ3.Location = new System.Drawing.Point(29, 743);
            this.LblCtfQ3.Name = "LblCtfQ3";
            this.LblCtfQ3.Size = new System.Drawing.Size(302, 40);
            this.LblCtfQ3.TabIndex = 27;
            this.LblCtfQ3.Text = "3. Did you travel outside the country\r\n for the past 2 weeks?";
            this.LblCtfQ3.Click += new System.EventHandler(this.LblCtfQ3_Click);
            // 
            // LblCtfTitle
            // 
            this.LblCtfTitle.AutoSize = true;
            this.LblCtfTitle.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCtfTitle.Location = new System.Drawing.Point(8, 23);
            this.LblCtfTitle.Name = "LblCtfTitle";
            this.LblCtfTitle.Size = new System.Drawing.Size(400, 49);
            this.LblCtfTitle.TabIndex = 28;
            this.LblCtfTitle.Text = "ROD\'s COMPANY";
            // 
            // LblCtfSubTitle
            // 
            this.LblCtfSubTitle.AutoSize = true;
            this.LblCtfSubTitle.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblCtfSubTitle.Location = new System.Drawing.Point(84, 73);
            this.LblCtfSubTitle.Name = "LblCtfSubTitle";
            this.LblCtfSubTitle.Size = new System.Drawing.Size(248, 26);
            this.LblCtfSubTitle.TabIndex = 29;
            this.LblCtfSubTitle.Text = "Contact Tracing Form";
            // 
            // GbCtfSexChoices
            // 
            this.GbCtfSexChoices.BackColor = System.Drawing.Color.Transparent;
            this.GbCtfSexChoices.Controls.Add(this.RbCtfSexMale);
            this.GbCtfSexChoices.Controls.Add(this.RbCtfSexFemale);
            this.GbCtfSexChoices.Location = new System.Drawing.Point(30, 324);
            this.GbCtfSexChoices.Name = "GbCtfSexChoices";
            this.GbCtfSexChoices.Size = new System.Drawing.Size(165, 48);
            this.GbCtfSexChoices.TabIndex = 36;
            this.GbCtfSexChoices.TabStop = false;
            // 
            // GbCtfAnswers1
            // 
            this.GbCtfAnswers1.BackColor = System.Drawing.Color.Transparent;
            this.GbCtfAnswers1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbCtfAnswers1.Controls.Add(this.RbCtfAnswer1Yes);
            this.GbCtfAnswers1.Controls.Add(this.RbCtfAnswer1No);
            this.GbCtfAnswers1.Location = new System.Drawing.Point(49, 604);
            this.GbCtfAnswers1.Name = "GbCtfAnswers1";
            this.GbCtfAnswers1.Size = new System.Drawing.Size(138, 48);
            this.GbCtfAnswers1.TabIndex = 37;
            this.GbCtfAnswers1.TabStop = false;
            // 
            // RbCtfAnswer1Yes
            // 
            this.RbCtfAnswer1Yes.AutoSize = true;
            this.RbCtfAnswer1Yes.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer1Yes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer1Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer1Yes.Name = "RbCtfAnswer1Yes";
            this.RbCtfAnswer1Yes.Size = new System.Drawing.Size(53, 21);
            this.RbCtfAnswer1Yes.TabIndex = 9;
            this.RbCtfAnswer1Yes.TabStop = true;
            this.RbCtfAnswer1Yes.Text = "Yes";
            this.RbCtfAnswer1Yes.UseVisualStyleBackColor = false;
            this.RbCtfAnswer1Yes.CheckedChanged += new System.EventHandler(this.RbCtfAnswer1Yes_CheckedChanged);
            // 
            // RbCtfAnswer1No
            // 
            this.RbCtfAnswer1No.AutoSize = true;
            this.RbCtfAnswer1No.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer1No.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer1No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer1No.Name = "RbCtfAnswer1No";
            this.RbCtfAnswer1No.Size = new System.Drawing.Size(47, 21);
            this.RbCtfAnswer1No.TabIndex = 10;
            this.RbCtfAnswer1No.TabStop = true;
            this.RbCtfAnswer1No.Text = "No";
            this.RbCtfAnswer1No.UseVisualStyleBackColor = false;
            // 
            // GbCtfAnswers2
            // 
            this.GbCtfAnswers2.BackColor = System.Drawing.Color.Transparent;
            this.GbCtfAnswers2.Controls.Add(this.RbCtfAnswer2Yes);
            this.GbCtfAnswers2.Controls.Add(this.RbCtfAnswer2No);
            this.GbCtfAnswers2.Location = new System.Drawing.Point(49, 694);
            this.GbCtfAnswers2.Name = "GbCtfAnswers2";
            this.GbCtfAnswers2.Size = new System.Drawing.Size(138, 48);
            this.GbCtfAnswers2.TabIndex = 38;
            this.GbCtfAnswers2.TabStop = false;
            // 
            // RbCtfAnswer2Yes
            // 
            this.RbCtfAnswer2Yes.AutoSize = true;
            this.RbCtfAnswer2Yes.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer2Yes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer2Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer2Yes.Name = "RbCtfAnswer2Yes";
            this.RbCtfAnswer2Yes.Size = new System.Drawing.Size(53, 21);
            this.RbCtfAnswer2Yes.TabIndex = 9;
            this.RbCtfAnswer2Yes.TabStop = true;
            this.RbCtfAnswer2Yes.Text = "Yes";
            this.RbCtfAnswer2Yes.UseVisualStyleBackColor = false;
            this.RbCtfAnswer2Yes.CheckedChanged += new System.EventHandler(this.RbCtfAnswer2Yes_CheckedChanged);
            // 
            // RbCtfAnswer2No
            // 
            this.RbCtfAnswer2No.AutoSize = true;
            this.RbCtfAnswer2No.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer2No.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer2No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer2No.Name = "RbCtfAnswer2No";
            this.RbCtfAnswer2No.Size = new System.Drawing.Size(47, 21);
            this.RbCtfAnswer2No.TabIndex = 10;
            this.RbCtfAnswer2No.TabStop = true;
            this.RbCtfAnswer2No.Text = "No";
            this.RbCtfAnswer2No.UseVisualStyleBackColor = false;
            this.RbCtfAnswer2No.CheckedChanged += new System.EventHandler(this.RbCtfAnswer2No_CheckedChanged);
            // 
            // GbCtfAnswers3
            // 
            this.GbCtfAnswers3.BackColor = System.Drawing.Color.Transparent;
            this.GbCtfAnswers3.Controls.Add(this.RbCtfAnswer3Yes);
            this.GbCtfAnswers3.Controls.Add(this.RbCtfAnswer3No);
            this.GbCtfAnswers3.Location = new System.Drawing.Point(49, 785);
            this.GbCtfAnswers3.Name = "GbCtfAnswers3";
            this.GbCtfAnswers3.Size = new System.Drawing.Size(138, 48);
            this.GbCtfAnswers3.TabIndex = 39;
            this.GbCtfAnswers3.TabStop = false;
            // 
            // RbCtfAnswer3Yes
            // 
            this.RbCtfAnswer3Yes.AutoSize = true;
            this.RbCtfAnswer3Yes.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer3Yes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer3Yes.Location = new System.Drawing.Point(9, 19);
            this.RbCtfAnswer3Yes.Name = "RbCtfAnswer3Yes";
            this.RbCtfAnswer3Yes.Size = new System.Drawing.Size(53, 21);
            this.RbCtfAnswer3Yes.TabIndex = 9;
            this.RbCtfAnswer3Yes.TabStop = true;
            this.RbCtfAnswer3Yes.Text = "Yes";
            this.RbCtfAnswer3Yes.UseVisualStyleBackColor = false;
            this.RbCtfAnswer3Yes.CheckedChanged += new System.EventHandler(this.RbCtfAnswer3Yes_CheckedChanged);
            // 
            // RbCtfAnswer3No
            // 
            this.RbCtfAnswer3No.AutoSize = true;
            this.RbCtfAnswer3No.BackColor = System.Drawing.Color.MistyRose;
            this.RbCtfAnswer3No.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbCtfAnswer3No.Location = new System.Drawing.Point(87, 18);
            this.RbCtfAnswer3No.Name = "RbCtfAnswer3No";
            this.RbCtfAnswer3No.Size = new System.Drawing.Size(47, 21);
            this.RbCtfAnswer3No.TabIndex = 10;
            this.RbCtfAnswer3No.TabStop = true;
            this.RbCtfAnswer3No.Text = "No";
            this.RbCtfAnswer3No.UseVisualStyleBackColor = false;
            this.RbCtfAnswer3No.CheckedChanged += new System.EventHandler(this.RbCtfAnswer3No_CheckedChanged);
            // 
            // BtnCtfSubmit
            // 
            this.BtnCtfSubmit.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCtfSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCtfSubmit.Location = new System.Drawing.Point(117, 854);
            this.BtnCtfSubmit.Name = "BtnCtfSubmit";
            this.BtnCtfSubmit.Size = new System.Drawing.Size(147, 29);
            this.BtnCtfSubmit.TabIndex = 40;
            this.BtnCtfSubmit.Text = "Submit";
            this.BtnCtfSubmit.UseVisualStyleBackColor = false;
            this.BtnCtfSubmit.Click += new System.EventHandler(this.BtnCtfSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 902);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 902);
            this.panel2.TabIndex = 42;
            // 
            // ContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 902);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCtfSubmit);
            this.Controls.Add(this.GbCtfAnswers3);
            this.Controls.Add(this.GbCtfAnswers2);
            this.Controls.Add(this.GbCtfAnswers1);
            this.Controls.Add(this.GbCtfSexChoices);
            this.Controls.Add(this.LblCtfSubTitle);
            this.Controls.Add(this.LblCtfTitle);
            this.Controls.Add(this.LblCtfQ3);
            this.Controls.Add(this.LblCtfQ2);
            this.Controls.Add(this.LblCtfQ1);
            this.Controls.Add(this.LblCtfInstruction2);
            this.Controls.Add(this.LblCtfHealthStatus);
            this.Controls.Add(this.TbCtfTimeOut);
            this.Controls.Add(this.TbCtfTImeIn);
            this.Controls.Add(this.LblCtfTimeOutFormat);
            this.Controls.Add(this.LblCtfTimeOut);
            this.Controls.Add(this.LblCtfTimeInFormat);
            this.Controls.Add(this.LblCtfTimeIn);
            this.Controls.Add(this.TbCtfContactNo);
            this.Controls.Add(this.LblCtfContactNoFormat);
            this.Controls.Add(this.LblCtfContactNo);
            this.Controls.Add(this.TbCtfAge);
            this.Controls.Add(this.LblCtfAgeFormat);
            this.Controls.Add(this.LblCtfAge);
            this.Controls.Add(this.LblCtfSex);
            this.Controls.Add(this.TbCtfAddress);
            this.Controls.Add(this.LblCtfAddressFormat);
            this.Controls.Add(this.LblCtfAddress);
            this.Controls.Add(this.TbCtfName);
            this.Controls.Add(this.LblCtfNameFormat);
            this.Controls.Add(this.LblCtfName);
            this.Controls.Add(this.LblCtfInstruction1);
            this.Controls.Add(this.LblCtfPersonlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ContactTracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rod\'s Company Contact Tracing ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbCtfSexChoices.ResumeLayout(false);
            this.GbCtfSexChoices.PerformLayout();
            this.GbCtfAnswers1.ResumeLayout(false);
            this.GbCtfAnswers1.PerformLayout();
            this.GbCtfAnswers2.ResumeLayout(false);
            this.GbCtfAnswers2.PerformLayout();
            this.GbCtfAnswers3.ResumeLayout(false);
            this.GbCtfAnswers3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCtfPersonlInfo;
        private Label LblCtfInstruction1;
        private Label LblCtfName;
        private Label LblCtfNameFormat;
        private TextBox TbCtfName;
        private Label LblCtfAddress;
        private Label LblCtfAddressFormat;
        private TextBox TbCtfAddress;
        private Label LblCtfSex;
        private RadioButton RbCtfSexMale;
        private RadioButton RbCtfSexFemale;
        private Label LblCtfAge;
        private Label LblCtfAgeFormat;
        private TextBox TbCtfAge;
        private Label LblCtfContactNo;
        private Label LblCtfContactNoFormat;
        private TextBox TbCtfContactNo;
        private Label LblCtfTimeIn;
        private Label LblCtfTimeInFormat;
        private Label LblCtfTimeOut;
        private Label LblCtfTimeOutFormat;
        private TextBox TbCtfTImeIn;
        private TextBox TbCtfTimeOut;
        private Label LblCtfHealthStatus;
        private Label LblCtfInstruction2;
        private Label LblCtfQ1;
        private Label LblCtfQ2;
        private Label LblCtfQ3;
        private Label LblCtfTitle;
        private Label LblCtfSubTitle;
        private GroupBox GbCtfSexChoices;
        private GroupBox GbCtfAnswers1;
        private RadioButton RbCtfAnswer1Yes;
        private RadioButton RbCtfAnswer1No;
        private GroupBox GbCtfAnswers2;
        private RadioButton RbCtfAnswer2Yes;
        private RadioButton RbCtfAnswer2No;
        private GroupBox GbCtfAnswers3;
        private RadioButton RbCtfAnswer3Yes;
        private RadioButton RbCtfAnswer3No;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Panel panel2;
        public Button BtnCtfSubmit;
    }
}