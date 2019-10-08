using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMgame {
    class MyMoney {
        public int Money { set; get; } = 3000;
        public void ShowInfo() {
            Console.WriteLine($"※預金残高は{Money}万円です。");
        }
        public int OutMoney(int random) {
            int outMoney= random * 100;
            Money -= outMoney;
            return outMoney;
        }
        public bool Judge() {
            return Money<=0 ? false:true;
        }
        public void Init() {
            Money = 3000;
        }
    }
}
