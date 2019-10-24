namespace Interview
{
    partial class frmTestVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
            this.lblFPS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdSaveFPS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.KeepAspectRatio = true;
            this.videoSourcePlayer.Location = new System.Drawing.Point(2, 53);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(796, 396);
            this.videoSourcePlayer.TabIndex = 2;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new Accord.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // lblFPS
            // 
            this.lblFPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFPS.ForeColor = System.Drawing.Color.Blue;
            this.lblFPS.Location = new System.Drawing.Point(2, 9);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(523, 41);
            this.lblFPS.TabIndex = 6;
            this.lblFPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdSaveFPS
            // 
            this.cmdSaveFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveFPS.Enabled = false;
            this.cmdSaveFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSaveFPS.Location = new System.Drawing.Point(550, 7);
            this.cmdSaveFPS.Name = "cmdSaveFPS";
            this.cmdSaveFPS.Size = new System.Drawing.Size(248, 42);
            this.cmdSaveFPS.TabIndex = 7;
            this.cmdSaveFPS.Text = "Записать в настройки";
            this.cmdSaveFPS.UseVisualStyleBackColor = true;
            this.cmdSaveFPS.Click += new System.EventHandler(this.cmdSaveFPS_Click);
            // 
            // frmTestVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSaveFPS);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.videoSourcePlayer);
            this.MinimizeBox = false;
            this.Name = "frmTestVideo";
            this.Text = "Тест FPS для видео";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTestVideo_FormClosing);
            this.Load += new System.EventHandler(this.frmTestVideo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Timer timer1;
        public Accord.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button cmdSaveFPS;
    }
}