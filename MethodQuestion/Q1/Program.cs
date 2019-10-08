using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("整数を1つ入力してください>");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"{input}の二乗は{Calc(input)}です");
        }
        static int Calc(int n) {
            return n * n;
        }
    }
}
