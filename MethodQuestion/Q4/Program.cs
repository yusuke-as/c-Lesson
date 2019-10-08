using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4 {
    class Program {
        static void Main(string[] args) {
            MakeTriangle(3);
            MakeTriangle(4);
            MakeTriangle(5);
        }
        static void MakeTriangle(int n) {
            for(int i = 1; i <= n; i++) {
                for(int j = 0; j < i; j++) {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
