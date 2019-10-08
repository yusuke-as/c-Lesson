using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefPractice {
    class Program {
        static void Main(string[] args) {
            Console.Write("整数を,区切りで入力してください>");
            /* string[] strArr = Console.ReadLine().Split(',');
             int[] data = new int[strArr.Length];
             for(int i = 0; i < strArr.Length; i++) {
                 data[i] = int.Parse(strArr[i]);
             }*/
            var data = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            getMinMax(data, out int minVal, out int maxVal);
            Console.WriteLine($"min:{minVal},max:{maxVal}");
        }
        static void getMinMax(int[] arr,out int min,out int max) {
            min = arr[0];
            max = arr[0];
            foreach(var a in arr) {
                if (a < min) {
                    min = a;
                }
                if (a > max) {
                    max = a;
                }
            }
        }
    }
}
