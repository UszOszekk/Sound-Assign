using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Directory_Sound_Player_Assigner
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
           
        }

        //select button + the label stuff
       
        public void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "audio files (*.wav)|*.wav";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.DefaultExt = ".wav";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;
                    
                 
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            

            labelpath.Text = filePath;
            
        }

        private void Selector_Load(object sender, EventArgs e)
        {

        }
       
        //play button
        public void play_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            string PATH = labelpath.Text;
            player.SoundLocation = PATH;

            player.Play();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 second = new Form2();
            second.PATH2 = labelpath.Text;
            second.Show();
        }
    }
}
