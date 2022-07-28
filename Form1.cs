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
            while (true)
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

                if (labelpath1.Text == "")
                {
                    var box1 = MessageBox.Show("select proper path", "Sound Player Assigner", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (box1 == DialogResult.Cancel)
                    {
                        labelpath1.Text = "Select Path";
                        break;
                    }
                }
                else
                {
                    labelpath1.Text = filePath;
                    select1.BackColor = Color.LimeGreen;
                    break;
                }


            }
        }

        private void Selector_Load(object sender, EventArgs e)
        {

        }
       
        //play button
        public void play_Click(object sender, EventArgs e)
        {
            if (labelpath1.Text == "Select Path")
            {
                MessageBox.Show("Please select path", "Sound Player Assigner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                SoundPlayer play = new SoundPlayer();
                string PATH = labelpath1.Text;
                play.SoundLocation = PATH;

                play.Play();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 second = new Form2();
            second.PATHA = labelpath1.Text;
            second.PATHB = labelpath2.Text;
            second.PATHC = labelpath3.Text;
            second.Show();
        }

        public void select2_Click(object sender, EventArgs e)
        {
            while (true)
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
                labelpath2.Text = filePath;
                if (labelpath2.Text == "")
                {
                    var box2 = MessageBox.Show("select proper path", "Sound Player Assigner", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (box2 == DialogResult.Cancel)
                    {
                        labelpath2.Text = "Select Path";
                        break;
                    }
                }
                else
                {

                    select2.BackColor = Color.LimeGreen;
                    break;
                }
            }
        }
        
        public void play2_Click(object sender, EventArgs e)
        {
            if (labelpath2.Text == "Select Path")
            {
                MessageBox.Show("Please select path","Sound Player Assigner",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            
            }
            else
            {
                SoundPlayer playB = new SoundPlayer();
                string PATHB = labelpath2.Text;
                playB.SoundLocation = PATHB;

                playB.Play();
            }
        }

        private void select3_Click(object sender, EventArgs e)
        {
            while (true)
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
                labelpath3.Text = filePath;
                if (labelpath3.Text == "")
                {

                    var box3 = MessageBox.Show("select proper path", "Sound Player Assigner", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (box3 == DialogResult.Cancel)
                    {
                        labelpath3.Text = "Select Path";
                        break;
                    }

                }
                else
                { 
                        select3.BackColor = Color.LimeGreen;
                        break;
                    
                }
            }
        }

        private void play3_Click(object sender, EventArgs e)
        {
            if (labelpath3.Text == "Select Path")
            {
                MessageBox.Show("Please select path", "Sound Player Assigner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SoundPlayer playC = new SoundPlayer();
                string PATHC = labelpath3.Text;
                playC.SoundLocation = PATHC;

                playC.Play();
            }
        }
    }
}
