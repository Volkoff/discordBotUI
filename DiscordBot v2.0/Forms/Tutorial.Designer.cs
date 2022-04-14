namespace DiscordBot_v2._0.Forms
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FolderBrowserDialogTutorial = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 125);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save to path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveToPath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChoosePath_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Done_click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private FolderBrowserDialog FolderBrowserDialogTutorial;
    }
}