using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げを集計するクラス
    class SalesCounter {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) 
                    //すでにコレクションに店舗が設定されてる
                    dict[sale.ShopName] += sale.Amount;
                 else
                    //コレクション店舗を登録
                    dict[sale.ShopName] = sale.Amount;
                }
                return dict;
            }
        }
    }
