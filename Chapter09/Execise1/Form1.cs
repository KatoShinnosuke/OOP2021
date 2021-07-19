using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();  //一行読み込み
                        if (line.Contains(tbKeyWord.Text)){
                            count++;
                        }
                        tbOutput.Text =
                        "キーワード「" + tbKeyWord.Text + "」は、" + count.ToString() + "行です。";
                    }
                }
            }
        }
        private void btReadAllLines_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
            }
        }
    }
}
