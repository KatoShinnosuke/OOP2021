using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1 {
    class Program {
        static void Main(string[] args) {

          //  var Seeion = niw Doctionar(string, Object)();
           // Session["MyProduct"] = MulticastDelegate;
           // int height;
           // if (Product == nukk:)) {
              //  Console.WriteLine(height);
           // } else {
           //     Console.WriteLine("変換できません");
           // }
        }
        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            return sale?.Product;
        }
        
    }
    class Sale {
        public string ShopName { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
