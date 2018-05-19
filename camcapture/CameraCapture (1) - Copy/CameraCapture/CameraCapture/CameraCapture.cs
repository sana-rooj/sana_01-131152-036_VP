using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System.IO;

namespace CameraCapture
{
    public partial class Recording : Form
    {
        public string userIdCapture;
        private Capture capture;       
        private bool captureInProgress;
        private HaarCascade haar;
        private int counter;
        private Bitmap firstFrame;
        public Recording()
        {
            InitializeComponent();
            counter = 0;
        }
      
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> ImageFrame = capture.QuerySmallFrame();

            if (ImageFrame != null) {

                Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();
                var faces=
                    grayframe.DetectHaarCascade(haar,1.4,4,Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(25,25))[0];
                foreach (var face in faces) {
                    
                    ImageFrame.Draw(face.rect, new Bgr(Color.Green), 3);
                    Bitmap BmpInput = ImageFrame.ToBitmap();
                    if (counter == 0)
                    {
                        firstFrame = BmpInput;
                    }
                    counter++;
                    pictureBox2.Image = BmpInput;
                    ImageConverter converter = new ImageConverter();
                    byte[] file= (byte[])converter.ConvertTo(BmpInput, typeof(byte[]));
                    database obj = new database();
                    if (!Equals(firstFrame,BmpInput))
                    {
                       
                        obj.saveImage(file, userIdCapture);
                    }
                   
                }

                counter = 0;

            
            
            }
            CamImgBox.Image = ImageFrame;

            
        }

      
        private void btnStart_Click_1(object sender, EventArgs e)
        {

        

            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (captureInProgress)
                { 
                    btnStart.Text = "Start!"; //
                    record.Hide();
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    
                    btnStart.Text = "Stop";
                    record.Show();
                    Application.Idle += ProcessFrame;
                }

                captureInProgress = !captureInProgress;
            }
        }

        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void CameraCapture_Load(object sender, EventArgs e)
        {
         MessageBox.Show(userIdCapture);
                haar = new HaarCascade("haarcascade_frontalface_alt2.xml");
                
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void record_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.userIdMenu = userIdCapture;
            obj.Show();
            this.Hide();
        }

        private void CamImgBox_Click(object sender, EventArgs e)
        {

        }

        private static bool Equals(Bitmap bmp1, Bitmap bmp2)
        {
            if (!bmp1.Size.Equals(bmp2.Size))
            {
                return false;
            }
            for (int x = 0; x < bmp1.Width; ++x)
            {
                for (int y = 0; y < bmp1.Height; ++y)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
