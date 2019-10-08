using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugoroluApp {
    class Dice {
        public string Name { get; }
        public int Position { set; get; }
        public Dice(string name,int position) {
            Name = name;
            Position = position;
        }       
        public void DoTurn(int diceNumber) {
            Console.WriteLine($"{Name}:");
            Console.Write("ゴールまでの距離:");
            ShowPosition();
            Console.WriteLine($"出た目:{diceNumber}");
            Console.Write("ゴールまでの距離:");
            Throw(diceNumber);
            ShowPosition();
            Console.ReadLine();
        }
        public void Throw(int n) {
            if (n >= Position) {
                Position = n - Position;
            } else {
                Position -= n;
            }           
        }
        public void ShowPosition() {
            if (Position == 0) {
                Console.WriteLine("ARRIVE!");
                return;
            }
            for (int i = 0; i < Position; i++) {
                Console.Write("■");
            }
            Console.WriteLine();
        }        
    }
}
