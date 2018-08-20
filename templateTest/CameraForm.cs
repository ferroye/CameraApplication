using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.SDK.Export;
using VideoOS.Platform.Client;
using VideoOS.Platform.Messaging;
using VideoOS.Platform.UI;
using VideoOS.Platform.Util;
using AVIExporter = VideoOS.Platform.Data.AVIExporter;



namespace templateTest
{
    public partial class CameraForm : Form
    {
        private ImageViewerControl imageViewerControl2;
        private MainForm mForm;
        private Item selectedItem;
        private double _speed = 0.0;
        private int TogMove;
        private int MValx;
        private int MValy;
        private string _path = null;
        private Timer _timer = new Timer() { Interval = 100 };
        VideoOS.Platform.Data.IExporter _exporter;

        enum ServerType { Ccode, Ecode, Unsupported }
        

        public CameraForm(MainForm mmForm, Item selectIt)
        {
            selectedItem = selectIt;
            InitializeComponent();
            comboBoxSampleRate.SelectedIndex = 0;
            mForm = mmForm;
            mForm.generalLog.AppendText("Created Camera Form \r\n");
            EnvironmentManager.Instance.RegisterReceiver(PlaybackTimeChangedHandler,
                                                         new MessageIdFilter(MessageId.SmartClient.PlaybackCurrentTimeIndication));
            //this.Width = 555;
            //this.Height = 666;
            //posSizeControl = false;
            //export_groupBox.Hide();
            //ListPresets();
            //checkSetPTZ();
            //ListSequences();
        }
        #region Load Camera 
        private void CameraForm_Load(object sender, EventArgs e)
        {
            // check if the camera is initilized
            if (imageViewerControl2 != null)
            {
                imageViewerControl2.Disconnect();
                imageViewerControl2.Close();
                imageViewerControl2.Dispose();
                imageViewerControl2 = null;
            }
            try
            {   
                //image view control settings
                imageViewerControl2 = ClientControl.Instance.GenerateImageViewerControl();
                imageViewerControl2.Dock = DockStyle.Fill;
                imageViewerControl2.ClickEvent += new EventHandler(_imageViewerControl1_ClickEvent);
                panel1.Controls.Clear();
                panel1.Controls.Add(imageViewerControl2);
                imageViewerControl2.CameraFQID = selectedItem.FQID;
                imageViewerControl2.EnableVisibleHeader = checkBoxHeader.Checked;
                imageViewerControl2.EnableVisibleLiveIndicator = EnvironmentManager.Instance.Mode == Mode.ClientLive;
                imageViewerControl2.EnableMousePtzEmbeddedHandler = true;
                imageViewerControl2.MaintainImageAspectRatio = true;
                imageViewerControl2.ImageOrPaintInfoChanged += ImageOrPaintChangedHandler;

                imageViewerControl2.EnableRecordedImageDisplayedEvent = true;
                //imageViewerControl2.RecordedImageReceivedEvent += _imageViewerControl1_RecordedImageReceivedEvent;

                imageViewerControl2.EnableVisibleTimeStamp = true;

                
                imageViewerControl2.EnableDigitalZoom = checkBoxDigitalZoom.Checked; ;
                imageViewerControl2.Initialize();
                imageViewerControl2.Connect();

                //MainFo
                mForm.generalLog.AppendText("Selected Camera\r\n");
                //buttonViewProperties.Enabled = true;

            }
            catch (Exception ex)
            {
                mForm.generalLog.AppendText("Error: " + ex + "\r\n");

            }

        }
        void ImageOrPaintChangedHandler(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("ImageSize:" + imageViewerControl2.ImageSize.Width + "x" + imageViewerControl2.ImageSize.Height + ", PaintSIze:" +
                imageViewerControl2.PaintSize.Width + "x" + imageViewerControl2.PaintSize.Height +
                ", PaintLocation:" + imageViewerControl2.PaintLocation.X + "-" + imageViewerControl2.PaintLocation.Y);
        }
        void _imageViewerControl1_ClickEvent(object sender, EventArgs e)
        {
            if (imageViewerControl2 != null)
                imageViewerControl2.Selected = false;
            imageViewerControl2.Selected = true;
        }
        #endregion

        #region Time changed event handler

        private void HandleTimeChanged(DateTime time)
        {
            textBoxTime.Text = time.ToShortDateString() + "  " + time.ToLongTimeString();

            imageViewerControl2.Invalidate();
        }

        private object PlaybackTimeChangedHandler(VideoOS.Platform.Messaging.Message message, FQID dest, FQID sender)
        {
            DateTime time = ((DateTime)message.Data).ToLocalTime();
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => HandleTimeChanged(time)));
            }
            else
                HandleTimeChanged(time);
            return null;
        }

        #endregion

        #region Playback handling


        private void checkBoxDigitalZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (imageViewerControl2 != null)
                imageViewerControl2.EnableDigitalZoom = checkBoxDigitalZoom.Checked;
          
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.PlayStop }));
            EnvironmentManager.Instance.Mode = Mode.ClientPlayback;
            buttonMode.Text = "Current mode: Playback";
            _speed = 0.0;
        }

        private void OnModeClick(object sender, EventArgs e)
        {
            if (EnvironmentManager.Instance.Mode == Mode.ClientLive)
            {
                if (imageViewerControl2 != null)
                    imageViewerControl2.EnableVisibleLiveIndicator = false;
                EnvironmentManager.Instance.Mode = Mode.ClientPlayback;
                buttonMode.Text = "Current mode: Playback";
            }
            else
            {
                if (imageViewerControl2 != null)
                    imageViewerControl2.EnableVisibleLiveIndicator = true;
                EnvironmentManager.Instance.Mode = Mode.ClientLive;
                buttonMode.Text = "Current mode: Live";
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (_speed == 0.0)
                _speed = 1.0;
            else
                _speed *= 2;
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.PlayReverse, Speed = _speed }));
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (_speed == 0.0)
                _speed = 1.0;
            else
                _speed *= 2;
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.PlayForward, Speed = _speed }));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.Begin }));
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.End }));
        }

        private void OnPrevSequence(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.PreviousSequence }));
        }

        private void OnNextSequence(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.NextSequence }));
        }

        private void OnPreviousFrame(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.Previous }));
        }

        private void OnNextFrame(object sender, EventArgs e)
        {
            EnvironmentManager.Instance.SendMessage(new VideoOS.Platform.Messaging.Message(
                                                        MessageId.SmartClient.PlaybackCommand,
                                                        new PlaybackCommandData() { Command = PlaybackData.Next }));
        }

        #endregion


        #region Record Controls 
        private void OnStopRecording1(object sender, EventArgs e)
        {
            if (selectedItem != null)
                EnvironmentManager.Instance.SendMessage(
                    new VideoOS.Platform.Messaging.Message(MessageId.Control.StopRecordingCommand), selectedItem.FQID);
        }

        private void OnClose(object sender, EventArgs e)
        {
            imageViewerControl2.Disconnect();
            imageViewerControl2.Close();
            Close();
        }
        
        private void buttonLiftMask_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
                EnvironmentManager.Instance.SendMessage(
                    new VideoOS.Platform.Messaging.Message(MessageId.Control.StartRecordingCommand), selectedItem.FQID);

        }
        #endregion

       
        #region Camera View Position
        private void buttonUp_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Up);
            EnvironmentManager.Instance.PostMessage(msg, selectedItem.FQID);
        }

        private void buttonleft_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Left);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Down);
            EnvironmentManager.Instance.PostMessage(msg, selectedItem.FQID);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Right);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Home);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.UpRight);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.UpLeft);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.DownLeft);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.DownRight);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.ZoomIn);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            VideoOS.Platform.Messaging.Message msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.ZoomOut);
            EnvironmentManager.Instance.SendMessage(msg, selectedItem.FQID);
        }
        #endregion


        #region Move From event
        private void CameraForm_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValx = e.X;
            MValy = e.Y;
        }

        private void CameraForm_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void CameraForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove==1)
            {
                this.SetDesktopLocation(MousePosition.X - MValx, MousePosition.Y - MValy);
            }
        }



        #endregion

        private void _liftPrivacyMask_Click(object sender, EventArgs e)
        {
            if (Configuration.Instance.ServerFQID.ServerId.UserContext.PrivacyMaskLifted)
            {
                if (Configuration.Instance.ServerFQID.ServerId.UserContext.SetPrivacyMaskLifted(false))
                    _liftPrivacyMask.Text = "Lift privacy mask";
            }
            else
            {
                if (Configuration.Instance.ServerFQID.ServerId.UserContext.SetPrivacyMaskLifted(true))
                    _liftPrivacyMask.Text = "Set privacy mask";
            }
        }

        private void radioButtonMKV_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVideoFilename.Enabled = radioButtonMKV.Checked || radioButtonAVI.Checked;
            comboBoxCodec.Enabled = radioButtonAVI.Checked;
        }

        private void OnEncryptChanged(object sender, EventArgs e)
        {
            if (checkBoxEncrypt.Checked)
            {
                textBoxEncryptPassword.Enabled = true;
            }
            else
            {
                textBoxEncryptPassword.Enabled = false;
                textBoxEncryptPassword.Text = "";
            }

        }

        private void OnDBFormatChanged(object sender, EventArgs e)
        {
            checkBoxSign.Enabled = radioButtonBLK.Checked;
            checkBoxEncrypt.Enabled = radioButtonBLK.Checked;
            checkBoxReExport.Enabled = radioButtonBLK.Checked;
            checkBoxIncludeBookmark.Enabled = radioButtonBLK.Checked;
            OnEncryptChanged(null, null);
        }


        private void radioButtonAVI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVideoFilename.Enabled = radioButtonMKV.Checked || radioButtonAVI.Checked;
            comboBoxCodec.Enabled = radioButtonAVI.Checked;
            comboBoxSampleRate.Enabled = radioButtonAVI.Checked;

            BuildCodecList();
        }
        private void BuildCodecList()
        {
            comboBoxCodec.Items.Clear();
            if (radioButtonAVI.Checked)
            {
                AVIExporter tempExporter = new VideoOS.Platform.Data.AVIExporter() { Width = 320, Height = 240, Filename = textBoxVideoFilename.Text };
                tempExporter.Init();
                string[] codecList = tempExporter.CodecList;
                tempExporter.Close();
                foreach (string name in codecList)
                {
                    comboBoxCodec.Items.Add(name);
                }
                comboBoxCodec.SelectedIndex = 0;
            }

        }

        private void OnDatabaseChanged(object sender, EventArgs e)
        {
            groupBoxDbSettings.Enabled = radioButtonDB.Checked;
        }
        /// <summary>
        /// Update progress 10 times a second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowProgress(object sender, EventArgs e)
        {
            if (_exporter != null)
            {
                int progress = _exporter.Progress;
                int lastError = _exporter.LastError;
                string lastErrorString = _exporter.LastErrorString;
                if (progress >= 0)
                {
                    progressBar.Value = progress;
                    if (progress == 100)
                    {
                        _timer.Stop();
                        labelError.Text = "Done";
                        _exporter.EndExport();
                        _exporter = null;
                        ///*buttonCancel*/.Enabled = false;
                    }
                }
                if (lastError > 0)
                {
                    progressBar.Value = 0;
                    labelError.Text = lastErrorString + "  ( " + lastError + " )";
                    if (_exporter != null)
                    {
                        _exporter.EndExport();
                        _exporter = null;
                        //buttonCancel.Enabled = false;
                    }
                }
            }
        }

        private void buttonExport_Click_1(object sender, EventArgs e)
        {
            bool isStarted = false;
            List<Item> audioSources = new List<Item>();
            String destPath = _path;

            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                MessageBox.Show("Start time need to be lower than end time");
                return;
            }

            if (checkBoxRelated.Checked)
            {
                audioSources = selectedItem.GetRelated(); // Get the defined related Microphones and Speakers for the selected camera
                if (EnvironmentManager.Instance.MasterSite.ServerId.ServerType == ServerId.EnterpriseServerType)
                {
                    //Enterprise does not record speaker sound
                    foreach (Item item in audioSources.ToList())
                    {
                        if (item.FQID.Kind != Kind.Microphone)
                        {
                            audioSources.Remove(item);
                        }
                    }
                }
            }

            if (radioButtonAVI.Checked)
            {
                if (textBoxVideoFilename.Text == "")
                {
                    MessageBox.Show("Please enter a filename for the AVI file.", "Enter Filename");
                    return;
                }
                _exporter = new VideoOS.Platform.Data.AVIExporter()
                {
                    Filename = textBoxVideoFilename.Text,
                    Codec = (String)comboBoxCodec.SelectedItem,
                    AudioSampleRate = Int32.Parse(comboBoxSampleRate.SelectedItem.ToString())
                };

                destPath = Path.Combine(_path, "Exported Images\\" + selectedItem.Name);
            }
            else if (radioButtonMKV.Checked)
            {
                if (textBoxVideoFilename.Text == "")
                {
                    MessageBox.Show("Please enter a filename for the MKV file.", "Enter Filename");
                    return;
                }
                _exporter = new VideoOS.Platform.Data.MKVExporter() { Filename = textBoxVideoFilename.Text };
                destPath = Path.Combine(_path, "Exported Images\\" + selectedItem.Name);
            }
            else
            {
                if (radioButtonPIC.Checked)
                {
                    _exporter = new VideoOS.Platform.Data.DBExporter();
                }
                else
                {
                    if (checkBoxEncrypt.Checked && textBoxEncryptPassword.Text == "")
                    {
                        MessageBox.Show("Please enter password to encrypt with.", "Enter Password");
                        return;
                    }
                    _exporter = new VideoOS.Platform.Data.DBExporter(true)
                    {
                        Encryption = checkBoxEncrypt.Checked,
                        EncryptionStrength = VideoOS.Platform.Data.EncryptionStrength.AES128,
                        Password = textBoxEncryptPassword.Text,
                        SignExport = checkBoxSign.Checked,
                        PreventReExport = checkBoxReExport.Checked,
                        IncludeBookmarks = checkBoxIncludeBookmark.Checked
                    };
                }
            }

            _exporter.Init();
            _exporter.Path = destPath;
            _exporter.CameraList = new List<Item>() { selectedItem };
            _exporter.AudioList = audioSources;

            isStarted = _exporter.StartExport(dateTimePickerStart.Value.ToUniversalTime(), dateTimePickerEnd.Value.ToUniversalTime());

            try
            {
                if (isStarted)
                {
                    _timer.Tick += ShowProgress;
                    _timer.Start();

                    buttonExport.Enabled = false;

                    //execute shell cmd


                    //buttonCancel.Enabled = true;
                }
                else
                {
                    int lastError = _exporter.LastError;
                    string lastErrorString = _exporter.LastErrorString;
                    labelError.Text = lastErrorString + "  ( " + lastError + " )";
                    _exporter.EndExport();
                }
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Start Export", ex);
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.SelectedPath;
                buttonDestination.Text = _path;

                if (selectedItem != null && _path != null)
                    buttonExport.Enabled = true;
            }
        }
    }
}
