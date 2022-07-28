using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Directory_Sound_Player_Assigner
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        public string PATHA { get; set; }
        public string PATHB { get; set; }
        public string PATHC { get; set; }


        public void button1_Click(object sender, EventArgs e)
        {
            if (PATHA == "Select Path")
            {
                MessageBox.Show("Please select path", "Sound Player Assigner", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = PATHA;
                player1.Play();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PATHB == "Select Path")
            {
                MessageBox.Show("Please select path", "Sound Player Assigner", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = PATHB;
                player1.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PATHC == "Select Path")
            {
                MessageBox.Show("Please select path", "Sound Player Assigner", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = PATHC;
                player1.Play();
            }
        }
    }
}
