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
        public static string twitchClientId;
        public static string twitchAccessToken;
        public static string YouTubeApiKey;
        public static string DiscordApiKey;
        private OpenFileDialog OpenFileDialogUpload;
        public UploadConfig()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            OpenFileDialogUpload = new OpenFileDialog();
        }

        private void UploadTwitchKeys_Click(object sender, EventArgs e)
        {
            if(OpenFileDialogUpload.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenFileDialogUpload.FileName;
                if (!filePath.EndsWith(".json"))
                {
                    Forms.InvalidFile invalidFile = new Forms.InvalidFile();
                    invalidFile.ShowDialog();
                    return;
                }
                string fileContaints = File.ReadAllText(filePath);
                dynamic jsonFile = JsonConvert.DeserializeObject(fileContaints);
                path.Text = "Twitch client ID: " + jsonFile["TwitchClientID"] + 
                    " \n Twitch Access Token: " +  jsonFile["TwitchAccessToken"] + 
                    " \n YouTube API key" + jsonFile["DiscordApiKey"];
                twitchClientId = jsonFile["TwitchClientID"];
                twitchAccessToken= jsonFile["TwitchAccessToken"];
                YouTubeApiKey = jsonFile["YouTubeApiKey"];
                DiscordApiKey = jsonFile["DiscordApiKey"];
                Form1.wasUploaded = true;
            }

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
