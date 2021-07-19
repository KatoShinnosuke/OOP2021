using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise2 {
    public partial class Form1 : Form {
        public Form1() {
            string inputPath = "";
            string outputPath = "";
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void bt1_Click(object sender, EventArgs e) {
            if (sfdOpenFile.ShowDialog() == DialogResult.OK) {

                inputPath = sfdOpenFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (sfdOpenFile.ShowDialog() == DialogResult.OK) {
                outputPath = sfdSaveFile.FileName;
            }
        }

        private void bt3_Click(object sender, EventArgs e) {
            var lines = File.ReadLines(inputPath).select((string, n) => string.Format("{0,4}:{1}", n + 1, s)).ToArray();
            File.WriteAllLines(outputPath, lines);
        }
    }
}
