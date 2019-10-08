using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson2 {
    class Program {
        delegate void Decorate(string s);
        static void Main(string[] args) {
            string str = "hello";
            StrDecorate(str, Star);
            StrDecorate(str, delegate (string s) {
                Console.WriteLine($"@{s}@");
            });
            StrDecorate(str, (string s) => { Console.WriteLine($"@{s}@"); });
            StrDecorate(str,s=> Console.WriteLine($"@{s}@"));
            StrDecorate(str, s => Console.WriteLine($"「{s}」"));
        }
        static void Star(string s) {
            Console.WriteLine($"*{s}*");
        }
        static void StrDecorate(string str,Decorate dec) {
            dec(str);
        }
    }
}
