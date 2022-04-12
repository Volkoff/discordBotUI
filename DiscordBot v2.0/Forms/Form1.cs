namespace DiscordBot_v2._0
{
    public partial class Form1 : Form
    {

        public static bool wasUploaded = false;
        TelegramApiManager telegramApiManager;
        DiscordApiManager discordApiManager;
        public Form1()
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
            UpdateUiData();
            telegramApiManager.SendSimpleMessage("Bot has been started");

            if (wasUploaded)
            {
                UpdateUiDataFromImport();
            }
            new Program().MainAsync(uiData,telegramApiManager,discordApiManager);
            
        }

        public void UpdateUiData()
        {
            uiData.TwitchClientID = TxtTwitchClientID.Text;
            uiData.TwitchAccessToken = TxtTwitchAccessToken.Text;
            uiData.YouTubeApiKey = TxtYouTubeApiKey.Text;
            uiData.DiscordApiKey = TxtDiscordToken.Text;
        }
        public void UpdateUiDataFromImport()
        {
            uiData.TwitchClientID = UploadConfig.twitchClientId;
            uiData.TwitchAccessToken = UploadConfig.twitchAccessToken;
            uiData.YouTubeApiKey = UploadConfig.YouTubeApiKey;
            uiData.DiscordApiKey = UploadConfig.DiscordApiKey;
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
    }
}