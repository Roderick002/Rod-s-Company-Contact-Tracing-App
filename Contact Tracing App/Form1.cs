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
                MessageBox.Show("Choose Your Sex!");
            }

            string Answer1 = null;
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
                MessageBox.Show("Answer Question 1 in Health Status!");
            }

            string Answer2 = null;
            if (RbCtfAnswer2Yes.Checked)
            {
                Answer2 = "YES";
            }

            else if (RbCtfAnswer1No.Checked)
            {
                Answer2 = "NO";
            }
            else
            {
                MessageBox.Show("Answer Question 2 in Health Status!");
            }

            string Answer3 = null;
            if (RbCtfAnswer3Yes.Checked)
            {
                Answer3 = "YES";
            }

            else if (RbCtfAnswer1No.Checked)
            {
                Answer3 = "NO";
            }
            else
            {
                MessageBox.Show("Answer Question 3 in Health Status!");
            }

            if ((TbCtfName.Text == "") ||
                (TbCtfAddress.Text == "") ||
                (TbCtfAge.Text == "")
               )
            {
                MessageBox.Show("Fill All The Information Needed!");
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
    }
}