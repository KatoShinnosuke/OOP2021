using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Song[] songs = new Song[2];

            songs[0] = new Song("僕のこと", "ミセス", 310);
            songs[1] = new Song("青と夏", "ミセス", 310);
            
            foreach(var i in songs) {
                Console.WriteLine("曲名:{0},歌手:{1},演奏時間:{2}:{3:00}",i.Title1,i.ArtistName1,(i.Length1/60),(i.Length1%60));
            }
        }
    }
}
