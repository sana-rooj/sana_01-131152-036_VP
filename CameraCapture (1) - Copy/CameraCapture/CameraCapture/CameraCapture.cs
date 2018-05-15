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
        //declaring global variables
        private Capture capture;        //takes images from camera as image frames
        private bool captureInProgress;
        private HaarCascade haar;

        public Recording()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------//
        //Process Frame() below is our user defined function in which we will create an EmguCv 
        //type image called ImageFrame. capture a frame from camera and allocate it to our 
        //ImageFrame. then show this image in ourEmguCV imageBox
        //------------------------------------------------------------------------------//
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> ImageFrame = capture.QuerySmallFrame();

            if (ImageFrame != null) {

                Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();
                var faces=
                    grayframe.DetectHaarCascade(haar,1.4,4,Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(25,25))[0];
                foreach (var face in faces) {

                    ImageFrame.Draw(face.rect, new Bgr(Color.Green), 3);
                    //byte[] file;
                    //string path = @"C: \Users\sanaa\Downloads\download.jpg";

                    //using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    //{
                    //    using (var reader = new BinaryReader(stream))
                    //    {
                    //        file = reader.ReadBytes((int)stream.Length);
                    //    }
                    //}
                    //database obj = new database();
                    //MessageBox.Show(userIdCapture);
                    //obj.saveImage(file, userIdCapture);

                }
            
            
            
            
            }
            CamImgBox.Image = ImageFrame;

            
        }

        //btnStart_Click() function is the one that handles our "Start!" button' click 
        //event. it creates a new capture object if its not created already. e.g at first time
        //starting. once the capture is created, it checks if the capture is still in progress,
        //if so the
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
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    btnStart.Text = "Start!"; //
                    record.Hide();
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
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
            obj.Show();
            this.Hide();
        }

        private void CamImgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
