using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelmanism
{
    class Player
    {
        private int nowOpenCardIndex1;//今回1枚目に開いたカードの添え字
        private int nowOpenCardIndex2;//今回2枚目に開いたカードの添え字
        //前回1枚目に開いたカードの添え字
        public int BeforeOpenCardIndex1 { get; set; }
        //前回2枚目に開いたカードの添え字
        public int BeforeOpenCardIndex2 { get; set; }
        //めくった枚数
        public int OpenCounter { get; set; }
        //コンストラクタ
        public Player()
        {
            nowOpenCardIndex1 = nowOpenCardIndex2 = -1;
            BeforeOpenCardIndex1 = BeforeOpenCardIndex2 = -1;
        }
        //今回1枚目に開いたカードの添え字
        public int NowOpenCardIndex1
        {
            get { return nowOpenCardIndex1; }
            set
            {
                nowOpenCardIndex1 = value;
                OpenCounter++;
            }
        }
            //今回2枚目に開いたカードの添え字
        public int NowOpenCardIndex2
        {
            get { return nowOpenCardIndex2; }
            set
            {
                nowOpenCardIndex2 = value;
                OpenCounter++;
            }
        }
        //カードの情報をリセット
        public void Reset()
        {
            BeforeOpenCardIndex1 = NowOpenCardIndex1;
            BeforeOpenCardIndex2 = NowOpenCardIndex2;
            BeforeOpenCardIndex1 = -1;
            BeforeOpenCardIndex2 = -1;
            OpenCounter = 0;
        }
    }
}
