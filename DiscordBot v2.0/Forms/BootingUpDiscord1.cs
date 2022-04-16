using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;

namespace DiscordBot_v2._0
{
    public partial class BootingUpDiscord1 : Form
    {

        public static bool wasUploaded = false;
        public static string chatID;
        private bool canStart = false;
        TelegramApiManager telegramApiManager;
        DiscordApiManager discordApiManager;
        public BootingUpDiscord1()
        {
            InitializeComponent();
        }
        static UIDataUserInput uiData = new UIDataUserInput();
        private void Form1_Load(object sender, EventArgs e)
        {
            discordApiManager = new DiscordApiManager();
            telegramApiManager = new TelegramApiManager("5251072349:AAGdcgDDwPncF86wNI4nbrwvlAAfQ20ZXks",discordApiManager);
        }
        /// <summary>
        /// Start bot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (wasUploaded)
            {
                UpdateUiDataFromImport();
            }
            else
            {
                UpdateUiData();
            }
            if (canStart)
            {
                if(TxtChatIdTelegram.Text == "Chat ID Telegram" || TxtChatIdTelegram.Text =="")
                {
                    ErrorProvider.Text = "Please input chat id of telegram for administration";
                    return;
                }
                chatID = TxtChatIdTelegram.Text;
                telegramApiManager.SendSimpleMessage("Bot has been started");
                new Program().MainAsync(uiData,telegramApiManager,discordApiManager);
                Forms.Running running = new Forms.Running();
                this.Hide();
                running.Show();
            }
                
            
        }

        public void UpdateUiData()
        {
            if(TxtDiscordToken.Text == "Insert Discord Api Key" || 
                TxtTwitchClientID.Text == "Twitch Client ID" || 
                TxtYouTubeApiKey.Text == "Insert Discord Api Key" ||
                TxtSpotifyApiKey.Text == "Insert Spotify Api Key")
            {
                ErrorProvider.Text = "Either upload or input api keys";
                return;
            }
            canStart = true;
            uiData.TwitchClientID = TxtTwitchClientID.Text;
            uiData.TwitchAccessToken = TxtTwitchAccessToken.Text;
            uiData.YouTubeApiKey = TxtYouTubeApiKey.Text;
            uiData.DiscordApiKey = TxtDiscordToken.Text;
            uiData.SpotifyClientId = TxtSpotifyApiKey.Text;
            uiData.SpotifyClientSecretKey = TxtSpotifyClientSecret.Text;
        }
        public void UpdateUiDataFromImport()
        {
            uiData.TwitchClientID = UploadConfig.twitchClientId;
            uiData.TwitchAccessToken = UploadConfig.twitchAccessToken;
            uiData.YouTubeApiKey = UploadConfig.YouTubeApiKey;
            uiData.DiscordApiKey = UploadConfig.DiscordApiKey;
            uiData.SpotifyClientId = UploadConfig.SpotifyClientID;
            uiData.SpotifyClientSecretKey = UploadConfig.SpotifyClientSecretID;
            canStart = true;
        }

        private void UploadFormLoad_Click(object sender, EventArgs e)
        {
            UploadConfig up = new UploadConfig();
            up.Show();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            telegramApiManager.SendSimpleMessage("Shutting down \n" +
                "Closing application");
            Application.Exit();
        }

        private void InputKeysButton_Click(object sender, EventArgs e)
        {
            InputKeysForm input = new InputKeysForm();
            input.Show();
        }

        private void OpenTutorialVideoForm_Click(object sender, EventArgs e)
        {
            Forms.Tutorial_Video tutorial_Video = new Forms.Tutorial_Video();
            tutorial_Video.Show();
        }

        private void TelegramTutorial_Click(object sender, EventArgs e)
        {
            Forms.TutorialTelegram tutorial_Telegram = new Forms.TutorialTelegram();
            tutorial_Telegram.Show();
        }
    }
}