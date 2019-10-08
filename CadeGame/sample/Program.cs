using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample {
    class Program {
        const int CARDS = 10;
        const int MAX_TURN = 3;
        const int MAX_HP = 2500;
        const int MIN_POWER = 20;
        const int MAX_POWER = 100;
        static int enemyHp;
        static bool isEnemyDie;
        static int[] cards = new int[CARDS];
        static Random rand = new Random();

        static void CreateDeck() {
            for(int i = 0; i < CARDS; i++) {
                cards[i] = rand.Next(MIN_POWER, MAX_POWER + 1);
            }
        }
        static void InitGame() {
            enemyHp = MAX_HP;
            isEnemyDie = false;
            CreateDeck();
            Console.WriteLine("\nガチャを引いた");
            Console.WriteLine(String.Join(" ", cards));
            Console.WriteLine("BasePower:" + cards.Sum());
            WaitEnter();
        }
        static void WaitEnter() {
            Console.ReadLine();
            Console.WriteLine();
        }
        static void DisplayHp() {
            Console.WriteLine("HP:" + enemyHp);
            int starCount = enemyHp / 100;
            if(enemyHp%100 != 0) {
                starCount++;
            }
            for(int i = 0; i < starCount; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void AppearEnemy() {
            Console.WriteLine("敵が現れた！");
            DisplayHp();
            WaitEnter();

        }
        static void Turn(int n) {
            Console.WriteLine("turn" + (n+1));
            var damages = cards.Select(OneCardPower).ToArray();
            Console.WriteLine(string.Join(" ", damages));
            int sum = damages.Sum();
            Console.WriteLine($"合計{sum}ダメージを与えた");
            enemyHp -= sum;
            if (enemyHp <= 0) {
                isEnemyDie = true;
                Console.WriteLine("タワバァ！");
            } else {
                DisplayHp();
            }
            WaitEnter();
        }
        static int OneCardPower(int cardPower) {
            int n = rand.Next(10);
            return n < 3 ? cardPower * 2 : cardPower;
        }
        static bool isRetry() {
            Console.Write("もう一度?(Yes...1,No...2)>");
            int input = int.Parse(Console.ReadLine());
            return input == 1;
        }
        static void Main(string[] args) {
            while (true) {
                InitGame();
                AppearEnemy();
                for(int i = 0; i < MAX_TURN&&!isEnemyDie; i++) {
                    Turn(i);
                }
                if (isEnemyDie) {
                    Console.WriteLine("討伐成功！");
                } else {
                    Console.WriteLine("討伐に失敗した...");
                }
                if (!isRetry()) {
                    Console.WriteLine("アプリケーションを終了します。");
                    break;
                }
            }
        }
    }
}
