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
    public partial class ContactTracingRecords : Form
    {
        public ContactTracingRecords()
        {
            InitializeComponent();
        }

        private void ContactTracingRecords_Load(object sender, EventArgs e)
        {

        }

        private void BtnCtfViewAll_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\Contact Tracing Record.txt");

            LbCtfRecordList.Items.Clear();
            string records;
            do
            {
                records = file.ReadLine();

                LbCtfRecordList.Items.Add(records.ToString());
                         
            } while (!file.EndOfStream);


        }

        private void BtnCtfBack_Click(object sender, EventArgs e)
        {
            CTFMenu Menu = new CTFMenu();
            Menu.Show();

            this.Hide();
        }
       
        //Disable X button
        private const int CP_NO_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NO_CLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
