using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("整数を1つ入力してください>");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("整数を1つ入力してください>");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{input1}と{input2}の平均は{CalcAve(input1,input2)}です");
        }
        static int CalcAve(int a,int b) {
            return (a+b)/2;
        }
    }
}
