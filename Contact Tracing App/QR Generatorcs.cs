using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Contact_Tracing_App
{
    public partial class QR_Generatorcs : Form
    {
        public QR_Generatorcs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QR_Generatorcs_Load(object sender, EventArgs e)
        {
            GbQcgReference.Visible = false;
            BtnQcgSaveQr.Enabled = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void TbQrgAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnQcgGenerate_Click(object sender, EventArgs e)
        {
            //Variable Declarations
            string Name = TbCtfName.Text;
            string Address = TbCtfAddress.Text;
            string Age = TbCtfAge.Text;
            string ContactNumber = TbCtfContactNo.Text;
            string Sex = null;
            string Answer1 = null;
            string Answer2 = null;
            string Answer3 = null;

            //Labels Fore Color Changing For Unfilled Information
            if (TbCtfName.Text == "")
            {
                LblCtfName.ForeColor = Color.Red;
            }
            if (TbCtfAddress.Text == "")
            {
                LblCtfAddress.ForeColor = Color.Red;
            }
            if (TbCtfAge.Text == "")
            {
                LblCtfAge.ForeColor = Color.Red;
            }
            if (TbCtfContactNo.Text == "")
            {
                LblCtfContactNo.ForeColor = Color.Red;
            }

            //Radio Buttons(Sex, Q1, Q2, Q3) Return Value for Record
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

            //Unfilled Information Condition
            if ((TbCtfName.Text == "") ||
                (TbCtfAddress.Text == "") ||
                (TbCtfAge.Text == "") ||
                (TbCtfContactNo.Text == "") ||
                ((!RbCtfSexMale.Checked) && (!RbCtfSexFemale.Checked)) ||
                ((!RbCtfAnswer1Yes.Checked) && (!RbCtfAnswer1No.Checked)) ||
                ((!RbCtfAnswer2Yes.Checked) && (!RbCtfAnswer2No.Checked)) ||
                ((!RbCtfAnswer3Yes.Checked) && (!RbCtfAnswer3No.Checked))
               )
            {
                MessageBox.Show("Fill All The Information Needed!");

                LblCtfName.ForeColor = Color.Black;
                LblCtfAddress.ForeColor = Color.Black;
                LblCtfAge.ForeColor = Color.Black;
                LblCtfSex.ForeColor = Color.Black;
                LblCtfContactNo.ForeColor = Color.Black;
                LblCtfQ1.ForeColor = Color.Black;
                LblCtfQ2.ForeColor = Color.Black;
                LblCtfQ3.ForeColor = Color.Black;
            }
            //Information Writing Format For Text File Record
            else
            {
                TbQcgReference.AppendText("Name: " + Name);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText("Address: " + Address);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText("Age: " + Age);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText("Sex: " + Sex);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText("Contact Number: " + ContactNumber);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText(LblCtfQ1.Text + " " + Answer1);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText(LblCtfQ2.Text + " " + Answer2);
                TbQcgReference.AppendText(Environment.NewLine);
                TbQcgReference.AppendText(LblCtfQ3.Text + " " + Answer3);

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(TbQcgReference.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                PbQcgQrcode.Image = code.GetGraphic(3);
                

                TbQcgName.Text = Name;

                BtnQcgSaveQr.Enabled = true;
                BtnQcgGenerate.Enabled = false;
            }
        }

        private void PbQcgQrcode_Click(object sender, EventArgs e)
        {

        }

        private void BtnQcgSaveQr_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(QrgPanelSaveQr.Width,QrgPanelSaveQr.Height))
            {
                QrgPanelSaveQr.DrawToBitmap(bmp, new Rectangle(0,0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\Saved QR Codes\" + TbQcgName.Text + ".jpeg");

                MessageBox.Show("Your QR Code Has Been Succesfully Saved");
                //Answers Field Return To Blank In Preparation For Another Response  
                TbCtfName.Text = ("");
                TbCtfAddress.Text = ("");
                TbCtfAge.Text = ("");
                TbCtfContactNo.Text = ("");
                RbCtfSexMale.Checked = false;
                RbCtfSexFemale.Checked = false;
                RbCtfAnswer1Yes.Checked = false;
                RbCtfAnswer1No.Checked = false;
                RbCtfAnswer2Yes.Checked = false;
                RbCtfAnswer2No.Checked = false;
                RbCtfAnswer3Yes.Checked = false;
                RbCtfAnswer3No.Checked = false;
                TbQcgReference.Text = ("");
                PbQcgQrcode.Image = null;
                TbQcgName.Text = ("");
                BtnQcgGenerate.Enabled = true;
            }
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
        private void BtnQcgBack_Click(object sender, EventArgs e)
        {
            CTFMenu Ctf = new CTFMenu();
            Ctf.Show();

            this.Hide();
        }

        private void QrgPanelSaveQr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbQcgName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
