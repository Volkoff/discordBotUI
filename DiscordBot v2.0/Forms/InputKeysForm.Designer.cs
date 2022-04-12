namespace DiscordBot_v2._0
{
    partial class InputKeysForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtTwitchAccessToken = new System.Windows.Forms.TextBox();
            this.TxtDiscordApiKey = new System.Windows.Forms.TextBox();
            this.TxtYouTubeApiKey = new System.Windows.Forms.TextBox();
            this.TxtTwitchClientID = new System.Windows.Forms.TextBox();
            this.SaveToPathButton = new System.Windows.Forms.Button();
            this.PathChooseButton = new System.Windows.Forms.Button();
            this.OpenFileDialogInputKeys = new System.Windows.Forms.OpenFileDialog();
            this.OpenTutorialForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTwitchAccessToken
            // 
            this.TxtTwitchAccessToken.Location = new System.Drawing.Point(211, 12);
            this.TxtTwitchAccessToken.Name = "TxtTwitchAccessToken";
            this.TxtTwitchAccessToken.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchAccessToken.TabIndex = 13;
            this.TxtTwitchAccessToken.Text = "Twitch Access Token";
            // 
            // TxtDiscordApiKey
            // 
            this.TxtDiscordApiKey.Location = new System.Drawing.Point(12, 125);
            this.TxtDiscordApiKey.Name = "TxtDiscordApiKey";
            this.TxtDiscordApiKey.Size = new System.Drawing.Size(390, 23);
            this.TxtDiscordApiKey.TabIndex = 12;
            this.TxtDiscordApiKey.Text = "Input DiscordAPI key";
            // 
            // TxtYouTubeApiKey
            // 
            this.TxtYouTubeApiKey.Location = new System.Drawing.Point(12, 61);
            this.TxtYouTubeApiKey.Name = "TxtYouTubeApiKey";
            this.TxtYouTubeApiKey.Size = new System.Drawing.Size(194, 23);
            this.TxtYouTubeApiKey.TabIndex = 11;
            this.TxtYouTubeApiKey.Text = "Insert YouTubeAPI key";
            // 
            // TxtTwitchClientID
            // 
            this.TxtTwitchClientID.Location = new System.Drawing.Point(12, 12);
            this.TxtTwitchClientID.Name = "TxtTwitchClientID";
            this.TxtTwitchClientID.Size = new System.Drawing.Size(138, 23);
            this.TxtTwitchClientID.TabIndex = 10;
            this.TxtTwitchClientID.Text = "Twitch Client ID";
            // 
            // SaveToPathButton
            // 
            this.SaveToPathButton.Location = new System.Drawing.Point(604, 342);
            this.SaveToPathButton.Name = "SaveToPathButton";
            this.SaveToPathButton.Size = new System.Drawing.Size(184, 96);
            this.SaveToPathButton.TabIndex = 14;
            this.SaveToPathButton.Text = "Save to path";
            this.SaveToPathButton.UseVisualStyleBackColor = true;
            // 
            // PathChooseButton
            // 
            this.PathChooseButton.Location = new System.Drawing.Point(414, 342);
            this.PathChooseButton.Name = "PathChooseButton";
            this.PathChooseButton.Size = new System.Drawing.Size(184, 96);
            this.PathChooseButton.TabIndex = 15;
            this.PathChooseButton.Text = "Choose path";
            this.PathChooseButton.UseVisualStyleBackColor = true;
            this.PathChooseButton.Click += new System.EventHandler(this.PathChooseButton_Click);
            // 
            // OpenTutorialForm
            // 
            this.OpenTutorialForm.Location = new System.Drawing.Point(12, 366);
            this.OpenTutorialForm.Name = "OpenTutorialForm";
            this.OpenTutorialForm.Size = new System.Drawing.Size(181, 72);
            this.OpenTutorialForm.TabIndex = 16;
            this.OpenTutorialForm.Text = "Peek tutorial";
            this.OpenTutorialForm.UseVisualStyleBackColor = true;
            this.OpenTutorialForm.Click += new System.EventHandler(this.OpenTutorialForm_Click);
            // 
            // InputKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenTutorialForm);
            this.Controls.Add(this.PathChooseButton);
            this.Controls.Add(this.SaveToPathButton);
            this.Controls.Add(this.TxtTwitchAccessToken);
            this.Controls.Add(this.TxtDiscordApiKey);
            this.Controls.Add(this.TxtYouTubeApiKey);
            this.Controls.Add(this.TxtTwitchClientID);
            this.Name = "InputKeysForm";
            this.Text = "InputKeysForm";
            this.Load += new System.EventHandler(this.InputKeysForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtTwitchAccessToken;
        private TextBox TxtDiscordApiKey;
        private TextBox TxtYouTubeApiKey;
        private TextBox TxtTwitchClientID;
        private Button SaveToPathButton;
        private Button PathChooseButton;
        private OpenFileDialog OpenFileDialogInputKeys;
        private Button OpenTutorialForm;
    }
}