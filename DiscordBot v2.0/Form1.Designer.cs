namespace DiscordBot_v2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTwitchClientID = new System.Windows.Forms.TextBox();
            this.TxtYouTubeApiKey = new System.Windows.Forms.TextBox();
            this.DiscordToken = new System.Windows.Forms.TextBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtTwitchAccessToken = new System.Windows.Forms.TextBox();
            this.SaveKeysButton = new System.Windows.Forms.Button();
            this.UploadFormLoad = new System.Windows.Forms.Button();
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
            // TxtTwitchClientID
            // 
            this.TxtTwitchClientID.Location = new System.Drawing.Point(12, 32);
            this.TxtTwitchClientID.Name = "TxtTwitchClientID";
            this.TxtTwitchClientID.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchClientID.TabIndex = 1;
            this.TxtTwitchClientID.Text = "Twitch Client ID";
            // 
            // TxtYouTubeApiKey
            // 
            this.TxtYouTubeApiKey.Location = new System.Drawing.Point(12, 81);
            this.TxtYouTubeApiKey.Name = "TxtYouTubeApiKey";
            this.TxtYouTubeApiKey.Size = new System.Drawing.Size(194, 23);
            this.TxtYouTubeApiKey.TabIndex = 2;
            this.TxtYouTubeApiKey.Text = "Insert YouTubeAPI key";
            // 
            // DiscordToken
            // 
            this.DiscordToken.Location = new System.Drawing.Point(12, 129);
            this.DiscordToken.Name = "DiscordToken";
            this.DiscordToken.Size = new System.Drawing.Size(499, 23);
            this.DiscordToken.TabIndex = 3;
            this.DiscordToken.Text = "Input api key here";
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
            // TxtTwitchAccessToken
            // 
            this.TxtTwitchAccessToken.Location = new System.Drawing.Point(211, 32);
            this.TxtTwitchAccessToken.Name = "TxtTwitchAccessToken";
            this.TxtTwitchAccessToken.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchAccessToken.TabIndex = 9;
            this.TxtTwitchAccessToken.Text = "Twitch Access Token";
            // 
            // SaveKeysButton
            // 
            this.SaveKeysButton.Location = new System.Drawing.Point(585, 55);
            this.SaveKeysButton.Name = "SaveKeysButton";
            this.SaveKeysButton.Size = new System.Drawing.Size(139, 72);
            this.SaveKeysButton.TabIndex = 4;
            this.SaveKeysButton.Text = "Save Keys";
            this.SaveKeysButton.UseVisualStyleBackColor = true;
            this.SaveKeysButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UploadFormLoad
            // 
            this.UploadFormLoad.Location = new System.Drawing.Point(585, 147);
            this.UploadFormLoad.Name = "UploadFormLoad";
            this.UploadFormLoad.Size = new System.Drawing.Size(139, 72);
            this.UploadFormLoad.TabIndex = 10;
            this.UploadFormLoad.Text = "Upload Keys";
            this.UploadFormLoad.UseVisualStyleBackColor = true;
            this.UploadFormLoad.Click += new System.EventHandler(this.UploadFormLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadFormLoad);
            this.Controls.Add(this.TxtTwitchAccessToken);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.SaveKeysButton);
            this.Controls.Add(this.DiscordToken);
            this.Controls.Add(this.TxtYouTubeApiKey);
            this.Controls.Add(this.TxtTwitchClientID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Discord bot settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox TxtTwitchClientID;
        private TextBox TxtYouTubeApiKey;
        private TextBox DiscordToken;
        private Button EndButton;
        private PictureBox pictureBox1;
        private TextBox TxtTwitchAccessToken;
        private Button SaveKeysButton;
        private Button UploadFormLoad;
    }
}