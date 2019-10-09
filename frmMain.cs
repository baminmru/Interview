using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;
using Accord;

using Accord.Video.FFMPEG;
using System.Xml;
using NAudio.Wave;
using System.IO;

using Newtonsoft.Json;
using System.Net.Http;
using NLog;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Interview
{
    public partial class frmMain : Form
    {
        private const int MINAUDIO = 1;
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private WaveInEvent waveIn;
        private WaveFileWriter waveFile;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCaptureDevice photoDevice;
        private VideoCapabilities[] videoCapabilities;
        private VideoFileWriter FileWriter =  null;

        private bool VideoRecording = false;

        // Audio
        //private MemoryStream stream;

       // private IAudioSource AudioSource;

        //private WaveEncoder encoder;
     


        //private int frames;
        //private int samples;
        //private TimeSpan duration;

        //public int FrameCount=0;
        private Guid UserID;

        public frmMain()
        {
            InitializeComponent();
           

            UserID = Guid.NewGuid();
            logger.Info("UserID=" + UserID.ToString());

            // enumerate video devices
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (myDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in myDevices)
                {
                    photoCombo.Items.Add(device.Name);
                    videoCombo.Items.Add(device.Name);
                }
            }
            else
            {
                videoCombo.Items.Add("No DirectShow devices found");
                photoCombo.Items.Add("No DirectShow devices found");
            }

            photoCombo.SelectedIndex = 0;
            videoCombo.SelectedIndex = 0;

            


            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                AudioDevices.Items.Add(caps.ProductName);
            }
            AudioDevices.SelectedIndex = 0;

            ReadCFG();

        }


        private void photoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myDevices.Count != 0)
            {
                photoDevice = new VideoCaptureDevice(myDevices[photoCombo.SelectedIndex].MonikerString);
                EnumeratedSupportedFrameSizes(photoDevice);
            }
        }

        private void videoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myDevices.Count != 0)
            {
                videoDevice = new VideoCaptureDevice(myDevices[videoCombo.SelectedIndex].MonikerString);
                EnumeratedSupportedFrameSizes2(videoDevice);
            }
        }

        // Collect supported video and snapshot sizes
        private void EnumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            photoResolutionCombo.Items.Clear();
          

            try
            {
                videoCapabilities = videoDevice.VideoCapabilities;
           

                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    photoResolutionCombo.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

               
                if (videoCapabilities.Length == 0)
                {
                    photoResolutionCombo.Items.Add("Not supported");
                }
              
                photoResolutionCombo.SelectedIndex = 0;
                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void EnumeratedSupportedFrameSizes2(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            videoResolutionCombo.Items.Clear();


            try
            {
                videoCapabilities = videoDevice.VideoCapabilities;
            

                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    videoResolutionCombo.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }


                if (videoCapabilities.Length == 0)
                {
                    videoResolutionCombo.Items.Add("Not supported");
                }

                videoResolutionCombo.SelectedIndex = 0;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // On "Connect" button clicked
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (photoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    photoDevice.VideoResolution = videoCapabilities[photoResolutionCombo.SelectedIndex];
                }

               

                photoSourcePlayer.VideoSource = photoDevice;
                photoSourcePlayer.Start();
            }
        }

        // On "Disconnect" button clicked
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        // Disconnect from video device
        private void Disconnect()
        {
            if (photoSourcePlayer.VideoSource != null)
            {
                // stop photo device
                photoSourcePlayer.SignalToStop();
            }
            if (photoSourcePlayer.VideoSource != null)
            {
                photoSourcePlayer.WaitForStop();
                photoSourcePlayer.VideoSource = null;

            }
        }

        private void DisconnectVideo()
        {
            //if (VideoRecording)
            {
               
                if (videoSourcePlayer.VideoSource != null)
                {
                    // stop video device
                    videoSourcePlayer.SignalToStop();
                }
              
                if (videoSourcePlayer.VideoSource != null)
                {
                    videoSourcePlayer.WaitForStop();
                    videoSourcePlayer.VideoSource = null;
                }
                VideoRecording = false;
            }
            
        }


        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (txtPath.Text=="")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }
            XmlDocument xDoc = new XmlDocument();

            xDoc.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?><interview/>");
            XmlNode n = xDoc.LastChild;
            XmlAttribute attr ;
            attr = xDoc.CreateAttribute("F");
            attr.Value = txtF.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("I");
            attr.Value = txtI.Text;
            n.Attributes.Append(attr);


            attr = xDoc.CreateAttribute("O");
            attr.Value = txtO.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("SER");
            attr.Value = textSer.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("NUM");
            attr.Value = txtNum.Text;
            n.Attributes.Append(attr);

            xDoc.Save(txtPath.Text + "/" + UserID.ToString() + ".xml");

            tabInterview.SelectedIndex = 1;
           
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAll();
        }

        private void CmdPath_Click(object sender, EventArgs e)
        {
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderDlg.SelectedPath;

               // SaveCFG();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
            tabInterview.SelectedIndex = 2;
            
        }

     

        private void StopAll()
        {
            Disconnect();
            DisconnectVideo();


            if (waveIn != null)
            {
                waveIn.StopRecording();
                if (waveFile != null)
                {
                    waveFile.Close();
                    waveFile?.Dispose();
                    waveFile = null;
                }
                waveIn.Dispose();
                waveIn = null;

               
            }

            if (FileWriter != null)
            {
                lock (FileWriter)
                {
                    FileWriter.Flush();
                    VideoRecording = false;
                    FileWriter.Close();
                }
                FileWriter = null;

                logger.Info("Merging tracks for video");
                mergefile(txtPath.Text + "/" + UserID.ToString() + ".snd", txtPath.Text + "/" + UserID.ToString() + "_video.avi", txtPath.Text + "/" + UserID.ToString() + ".avi");
            }

            
           
        }

        private void mergefile(string wavefilepath, string videofilepath, string mergedfilepath)
        {
            string Path_FFMPEG = Application.StartupPath + "\\ffmpeg.exe";
           
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            string mp3file = wavefilepath.Replace(".snd", ".mp3");

            try
            {

                proc.StartInfo.Arguments = string.Format("-y -i {0} -vn -ar 16000 -ac 1 -acodec libmp3lame {1}", wavefilepath, mp3file);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.FileName = Path_FFMPEG;
                proc.Start();

                string StdOutVideo = proc.StandardOutput.ReadToEnd();
                string StdErrVideo = proc.StandardError.ReadToEnd();
                logger.Debug(StdErrVideo);
                logger.Debug(StdOutVideo);
            }
            catch (System.Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                proc.WaitForExit();
                proc.Close();
            }


            //ffmpeg - i input.wav - vn - ar 44100 - ac 2 - b:a 192k output.mp3

            try
            {
               
                proc.StartInfo.Arguments = string.Format("-y -i {0} -i {1} -acodec copy -vcodec copy {2}", mp3file, videofilepath, mergedfilepath);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.FileName = Path_FFMPEG;
                proc.Start();

                string StdOutVideo = proc.StandardOutput.ReadToEnd();
                string StdErrVideo = proc.StandardError.ReadToEnd();
                logger.Debug(StdErrVideo);
                logger.Debug(StdOutVideo);
            }
            catch (System.Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                proc.WaitForExit();
                proc.Close();
            }

            try
            {
                File.Delete(wavefilepath);
                File.Delete(mp3file);
                File.Delete(videofilepath);
            }
            catch (System.Exception ex)
            {
                logger.Error(ex);
            }



        }

        private void TabInterview_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopAll();
            logger.Info("Tab changed to " + tabInterview.SelectedIndex.ToString());
            if (tabInterview.SelectedIndex == 0)
            {

               
                startRecord.Enabled = true;
                stopRecord.Enabled = false;
                cmdNextClient.Enabled = false;

                cmdStartAudioRecord.Enabled = true;
                cmdStopAudioRecord.Enabled = false;
                cmdNext2.Enabled = false;

                cmdNext1.Enabled = false;
                cmdStart.Enabled = false;
                lblRecording.Text = "";
                lblRecording.ForeColor = Color.Blue;
                lblPhoto.Text = "";
                lblPhoto.ForeColor = Color.Blue;
                TxtF_TextChanged(sender, e);
            }

            if (tabInterview.SelectedIndex == 1)
            {
                lblPhoto.Text = "";
                lblPhoto.ForeColor = Color.Blue;
                if (photoDevice != null)
                {
                    if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                    {
                        if(photoResolutionCombo.SelectedIndex>=0 && photoResolutionCombo.SelectedIndex< videoCapabilities.Length)
                            photoDevice.VideoResolution = videoCapabilities[photoResolutionCombo.SelectedIndex];
                        else
                            photoDevice.VideoResolution = videoCapabilities[0];
                    }

                    photoSourcePlayer.VideoSource = photoDevice;
                    photoSourcePlayer.Start();
                }
            }
            if (tabInterview.SelectedIndex == 2)
            {
                lblRecording.Text = "";
                lblRecording.ForeColor = Color.Blue;
            }

            if (tabInterview.SelectedIndex == 3)
            {
                if (videoDevice != null)
                {
                    if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                    {
             
                        if (videoResolutionCombo.SelectedIndex >= 0 && videoResolutionCombo.SelectedIndex < videoCapabilities.Length)
                            videoDevice.VideoResolution = videoCapabilities[videoResolutionCombo.SelectedIndex];
                        else
                            videoDevice.VideoResolution = videoCapabilities[0];
                    }

                    videoSourcePlayer.VideoSource = videoDevice;
                    videoSourcePlayer.Start();
                }

               
            }
        }

        //private void AudioSource_NewFrame(object sender, Accord.Audio.NewFrameEventArgs eventArgs)
        //{
        //    if (!VideoRecording) return;
        //    //// Save to memory
        //   // encoder.Encode(eventArgs.Signal);
           
        //    // Update counters
        //    //duration += eventArgs.Signal.Duration;
          
        //    //frames += eventArgs.Signal.Length;

        //}

        private void StartRecord_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }

            if (videoSourcePlayer.VideoSource == null)
            {
                if (videoDevice != null)
                {
                    if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                    {

                        if (videoResolutionCombo.SelectedIndex >= 0 && videoResolutionCombo.SelectedIndex < videoCapabilities.Length)
                            videoDevice.VideoResolution = videoCapabilities[videoResolutionCombo.SelectedIndex];
                        else
                            videoDevice.VideoResolution = videoCapabilities[0];
                    }

                    videoSourcePlayer.VideoSource = videoDevice;
                    videoSourcePlayer.Start();
                }
            }

            logger.Info("Start record video");
            VideoRecording = true;
            FrameCount = 0;
            StartTime = DateTime.Now;

            logger.Info("Start record audio");


            string fPath = txtPath.Text + "/" + UserID.ToString() + ".snd";
            try
            {
                if (File.Exists(fPath))
                {
                    File.Delete(fPath);
                }
            }
            catch (System.Exception ex)
            {
                logger.Error(ex, "Deleting previous wav file");
            }

            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = AudioDevices.SelectedIndex;
            waveIn.WaveFormat = new WaveFormat(16000, 16, 1);
           

            waveIn.BufferMilliseconds = 1000;
            waveFile = new WaveFileWriter(fPath, waveIn.WaveFormat);
            waveIn.DataAvailable += WaveOnDataAvailable;
            waveIn.StartRecording();


            //AudioSource = new AudioCaptureDevice()
            //{
            //    // Listen on 22050 Hz
            //    DesiredFrameSize = 8192,
            //    SampleRate = 22050,
            //    // We will be reading 16-bit PCM
            //    Format = SampleFormat.Format16Bit
            //};
            ////duration = TimeSpan.FromTicks(0);
            //AudioSource.NewFrame += AudioSource_NewFrame;


            // Create stream to store file
            //stream = new MemoryStream();
            //encoder = new WaveEncoder(stream);


            FileWriter = new VideoFileWriter();
            //FileWriter.Codec = VideoCodec.MPEG4;
            //FileWriter.Height = videoDevice.VideoResolution.FrameSize.Height;
            //FileWriter.Width  = videoDevice.VideoResolution.FrameSize.Width;


            fPath = txtPath.Text + "/" + UserID.ToString() + "_video.avi";
            try
            {
                if (File.Exists(fPath))
                {
                    File.Delete(fPath);
                }
            }
            catch (System.Exception ex)
            {
                logger.Error(ex, "Deleting previous video file");
            }

            // Start
            FileWriter.Open(fPath, videoDevice.VideoResolution.FrameSize.Width, videoDevice.VideoResolution.FrameSize.Height,16,VideoCodec.MPEG4);
            //AudioSource.Start();

            startRecord.Enabled = false;
            stopRecord.Enabled = true;

        }
        private void WaveOnDataAvailable(object sender, WaveInEventArgs a)
        {
            waveFile.WriteAsync(a.Buffer, 0, a.BytesRecorded);
            //System.Diagnostics.Debug.Print("recoded: " + a.BytesRecorded.ToString());
            
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        async private void Button1_Click(object sender, EventArgs e)
        {
            
            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }

            //if (txtQServer.Text == "")
            //{
            //    MessageBox.Show("Задайте имя сервера для проверки качества");
            //    return;
            //}

            cmdShot.Enabled = false;
            logger.Info("Make photo");
            try
            {

                lock (photoSourcePlayer)
                {
                    
                    Bitmap b = new Bitmap(photoSourcePlayer.GetCurrentVideoFrame());
                    Image bi ;
                    bi = (Image)b;

                    {
                        string fPath = txtPath.Text + "\\" + UserID.ToString() + ".jpg";
                        try {
                            if (File.Exists(fPath))
                            {
                                File.Delete(fPath);
                            }
                        }
                        catch (System.Exception ex)
                        {
                            logger.Error(ex,"Deleting previous photo");
                        }
                        EncoderParameters ep = new System.Drawing.Imaging.EncoderParameters(1);
                        System.Drawing.Imaging.Encoder myEncoder =  System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                        ep.Param[0] = myEncoderParameter;
                        ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

                        bi.Save(fPath, jgpEncoder, ep);
                    }
                }

                if (txtQServer.Text == "")
                {
                    lblPhoto.Text = "Сервер для проверки не определен. Фото не проверяется!";
                    lblPhoto.ForeColor = Color.Red;
                    cmdNext1.Enabled = true;
                }
                else
                {

                    lblPhoto.Text = "Идет проверка";
                    lblPhoto.ForeColor = Color.Blue;

                    bool result = await VerifyPhoto();
                    if (result)
                    {
                        cmdNext1.Enabled = true;
                        lblPhoto.Text = "Проверено!";
                        lblPhoto.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblPhoto.Text = "Ещё разок :-(";
                        lblPhoto.ForeColor = Color.Red;
                    }
                }
            }
            catch (System.Exception ex)
            {
                logger.Error(ex);
            }
            cmdShot.Enabled = true;
        }

       

        private void StopRecord_Click(object sender, EventArgs e)
        {
            
            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }

            logger.Info("Stop record audio");
            StopAll();

            startRecord.Enabled = true;
            stopRecord.Enabled = false;
            cmdNextClient.Enabled = true;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtF.Text = "";
            txtI.Text = "";
            txtO.Text = "";
            txtNum.Text = "";
            textSer.Text = "";
            UserID = Guid.NewGuid();
            tabInterview.SelectedIndex = 0;
        }
        
        private void PhotoSourcePlayer_NewFrameReceived(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            //pictureBox1.Image = eventArgs.Frame;
        }

        //private void VideoSourcePlayer1_NewFrameReceived(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        //{
        //    if (!VideoRecording) return;

        //    if (FileWriter != null)
        //    {
              
        //        lock (FileWriter)
        //        {
        //            try
        //            {
        //                FileWriter.WriteVideoFrame(eventArgs.Frame);
        //                FileWriter.Flush();
        //            }
        //            catch(System.Exception ex )
        //            {
        //                System.Diagnostics.Debug.Print(ex.Message);
        //            }

        //        }
        //    }
            
        //}

        private void CmdSaveCFG_Click(object sender, EventArgs e)
        {
            SaveCFG();
            ReadCFG();
        }
        private void SaveCFG()
        {
            logger.Info("Save config");

            XmlDocument xDoc = new XmlDocument();

            xDoc.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?><config/>");
            XmlNode n = xDoc.LastChild;
            XmlAttribute attr;

            if (txtPath.Text != "")
            {
                if (Directory.Exists(txtPath.Text))
                {
                    attr = xDoc.CreateAttribute("path");
                    attr.Value = txtPath.Text;
                    n.Attributes.Append(attr);
                }
            }
            else
            {
                logger.Info("Use default directory");

                txtPath.Text =Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"/Interview";
                if (!Directory.Exists(txtPath.Text))
                {
                    Directory.CreateDirectory(txtPath.Text);
                }
                if (Directory.Exists(txtPath.Text))
                {
                    attr = xDoc.CreateAttribute("path");
                    attr.Value = txtPath.Text;
                    n.Attributes.Append(attr);
                }
            }

            if (txtQServer.Text != "")
            {
                if (!txtQServer.Text.EndsWith("/"))
                    txtQServer.Text += "/";

                attr = xDoc.CreateAttribute("QServer");
                attr.Value = txtQServer.Text;
                n.Attributes.Append(attr);
            }
            else
            {
                logger.Info("Check server not defined!");
            }

            attr = xDoc.CreateAttribute("PhotoCamera");
            attr.Value = photoCombo.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("PhotoResolution");
            attr.Value = photoResolutionCombo.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("VideoCamera");
            attr.Value = videoCombo.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("VideoResolution");
            attr.Value = videoResolutionCombo.Text;
            n.Attributes.Append(attr);

            attr = xDoc.CreateAttribute("AudioDevice");
            attr.Value = AudioDevices.Text;
            n.Attributes.Append(attr);


            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) ;

            try
            {
                xDoc.Save(path + @"\Interview_Config.xml");
            }catch (Exception ex)
            {
                logger.Error(ex);
            }

        }

        void ReadCFG()
        {
            logger.Info("Read config");
            try
            {
                XmlDocument xDoc = new XmlDocument();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                xDoc.Load(path + @"\Interview_Config.xml");
              
                XmlNode n = xDoc.LastChild;
                XmlAttribute attr;

                try
                {
                    attr = n.Attributes["path"];
                    if (Directory.Exists(attr.Value))
                    {
                        txtPath.Text = attr.Value;
                    }
                    else
                    {
                        txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +@"\Interview";
                        if (!Directory.Exists(txtPath.Text))
                        {
                            Directory.CreateDirectory(txtPath.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }

                try
                {
                    attr = n.Attributes["QServer"];
                    txtQServer.Text = attr.Value;
                }
                catch(Exception ex) {
                    logger.Error(ex);
                }

                try
                {
                    if(photoCombo.Items.Contains(n.Attributes["PhotoCamera"].Value))
                        photoCombo.Text = n.Attributes["PhotoCamera"].Value;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }


                try
                {
                    if(photoResolutionCombo.Items.Contains(n.Attributes["PhotoResolution"].Value))
                        photoResolutionCombo.Text = n.Attributes["PhotoResolution"].Value;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }


                try
                {
                    if(videoCombo.Items.Contains(n.Attributes["VideoCamera"].Value))
                        videoCombo.Text= n.Attributes["VideoCamera"].Value;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }


                try
                {
                    if(videoResolutionCombo.Items.Contains(n.Attributes["VideoResolution"].Value))
                        videoResolutionCombo.Text = n.Attributes["VideoResolution"].Value;      
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }


                try
                {
                    if(AudioDevices.Items.Contains(n.Attributes["AudioDevice"].Value))
                        AudioDevices.Text = n.Attributes["AudioDevice"].Value;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabInterview.SelectedIndex = 3;
        }

        TimeSpan recordTime;
        DateTime recordStartTime;
        private void CmdStartAudioRecord_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }
            //if (txtQServer.Text == "")
            //{
            //    MessageBox.Show("Задайте имя сервера для проверки качества");
            //    return;
            //}

            logger.Info("Start record audio");
            string fPath = txtPath.Text + "/" + UserID.ToString() + ".wav";
            try
            {
                if (File.Exists(fPath))
                {
                    File.Delete(fPath);
                }
            }
            catch (System.Exception ex)
            {
                logger.Error(ex, "Deleting previous wav file");
            }
            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = AudioDevices.SelectedIndex;
            waveIn.WaveFormat = new WaveFormat(16000, 16, 1);
            waveIn.BufferMilliseconds = 2000;
            waveFile = new WaveFileWriter(fPath, waveIn.WaveFormat);
            waveIn.DataAvailable += WaveOnDataAvailable;
            waveIn.StartRecording();
            cmdStartAudioRecord.Enabled = false;
           
            recordStartTime = DateTime.Now;
            timer1.Enabled = true;
        }

        async private void CmdStopAudioRecord_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь для сохранения файлов");
                return;
            }
            logger.Info("Stop record audio");
            StopAll();
            timer1.Enabled = false;

            if (txtQServer.Text == "")
            {
                lblRecording.Text = "Сервер для проверки не задан. Проверка аудио не производится." ;
                lblRecording.ForeColor = Color.Red;
                cmdNext2.Enabled = true;
            }
            else
            {
                lblRecording.Text = "Проверка записи";
                lblRecording.ForeColor = Color.Blue;

                cmdStartAudioRecord.Enabled = true;
                cmdStopAudioRecord.Enabled = false;

                bool result = await VerifyRecord();
                if (result)
                {
                    cmdNext2.Enabled = true;
                    lblRecording.Text = "Качество записи удовлетворительно";
                    lblRecording.ForeColor = Color.Green;
                }
                else
                {
                    lblRecording.Text = "Проверка дала отрицательный результат. (" + VerifyState + ")";
                    lblRecording.ForeColor = Color.Red;
                }

            }

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void CmdPrepareFiles_Click(object sender, EventArgs e)
        {

            if (txtPrefix.Text == "")
            {
                MessageBox.Show("Задайте номер группы");
                return;
            }

            if (txtPath.Text == "")
            {
                MessageBox.Show("Задайте путь к файлам");
                return;
            }
            txtLog.Text = "";

            DirectoryInfo di = new DirectoryInfo(txtPath.Text);
            FileInfo[] files = di.GetFiles("*.xml");
            //Dictionary<Guid, string> src = new Dictionary<Guid, string>();
            List<string> src = new List<string>();
            pb.Visible = true;
            pb.Minimum = 0;
            pb.Maximum = files.Length;
            pb.Value = 0;
            foreach (FileInfo f in files)
            {
                pb.Value += 1;
                try
                {
                    XmlDocument xDoc = new XmlDocument();

                    xDoc.Load(f.FullName);
                    XmlNode n = xDoc.LastChild;
                    XmlAttribute attr;
                    string Name = "";
                    try
                    {
                        attr = n.Attributes["F"];
                        Name += attr.Value;
                    }
                    catch {
                        Name += "?";
                    }

                    try
                    {
                        attr = n.Attributes["I"];
                        Name += "_" + attr.Value;
                    }
                    catch {
                        Name += "_?";
                    }

                    try
                    {
                        attr = n.Attributes["O"];
                        Name += "_" + attr.Value;
                    }
                    catch {

                        Name += "_?";
                    }
                    Name += ";" + f.Name.Replace(f.Extension, "");
                    src.Add(Name);
                }
                catch { }
            }
            pb.Value = 0;


            src.Sort();
            foreach(String s in src)
            {
                pb.Value++;
                String[] spl = s.Split(';');
                FileInfo[] toRename = di.GetFiles(spl[1]+"*.*");
                txtLog.Text = spl[0] + "\r\n" + txtLog.Text;
                foreach (FileInfo rf in toRename)
                {
                    txtLog.Text = rf.Name + " -> " + txtPrefix.Text + "." + pb.Value.ToString() + "." + spl[0] + rf.Extension + "\r\n" + txtLog.Text;
                    rf.MoveTo(txtPath.Text + "/" + txtPrefix.Text + "." + pb.Value.ToString() + "." + spl[0] + rf.Extension);
                }


            }

            pb.Visible = false;
            pb.Value = 0;
        }

        private void TxtF_TextChanged(object sender, EventArgs e)
        {
            if(txtF.Text !="" && txtI.Text != "")
            {
                cmdStart.Enabled = true;
            }
            else
            {
                cmdStart.Enabled = false;
            }
        }

        private void TxtI_TextChanged(object sender, EventArgs e)
        {
            if (txtF.Text != "" && txtI.Text != "")
            {
                cmdStart.Enabled = true;
            }
            else
            {
                cmdStart.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            recordTime = DateTime.Now - recordStartTime;
            lblRecording.Text = "Идет запись: " + recordTime.ToString(@"hh\:mm\:ss");
            lblRecording.ForeColor = Color.Blue;
            if(DateTime.Now > recordStartTime.AddSeconds(MINAUDIO))
            {
                cmdStopAudioRecord.Enabled = true;
            }
        }


        private string VerifyState = "";
        private async Task<bool> VerifyRecord()
        {
          

            bool OK = false;
            if (txtQServer.Text == "")
                return false;
            try
            {
                VerifyState = "";
                HttpClient client = new HttpClient();

                ProxyFile pf = new ProxyFile();
                pf.Data = File.ReadAllBytes(txtPath.Text + "/" + UserID.ToString() + ".wav");
                pf.FileName = UserID.ToString() + ".wav";
                logger.Info("verify file: " + pf.FileName);

                // pass file to check server
                logger.Info("upload file");
                var content = new StringContent(JsonConvert.SerializeObject(pf), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(txtQServer.Text  + "api/QualityProxy/uploadfile", content);
                string cont = await result.Content.ReadAsStringAsync();
                logger.Info(cont);


                logger.Info("start checking");
                // start checking process
                var result2 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/startcheckaudio/" + pf.FileName);
                string cont2 = await result2.Content.ReadAsStringAsync();
                logger.Info(cont2);
                var res2 = JsonConvert.DeserializeObject<RespID>(cont2);
                string id = res2.id;



                int cnt = 5;
                while (cnt > 0 && OK == false)
                {
                    cnt--;
                    System.Threading.Thread.Sleep(1000);
                    logger.Info("verify result");
                    // verify process
                    var result3 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/resultcheckaudio/" + id);
                    string cont3 = await result3.Content.ReadAsStringAsync();
                    logger.Info(cont3);

                    try
                    {
                        var data = JsonConvert.DeserializeObject<RootObject>(cont3);
                        if (data.body.vad_segmentations[0].quality.ToString() != "")
                            if (data.body.vad_segmentations[0].quality.ToString() != "0")
                            {
                                OK = true;
                            }
                            else
                            {
                                VerifyState = data.body.vad_segmentations[0].state;
                                cnt = 0;
                            }
                    }
                    catch (System.Exception ex)
                    {
                        logger.Error(ex);
                    }
                    
                }


                // delete results
                logger.Info("delete operation");
                var result4 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/delcheckaudio/" + id);
                string cont4 = await result4.Content.ReadAsStringAsync();
                logger.Info(cont4);

                // delete file on server
                logger.Info("unlink file");
                var result5 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/unlinkfile/" + pf.FileName);
                string cont5 = await result5.Content.ReadAsStringAsync();
                logger.Info(cont5);

            }
            catch (System.Exception ex)
            {
                logger.Error(ex);  
                return false;
            }


            return OK;
        }


        private async Task<bool> VerifyPhoto()
        {
            bool OK = false;

            if (txtQServer.Text == "")
                return false;
            try
            {
                HttpClient client = new HttpClient();

                ProxyFile pf = new ProxyFile();
                pf.Data = File.ReadAllBytes(txtPath.Text + "/" + UserID.ToString() + ".jpg");
                pf.FileName = UserID.ToString() + ".jpg";
                logger.Info("verify file: " + pf.FileName);

                logger.Info("upload file");
                // pass file to check server
                var content = new StringContent(JsonConvert.SerializeObject(pf), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(txtQServer.Text + "api/QualityProxy/uploadfile", content);
                string cont = await result.Content.ReadAsStringAsync();
                logger.Info(cont);


                logger.Info("start checking");
                // start checking process
                var result2 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/startcheckimage/" + pf.FileName);
                string cont2 = await result2.Content.ReadAsStringAsync();
                logger.Info(cont2);
                var res2 = JsonConvert.DeserializeObject<RespID>(cont2);
                string id = res2.id;


                int cnt = 5;
                while (cnt > 0 && OK == false)
                {
                    cnt--;
                    System.Threading.Thread.Sleep(1000);
                    logger.Info("verify result");
                    // verify process
                    var result3 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/resultcheckimage/" + id);
                    string cont3 = await result3.Content.ReadAsStringAsync();
                    logger.Info(cont3);

                    try
                    {
                        var data = JsonConvert.DeserializeObject<IResult>(cont3);
                        if (data.body.detections.Count>0)
                            if (data.body.detections[0].confidence.ToString() != "")
                                if (data.body.detections[0].confidence.ToString() != "0")
                                    OK = true;
                    }
                    catch (System.Exception ex)
                    {
                        logger.Error(ex);
                    }

                }


                logger.Info("delete operation");
                // delete results
                var result4 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/delcheckimage/" + id);
                string cont4 = await result4.Content.ReadAsStringAsync();
                logger.Info(cont4);

                logger.Info("unlink file");
                // delete file on server
                var result5 = await client.GetAsync(txtQServer.Text + "api/QualityProxy/unlinkfile/" + pf.FileName);
                string cont5 = await result5.Content.ReadAsStringAsync();
                logger.Info(cont5);

            }
            catch (System.Exception ex)
            {
                logger.Error(ex);
                return false;
            }


            return OK;
        }

        private void LblPhoto_Click(object sender, EventArgs e)
        {

        }

        private void TxtQServer_TextChanged(object sender, EventArgs e)
        {

        }

        private uint FrameCount=0;
        private DateTime StartTime;
        private TimeSpan ts = new TimeSpan(0);
        private void VideoSourcePlayer_NewFrame_1(object sender, ref Bitmap image)
        {
            if (!VideoRecording) return;

            if (FileWriter != null)
            {

                //lock (FileWriter)
                //{
                    try
                    {
                        FrameCount++;
                        //ts = DateTime.Now - StartTime;
                        FileWriter.WriteVideoFrame(image,FrameCount);
                        //System.Diagnostics.Debug.Print("NewFrame: " + FrameCount.ToString());
                    }
                    catch (System.Exception ex)
                    {
                        logger.Error(ex);
                    }

                //}
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://linkas.ru/");
        }
    }
}

