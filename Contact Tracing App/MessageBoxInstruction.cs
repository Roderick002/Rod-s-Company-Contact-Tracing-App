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
    public partial class MessageBoxInstruction : Form
    {
        public MessageBoxInstruction()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTFMenu Mb2 = new CTFMenu();
            Mb2.Owner = this;
            Mb2.Show();
            
           this.Hide();
        }
    }
}
