using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5 {
    class Program {
        static void Main(string[] args) {
            MakeTriangle(3, 'a');
            MakeTriangle(5, '★');
            MakeTriangle(2, '@');
        }
        static void MakeTriangle(int n, char c) {
            for (int i = 1; i <= n; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
     }
}
