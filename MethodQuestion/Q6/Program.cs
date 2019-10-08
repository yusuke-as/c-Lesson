using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6 {
    class Program {
        static void Main(string[] args) {
            ninenine(1);
            ninenine(2);
            ninenine(3);
            ninenine(4);
            ninenine(5);
            ninenine(6);
            ninenine(7);
            ninenine(8);
            ninenine(9);
        }
        static void ninenine(int n) {
            for(int i = 1; i <= 9; i++) {
                Console.Write(i * n + " ");
            }
            Console.WriteLine();
        }
    }
}
