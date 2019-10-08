using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice {
    class Program {
        delegate int MathFanc(int a, int b);
        static void Main(string[] args) {
            MathFanc mf = Plus;
            Console.WriteLine(mf(5, 2));
            Console.WriteLine(Calc(10, 2, Plus));
            Console.WriteLine(Calc(10, 2, delegate(int a,int b) { return a * b; }));
            Console.WriteLine(Calc(10, 2, (a, b) => a /b));
            Console.WriteLine(Calc(10, 2, (a, b) => a > b ? a : b));
        }
        static int Plus(int a,int b) {
            return a + b;
        }
        /*static int Calc(int a,int b,MathFanc mf) {
            return mf(a, b);
        }*/
        //func<>の最後が戻り値！
        static int Calc(int a,int b, Func<int, int, int> mf) {
            return mf(a, b);
        }
    }
}
