using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMgame {
    class Program {
        static void Main(string[] args) {
            MyMoney my = new MyMoney();
            var banks=new List<Bank> {
                new Bank("鳥肌銀行", 500),
                new Bank("ときめき銀行", 900),
                new Bank("さわやか銀行", 200)
             };           
            Random rand = new Random();
            int number;
            int upperLine;
            int returnMoney;
            while (true) {
                Console.WriteLine("[借入額]");
                foreach(Bank b in banks) {                   
                        b.ShowInfo();
                }
                my.ShowInfo();
                Console.WriteLine();

                Console.Write("引き出しますか(はい: y いいえ: n) >");
                string select = Console.ReadLine();
                switch (select) {
                    case "n":                  
                        Console.WriteLine("…夢だった。最初からやり直し！！");
                        my.Init();
                        foreach (Bank b in banks) {
                            b.Init();
                        }
                        break;
                    case "y":
                        if (my.Money >= 1000) {
                            upperLine = 10;
                        } else {
                            upperLine = my.Money / 100;
                        }
                        number = rand.Next(1, upperLine+1);
                        returnMoney=my.OutMoney(number);
                        Console.WriteLine($"トメは{returnMoney}万円の引き出しに成功した！！");                      
                        Console.Write($"何処に返済しますか ? ({banks.Select(n=>n.Name+":"+0)})>");
                        int returnDist=int.Parse(Console.ReadLine());
                        banks[returnDist].GetMoney(returnMoney);
                        if (!my.Judge()) {                           
                            return;
                        }                        
                        break;
                    default:
                        break;                    
                }
                if (banks[0].isFinish && banks[1].isFinish &&banks[2].isFinish) {
                    Console.WriteLine("全ての借金返済が完了した！！");
                    break;
                }
                Console.WriteLine();
            }
            if (!(banks[0].isFinish && banks[1].isFinish && banks[2].isFinish)) {
                Console.WriteLine("預金がなくなった！！");
                Console.WriteLine("ヒロシ「トメ、なんてことをしてくれたんだ！！」");
                Console.WriteLine("ゲームオーバー");
            }
        }
    }
}
