using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carReportSystem {
    public class CarReport {
        public DateTime Date { get; set; }
        public string Auther { get; set; }
        public MakerGroup Maker { get; set; }
        public string CarName { get; set; }
        public string Report { get; set; }
        public Image Picture { get; set; }


        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }
        //データ更新
        public CarReport
            (DateTime date,string auther,MakerGroup maker,
            string carname,string report,Image picture) {
            this.Auther = auther;
            this.Date = date;
            this.Maker = maker;
            this.CarName = carname;
            this.Report = report;
            this.Picture = picture;
        }
    }
}
