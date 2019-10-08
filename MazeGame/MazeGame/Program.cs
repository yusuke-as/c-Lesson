using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame {
    class Program {
        static void Main(string[] args) {
            Drawmap();
            while (true) {
                string key = Console.ReadLine();
                MovePlayer(key);
                Drawmap();
                if (CheckGoal()) {
                    break;
                }
            }
            Console.WriteLine("GAME CREAR!");
        }
        static char[] map ={
            '#', '#', '#', '#', '#',
             '#', ' ', ' ', ' ', '#',
             '#', ' ', '#', ' ', '#',
             '#', 'P', '#', 'G', '#',
             '#', '#', '#', '#', '#',
        };
        static void Drawmap() {
            for(int i = 0; i < map.Length; i++) {
                Console.Write(map[i]);
                if ((i + 1) % 5 == 0) {
                    Console.Write(System.Environment.NewLine);
                }
            }
        }
        static void MovePlayer(string key) {
            int PlayerPos = Array.IndexOf(map, 'P');
            int PlayerNextPos = 0;
            if (key == "a") {
                PlayerNextPos = PlayerPos - 1;
            } else if (key == "d") {
                PlayerNextPos = PlayerPos + 1;
            } else if (key == "w") {
                PlayerNextPos = PlayerPos - 5;
            } else if (key == "s") {
                PlayerNextPos = PlayerPos + 5;
            } else {
                return;
            }
            if (map[PlayerNextPos] != '#') {
                map[PlayerNextPos] = 'P';
                map[PlayerPos] = ' ';
            }
        }
        static bool CheckGoal() {
            if (Array.IndexOf(map,'G') < 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
