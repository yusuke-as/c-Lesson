using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp {
    class Program {
        static void Main(string[] args) {
            Console.Write("現在の体重は？:> ");
            int now = int.Parse(Console.ReadLine());
            Console.Write("目標体重は？:> ");
            int goal = int.Parse(Console.ReadLine());
            Human h = new Human(now, goal);
            while (true) {               
                Console.Write("目標に向けて今日は何キロ走りますか？1…10km、2…20km、3…30km、4…現在の情報、5…終了> ");
                int select = int.Parse(Console.ReadLine());
                switch (select) {
                    case 1:
                        h.NowWeight -= 1;
                        if (h.Gudge()) {
                            return;
                        }
                        h.Run10();
                        break;
                    case 2:
                        h.NowWeight -= 5;
                        if (h.Gudge()) {
                            return;
                        }
                        h.Run20();
                        break;
                    case 3:
                        h.NowWeight -= 10;
                        if (h.Gudge()) {
                            return;
                        }
                        h.Run30();
                        break;
                    case 4:
                        h.ShowStatus();
                        break;
                    case 5:
                        Console.WriteLine("アプリケーションを終了します。");
                        return;
                }
            }
        }
    }
}
