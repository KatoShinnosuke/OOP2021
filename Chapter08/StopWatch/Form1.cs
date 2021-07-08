using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class  Form1 : Form{

        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\.ff");
            tbStart.Text = "00:00:00:00";

        }

        private void lbTimerDisp_Click(object sender, EventArgs e) {
            sw.Start();
            tmDisp.Start();
        }

        private void btstop_Click(object sender, EventArgs e) {
            sw.Stop();
            tmDisp.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
        }
    }
}
