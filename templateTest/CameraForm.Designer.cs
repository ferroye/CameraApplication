namespace templateTest
{
    partial class CameraForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxPlayback = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.checkBoxHeader = new System.Windows.Forms.CheckBox();
            this.checkBoxDigitalZoom = new System.Windows.Forms.CheckBox();
            this.buttonLiftMask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.export_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.radioButtonMKV = new System.Windows.Forms.RadioButton();
            this.radioButtonAVI = new System.Windows.Forms.RadioButton();
            this.groupBoxDbSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeBookmark = new System.Windows.Forms.CheckBox();
            this.checkBoxReExport = new System.Windows.Forms.CheckBox();
            this.textBoxEncryptPassword = new System.Windows.Forms.TextBox();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.checkBoxSign = new System.Windows.Forms.CheckBox();
            this.radioButtonBLK = new System.Windows.Forms.RadioButton();
            this.radioButtonPIC = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSampleRate = new System.Windows.Forms.ComboBox();
            this.textBoxVideoFilename = new System.Windows.Forms.TextBox();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this._liftPrivacyMask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRelated = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDB = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPlayback.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.export_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDbSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 402);
            this.panel1.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Green;
            this.button9.Location = new System.Drawing.Point(221, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "| | stop";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnStopRecording1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(150, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "|> record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxPlayback
            // 
            this.groupBoxPlayback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlayback.Controls.Add(this.button7);
            this.groupBoxPlayback.Controls.Add(this.button2);
            this.groupBoxPlayback.Controls.Add(this.buttonMode);
            this.groupBoxPlayback.Controls.Add(this.button5);
            this.groupBoxPlayback.Controls.Add(this.textBoxTime);
            this.groupBoxPlayback.Controls.Add(this.buttonStop);
            this.groupBoxPlayback.Controls.Add(this.buttonForward);
            this.groupBoxPlayback.Controls.Add(this.buttonReverse);
            this.groupBoxPlayback.Location = new System.Drawing.Point(14, 86);
            this.groupBoxPlayback.Name = "groupBoxPlayback";
            this.groupBoxPlayback.Size = new System.Drawing.Size(288, 100);
            this.groupBoxPlayback.TabIndex = 20;
            this.groupBoxPlayback.TabStop = false;
            this.groupBoxPlayback.Text = "Playback Control";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(11, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "< Frame";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnPreviousFrame);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(11, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "< Sequence";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnPrevSequence);
            // 
            // buttonMode
            // 
            this.buttonMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMode.Location = new System.Drawing.Point(109, 18);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(165, 23);
            this.buttonMode.TabIndex = 3;
            this.buttonMode.Text = "Current mode: Live";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.OnModeClick);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(11, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "DB N/A";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTime.Location = new System.Drawing.Point(108, 73);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(166, 21);
            this.textBoxTime.TabIndex = 7;
            // 
            // buttonStop
            // 
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStop.Location = new System.Drawing.Point(168, 47);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(45, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "| |";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonForward.Location = new System.Drawing.Point(229, 47);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(45, 23);
            this.buttonForward.TabIndex = 6;
            this.buttonForward.Text = ">>";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReverse.Location = new System.Drawing.Point(108, 47);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(45, 23);
            this.buttonReverse.TabIndex = 4;
            this.buttonReverse.Text = "<<";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHeader.AutoSize = true;
            this.checkBoxHeader.Checked = true;
            this.checkBoxHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHeader.Location = new System.Drawing.Point(22, 45);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(91, 17);
            this.checkBoxHeader.TabIndex = 23;
            this.checkBoxHeader.Text = "Show Header";
            this.checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigitalZoom
            // 
            this.checkBoxDigitalZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDigitalZoom.AutoSize = true;
            this.checkBoxDigitalZoom.Location = new System.Drawing.Point(56, 64);
            this.checkBoxDigitalZoom.Name = "checkBoxDigitalZoom";
            this.checkBoxDigitalZoom.Size = new System.Drawing.Size(83, 17);
            this.checkBoxDigitalZoom.TabIndex = 22;
            this.checkBoxDigitalZoom.Text = "Digital zoom";
            this.checkBoxDigitalZoom.UseVisualStyleBackColor = true;
            // 
            // buttonLiftMask
            // 
            this.buttonLiftMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLiftMask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLiftMask.Location = new System.Drawing.Point(81, 16);
            this.buttonLiftMask.Name = "buttonLiftMask";
            this.buttonLiftMask.Size = new System.Drawing.Size(155, 23);
            this.buttonLiftMask.TabIndex = 24;
            this.buttonLiftMask.Text = "Lift privacy mask";
            this.buttonLiftMask.UseVisualStyleBackColor = true;
            this.buttonLiftMask.Click += new System.EventHandler(this.buttonLiftMask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.groupBoxPlayback);
            this.groupBox1.Controls.Add(this.buttonLiftMask);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxHeader);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.checkBoxDigitalZoom);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(25, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 197);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Utility";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(291, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnClose);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.buttonC);
            this.groupBox3.Controls.Add(this.buttonDown);
            this.groupBox3.Controls.Add(this.buttonUp);
            this.groupBox3.Controls.Add(this.buttonleft);
            this.groupBox3.Controls.Add(this.buttonRight);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(351, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 108);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move in steps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "|";
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(134, 67);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "--";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(134, 29);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(94, 76);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(33, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(22, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(33, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(94, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 24);
            this.button8.TabIndex = 16;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(22, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonC
            // 
            this.buttonC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonC.Location = new System.Drawing.Point(57, 48);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(32, 23);
            this.buttonC.TabIndex = 14;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDown.Location = new System.Drawing.Point(57, 76);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(33, 23);
            this.buttonDown.TabIndex = 11;
            this.buttonDown.Text = "v";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUp.Location = new System.Drawing.Point(57, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(33, 23);
            this.buttonUp.TabIndex = 10;
            this.buttonUp.Text = "^";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonleft.Location = new System.Drawing.Point(22, 48);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(33, 23);
            this.buttonleft.TabIndex = 13;
            this.buttonleft.Text = "<";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonleft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRight.Location = new System.Drawing.Point(94, 48);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(33, 23);
            this.buttonRight.TabIndex = 12;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // export_groupBox
            // 
            this.export_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.export_groupBox.Controls.Add(this.groupBox2);
            this.export_groupBox.Controls.Add(this.progressBar);
            this.export_groupBox.Controls.Add(this.button4);
            this.export_groupBox.Controls.Add(this.labelError);
            this.export_groupBox.Controls.Add(this.label10);
            this.export_groupBox.Controls.Add(this.buttonExport);
            this.export_groupBox.Controls.Add(this.radioButtonMKV);
            this.export_groupBox.Controls.Add(this.radioButtonAVI);
            this.export_groupBox.Controls.Add(this.groupBoxDbSettings);
            this.export_groupBox.Controls.Add(this.groupBox4);
            this.export_groupBox.Controls.Add(this.label4);
            this.export_groupBox.Controls.Add(this.checkBoxRelated);
            this.export_groupBox.Controls.Add(this.label6);
            this.export_groupBox.Controls.Add(this.radioButtonDB);
            this.export_groupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.export_groupBox.Location = new System.Drawing.Point(544, 12);
            this.export_groupBox.Name = "export_groupBox";
            this.export_groupBox.Size = new System.Drawing.Size(452, 604);
            this.export_groupBox.TabIndex = 28;
            this.export_groupBox.TabStop = false;
            this.export_groupBox.Text = "Export";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Controls.Add(this.buttonDestination);
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(21, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 130);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Selection";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(123, 60);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerEnd.TabIndex = 6;
            // 
            // buttonDestination
            // 
            this.buttonDestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDestination.Location = new System.Drawing.Point(123, 97);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(250, 23);
            this.buttonDestination.TabIndex = 5;
            this.buttonDestination.Text = "Select...";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(123, 23);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination folder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Export interval:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 463);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(407, 23);
            this.progressBar.TabIndex = 21;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(133, 501);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Export result:";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Enabled = false;
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExport.Location = new System.Drawing.Point(84, 564);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 20;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click_1);
            // 
            // radioButtonMKV
            // 
            this.radioButtonMKV.AutoSize = true;
            this.radioButtonMKV.Location = new System.Drawing.Point(305, 87);
            this.radioButtonMKV.Name = "radioButtonMKV";
            this.radioButtonMKV.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMKV.TabIndex = 29;
            this.radioButtonMKV.Text = "MKV";
            this.radioButtonMKV.UseVisualStyleBackColor = true;
            this.radioButtonMKV.CheckedChanged += new System.EventHandler(this.radioButtonMKV_CheckedChanged);
            // 
            // radioButtonAVI
            // 
            this.radioButtonAVI.AutoSize = true;
            this.radioButtonAVI.Location = new System.Drawing.Point(257, 87);
            this.radioButtonAVI.Name = "radioButtonAVI";
            this.radioButtonAVI.Size = new System.Drawing.Size(42, 17);
            this.radioButtonAVI.TabIndex = 26;
            this.radioButtonAVI.Text = "AVI";
            this.radioButtonAVI.UseVisualStyleBackColor = true;
            this.radioButtonAVI.CheckedChanged += new System.EventHandler(this.radioButtonAVI_CheckedChanged);
            // 
            // groupBoxDbSettings
            // 
            this.groupBoxDbSettings.Controls.Add(this.checkBoxIncludeBookmark);
            this.groupBoxDbSettings.Controls.Add(this.checkBoxReExport);
            this.groupBoxDbSettings.Controls.Add(this.textBoxEncryptPassword);
            this.groupBoxDbSettings.Controls.Add(this.checkBoxEncrypt);
            this.groupBoxDbSettings.Controls.Add(this.checkBoxSign);
            this.groupBoxDbSettings.Controls.Add(this.radioButtonBLK);
            this.groupBoxDbSettings.Controls.Add(this.radioButtonPIC);
            this.groupBoxDbSettings.Location = new System.Drawing.Point(31, 109);
            this.groupBoxDbSettings.Name = "groupBoxDbSettings";
            this.groupBoxDbSettings.Size = new System.Drawing.Size(183, 177);
            this.groupBoxDbSettings.TabIndex = 30;
            this.groupBoxDbSettings.TabStop = false;
            // 
            // checkBoxIncludeBookmark
            // 
            this.checkBoxIncludeBookmark.AutoSize = true;
            this.checkBoxIncludeBookmark.Enabled = false;
            this.checkBoxIncludeBookmark.Location = new System.Drawing.Point(34, 149);
            this.checkBoxIncludeBookmark.Name = "checkBoxIncludeBookmark";
            this.checkBoxIncludeBookmark.Size = new System.Drawing.Size(116, 17);
            this.checkBoxIncludeBookmark.TabIndex = 6;
            this.checkBoxIncludeBookmark.Text = "Include bookmarks";
            this.checkBoxIncludeBookmark.UseVisualStyleBackColor = true;
            // 
            // checkBoxReExport
            // 
            this.checkBoxReExport.AutoSize = true;
            this.checkBoxReExport.Enabled = false;
            this.checkBoxReExport.Location = new System.Drawing.Point(34, 126);
            this.checkBoxReExport.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxReExport.Name = "checkBoxReExport";
            this.checkBoxReExport.Size = new System.Drawing.Size(107, 17);
            this.checkBoxReExport.TabIndex = 5;
            this.checkBoxReExport.Text = "Prevent re-export";
            this.checkBoxReExport.UseVisualStyleBackColor = true;
            // 
            // textBoxEncryptPassword
            // 
            this.textBoxEncryptPassword.Enabled = false;
            this.textBoxEncryptPassword.Location = new System.Drawing.Point(54, 102);
            this.textBoxEncryptPassword.Name = "textBoxEncryptPassword";
            this.textBoxEncryptPassword.Size = new System.Drawing.Size(119, 20);
            this.textBoxEncryptPassword.TabIndex = 4;
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Enabled = false;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(34, 83);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(94, 17);
            this.checkBoxEncrypt.TabIndex = 3;
            this.checkBoxEncrypt.Text = "Encrypt export";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            this.checkBoxEncrypt.CheckedChanged += new System.EventHandler(this.OnEncryptChanged);
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.AutoSize = true;
            this.checkBoxSign.Enabled = false;
            this.checkBoxSign.Location = new System.Drawing.Point(34, 60);
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSign.TabIndex = 2;
            this.checkBoxSign.Text = "Sign export";
            this.checkBoxSign.UseVisualStyleBackColor = true;
            // 
            // radioButtonBLK
            // 
            this.radioButtonBLK.AutoSize = true;
            this.radioButtonBLK.Location = new System.Drawing.Point(12, 37);
            this.radioButtonBLK.Name = "radioButtonBLK";
            this.radioButtonBLK.Size = new System.Drawing.Size(93, 17);
            this.radioButtonBLK.TabIndex = 1;
            this.radioButtonBLK.Text = "BLK file format";
            this.radioButtonBLK.UseVisualStyleBackColor = true;
            this.radioButtonBLK.CheckedChanged += new System.EventHandler(this.OnDBFormatChanged);
            // 
            // radioButtonPIC
            // 
            this.radioButtonPIC.AutoSize = true;
            this.radioButtonPIC.Checked = true;
            this.radioButtonPIC.Location = new System.Drawing.Point(12, 14);
            this.radioButtonPIC.Name = "radioButtonPIC";
            this.radioButtonPIC.Size = new System.Drawing.Size(90, 17);
            this.radioButtonPIC.TabIndex = 0;
            this.radioButtonPIC.TabStop = true;
            this.radioButtonPIC.Text = "PIC file format";
            this.radioButtonPIC.UseVisualStyleBackColor = true;
            this.radioButtonPIC.CheckedChanged += new System.EventHandler(this.OnDBFormatChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSampleRate);
            this.groupBox4.Controls.Add(this.textBoxVideoFilename);
            this.groupBox4.Controls.Add(this.comboBoxCodec);
            this.groupBox4.Controls.Add(this._liftPrivacyMask);
            this.groupBox4.Location = new System.Drawing.Point(239, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 150);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // comboBoxSampleRate
            // 
            this.comboBoxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleRate.Enabled = false;
            this.comboBoxSampleRate.FormattingEnabled = true;
            this.comboBoxSampleRate.Items.AddRange(new object[] {
            "8000",
            "16000",
            "44100"});
            this.comboBoxSampleRate.Location = new System.Drawing.Point(12, 81);
            this.comboBoxSampleRate.Name = "comboBoxSampleRate";
            this.comboBoxSampleRate.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSampleRate.TabIndex = 10;
            // 
            // textBoxVideoFilename
            // 
            this.textBoxVideoFilename.Enabled = false;
            this.textBoxVideoFilename.Location = new System.Drawing.Point(12, 16);
            this.textBoxVideoFilename.Name = "textBoxVideoFilename";
            this.textBoxVideoFilename.Size = new System.Drawing.Size(161, 20);
            this.textBoxVideoFilename.TabIndex = 9;
            this.textBoxVideoFilename.Text = "Type your avi file name here ...";
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.Enabled = false;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Location = new System.Drawing.Point(13, 49);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCodec.TabIndex = 10;
            // 
            // _liftPrivacyMask
            // 
            this._liftPrivacyMask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._liftPrivacyMask.Location = new System.Drawing.Point(13, 111);
            this._liftPrivacyMask.Name = "_liftPrivacyMask";
            this._liftPrivacyMask.Size = new System.Drawing.Size(161, 23);
            this._liftPrivacyMask.TabIndex = 25;
            this._liftPrivacyMask.Text = "Lift privacy mask";
            this._liftPrivacyMask.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Audio:";
            // 
            // checkBoxRelated
            // 
            this.checkBoxRelated.AutoSize = true;
            this.checkBoxRelated.Location = new System.Drawing.Point(141, 57);
            this.checkBoxRelated.Name = "checkBoxRelated";
            this.checkBoxRelated.Size = new System.Drawing.Size(165, 17);
            this.checkBoxRelated.TabIndex = 18;
            this.checkBoxRelated.Text = "Include related audio devices";
            this.checkBoxRelated.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Export format:";
            // 
            // radioButtonDB
            // 
            this.radioButtonDB.AutoSize = true;
            this.radioButtonDB.Checked = true;
            this.radioButtonDB.Location = new System.Drawing.Point(91, 86);
            this.radioButtonDB.Name = "radioButtonDB";
            this.radioButtonDB.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDB.TabIndex = 22;
            this.radioButtonDB.TabStop = true;
            this.radioButtonDB.Text = "Database";
            this.radioButtonDB.UseVisualStyleBackColor = true;
            this.radioButtonDB.CheckedChanged += new System.EventHandler(this.OnDatabaseChanged);
            // 
            // CameraForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::templateTest.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 642);
            this.Controls.Add(this.export_groupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CameraForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CameraForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CameraForm_MouseUp);
            this.groupBoxPlayback.ResumeLayout(false);
            this.groupBoxPlayback.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.export_groupBox.ResumeLayout(false);
            this.export_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDbSettings.ResumeLayout(false);
            this.groupBoxDbSettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxPlayback;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.CheckBox checkBoxDigitalZoom;
        private System.Windows.Forms.Button buttonLiftMask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox export_groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.RadioButton radioButtonMKV;
        private System.Windows.Forms.RadioButton radioButtonAVI;
        private System.Windows.Forms.GroupBox groupBoxDbSettings;
        private System.Windows.Forms.CheckBox checkBoxIncludeBookmark;
        private System.Windows.Forms.CheckBox checkBoxReExport;
        private System.Windows.Forms.TextBox textBoxEncryptPassword;
        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.CheckBox checkBoxSign;
        private System.Windows.Forms.RadioButton radioButtonBLK;
        private System.Windows.Forms.RadioButton radioButtonPIC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxSampleRate;
        private System.Windows.Forms.TextBox textBoxVideoFilename;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.Button _liftPrivacyMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxRelated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonDB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}