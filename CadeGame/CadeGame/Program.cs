using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeGame {
    class Program {
        static void Main(string[] args) {
            Battle();           
            while (true) {
                Console.Write("もう一度?(Yes...1,No...2)>");
                int ans = int.Parse(Console.ReadLine());
                switch(ans){
                    case 1:
                        Battle();
                        break;
                    case 2:
                        Console.WriteLine("アプリケーションを終了します。");
                        return;
                }
            }
        }
        static int[] MakeCards() {
            int[] cards = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++) {
                cards[i] = rand.Next(20, 101);
            }
            return cards;
        }
        static int[] Attack(int[] cards) {
            int[] attackCards = new int[cards.Length];
            Random rand = new Random();
            for (int i = 0; i < cards.Length; i++) {
                if (rand.Next(1, 11) <= 3) {
                    attackCards[i] = cards[i] * 2;
                } else {
                    attackCards[i] = cards[i];
                }
            }
            return attackCards;
        }
        static void ShowHp(int enemyHp) {
            int hpGauge = 0;
            if (enemyHp%100==0) {
                hpGauge = enemyHp/100;
            } else {
                hpGauge = enemyHp / 100 + 1;
            }
            for(int i = 0; i < hpGauge; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void Battle() {
            var cards = MakeCards();
            Console.WriteLine("ガチャを引いた！");
            Console.WriteLine(String.Join(" ", cards));
            Console.WriteLine($"BasePower:{cards.Sum()}");
            Console.WriteLine();
            Console.WriteLine("敵が現れた！");
            int enemyHp = 2500;
            Console.WriteLine($"HP:{enemyHp}");
            ShowHp(enemyHp);
            Console.ReadLine();
            int attackCount = 0;
            while (true) {
                if (attackCount == 3) {
                    break;
                }
                attackCount++;
                Console.WriteLine($"turn{attackCount}");
                int[] attackCards = Attack(cards);
                Console.WriteLine(String.Join(" ", attackCards));
                Console.WriteLine($"合計{attackCards.Sum()}のダメージを与えた！");
                enemyHp -= attackCards.Sum();
                if(enemyHp > 0) { 
                   Console.WriteLine($"HP:{enemyHp}");
                   ShowHp(enemyHp);
                }
                if (enemyHp <= 0) {
                    Console.WriteLine("タワバァ！");
                    Console.WriteLine("討伐成功！");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
