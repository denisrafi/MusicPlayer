using System;           
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        private Band Band = new Band();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             using (OpenFileDialog ofd = new OpenFileDialog())
             {
                ofd.Filter = "MP3 File|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Band.open(ofd.FileName); 
                }
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Band.play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Band.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
