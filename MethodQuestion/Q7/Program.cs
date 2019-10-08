using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7 {
    class Program {
        static void Main(string[] args) {
            for (int i = 10000; i <= 10100; i++) {
                if (IsPrime(i)) {
                    Console.WriteLine(i);
                }
            }
         }
        static bool IsPrime(int n) {
            bool ans = false;
            for(int i = 2; i < n; i++) {
                if (n % i == 0) {
                    ans = false;
                    break;
                } else {
                    ans = true;
                 }
            }
            return ans;
            /*
            if (n < 2) {
                return false;
            } else if (n == 2) {
                return true;
            }else if (n % 2 == 0) {
                return false;
            } else {
                bool isPrime = true;
                for(int i = 3; i < n; i += 2) {
                    if (n % i == 0) {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
          */
        }
    }
}
