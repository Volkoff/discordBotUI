using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot_v2._0
{
    public partial class InputKeysForm : Form
    {
        private OpenFileDialog openFileDialogInputKeys;
        string filePath;
        static UIDataUserInput uiData = new UIDataUserInput();
        public InputKeysForm()
        {
            InitializeComponent();
        }

        private void PathChooseButton_Click(object sender, EventArgs e)
        {
            UpdateUiData();
            if (openFileDialogInputKeys.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogInputKeys.FileName;
                if (!filePath.EndsWith(".json"))
                {
                    Forms.InvalidFile invalidFile = new Forms.InvalidFile();
                    invalidFile.ShowDialog();
                    return;
                }
                filePath = openFileDialogInputKeys.FileName;
            }
        }

        public void UpdateUiData()
        {
            uiData.TwitchClientID = TxtTwitchClientID.Text;
            uiData.TwitchAccessToken = TxtTwitchAccessToken.Text;
            uiData.YouTubeApiKey = TxtYouTubeApiKey.Text;
            uiData.DiscordApiKey = TxtDiscordApiKey.Text;
            uiData.SpotifyClientId = TxtSpotifyClientID.Text;
            uiData.SpotifyClientSecretKey = TxtSpotifyClientSecret.Text;
        }

        private void InputKeysForm_Load(object sender, EventArgs e)
        {
            openFileDialogInputKeys = new OpenFileDialog();
        }

        private void OpenTutorialForm_Click(object sender, EventArgs e)
        {
            Forms.Tutorial  tutorial = new Forms.Tutorial();
            tutorial.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveToPathButton_Click(object sender, EventArgs e)
        {
            if(filePath == null)
            {
                Forms.InvalidFile invalidFile = new Forms.InvalidFile();
                invalidFile.ShowDialog();
                return;
            }
            string uiDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(uiData);
            File.WriteAllTextAsync(filePath, uiDataJson);
        }
    }
}
