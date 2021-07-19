using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carReportSystem {
    public class CarReport {
        [DisplayName("日付")]
        public DateTime Date { get; set; }
        [DisplayName("記録者")]
        public string Auther { get; set; }
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }
        [DisplayName("車名")]
        public string CarName { get; set; }
        [DisplayName("レポート")]
        public string Report { get; set; }
        [DisplayName("画像")]
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
