using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class CTFMenu : Form
    {
        public CTFMenu()
        {
            InitializeComponent();
        }

        private void CTFMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCtfStart_Click(object sender, EventArgs e)
        {
            MessageBoxInstruction CTF = new MessageBoxInstruction();
            CTF.Owner = this;
            CTF.Show();

            this.Hide();

        }

        private void BtnCtfExit_Click(object sender, EventArgs e)
        {
            MessageBoxInstruction Mb1 = new MessageBoxInstruction();
            Mb1.Owner = this;

            Application.Exit();
        }

        private void BtnCtfViewRecords_Click(object sender, EventArgs e)
        {
            ContactTracingRecords records = new ContactTracingRecords();
            records.Owner = this;
            records.Show();

            this.Hide();
        }

        private void BtnCtfScanQRcode_Click(object sender, EventArgs e)
        {
            QR_Code_Scanner QCS = new QR_Code_Scanner();
            QCS.Owner = this;
            QCS.Show();

            this.Hide();
        }
    }
}
