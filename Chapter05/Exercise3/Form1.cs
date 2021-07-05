using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void inputStrText_TextChanged(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
        }

        private void a_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count( c => c == ' ' );
            a.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Replace("big", "samll");
        }

        private void button3_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ')
                .Where(s => s.Length<= 4);
            
        }

        private void button4_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                //tbStrBuilder.Text = sb.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            //inputStrDate.Text =
        }

        private void button5_Click(object sender, EventArgs e) {
            foreach (var pair  in inpuStrdate.Text.Split(';')) {
                var array = pair.Split('=');

            }
        }
        private string Tojapanese(string key) {
            switch(key){
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数がただしくありません");
        }
    }
}