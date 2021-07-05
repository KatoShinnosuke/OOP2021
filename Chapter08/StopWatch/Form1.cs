using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Stopwatch : Form {

        Stopwatch sw = new Stopwatch();
        public Stopwatch() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\.ff");
            lbTimerDisp.Text = "00:00:00:00";

        }
    }
}
