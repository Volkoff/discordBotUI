namespace DiscordBot_v2._0
{
    public partial class Form1 : Form
    {

        public static bool wasUploaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        static UIDataUserInput uiData = new UIDataUserInput();
        TelegramApiManager telegram = new TelegramApiManager();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Start bot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            telegram.BotHandler("Bot has been started");

            if (wasUploaded)
            {
                UpdateUiDataFromImport();
            }
            new Program().MainAsync(uiData);
            
        }
        /// <summary>
        /// Save keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {
            UpdateUiData();
            string uiDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(uiData);
            File.WriteAllTextAsync("api.json", uiDataJson);
        }

        public void UpdateUiData()
        {
            uiData.TwitchClientID = TxtTwitchClientID.Text;
            uiData.TwitchAccessToken = TxtTwitchAccessToken.Text;
            uiData.YouTubeApiKey = TxtYouTubeApiKey.Text;
        }
        public void UpdateUiDataFromImport()
        {
            uiData.TwitchClientID = UploadConfig.twID;
            uiData.TwitchAccessToken = UploadConfig.twAT;
        }

        private void UploadFormLoad_Click(object sender, EventArgs e)
        {
            UploadConfig up = new UploadConfig();
            up.Show();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            telegram.BotHandler("Shutting down \n" +
                "Closing application");
            Application.Exit();
        }

    }
}