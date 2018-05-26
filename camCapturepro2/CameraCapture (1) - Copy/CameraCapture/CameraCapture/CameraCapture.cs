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
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;
using System.Web;

namespace CameraCapture
{
    public partial class Recording : Form
    {
        public string userIdCapture;
        private Capture capture;       
        private bool captureInProgress;
        private HaarCascade haar;
        private int counter;
        private int counterEmail;
        private Bitmap firstFrame;
        
        public Recording()
        {
            InitializeComponent();
            counter = 0;
            counterEmail = 0;
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
                    if (!Equals(firstFrame, BmpInput))
                    {
                        
                        obj.saveImage(file, userIdCapture);
                        counterEmail++;
                    }

                }
                if (counterEmail > 5)
                {
                    sendEmail();
                    sendSMSText();
                  //  sendSmsDetails();
                    counterEmail = 0;
                }
                
                counter = 0;



            }
            CamImgBox.Image = ImageFrame;

            
        }

      
        private void btnStart_Click_1(object sender, EventArgs e)
        {

        

         
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
           

            if (capture != null)
            {
                if (captureInProgress)
                { 
                    btnStart.Text = "Start!"; //
                    record.Hide();//record icon on the interface
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
                
                capture = null;
        }

        private void CameraCapture_Load(object sender, EventArgs e)
        {
       
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
            //ReleaseData();
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


        private void sendEmail()
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = Enabled;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("WeSecureYou12@gmail.com", "mysite1234");
                MailMessage msg = new MailMessage();
                database objData = new database();
                string emailUser=objData.getEmailId(userIdCapture);
                msg.To.Add(emailUser);
                msg.From = new MailAddress("WeSecureYou12@gmail.com");
                msg.Subject = "ALERT!";
                msg.Body = "intuder has been detected";
                client.Send(msg);
                MessageBox.Show("sucessful");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sendSmsDetails()
        {
            database objData = new database();
           string data= objData.getSmsDetails(userIdCapture);
            string[] dataEle = data.Split(',');
            string masking = "weSecureYou";
            string message = "ALERT!! An intruder has been detected.";
          
            string jsonResponse = SendSMS(masking, dataEle[1].ToString(), message, dataEle[0].ToString(), dataEle[2].ToString());
        }



        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://Lifetimesms.com" +
              "/plain?" +
                "username=" + MyUsername +
                "&password=" + MyPassword +
                "&from=" + Masking +
                "&to=" + toNumber +
                "&message=" + System.Net.WebUtility.UrlEncode(MessageText);


            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            MessageBox.Show("404:URL not found :" + URI);
                            break;
                        case HttpStatusCode.BadRequest:
                            MessageBox.Show("400:Bad Request");
                            break;

                        default:
                            return httpWebResponse.StatusCode.ToString();
                    }
                }
            }
            return null;
        }

        private string sendSMSText()
        {
            database objData = new database();
            string data = objData.getSmsDetails(userIdCapture);
            string[] dataEle = data.Split(',');
            string number = "+" + dataEle[1];
            String message = HttpUtility.UrlEncode("ALERT!! INTRUDER has been detected");
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"apikey" , "oxilOxeYqCM-1L12yx3AabzEST4abViGe1FQzgV5pk"},
                {"numbers" , number},
                {"message" , message},
                {"sender" , "secure"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }
    }
}
