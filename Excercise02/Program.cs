using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02 {
    class Program {
        static void Main(string[] args) {
            var ymCollection = new YearNonth[] {
              new YearNonth(2000,1),
              new YearNonth(2001,2),
              new YearNonth(2004,3),
              new YearNonth(2008,4),
              new YearNonth(2016,5),
          };
            foreach (var ym in YearNonth) {
                Console.WriteLine(ym);

            }
            if (First21Century(YearNonth) == null) {
            } else {
                Console.WriteLine((First21Century(YearNonth).Year));

            }
            var OneMonthLater = YearNonth.select(s => s.AddOnwMonth());
            foreach (var ym in YearNonth) {
                Console.WriteLine(ym);
            }
        }
        
        public static YearNonth First21Century(YearNonth[] YearNonth) {
                foreach (var ym in YearNonth) {
                    if (ym.Is21Centuy) {
                        return ym;
                    }
                }
                return null;
        }
    }
}
