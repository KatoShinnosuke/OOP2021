using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();
            Console.WriteLine("本の平均価格は" + books.Average
                (x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" +
                books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("最も価格の高い本" +
                books.Max(x => x.Price) + "円");
            Console.WriteLine("最も価格が安い本" +
                books.Min(x => x.Price) + "円");
            //500円以上の本は何冊
            Console.WriteLine("500円以上の本" +
                books.Where(x => 500 < x.Price).Count() + "冊");
            //本のタイトルに「物語」が含まれている本の一覧
            Console.WriteLine("物語" + books.Count
                (x => x.Title.Contains(("物語") + "です")));
            //本のタイトルに「物語」が含まれてる本一覧
            var bookDate = books.Where(x => x.Title.Contains("物語"))
                .Take(2);
            foreach (var book in bookDate) {
                Console.WriteLine(book.Title);
            }
           var output = books OrderByDescending(x => x.price);
            foreach (var item in output) {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            Console.WriteLine();

            var titles =books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
