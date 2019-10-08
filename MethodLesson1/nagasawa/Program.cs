using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagasawa {
    class Program {
        static void Main(string[] args) {
            Console.Write("今年は?>");
            int now = int.Parse(Console.ReadLine());
            Console.Write("生まれた年は?>");
            int birth = int.Parse(Console.ReadLine());
            int age = CalcAge(now, birth);
            Console.WriteLine("あなたの年齢は" + age + "歳です");
        }
        static int CalcAge(int now,int birth) {
            return now - birth;
        }
    }
}
