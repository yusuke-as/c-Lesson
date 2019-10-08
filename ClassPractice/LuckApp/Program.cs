using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckApp {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int target = rand.Next(1, 101);
            Character charA = new Character(rand.Next(1, 21));
            Character charB = new Character(rand.Next(1, 21));
            Console.WriteLine($"A　　【運】{charA.Luck}");
            Console.WriteLine($"B　　【運】{charB.Luck}");
            int cardA, cardB;
            bool isOKA = false, isOKB = false;
            while (true) {
                for (int i = 0; i < charA.Luck; i++) {
                    cardA = rand.Next(1, 101);
                    if (cardA == target) {
                        isOKA = true;
                        break;
                    }
                }
                for (int i = 0; i < charB.Luck; i++) {
                    cardB = rand.Next(1, 101);
                    if (cardB == target) {
                        isOKB = true;
                        break;
                    }
                }
                Console.Write("Aのドロー　・・・・・・・・・");
                Console.WriteLine(isOKA ? "当たり！" : "はずれ");
                if (isOKA && isOKB == false) {
                    if (charA.Luck < charB.Luck) {
                        Console.WriteLine("【下剋上】");
                    } else {
                        Console.WriteLine("【WIN】");
                    }
                }
                if (isOKA == false && isOKB) {
                    if (charA.Luck > charB.Luck) {
                    } else {
                        Console.WriteLine("【LOSE】");
                    }
                }
                Console.Write("Bのドロー　・・・・・・・・・");
                Console.WriteLine(isOKB ? "当たり！" : "はずれ");
                if (isOKB && isOKA == false) {
                    if (charB.Luck < charA.Luck) {
                        Console.WriteLine("【下剋上】");
                    } else {
                        Console.WriteLine("【WIN】");
                    }
                }
                if (isOKB == false && isOKA) {
                    if (charB.Luck > charA.Luck) {
                    } else {
                        Console.WriteLine("【LOSE】");
                    }
                }
                if (isOKA || isOKB) {
                    return;
                }
                Console.WriteLine();
            }
        }
    }
}
