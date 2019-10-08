using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Fibo(50));
        }
        static int Fibo(int n) {
            if (n == 0) {
                return 0;
            }
            if(n == 1){
                return 1;
            } else { 
                return Fibo(n-2)+Fibo(n-1);
            }
        }
        /*
        static int Calc(int before, int after,int count) {
            int next = 0;
            if(count < 20){
                next = before+after;
                count++;
                Calc(after,next,count);
            }
            return next;
        }
        */
    }
}
