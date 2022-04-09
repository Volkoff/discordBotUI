using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscordBot_v2._0
{
    public partial class UploadConfig : Form
    {
        UIDataUserInput uiDataTwitch = new UIDataUserInput();
        public static string twID;
        public static string twAT;
        private OpenFileDialog openFileDialog;
        public UploadConfig()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
        }

        private void UploadTwitchKeys_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContaints = File.ReadAllText(filePath);
                dynamic jsonFile = JsonConvert.DeserializeObject(fileContaints);
                path.Text = jsonFile["TwitchClientID"] + " " +  jsonFile["TwitchAccessToken"];
                twID = jsonFile["TwitchClientID"];
                twAT= jsonFile["TwitchAccessToken"];
                Form1.wasUploaded = true;
            }

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UploadYouTube_Click(object sender, EventArgs e)
        {

        }
    }
}
