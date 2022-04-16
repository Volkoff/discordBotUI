using System.Windows.Forms;
namespace DiscordBot_v2._0.Forms
{
    partial class Running
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Running));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopWatch = new System.Windows.Forms.Label();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.SecretModeButton = new System.Windows.Forms.Button();
            this.IsRunning = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopWatch.Location = new System.Drawing.Point(30, 9);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(204, 65);
            this.StopWatch.TabIndex = 0;
            this.StopWatch.Text = "00:00:00";
            // 
            // CloseApplication
            // 
            this.CloseApplication.Location = new System.Drawing.Point(12, 121);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(91, 57);
            this.CloseApplication.TabIndex = 1;
            this.CloseApplication.Text = "End application";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // SecretModeButton
            // 
            this.SecretModeButton.Location = new System.Drawing.Point(175, 121);
            this.SecretModeButton.Name = "SecretModeButton";
            this.SecretModeButton.Size = new System.Drawing.Size(86, 57);
            this.SecretModeButton.TabIndex = 2;
            this.SecretModeButton.Text = "Enable Secret Mode";
            this.SecretModeButton.UseVisualStyleBackColor = true;
            this.SecretModeButton.Click += new System.EventHandler(this.SecretModeButton_Click);
            // 
            // IsRunning
            // 
            this.IsRunning.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IsRunning.BalloonTipText = "Bot is running";
            this.IsRunning.BalloonTipTitle = "Bot status";
            this.IsRunning.Icon = ((System.Drawing.Icon)(resources.GetObject("IsRunning.Icon")));
            this.IsRunning.Text = "Bot is running!";
            this.IsRunning.Visible = true;
            this.IsRunning.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IsRunning_MouseDoubleClick);
            // 
            // Running
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 190);
            this.Controls.Add(this.SecretModeButton);
            this.Controls.Add(this.CloseApplication);
            this.Controls.Add(this.StopWatch);
            this.Name = "Running";
            this.Text = "Running";
            this.Load += new System.EventHandler(this.Running_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label StopWatch;
        private Button CloseApplication;
        private Button SecretModeButton;
        private NotifyIcon IsRunning;
    }
}