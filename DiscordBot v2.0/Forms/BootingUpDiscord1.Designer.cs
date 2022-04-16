using System.Windows.Forms;
namespace DiscordBot_v2._0
{
    partial class BootingUpDiscord1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BootingUpDiscord1));
            this.button1 = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UploadFormLoad = new System.Windows.Forms.Button();
            this.InputKeysButton = new System.Windows.Forms.Button();
            this.TxtTwitchAccessToken = new System.Windows.Forms.TextBox();
            this.TxtDiscordToken = new System.Windows.Forms.TextBox();
            this.TxtYouTubeApiKey = new System.Windows.Forms.TextBox();
            this.TxtTwitchClientID = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.Label();
            this.TxtSpotifyApiKey = new System.Windows.Forms.TextBox();
            this.TxtSpotifyClientSecret = new System.Windows.Forms.TextBox();
            this.OpenTutorialVideoForm = new System.Windows.Forms.Button();
            this.TxtChatIdTelegram = new System.Windows.Forms.TextBox();
            this.TelegramTutorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start bot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(307, 340);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(204, 98);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "End application";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UploadFormLoad
            // 
            this.UploadFormLoad.Location = new System.Drawing.Point(585, 12);
            this.UploadFormLoad.Name = "UploadFormLoad";
            this.UploadFormLoad.Size = new System.Drawing.Size(139, 72);
            this.UploadFormLoad.TabIndex = 10;
            this.UploadFormLoad.Text = "Upload Keys";
            this.UploadFormLoad.UseVisualStyleBackColor = true;
            this.UploadFormLoad.Click += new System.EventHandler(this.UploadFormLoad_Click);
            // 
            // InputKeysButton
            // 
            this.InputKeysButton.Location = new System.Drawing.Point(585, 99);
            this.InputKeysButton.Name = "InputKeysButton";
            this.InputKeysButton.Size = new System.Drawing.Size(139, 72);
            this.InputKeysButton.TabIndex = 11;
            this.InputKeysButton.Text = "Save to Path Keys";
            this.InputKeysButton.UseVisualStyleBackColor = true;
            this.InputKeysButton.Click += new System.EventHandler(this.InputKeysButton_Click);
            // 
            // TxtTwitchAccessToken
            // 
            this.TxtTwitchAccessToken.Location = new System.Drawing.Point(211, 12);
            this.TxtTwitchAccessToken.Name = "TxtTwitchAccessToken";
            this.TxtTwitchAccessToken.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchAccessToken.TabIndex = 17;
            this.TxtTwitchAccessToken.Text = "Twitch Access Token";
            // 
            // TxtDiscordToken
            // 
            this.TxtDiscordToken.Location = new System.Drawing.Point(12, 99);
            this.TxtDiscordToken.Name = "TxtDiscordToken";
            this.TxtDiscordToken.Size = new System.Drawing.Size(194, 23);
            this.TxtDiscordToken.TabIndex = 16;
            this.TxtDiscordToken.Text = "Insert Discord Api Key";
            // 
            // TxtYouTubeApiKey
            // 
            this.TxtYouTubeApiKey.Location = new System.Drawing.Point(12, 61);
            this.TxtYouTubeApiKey.Name = "TxtYouTubeApiKey";
            this.TxtYouTubeApiKey.Size = new System.Drawing.Size(194, 23);
            this.TxtYouTubeApiKey.TabIndex = 15;
            this.TxtYouTubeApiKey.Text = "Insert YouTubeAPI key";
            // 
            // TxtTwitchClientID
            // 
            this.TxtTwitchClientID.Location = new System.Drawing.Point(12, 12);
            this.TxtTwitchClientID.Name = "TxtTwitchClientID";
            this.TxtTwitchClientID.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchClientID.TabIndex = 14;
            this.TxtTwitchClientID.Text = "Twitch Client ID";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.AutoSize = true;
            this.ErrorProvider.Location = new System.Drawing.Point(564, 322);
            this.ErrorProvider.Name = "ErrorProvider";
            this.ErrorProvider.Size = new System.Drawing.Size(0, 15);
            this.ErrorProvider.TabIndex = 18;
            // 
            // TxtSpotifyApiKey
            // 
            this.TxtSpotifyApiKey.Location = new System.Drawing.Point(12, 137);
            this.TxtSpotifyApiKey.Name = "TxtSpotifyApiKey";
            this.TxtSpotifyApiKey.Size = new System.Drawing.Size(194, 23);
            this.TxtSpotifyApiKey.TabIndex = 19;
            this.TxtSpotifyApiKey.Text = "Insert Spotify Client ID";
            // 
            // TxtSpotifyClientSecret
            // 
            this.TxtSpotifyClientSecret.Location = new System.Drawing.Point(212, 137);
            this.TxtSpotifyClientSecret.Name = "TxtSpotifyClientSecret";
            this.TxtSpotifyClientSecret.Size = new System.Drawing.Size(194, 23);
            this.TxtSpotifyClientSecret.TabIndex = 20;
            this.TxtSpotifyClientSecret.Text = "Insert Spotify Client Secret ";
            // 
            // OpenTutorialVideoForm
            // 
            this.OpenTutorialVideoForm.Location = new System.Drawing.Point(428, 137);
            this.OpenTutorialVideoForm.Name = "OpenTutorialVideoForm";
            this.OpenTutorialVideoForm.Size = new System.Drawing.Size(27, 23);
            this.OpenTutorialVideoForm.TabIndex = 21;
            this.OpenTutorialVideoForm.Text = "?";
            this.OpenTutorialVideoForm.UseVisualStyleBackColor = true;
            this.OpenTutorialVideoForm.Click += new System.EventHandler(this.OpenTutorialVideoForm_Click);
            // 
            // TxtChatIdTelegram
            // 
            this.TxtChatIdTelegram.Location = new System.Drawing.Point(276, 192);
            this.TxtChatIdTelegram.Name = "TxtChatIdTelegram";
            this.TxtChatIdTelegram.Size = new System.Drawing.Size(119, 23);
            this.TxtChatIdTelegram.TabIndex = 22;
            this.TxtChatIdTelegram.Text = "Chat ID Telegram";
            // 
            // TelegramTutorial
            // 
            this.TelegramTutorial.Location = new System.Drawing.Point(428, 191);
            this.TelegramTutorial.Name = "TelegramTutorial";
            this.TelegramTutorial.Size = new System.Drawing.Size(27, 23);
            this.TelegramTutorial.TabIndex = 23;
            this.TelegramTutorial.Text = "?";
            this.TelegramTutorial.UseVisualStyleBackColor = true;
            this.TelegramTutorial.Click += new System.EventHandler(this.TelegramTutorial_Click);
            // 
            // BootingUpDiscord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TelegramTutorial);
            this.Controls.Add(this.TxtChatIdTelegram);
            this.Controls.Add(this.OpenTutorialVideoForm);
            this.Controls.Add(this.TxtSpotifyClientSecret);
            this.Controls.Add(this.TxtSpotifyApiKey);
            this.Controls.Add(this.ErrorProvider);
            this.Controls.Add(this.TxtTwitchAccessToken);
            this.Controls.Add(this.TxtDiscordToken);
            this.Controls.Add(this.TxtYouTubeApiKey);
            this.Controls.Add(this.TxtTwitchClientID);
            this.Controls.Add(this.InputKeysButton);
            this.Controls.Add(this.UploadFormLoad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.button1);
            this.Name = "BootingUpDiscord";
            this.Text = "Discord bot settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button EndButton;
        private PictureBox pictureBox1;
        private Button UploadFormLoad;
        private Button InputKeysButton;
        private TextBox TxtTwitchAccessToken;
        private TextBox TxtDiscordToken;
        private TextBox TxtYouTubeApiKey;
        private TextBox TxtTwitchClientID;
        private Label ErrorProvider;
        private TextBox TxtSpotifyApiKey;
        private TextBox TxtSpotifyClientSecret;
        private Button OpenTutorialVideoForm;
        private TextBox TxtChatIdTelegram;
        private Button TelegramTutorial;
    }
}