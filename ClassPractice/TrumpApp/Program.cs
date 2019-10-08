using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpApp {
    class Program {
        static void Main(string[] args) {
            Trump t1 = new Trump();
            Trump t2 = new Trump();
            Random rand = new Random();
            int count = 1;
            int t1Number = 0;
            int t2Number = 0;            

            while (count <= 5) {
                Console.WriteLine("TURN:"+count);
                int n = t1.deck[rand.Next(0, t1.deck.Count())];
                t1Number = n % 100;
                if (t1Number == 99) {
                    Console.WriteLine("JOKER をドローした");
                } else {
                    Console.WriteLine(t1Number + "をドローした");
                }
                int m = t2.deck[rand.Next(0, t2.deck.Count())];
                t2Number = m % 100;
                if (t2Number == 99) {
                    Console.WriteLine("JOKER をドローした");
                } else {
                    Console.WriteLine(t2Number + "をドローした");
                }
                if(t1Number==99 && t2Number == 99) {
                    Console.WriteLine("あなたの負けですゲーム終了");
                    return;
                }
                if(t1Number==99 || t2Number == 99) {
                    Console.WriteLine("引ける回数が一回増えました");
                    continue;
                }
                if (t1Number == t2Number) {
                    Console.WriteLine("成功ですおめでとう！");
                    return;
                } else {
                    Console.WriteLine("残念...");
                }
                t1.deck.Remove(n);
                t2.deck.Remove(m);
                
                count++;
                if (count >5) {
                    Console.WriteLine("あなたの負けですゲーム終了");
                }
            }
        }
    }
}
