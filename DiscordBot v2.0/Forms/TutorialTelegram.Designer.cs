using System.Windows.Forms;
namespace DiscordBot_v2._0.Forms
{
    partial class TutorialTelegram
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(310, 121);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Follow this tutorial to get the chat id\nhttps://www.alphr.com/find-chat-id-telegr" +
    "am/\n";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(458, 145);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(119, 67);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TutorialTelegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 224);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TutorialTelegram";
            this.Text = "TutorialTelegram";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button CloseButton;
    }
}