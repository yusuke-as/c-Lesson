using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace practice {
    class Program {
        static void Main(string[] args) {
            ShowEvenOrOdd(1);
        }
        static void ShowEvenOrOdd(int n) {
            Console.WriteLine(n % 2 == 0 ? "偶数です":"奇数です");
        }
    }
}
