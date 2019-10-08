using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("整数を1つ入力してください>");
            int a = int.Parse(Console.ReadLine());
            Console.Write("整数を1つ入力してください>");
            int b = int.Parse(Console.ReadLine());
            Console.Write("整数を1つ入力してください>");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"最も大きい数値は{MaxOf(a,MaxOf(b,c))}です");
        }
        static int MaxOf(int a,int b) {
            return a > b ? a : b;
        }
    }
}
