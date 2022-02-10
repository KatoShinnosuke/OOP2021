using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3_System
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Mp3Player _mp3Player;
        public Form()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                
                dlgOpen.Filter = "Mp3 Filr|*.mp3";
                dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                
                if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _mp3Player = new Mp3Player(dlgOpen.FileName);
                    _mp3Player.Repeat = true;
                    tb1.Text = (dlgOpen.FileName);
                }
            }
                
        }

            private void btnPlay_Click(object sender, EventArgs e)
            {
                if (_mp3Player != null)
                    _mp3Player.Play();
            }

            private void btnStop_Click(object sender, EventArgs e)
            {
                if (_mp3Player != null)
                    _mp3Player.Stop();
            }
        }
    }