using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.Client;
using VideoOS.Platform.Messaging;
using VideoOS.Platform.UI;



namespace templateTest
{
    public partial class CameraForm : Form
    {
        private ImageViewerControl imageViewerControl2;
        private MainForm mForm;
        private Item selectedItem;
        private double _speed = 0.0;
        private bool posSizeControl=false;
        private int TogMove;
        private int MValx;
        private int MValy;

        enum ServerType { Ccode, Ecode, Unsupported }
        

        public CameraForm(MainForm mmForm, Item selectIt)
        {
            selectedItem = selectIt;
            InitializeComponent();
            mForm = mmForm;
            mForm.generalLog.AppendText("Created Camera Form \r\n");
            EnvironmentManager.Instance.RegisterReceiver(PlaybackTimeChangedHandler,
                                                         new MessageIdFilter(MessageId.SmartClient.PlaybackCurrentTimeIndication));
            this.Width = 555;
            this.Height = 666;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (posSizeControl)
            { 
                this.Width = 555;
                this.Height = 666;
                posSizeControl = false;
            }
            else
            {
                this.Width = 920;
                this.Height = 666;
                posSizeControl = true;
            }
            
        }
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

        
    }
}
