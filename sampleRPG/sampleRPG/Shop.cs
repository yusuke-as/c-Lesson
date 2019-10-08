using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleRPG {
    class Shop {
        public string shopName;
        public int salesAmount;

        public void Sell() {
            Console.WriteLine("お買い上げありがとうございます。");
        }
        public void Buy() {
            Console.WriteLine("お売りいただきありがとうございます。");
        }
    }
}
