using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimura {
    class Program {
        static void Main(string[] args) {
            Console.Write("記号を入力してください>");
            char c = char.Parse(Console.ReadLine());
            Console.Write("数字を入力してください>");
            int n = int.Parse(Console.ReadLine());
            ans(c, n);
        }
        static void ans(char c,int n) {
            for(int i = 0; i < n; i++) {
                Console.WriteLine(c);
            }
        }
    }
}
