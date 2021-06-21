using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class YearNonth {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearNonth(int Year, int Month) {
            this.Year = Year;
            this.Month = Month;
        }
        public bool Is21Century {
            get {
                return 2001 <= Year && Year <= 2100;
            }
        }
            public YearNonth AssOneNonth() {
            if (Month ==12) {
                return new YearNonth(this.Year+1,1);
            }else{
                return new YearNonth(this.Year, this.Month + 1);
            }
        }
        public override string ToString() {
            return $"{Year}年{Month}月";
        }
    }
}
