using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            //var ty1 = new DateTime(2016, 1, 20, 26, 0, 0);
            //var ty2 = new DateTime(2016, 1, 21, 1, 0, 0);
            //TimeSpan diff = ty1.Date - ty2.Date;
            //tbOutput.Text = "今日は" + (DayOfWeek)diff + "です。";


            tbOutput.Text = GetAge(dtoDateTime.Value , today).ToString;

            //tbOutput.Text = "今日は" + dow + "です";

            //var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            //if (isLeapYear) {
            //   tbLeapYear.Text = "閏年です";
            //} else {
            //   tbLeapYear.Text = "閏年ではないです";
            // }
            public int GetAge(DateTime birtday,DateTime targetDay) {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birtday.AddYears(age)) {
                    age--;
                }
                return age;
            }
        }
    }
}
