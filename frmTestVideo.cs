using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interview
{
    public partial class frmTestVideo : Form
    {

        public DateTime StartTime=DateTime.MinValue;
        public int FrameCount=0;
        public int LastFPS = 0;
        public bool SaveLastFPS = false;

        public frmTestVideo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StartTime != DateTime.MinValue)
            {
                TimeSpan ts = DateTime.Now - StartTime;
                if (ts.TotalSeconds > 0)
                {
                    lblFPS.Text = "FPS: " + (FrameCount / ts.TotalSeconds).ToString("#0.00");
                    LastFPS =(int) Math.Floor(FrameCount / ts.TotalSeconds);
                    if (cmdSaveFPS.Enabled == false)
                        cmdSaveFPS.Enabled = true;
                }
                    
            }
            Application.DoEvents();
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            if (StartTime == DateTime.MinValue)
            {
                FrameCount = 0;
                StartTime = DateTime.Now;
                timer1.Enabled = true;
            }
            FrameCount++;
        }

        private void frmTestVideo_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void frmTestVideo_Load(object sender, EventArgs e)
        {
            FrameCount = 0;
            LastFPS = 0;
            SaveLastFPS = false;
            timer1.Enabled = true;
        }

        private void cmdSaveFPS_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SaveLastFPS = true;
            this.Close();
        }
    }
}
