using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "曲(wavファイル)を選択してください";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "";
            //openFileDialog1.Filter = "wav ファイル|*.txt;*.log";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowHelp = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.Dispose();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb1.Text = (openFileDialog1.FileName);
            }

        }
        private System.Media.SoundPlayer player = null;
        
        private void PlaySound(string waveFile)
        {
            //string fileName = "C:\\music.mp3";

            if (player != null)
                StopSound();
            player = new System.Media.SoundPlayer(waveFile);

            if (checkBox_Loop.Checked == true)
            {
                player.PlayLooping(); 
            }
            else
            {
                player.Play(); 
            }
        }
        private void StopSound()
        {

            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "")
                StopSound();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PlaySound(tb1.Text);
        }
    }
}