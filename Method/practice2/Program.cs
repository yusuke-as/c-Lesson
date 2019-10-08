using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2 {
    class Program {
        static void Main(string[] args) {
            float ave = CalcAverage(1, 5, 7);
            Console.WriteLine(ave);
        }
        static float CalcAverage(int a,int b,int c) {
            return (a + b + c) / 3f;
        }

    }
}
