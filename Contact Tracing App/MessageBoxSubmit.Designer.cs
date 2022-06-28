namespace Contact_Tracing_App
{
    partial class MessageBoxSubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxSubmit));
            this.BtnMb1Yes = new System.Windows.Forms.Button();
            this.BtnMb1Exit = new System.Windows.Forms.Button();
            this.LblMb11 = new System.Windows.Forms.Label();
            this.LblMb12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnMb1Yes
            // 
            this.BtnMb1Yes.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMb1Yes.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMb1Yes.Location = new System.Drawing.Point(69, 153);
            this.BtnMb1Yes.Name = "BtnMb1Yes";
            this.BtnMb1Yes.Size = new System.Drawing.Size(142, 30);
            this.BtnMb1Yes.TabIndex = 0;
            this.BtnMb1Yes.Text = "YES";
            this.BtnMb1Yes.UseVisualStyleBackColor = false;
            this.BtnMb1Yes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMb1Exit
            // 
            this.BtnMb1Exit.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMb1Exit.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMb1Exit.Location = new System.Drawing.Point(249, 154);
            this.BtnMb1Exit.Name = "BtnMb1Exit";
            this.BtnMb1Exit.Size = new System.Drawing.Size(141, 30);
            this.BtnMb1Exit.TabIndex = 1;
            this.BtnMb1Exit.Text = "BACKTO MENU";
            this.BtnMb1Exit.UseVisualStyleBackColor = false;
            this.BtnMb1Exit.Click += new System.EventHandler(this.BtnMb1Exit_Click);
            // 
            // LblMb11
            // 
            this.LblMb11.AutoSize = true;
            this.LblMb11.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblMb11.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblMb11.Location = new System.Drawing.Point(46, 27);
            this.LblMb11.Name = "LblMb11";
            this.LblMb11.Size = new System.Drawing.Size(355, 68);
            this.LblMb11.TabIndex = 2;
            this.LblMb11.Text = "       YOUR RESPONSE\r\n HAS BEEN RECORDED!";
            this.LblMb11.Click += new System.EventHandler(this.LblMb11_Click);
            // 
            // LblMb12
            // 
            this.LblMb12.AutoSize = true;
            this.LblMb12.BackColor = System.Drawing.Color.Transparent;
            this.LblMb12.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMb12.Location = new System.Drawing.Point(1, 99);
            this.LblMb12.Name = "LblMb12";
            this.LblMb12.Size = new System.Drawing.Size(458, 45);
            this.LblMb12.TabIndex = 3;
            this.LblMb12.Text = "Submit another response?";
            this.LblMb12.Click += new System.EventHandler(this.LblMb12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 10);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-1, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 10);
            this.panel2.TabIndex = 5;
            // 
            // MessageBoxSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 211);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMb12);
            this.Controls.Add(this.BtnMb1Exit);
            this.Controls.Add(this.BtnMb1Yes);
            this.Controls.Add(this.LblMb11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxSubmit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageBoxSubmit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnMb1Exit;
        private Label LblMb11;
        private Label LblMb12;
        private Panel panel1;
        private Panel panel2;
        public Button BtnMb1Yes;
    }
}