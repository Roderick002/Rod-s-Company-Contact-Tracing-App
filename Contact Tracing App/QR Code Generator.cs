using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Contact_Tracing_App
{
    public partial class QR_Code_Scanner : Form
    {
        public QR_Code_Scanner()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void LblQrsCamera_Click(object sender, EventArgs e)
        {

        }

        private void BtnQcsStart_Click(object sender, EventArgs e)
        {
            if (BtnQcsStart.Text == "Start")
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[CbQcsCamera.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                TimerQcs.Start();
            }          

            if (BtnQcsStart.Text == "Scan Again")
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[CbQcsCamera.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                TimerQcs.Start();

                
            }

            BtnQcsStart.Text = "Scan Again";
            BtnQcsStart.Enabled = false;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PbQcsScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void QR_Code_Scanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CbQcsCamera.Items.Add(filterInfo.Name);
            CbQcsCamera.SelectedIndex = 0;

            BtnQcsSubmit.Enabled = false;
        }

        private void QR_Code_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((PbQcsScanner.Image != null) && (TimerQcs.Enabled = true))
            {
                captureDevice.SignalToStop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PbQcsScanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)PbQcsScanner.Image);
                if (result != null)
                {
                    //Listing decoded value to a text file for similar format
                    StreamWriter file = File.CreateText(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\QR Scanned Data.txt");
                    file.Write(result.ToString());
                    file.Close();

                    StreamReader Read= new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\QR Scanned Data.txt");

                    string reference;                  
                    do
                    {
                        reference = Read.ReadLine();

                        LbQcsReferenceList.Items.Add(reference.ToString());

                    } while (!Read.EndOfStream);

                    Read.Close();

                    BtnQcsSubmit.Enabled = true;
                 
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.SignalToStop();
                    }
                    
                    TimerQcs.Stop();
                }

            }
        }

        private void PbQcsScanner_Click(object sender, EventArgs e)
        {

        }

        private void BtnQcsBack_Click(object sender, EventArgs e)
        {
            CTFMenu Ctf = new CTFMenu();
            Ctf.Show();

            if ((PbQcsScanner.Image != null) && (TimerQcs.Enabled = true))
            {
                captureDevice.SignalToStop();
            }

            this.Hide();
        }

        private void BtnQcsSubmit_Click(object sender, EventArgs e)
        {
            string Date = DtpQcsDate.Value.ToString("dd/MM/yyyy");
            string Time = DtpQcsDate.Value.ToString("hh:mm tt");

            StreamWriter file = File.AppendText(@"C:\Users\damtr\OneDrive\Desktop\Programs\Contact Tracing App\Contact Tracing Record.txt");
            file.WriteLine("Date: " + Date);
            file.WriteLine(LbQcsReferenceList.Items[0].ToString());
            file.WriteLine("Date: " + Date);
            file.WriteLine("Time In: " + Time);
            for (int i = 1; i < 10; i++)
            {
                file.WriteLine(LbQcsReferenceList.Items[i].ToString());
            }

            file.WriteLine("");
            file.Close();

            BtnQcsStart.Enabled = true;
            BtnQcsSubmit.Enabled = false;
            MessageBox.Show("Record Has Been Successfully Submitted!");
            LbQcsReferenceList.Items.Clear();
            PbQcsScanner.Image = null;
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
