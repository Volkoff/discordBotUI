namespace DiscordBot_v2._0
{
    partial class UploadConfig
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
            this.DoneButton = new System.Windows.Forms.Button();
            this.SaveTwitchKeys = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UploadYouTube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(578, 306);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(210, 132);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // SaveTwitchKeys
            // 
            this.SaveTwitchKeys.Location = new System.Drawing.Point(31, 28);
            this.SaveTwitchKeys.Name = "SaveTwitchKeys";
            this.SaveTwitchKeys.Size = new System.Drawing.Size(163, 67);
            this.SaveTwitchKeys.TabIndex = 1;
            this.SaveTwitchKeys.Text = "Upload Twitch keys";
            this.SaveTwitchKeys.UseVisualStyleBackColor = true;
            this.SaveTwitchKeys.Click += new System.EventHandler(this.UploadTwitchKeys_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(288, 59);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(424, 96);
            this.path.TabIndex = 2;
            this.path.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UploadYouTube
            // 
            this.UploadYouTube.Location = new System.Drawing.Point(31, 137);
            this.UploadYouTube.Name = "UploadYouTube";
            this.UploadYouTube.Size = new System.Drawing.Size(163, 67);
            this.UploadYouTube.TabIndex = 3;
            this.UploadYouTube.Text = "Upload YouTube keys";
            this.UploadYouTube.UseVisualStyleBackColor = true;
            this.UploadYouTube.Click += new System.EventHandler(this.UploadYouTube_Click);
            // 
            // UploadConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadYouTube);
            this.Controls.Add(this.path);
            this.Controls.Add(this.SaveTwitchKeys);
            this.Controls.Add(this.DoneButton);
            this.Name = "UploadConfig";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button DoneButton;
        private Button SaveTwitchKeys;
        private RichTextBox path;
        private OpenFileDialog openFileDialog1;
        private Button UploadYouTube;
    }
}