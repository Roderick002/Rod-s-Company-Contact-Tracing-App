using System.IO;
namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a contact tracing app. Strictly follow the given format. Check your input data before clicking submit");
        }

        private void LblCtfName_Click(object sender, EventArgs e)
        {

        }

        private void LblCtfSex_Click(object sender, EventArgs e)
        {

        }

        private void LblCtfAgeFormat_Click(object sender, EventArgs e)
        {

        }

        private void LblCtfPersonlInfo_Click(object sender, EventArgs e)
        {

        }

        private void LblCtfQ3_Click(object sender, EventArgs e)
        {

        }

        private void TbCtfTImeIn_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void BtnCtfSubmit_Click(object sender, EventArgs e)
        {
         
            string Name = TbCtfName.Text;
            string Address = TbCtfAddress.Text;
            string Age = TbCtfAge.Text; 
            string ContactNumber = TbCtfContactNo.Text;
            string TimeIn = TbCtfTImeIn.Text;
            string TimeOut = TbCtfTimeOut.Text;
            string Sex = null;
            string Answer1 = null;
            string Answer2 = null;
            string Answer3 = null;

            if (TbCtfName.Text == "")
            {
                LblCtfName.ForeColor = Color.Red;
                LblCtfNameFormat.ForeColor = Color.Red;
            }
            if (TbCtfAddress.Text == "")
            {
                LblCtfAddress.ForeColor = Color.Red;
                LblCtfAddressFormat.ForeColor = Color.Red;
            }
            if (TbCtfAge.Text == "")
            {
                LblCtfAge.ForeColor = Color.Red;
                LblCtfAgeFormat.ForeColor = Color.Red;
            }
            if (TbCtfContactNo.Text == "")
            {
                LblCtfContactNo.ForeColor = Color.Red;
                LblCtfContactNoFormat.ForeColor = Color.Red;
            }
            if (TbCtfTImeIn.Text == "")
            {
                LblCtfTimeIn.ForeColor = Color.Red;
                LblCtfTimeInFormat.ForeColor = Color.Red;
            }
            if (TbCtfTimeOut.Text == "")
            {
                LblCtfTimeOut.ForeColor = Color.Red;
                LblCtfTimeOutFormat.ForeColor = Color.Red;
            }

            if (RbCtfSexMale.Checked)
            {
                Sex = "Male";
            }
            else if (RbCtfSexFemale.Checked)
            {
                Sex = "Female";
            }
            else
            {
                LblCtfSex.ForeColor = Color.Red;
            }

            
            if (RbCtfAnswer1Yes.Checked)
            {
                Answer1 = "YES";
            }

            else if (RbCtfAnswer1No.Checked)
            {
                Answer1 = "NO";
            }
            else
            {
                LblCtfQ1.ForeColor = Color.Red;
            }

            
            if (RbCtfAnswer2Yes.Checked)
            {
                Answer2 = "YES";
            }

            else if (RbCtfAnswer2No.Checked)
            {
                Answer2 = "NO";
            }
            else
            {
                LblCtfQ2.ForeColor = Color.Red;
            }

            
            if (RbCtfAnswer3Yes.Checked)
            {
                Answer3 = "YES";
            }

            else if (RbCtfAnswer3No.Checked)
            {
                Answer3 = "NO";
            }
            else
            {
                LblCtfQ3.ForeColor = Color.Red; 
            }

            if ((TbCtfName.Text == "") ||
                (TbCtfAddress.Text == "") ||
                (TbCtfAge.Text == "") ||
                (TbCtfTImeIn.Text == "") ||
                (TbCtfTimeOut.Text == "") ||
                ((!RbCtfSexMale.Checked) && (!RbCtfSexFemale.Checked)) ||
                ((!RbCtfAnswer1Yes.Checked) && (!RbCtfAnswer1No.Checked)) ||
                ((!RbCtfAnswer2Yes.Checked) && (!RbCtfAnswer2No.Checked)) ||
                ((!RbCtfAnswer3Yes.Checked) && (!RbCtfAnswer3No.Checked))
               )
            {
                MessageBox.Show("Fill All The Information Needed!");

                    LblCtfName.ForeColor = Color.Black;
                    LblCtfNameFormat.ForeColor = Color.Black;
                    LblCtfAddress.ForeColor = Color.Black;
                    LblCtfAddressFormat.ForeColor = Color.Black;
                    LblCtfAge.ForeColor = Color.Black;
                    LblCtfAgeFormat.ForeColor = Color.Black;
                    LblCtfContactNo.ForeColor = Color.Black;
                    LblCtfContactNoFormat.ForeColor = Color.Black;
                    LblCtfTimeIn.ForeColor = Color.Black;
                    LblCtfTimeInFormat.ForeColor = Color.Black;
                    LblCtfTimeOut.ForeColor = Color.Black;
                    LblCtfTimeOutFormat.ForeColor = Color.Black;
                    LblCtfSex.ForeColor = Color.Black;
                    LblCtfQ1.ForeColor = Color.Black;
                    LblCtfQ2.ForeColor = Color.Black;
                    LblCtfQ3.ForeColor = Color.Black;
                


            }
            else
            {
                StreamWriter file = File.AppendText(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\Contact Tracing Record.txt");
                file.WriteLine("");
                file.WriteLine("Name: " + Name);
                file.WriteLine("Address: " + Address);
                file.WriteLine("Age: " + Age);
                file.WriteLine("Sex: " + Sex);
                file.WriteLine("Contact Number: " + ContactNumber);
                file.WriteLine("Time In: " + TimeIn + "   Time Out: " + TimeOut);
                file.WriteLine(LblCtfQ1.Text + " " + Answer1);
                file.WriteLine(LblCtfQ2.Text + " " + Answer2);
                file.WriteLine(LblCtfQ3.Text + " " + Answer3);
                file.Close();
            }
        }

        private void LblCtfContactNoFormat_Click(object sender, EventArgs e)
        {

        }
    }
}