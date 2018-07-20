using System;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.Client;
using VideoOS.Platform.UI;

namespace templateTest
{
    public partial class MainForm : Form
    {
        // for pick an item 
        // for camera 
        private ImageViewerControl imageViewerControl;
        private Item selectedItem;

        public MainForm()
        {
            InitializeComponent();
            generalLog.AppendText("Start Application...\r\n");
        }

        private void OnClose(object sender, EventArgs e)
        {
            VideoOS.Platform.SDK.Environment.RemoveAllServers();
            Close();
        }
        // event will be loading when the mainform is being loaded.
        private void MainForm_Load(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("  hh:mm tt\r\nMM/dd/yyyy");
            //automatically load the camera then OPTION: give option to

        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            ItemPickerForm picker = new ItemPickerForm();
            picker.KindFilter = Kind.Camera;//specify the item type using the kindFilter
            picker.Init(Configuration.Instance.GetItems());

            if(picker.ShowDialog()== DialogResult.OK)
            {
                selectedItem = picker.SelectedItem;

                try
                {
                    generalLog.AppendText("Creating View...\r\n");
                    CameraForm newView = new CameraForm(this, selectedItem);
                    newView.Show();
                }
                catch(Exception ex)
                {
                    generalLog.AppendText("Error: " + ex + "\r\n");
                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
