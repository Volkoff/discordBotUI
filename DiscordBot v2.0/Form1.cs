namespace DiscordBot_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await new Program().MainAsync();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            XMLWriter xml = new XMLWriter();
        }
    }
}