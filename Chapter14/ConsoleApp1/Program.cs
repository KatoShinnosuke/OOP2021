using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
        {
            {"前橋",4210 },
            {"みなかみ",4220 },
            {"宇都宮",4110 },
            {"水戸",4010 },
        };
        List<int> cityCode = new List<int>();
        static void Main(string[] args)
        {
            new Program();
        }
       // コンストラクタ
           public Program()
        {
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();
            Console.WriteLine("地域コードを入力");
            int num = 1;
            foreach (KeyValuePair<string,int>pair in AreaDic)
            {
                Console.WriteLine("{0}:{1}",num++,pair.Key);
                cityCode.Add(pair.Value);
            }
            Console.WriteLine("1:前橋");
            Console.WriteLine("2:みなかみ");
            Console.WriteLine("3:宇都宮");
            Console.WriteLine("4:水戸");
            Console.WriteLine("9:その他(直接入力)");
            Console.WriteLine();

            Console.Write(">");
            var selectArea = Console.ReadLine();
            int pos = int.Parse(selectArea);

            IEnumerable<string> results;

            if (pos != 9)
            {
                _ = GetWeatherReportFromYahoo(cityCode[pos - 1]);
            }
            else
            {
                Console.Write("都市コードを入力");
                var inputCode = Console.ReadLine();
                results = GetWeatherReportFromYahoo(int.Parse(inputCode)); ;
            }



            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
       
       //リスト14.17
         private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\oktk5\OneDrive\画像\スクリーンショット\スクリーンショット (103).png");
            var filename = @"C:\temp\example.png";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }
        public void OpenReadSamlpe()
        {
            var wc = new WebClient();
            using(var stream = wc.OpenRead(@"https://yahoo.cp.jp/"))
                using(var sr = new StreamReader(stream,Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
