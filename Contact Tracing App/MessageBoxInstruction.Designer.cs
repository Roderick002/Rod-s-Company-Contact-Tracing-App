namespace Contact_Tracing_App
{
    partial class MessageBoxInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxInstruction));
            this.PbMbi1 = new System.Windows.Forms.PictureBox();
            this.LblMbi1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbMbi1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMbi1
            // 
            this.PbMbi1.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.Capture;
            this.PbMbi1.Image = global::Contact_Tracing_App.Properties.Resources.Capture1;
            this.PbMbi1.Location = new System.Drawing.Point(12, 16);
            this.PbMbi1.Name = "PbMbi1";
            this.PbMbi1.Size = new System.Drawing.Size(115, 107);
            this.PbMbi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMbi1.TabIndex = 0;
            this.PbMbi1.TabStop = false;
            this.PbMbi1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblMbi1
            // 
            this.LblMbi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMbi1.AutoSize = true;
            this.LblMbi1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMbi1.Location = new System.Drawing.Point(133, 34);
            this.LblMbi1.Name = "LblMbi1";
            this.LblMbi1.Size = new System.Drawing.Size(532, 72);
            this.LblMbi1.TabIndex = 1;
            this.LblMbi1.Text = "-->This is a contact tracing app.\r\n-->Strictly follow the given format.\r\n-->Check" +
    " your input data before clicking submit.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 10);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(-1, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 15);
            this.panel2.TabIndex = 3;
            // 
            // MessageBoxInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 141);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMbi1);
            this.Controls.Add(this.PbMbi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read This!";
            ((System.ComponentModel.ISupportInitialize)(this.PbMbi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PbMbi1;
        private Label LblMbi1;
        private Panel panel1;
        private Panel panel2;
    }
}