using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugoroluApp {
    class Dice {        
        int position;
        public Dice() {
            this.position = 10;
        }        
        public int Position {
            set {
                this.position = value;
            }
            get {
                return this.position;
            }
         }
        public void Throw(int n) {
            if (n >= Position) {
                Position = n - Position ;
            } else {
                Position -= n;
            }
            ShowPosition();
        }
        public void ShowPosition() {
            if (Position == 0) {
                Console.WriteLine("ARRIVE!");
                return;
            }
            for(int i = 0; i < Position; i++) {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}
