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
        public string PATH2 { get; set; }

        public void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = PATH2;
            player2.Play();




        }
        
    }
}
