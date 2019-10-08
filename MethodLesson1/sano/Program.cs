using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sano {
    class Program {
        static void Main(string[] args) {
            Console.Write("現在の体重を整数で入力>");
            int now = int.Parse(Console.ReadLine());
            Console.Write("目標の体重を整数で入力>");
            int goal = int.Parse(Console.ReadLine());
            Console.WriteLine(Judge(now, goal));
        }
        static string Judge(int a,int b) {
            string ans = "";
            if (a > b) {
                ans = $"あと{a - b}kg痩せましょう";
            }else if (a < b) {
                ans = $"あと{b -a }kg太りましょう";
            } else {
                ans = "ぴったりです";
            }
            return ans;
        }
    }
}
