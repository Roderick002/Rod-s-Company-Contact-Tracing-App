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
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CbQcsCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            TimerQcs.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PbQcsScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QR_Code_Scanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CbQcsCamera.Items.Add(filterInfo.Name);
            CbQcsCamera.SelectedIndex = 0;
        }

        private void QR_Code_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PbQcsScanner.Image != null)
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
                    TbQcsData.Text = result.ToString();
                    TimerQcs.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.SignalToStop();
                    }
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

            if (PbQcsScanner.Image != null)
            {
                captureDevice.SignalToStop();
            }

            this.Hide();
        }
    }
}
