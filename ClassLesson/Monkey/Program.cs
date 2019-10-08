using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyApp {
    class Program {
        static void Main(string[] args) {
            Monkey m = new Monkey();
            Console.Write("おさるの名前を決めてください>");
            m.Name=Console.ReadLine();
            Console.Write("おさるの歳を決めてください>");
            m.Age = int.Parse(Console.ReadLine());
            while (true) {
                Console.WriteLine("おさるに何をさせますか？1…挨拶、2…竹馬、3…逆立ち、4…終了>");
                int select = int.Parse(Console.ReadLine());
                switch(select){
                    case 1:
                        m.Aisatsu();
                        break;
                    case 2:
                        m.Takeuma();
                        break;
                    case 3:
                        m.Sakadachi();
                        break;
                    default:
                        Console.WriteLine("処理を終了します。");
                        return;
                }
            }
        }
    }
}
