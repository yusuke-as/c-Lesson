using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleRPG {
    class Program {
        static void Main(string[] args) {
            Player player1 = new Player("たかし",35);
            Player player2 = new Player("ひろし", 100);
            player2 = player1;
            Console.WriteLine(player2.hp);
            player1.hp = 0;
            Console.WriteLine(player2.hp);
        }
    }
}
