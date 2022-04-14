using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot_v2._0.Forms
{
    public partial class Tutorial : Form
    {
        private FolderBrowserDialog fbd;
        private string path;
        FileStream f1;
        public Tutorial()
        {
            InitializeComponent();
        }

        private void ChoosePath_click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogTutorial.ShowDialog() == DialogResult.OK)
            {
                path = FolderBrowserDialogTutorial.SelectedPath;
                path += "/api.json";
            }
        }

        private void Done_click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
        }

        private void SaveToPath_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                Forms.FileIsAlreadyCreated fileIsAlreadyCreated = new FileIsAlreadyCreated();
                fileIsAlreadyCreated.ShowDialog();
                return;
            }
            f1 = new FileStream(path, FileMode.CreateNew);
            Forms.Succesful succesful = new Succesful();
            succesful.ShowDialog();
        }
    }
}
