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
            

            StreamReader file = new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\Contact Tracing Record.txt");

            string reference;
            do
            {
                reference = file.ReadLine();

                LbCtfReferenceList.Items.Add(reference.ToString());

            } while (!file.EndOfStream);

            BtnCtfFilter.Enabled = false;
            BtnCtfViewDetails.Enabled = false;
        }

        //View All Records
        private void BtnCtfViewAll_Click(object sender, EventArgs e)
        {
            int length = LbCtfReferenceList.Items.Count;

            LbCtfRecordList.Items.Clear();

            for (int i = 2; i < length; i += 14)
            {
                String records = LbCtfReferenceList.Items[i].ToString();
                LbCtfRecordList.Items.Add(records);

            }

            BtnCtfViewDetails.Enabled = true;
            BtnCtfFilter.Enabled = true ;
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


        //View Details Of The Selected Record
        private void BtnCtfViewDetails_Click(object sender, EventArgs e)
        {
            if (BtnCtfFilter.Enabled == true)
            {
                if (LbCtfRecordList.SelectedItems.Count != 0)
                {

                    int index = LbCtfRecordList.SelectedIndex;
                    int details = index * 13;
                    int length = details + 14;
                    LbCtfRecordList.Items.Clear();

                    for (int i = details + (index + 2); i < length + index; i++)
                    {

                        String records = LbCtfReferenceList.Items[i].ToString();

                        LbCtfRecordList.Items.Add(records);

                    }

                    BtnCtfViewDetails.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Select a Record!");
                }
            }
           else if (BtnCtfFilter.Enabled == false)
            {
                string Date = DtpCtfDate.Value.ToString("dd/MM/yyyy");
                int firstindex = LbCtfReferenceList.FindStringExact("Date: " + Date);
                int index = LbCtfRecordList.SelectedIndex;
                int details = firstindex + (13 * index);
                int length = firstindex + (13 * index) + 13;
                LbCtfRecordList.Items.Clear();

                for (int i = details + (index + 1); i < length + index; i++)
                {

                    String records = LbCtfReferenceList.Items[i].ToString();

                    LbCtfRecordList.Items.Add(records);

                }
                BtnCtfFilter.Enabled = true;
                BtnCtfViewDetails.Enabled = false;
            }


        }
        //Date Filter
        private void BtnCtfFilter_Click(object sender, EventArgs e)
        {
            string date = "Date: " + DtpCtfDate.Text;
            int length = LbCtfReferenceList.Items.Count;
            LbCtfRecordList.Items.Clear();
            BtnCtfViewDetails.Enabled = true;

            for (int i = 1; i < length; i+=14)
            {
                string record = LbCtfReferenceList.Items[i].ToString();

                if (date == record)
                {
                    string filtered = LbCtfReferenceList.Items[i + 1].ToString();
                    LbCtfRecordList.Items.Add(filtered);
                }

            }
            BtnCtfFilter.Enabled = false;

        }
        private void GbCtfListReference_Enter(object sender, EventArgs e)
        {

        }

        private void LbCtfRecordList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpCtfDate_ValueChanged(object sender, EventArgs e)
        {
            BtnCtfFilter.Enabled = true;
        }
    }
}
