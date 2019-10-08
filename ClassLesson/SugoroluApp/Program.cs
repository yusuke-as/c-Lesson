using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugoroluApp {
    class Program {
        static void Main(string[] args) {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            int count = 0;

            dice1.ShowPosition();
            dice1.Throw(6);
            dice1.Throw(6);
            dice1.Throw(2);
            dice1.ShowPosition();
        }
    }
}
