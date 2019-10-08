using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLesson {
    class Program {
        static void Main(string[] args) {
            int x = 10;
            Fuga(x);
            Console.WriteLine("main:x=" + x);
            FugaRef(ref x);
            Console.WriteLine("main:x=" + x);
            Console.WriteLine();

           int[] arr = {2,4,6};
            /*Piyo(arr);
            Console.WriteLine("main:arr[0]=" + arr[0]);
            */
            Hoge(arr);
            Console.WriteLine("main:arr[0]=" + arr[0]);
            HogeRef(ref arr);
            Console.WriteLine("main:arr[0]=" + arr[0]);
            Console.WriteLine();

            int[] arr2;
            //×HogeRef(ref arr2);
            HogeOut(out arr2);
            Console.WriteLine("main:arr2[0]=" + arr2[0]);

            HogeOut(out int[] arr3);
            Console.WriteLine("main:arr3[0]=" + arr3[0]);

        }
        static void Fuga(int num) {
            num *= 2;
            Console.WriteLine("inFuga:num=" + num);
        }
        static void FugaRef(ref int num) {
            num *= 2;
            Console.WriteLine("inFugaRef:num=" + num);
        }
        static void Piyo(int[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                arr[i] *= arr[i];
            }
            Console.WriteLine("inPiyo:arr[0]=" + arr[0]);
        }
        static void Hoge(int[] arr) {
            arr = new int[] { 3, 4, 5 };
            Console.WriteLine("inHoge:arr[0]="+arr[0]);
        }
        static void HogeRef(ref int[] arr) {
            arr = new int[] { 3, 4, 5 };
            Console.WriteLine("inHogeRef:arr[0]=" + arr[0]);
        }
        static void HogeOut(out int[] arr) {
            arr = new int[] { 5, 6, 7 };
            Console.WriteLine("HogeOut:arr2[0]=" + arr[0]);
        }
    }
}
