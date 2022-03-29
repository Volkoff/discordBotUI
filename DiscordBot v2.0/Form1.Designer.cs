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
            this.YouTubeApiKey = new System.Windows.Forms.TextBox();
            this.TwitchApiKey = new System.Windows.Forms.TextBox();
            this.DiscordToken = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // YouTubeApiKey
            // 
            this.YouTubeApiKey.Location = new System.Drawing.Point(12, 32);
            this.YouTubeApiKey.Name = "YouTubeApiKey";
            this.YouTubeApiKey.Size = new System.Drawing.Size(499, 23);
            this.YouTubeApiKey.TabIndex = 1;
            this.YouTubeApiKey.Text = "Input api key here";
            // 
            // TwitchApiKey
            // 
            this.TwitchApiKey.Location = new System.Drawing.Point(12, 81);
            this.TwitchApiKey.Name = "TwitchApiKey";
            this.TwitchApiKey.Size = new System.Drawing.Size(499, 23);
            this.TwitchApiKey.TabIndex = 2;
            this.TwitchApiKey.Text = "Input api key here";
            // 
            // DiscordToken
            // 
            this.DiscordToken.Location = new System.Drawing.Point(12, 129);
            this.DiscordToken.Name = "DiscordToken";
            this.DiscordToken.Size = new System.Drawing.Size(499, 23);
            this.DiscordToken.TabIndex = 3;
            this.DiscordToken.Text = "Input api key here";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "set";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 98);
            this.button5.TabIndex = 7;
            this.button5.Text = "End application";
            this.button5.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DiscordToken);
            this.Controls.Add(this.TwitchApiKey);
            this.Controls.Add(this.YouTubeApiKey);
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
        private TextBox YouTubeApiKey;
        private TextBox TwitchApiKey;
        private TextBox DiscordToken;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}