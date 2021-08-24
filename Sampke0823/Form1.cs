using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sampke0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exec_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Value.Text);
            int jyou = int.Parse(Jyou.Text);

            double resule = Math.Pow(value, jyou);

            Result.Text = Result.ToString();
        }
    }
}
