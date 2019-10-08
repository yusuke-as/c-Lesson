using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobayashi {
    class Program {
        static void Main(string[] args) {
            Console.Write("数値を入力してください>");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(judge(n));
        }
        static bool judge(int n) {
            return n % 2 == 0 ? true : false;
        }
    }
}
