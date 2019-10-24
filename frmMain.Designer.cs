namespace Interview
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabInterview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.photoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
            this.cmdNext1 = new System.Windows.Forms.Button();
            this.cmdShot = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblRecording = new System.Windows.Forms.Label();
            this.cmdNext2 = new System.Windows.Forms.Button();
            this.cmdStopAudioRecord = new System.Windows.Forms.Button();
            this.cmdStartAudioRecord = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFPS = new System.Windows.Forms.Label();
            this.cmdNextClient = new System.Windows.Forms.Button();
            this.stopRecord = new System.Windows.Forms.Button();
            this.startRecord = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmdPrepareFiles = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmdSaveCFG = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AudioDevices = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numFPS = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.videoResolutionCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.videoCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.photoResolutionCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.photoCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtQServer = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabInterview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFPS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInterview
            // 
            this.tabInterview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInterview.Controls.Add(this.tabPage1);
            this.tabInterview.Controls.Add(this.tabPage2);
            this.tabInterview.Controls.Add(this.tabPage5);
            this.tabInterview.Controls.Add(this.tabPage3);
            this.tabInterview.Controls.Add(this.tabPage6);
            this.tabInterview.Controls.Add(this.tabPage4);
            this.tabInterview.Controls.Add(this.tabPage7);
            this.tabInterview.ImageList = this.imageList1;
            this.tabInterview.Location = new System.Drawing.Point(13, 14);
            this.tabInterview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInterview.Name = "tabInterview";
            this.tabInterview.SelectedIndex = 0;
            this.tabInterview.Size = new System.Drawing.Size(760, 643);
            this.tabInterview.TabIndex = 0;
            this.tabInterview.SelectedIndexChanged += new System.EventHandler(this.TabInterview_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtO);
            this.tabPage1.Controls.Add(this.txtI);
            this.tabPage1.Controls.Add(this.txtF);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmdStart);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(752, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные тестируемого";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Документ";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.Location = new System.Drawing.Point(121, 91);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(584, 26);
            this.txtNum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Номер:";
            // 
            // textSer
            // 
            this.textSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSer.Location = new System.Drawing.Point(121, 32);
            this.textSer.Name = "textSer";
            this.textSer.Size = new System.Drawing.Size(584, 26);
            this.textSer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Серия:";
            // 
            // txtO
            // 
            this.txtO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtO.Location = new System.Drawing.Point(135, 126);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(584, 26);
            this.txtO.TabIndex = 6;
            // 
            // txtI
            // 
            this.txtI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtI.Location = new System.Drawing.Point(135, 64);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(584, 26);
            this.txtI.TabIndex = 5;
            this.txtI.TextChanged += new System.EventHandler(this.TxtI_TextChanged);
            // 
            // txtF
            // 
            this.txtF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF.Location = new System.Drawing.Point(135, 11);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(584, 26);
            this.txtF.TabIndex = 4;
            this.txtF.TextChanged += new System.EventHandler(this.TxtF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStart.Enabled = false;
            this.cmdStart.Image = ((System.Drawing.Image)(resources.GetObject("cmdStart.Image")));
            this.cmdStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStart.Location = new System.Drawing.Point(7, 521);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(737, 60);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Начать интервью";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPhoto);
            this.tabPage2.Controls.Add(this.photoSourcePlayer);
            this.tabPage2.Controls.Add(this.cmdNext1);
            this.tabPage2.Controls.Add(this.cmdShot);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(752, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фото";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPhoto
            // 
            this.lblPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoto.ForeColor = System.Drawing.Color.Red;
            this.lblPhoto.Location = new System.Drawing.Point(7, 449);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(738, 64);
            this.lblPhoto.TabIndex = 4;
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhoto.Click += new System.EventHandler(this.LblPhoto_Click);
            // 
            // photoSourcePlayer
            // 
            this.photoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoSourcePlayer.KeepAspectRatio = true;
            this.photoSourcePlayer.Location = new System.Drawing.Point(7, 8);
            this.photoSourcePlayer.Name = "photoSourcePlayer";
            this.photoSourcePlayer.Size = new System.Drawing.Size(739, 438);
            this.photoSourcePlayer.TabIndex = 0;
            this.photoSourcePlayer.VideoSource = null;
            // 
            // cmdNext1
            // 
            this.cmdNext1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNext1.Enabled = false;
            this.cmdNext1.Image = ((System.Drawing.Image)(resources.GetObject("cmdNext1.Image")));
            this.cmdNext1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNext1.Location = new System.Drawing.Point(453, 521);
            this.cmdNext1.Name = "cmdNext1";
            this.cmdNext1.Size = new System.Drawing.Size(293, 60);
            this.cmdNext1.TabIndex = 2;
            this.cmdNext1.Text = "Далее";
            this.cmdNext1.UseVisualStyleBackColor = true;
            this.cmdNext1.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cmdShot
            // 
            this.cmdShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdShot.Image = ((System.Drawing.Image)(resources.GetObject("cmdShot.Image")));
            this.cmdShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdShot.Location = new System.Drawing.Point(7, 521);
            this.cmdShot.Name = "cmdShot";
            this.cmdShot.Size = new System.Drawing.Size(440, 60);
            this.cmdShot.TabIndex = 1;
            this.cmdShot.Text = "Сделать Фото";
            this.cmdShot.UseVisualStyleBackColor = true;
            this.cmdShot.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblRecording);
            this.tabPage5.Controls.Add(this.cmdNext2);
            this.tabPage5.Controls.Add(this.cmdStopAudioRecord);
            this.tabPage5.Controls.Add(this.cmdStartAudioRecord);
            this.tabPage5.ImageIndex = 2;
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 600);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Аудио";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblRecording
            // 
            this.lblRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecording.ForeColor = System.Drawing.Color.Red;
            this.lblRecording.Location = new System.Drawing.Point(7, 16);
            this.lblRecording.Name = "lblRecording";
            this.lblRecording.Size = new System.Drawing.Size(734, 487);
            this.lblRecording.TabIndex = 8;
            this.lblRecording.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdNext2
            // 
            this.cmdNext2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNext2.Enabled = false;
            this.cmdNext2.Image = ((System.Drawing.Image)(resources.GetObject("cmdNext2.Image")));
            this.cmdNext2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNext2.Location = new System.Drawing.Point(459, 521);
            this.cmdNext2.Name = "cmdNext2";
            this.cmdNext2.Size = new System.Drawing.Size(282, 60);
            this.cmdNext2.TabIndex = 7;
            this.cmdNext2.Text = "Далее";
            this.cmdNext2.UseVisualStyleBackColor = true;
            this.cmdNext2.Click += new System.EventHandler(this.Button4_Click);
            // 
            // cmdStopAudioRecord
            // 
            this.cmdStopAudioRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdStopAudioRecord.Enabled = false;
            this.cmdStopAudioRecord.Image = ((System.Drawing.Image)(resources.GetObject("cmdStopAudioRecord.Image")));
            this.cmdStopAudioRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStopAudioRecord.Location = new System.Drawing.Point(233, 521);
            this.cmdStopAudioRecord.Name = "cmdStopAudioRecord";
            this.cmdStopAudioRecord.Size = new System.Drawing.Size(220, 60);
            this.cmdStopAudioRecord.TabIndex = 6;
            this.cmdStopAudioRecord.Text = "Закончить запись";
            this.cmdStopAudioRecord.UseVisualStyleBackColor = true;
            this.cmdStopAudioRecord.Click += new System.EventHandler(this.CmdStopAudioRecord_Click);
            // 
            // cmdStartAudioRecord
            // 
            this.cmdStartAudioRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdStartAudioRecord.Image = ((System.Drawing.Image)(resources.GetObject("cmdStartAudioRecord.Image")));
            this.cmdStartAudioRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStartAudioRecord.Location = new System.Drawing.Point(7, 521);
            this.cmdStartAudioRecord.Name = "cmdStartAudioRecord";
            this.cmdStartAudioRecord.Size = new System.Drawing.Size(220, 60);
            this.cmdStartAudioRecord.TabIndex = 5;
            this.cmdStartAudioRecord.Text = "Начать запись";
            this.cmdStartAudioRecord.UseVisualStyleBackColor = true;
            this.cmdStartAudioRecord.Click += new System.EventHandler(this.CmdStartAudioRecord_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblFPS);
            this.tabPage3.Controls.Add(this.cmdNextClient);
            this.tabPage3.Controls.Add(this.stopRecord);
            this.tabPage3.Controls.Add(this.startRecord);
            this.tabPage3.Controls.Add(this.videoSourcePlayer);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Видео";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // lblFPS
            // 
            this.lblFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFPS.ForeColor = System.Drawing.Color.Blue;
            this.lblFPS.Location = new System.Drawing.Point(459, 521);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(98, 60);
            this.lblFPS.TabIndex = 5;
            this.lblFPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdNextClient
            // 
            this.cmdNextClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNextClient.Enabled = false;
            this.cmdNextClient.Image = ((System.Drawing.Image)(resources.GetObject("cmdNextClient.Image")));
            this.cmdNextClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNextClient.Location = new System.Drawing.Point(563, 521);
            this.cmdNextClient.Name = "cmdNextClient";
            this.cmdNextClient.Size = new System.Drawing.Size(177, 60);
            this.cmdNextClient.TabIndex = 4;
            this.cmdNextClient.Text = "Следующий";
            this.cmdNextClient.UseVisualStyleBackColor = true;
            this.cmdNextClient.Click += new System.EventHandler(this.Button3_Click);
            // 
            // stopRecord
            // 
            this.stopRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopRecord.Enabled = false;
            this.stopRecord.Image = ((System.Drawing.Image)(resources.GetObject("stopRecord.Image")));
            this.stopRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopRecord.Location = new System.Drawing.Point(233, 521);
            this.stopRecord.Name = "stopRecord";
            this.stopRecord.Size = new System.Drawing.Size(220, 60);
            this.stopRecord.TabIndex = 3;
            this.stopRecord.Text = "Закончить запись";
            this.stopRecord.UseVisualStyleBackColor = true;
            this.stopRecord.Click += new System.EventHandler(this.StopRecord_Click);
            // 
            // startRecord
            // 
            this.startRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startRecord.Image = ((System.Drawing.Image)(resources.GetObject("startRecord.Image")));
            this.startRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startRecord.Location = new System.Drawing.Point(7, 521);
            this.startRecord.Name = "startRecord";
            this.startRecord.Size = new System.Drawing.Size(220, 60);
            this.startRecord.TabIndex = 2;
            this.startRecord.Text = "Начать запись";
            this.startRecord.UseVisualStyleBackColor = true;
            this.startRecord.Click += new System.EventHandler(this.StartRecord_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.KeepAspectRatio = true;
            this.videoSourcePlayer.Location = new System.Drawing.Point(7, 35);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(733, 480);
            this.videoSourcePlayer.TabIndex = 1;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new Accord.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayer_NewFrame_1);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtLog);
            this.tabPage6.Controls.Add(this.cmdPrepareFiles);
            this.tabPage6.Controls.Add(this.pb);
            this.tabPage6.Controls.Add(this.txtPrefix);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.ImageIndex = 4;
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(752, 600);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Подготовить загрузку";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(7, 133);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(731, 382);
            this.txtLog.TabIndex = 4;
            // 
            // cmdPrepareFiles
            // 
            this.cmdPrepareFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrepareFiles.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrepareFiles.Image")));
            this.cmdPrepareFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrepareFiles.Location = new System.Drawing.Point(7, 521);
            this.cmdPrepareFiles.Name = "cmdPrepareFiles";
            this.cmdPrepareFiles.Size = new System.Drawing.Size(731, 60);
            this.cmdPrepareFiles.TabIndex = 3;
            this.cmdPrepareFiles.Text = "Подготовить файлы";
            this.cmdPrepareFiles.UseVisualStyleBackColor = true;
            this.cmdPrepareFiles.Click += new System.EventHandler(this.CmdPrepareFiles_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(7, 72);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(731, 43);
            this.pb.TabIndex = 2;
            this.pb.Visible = false;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefix.Location = new System.Drawing.Point(176, 25);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(562, 26);
            this.txtPrefix.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Номер протокола:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmdSaveCFG);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.ImageIndex = 5;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(752, 600);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Настройки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmdSaveCFG
            // 
            this.cmdSaveCFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveCFG.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveCFG.Image")));
            this.cmdSaveCFG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSaveCFG.Location = new System.Drawing.Point(7, 521);
            this.cmdSaveCFG.Name = "cmdSaveCFG";
            this.cmdSaveCFG.Size = new System.Drawing.Size(728, 60);
            this.cmdSaveCFG.TabIndex = 12;
            this.cmdSaveCFG.Text = "Сохранить ";
            this.cmdSaveCFG.UseVisualStyleBackColor = true;
            this.cmdSaveCFG.Click += new System.EventHandler(this.CmdSaveCFG_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cmdPath);
            this.groupBox5.Controls.Add(this.txtPath);
            this.groupBox5.Location = new System.Drawing.Point(7, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(728, 83);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Папка для сохранения данных";
            // 
            // cmdPath
            // 
            this.cmdPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPath.Location = new System.Drawing.Point(657, 36);
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(49, 26);
            this.cmdPath.TabIndex = 1;
            this.cmdPath.Text = "...";
            this.cmdPath.UseVisualStyleBackColor = true;
            this.cmdPath.Click += new System.EventHandler(this.CmdPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(17, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(634, 26);
            this.txtPath.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.AudioDevices);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(7, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 64);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Звук";
            // 
            // AudioDevices
            // 
            this.AudioDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioDevices.FormattingEnabled = true;
            this.AudioDevices.Location = new System.Drawing.Point(234, 25);
            this.AudioDevices.Name = "AudioDevices";
            this.AudioDevices.Size = new System.Drawing.Size(473, 28);
            this.AudioDevices.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Устройство для записи:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.numFPS);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.videoResolutionCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.videoCombo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(7, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 145);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Видео";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Тест FPS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numFPS
            // 
            this.numFPS.Location = new System.Drawing.Point(235, 93);
            this.numFPS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFPS.Name = "numFPS";
            this.numFPS.Size = new System.Drawing.Size(77, 26);
            this.numFPS.TabIndex = 13;
            this.numFPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "FPS:";
            // 
            // videoResolutionCombo
            // 
            this.videoResolutionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoResolutionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoResolutionCombo.FormattingEnabled = true;
            this.videoResolutionCombo.Location = new System.Drawing.Point(234, 59);
            this.videoResolutionCombo.Name = "videoResolutionCombo";
            this.videoResolutionCombo.Size = new System.Drawing.Size(473, 28);
            this.videoResolutionCombo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Разрешение видео:";
            // 
            // videoCombo
            // 
            this.videoCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCombo.FormattingEnabled = true;
            this.videoCombo.Location = new System.Drawing.Point(234, 25);
            this.videoCombo.Name = "videoCombo";
            this.videoCombo.Size = new System.Drawing.Size(473, 28);
            this.videoCombo.TabIndex = 9;
            this.videoCombo.SelectedIndexChanged += new System.EventHandler(this.videoCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Камера для видео:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.photoResolutionCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.photoCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 104);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фото";
            // 
            // photoResolutionCombo
            // 
            this.photoResolutionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoResolutionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photoResolutionCombo.FormattingEnabled = true;
            this.photoResolutionCombo.Location = new System.Drawing.Point(234, 59);
            this.photoResolutionCombo.Name = "photoResolutionCombo";
            this.photoResolutionCombo.Size = new System.Drawing.Size(473, 28);
            this.photoResolutionCombo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Разрешение фото:";
            // 
            // photoCombo
            // 
            this.photoCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photoCombo.FormattingEnabled = true;
            this.photoCombo.Location = new System.Drawing.Point(234, 25);
            this.photoCombo.Name = "photoCombo";
            this.photoCombo.Size = new System.Drawing.Size(473, 28);
            this.photoCombo.TabIndex = 9;
            this.photoCombo.SelectedIndexChanged += new System.EventHandler(this.photoCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Камера для фото:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtQServer);
            this.groupBox6.Location = new System.Drawing.Point(7, 435);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(728, 83);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сервер для проверки качества";
            // 
            // txtQServer
            // 
            this.txtQServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQServer.Location = new System.Drawing.Point(17, 37);
            this.txtQServer.Name = "txtQServer";
            this.txtQServer.Size = new System.Drawing.Size(688, 26);
            this.txtQServer.TabIndex = 0;
            this.txtQServer.TextChanged += new System.EventHandler(this.TxtQServer_TextChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lblAbout);
            this.tabPage7.Controls.Add(this.pictureBox1);
            this.tabPage7.ImageIndex = 6;
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(752, 600);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "О программе";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAbout.Location = new System.Drawing.Point(7, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(731, 370);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "Интервью, (С) LINKAS,2019";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(7, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            this.imageList1.Images.SetKeyName(1, "camera-retro.png");
            this.imageList1.Images.SetKeyName(2, "volume-up.png");
            this.imageList1.Images.SetKeyName(3, "video-camera.png");
            this.imageList1.Images.SetKeyName(4, "group.png");
            this.imageList1.Images.SetKeyName(5, "wrench.png");
            this.imageList1.Images.SetKeyName(6, "certificate.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 661);
            this.Controls.Add(this.tabInterview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интервью";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tabInterview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFPS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInterview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSer;
        private System.Windows.Forms.Label label4;
        private Accord.Controls.VideoSourcePlayer photoSourcePlayer;
        private System.Windows.Forms.Button cmdNext1;
        private System.Windows.Forms.Button cmdShot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox videoResolutionCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox videoCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox photoResolutionCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox photoCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox AudioDevices;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderDlg;
        private System.Windows.Forms.Button stopRecord;
        private System.Windows.Forms.Button startRecord;
        private Accord.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button cmdNextClient;
        private System.Windows.Forms.Button cmdSaveCFG;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cmdNext2;
        private System.Windows.Forms.Button cmdStopAudioRecord;
        private System.Windows.Forms.Button cmdStartAudioRecord;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtQServer;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdPrepareFiles;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblRecording;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.NumericUpDown numFPS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}