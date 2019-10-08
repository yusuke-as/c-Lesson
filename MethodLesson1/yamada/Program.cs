using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yamada {
    class Program {
        static void Main(string[] args) {
            Console.Write(",区切りで数値を入力してください>");
            int[] arr1 =Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write(",区切りで数値を入力してください>");
            int[] arr2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine(Judge(arr1, arr2));
        }
        static int Judge(int[] arr1,int[] arr2) {
            int sum1 = 0;
            int sum2 = 0;
            foreach(var n in arr1) {
                sum1 += n;
            }
            foreach (var n in arr2) {
                sum2 += n;
            }
            return sum1>sum2 ? sum1:sum2;
        }
    }
}
