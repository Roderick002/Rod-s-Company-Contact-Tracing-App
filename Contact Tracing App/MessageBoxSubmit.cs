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
    public partial class MessageBoxSubmit : Form
    {
        public MessageBoxSubmit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ((ContactTracing)Owner).BtnCtfSubmit.Enabled = true;
                      
             this.Close();
            
           
        }

        private void LblMb11_Click(object sender, EventArgs e)
        {

        }

        private void MessageBoxSubmit_Load(object sender, EventArgs e)
        {
          

           
        }
        
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void LblMb12_Click(object sender, EventArgs e)
        {

        }

        private void BtnMb1Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
