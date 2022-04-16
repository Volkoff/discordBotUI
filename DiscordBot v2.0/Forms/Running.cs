using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DiscordBot_v2._0.Forms
{
    public partial class Running : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        public Running()
        {
            InitializeComponent();
            
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Running_Load(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.StopWatch.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void SecretModeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsRunning.Visible = true;
            IsRunning.ShowBalloonTip(3000);
            this.ShowInTaskbar = false;
        }

        private void IsRunning_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            IsRunning.Visible = false;
            this.ShowInTaskbar = true;
        }
    }
}
