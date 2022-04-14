using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot_v2._0
{
    public partial class InputKeysForm : Form
    {
        private OpenFileDialog openFileDialogInputKeys;

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
                string filePath = openFileDialogInputKeys.FileName;
                string uiDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(uiData);
                File.WriteAllTextAsync(filePath, uiDataJson);

            }
        }

        public void UpdateUiData()
        {
            uiData.TwitchClientID = TxtTwitchClientID.Text;
            uiData.TwitchAccessToken = TxtTwitchAccessToken.Text;
            uiData.YouTubeApiKey = TxtYouTubeApiKey.Text;
            uiData.DiscordApiKey = TxtDiscordApiKey.Text;
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
    }
}
