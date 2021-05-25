using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConvertar {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フォール度からメートルへの対応表を出力
                PrintFeetToMeterList(1,10);
            } else {
                //フォール度からメートルへの対応表を出力
                PrintMeterToFeetList(1,10);
            }
        }
        //フォール度からメートルへの対応表を出力
        private static void PrintMeterToFeetList(int start,int stop) {
            for (int meter = start; meter <= stop; meter++) {
                FeetConverter converter = new FeetConverter();
                double feet = converter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} fm", meter, feet);

            }
        }
        //フォール度からメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter = converter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
    }
}
