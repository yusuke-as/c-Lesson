using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearLesson {
    class Program {
        static void Main(string[] args) {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            while (true) {
                Console.Write("1...Red,2...Blue,3...ClearConsole,4...End>");
                int select = int.Parse(Console.ReadLine());
                switch (select) {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(lorem);
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(lorem);
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("end");
                        return;
                }
            }
        }
    }
}
