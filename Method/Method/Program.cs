using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method {
    class Program {
        static void Main(string[] args) {
            int money = 2500;
            Console.WriteLine($"所持金は{ money}円です");
            int price=Shop("薬草");
            money -= price;
            Console.WriteLine($"所持金は{ money}円です");
            price = Shop("万能薬");
            money -= price;
            Console.WriteLine($"所持金は{ money}円です");
            Thankyou();
        }
        static int Shop(string itemName) {
            Console.WriteLine("いらっしゃいませ!");
            int price = 0;
            if (itemName == "薬草") {
                Console.WriteLine(itemName+"は100円です");
                price = 100;
            } else if (itemName == "万能薬") {
                Console.WriteLine(itemName + "は500円です");
                price = 500;
            } else if (itemName == "こん棒") {
                Console.WriteLine(itemName+"は1500円です");
                price = 1500;
            } else {
                Console.WriteLine("売り切れです");
            }
            return price;
        }
        static void Thankyou() {
            Console.WriteLine("ありがとうございました!");
        }
    }
}
