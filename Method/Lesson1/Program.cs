using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ShowInfo());
            Console.WriteLine(ShowInfo("山田"));
            Console.WriteLine(ShowInfo("山田",22));
            //ラベルを使用し定義することもできる
            Console.WriteLine(ShowInfo(age: 30));
            Console.WriteLine(ShowInfo(age: 40, name: "田中"));

            Console.WriteLine(CalcAdd(2, 3, 5));
            Console.WriteLine(CalcAdd());
            Console.WriteLine(CalcAdd(2,3,4,5,6));

            //エラー→Console.WriteLine(CalcAdd2());
            Console.WriteLine(CalcAdd2(2, 3, 4, 5, 6));
        }
        //オーバーロードも初期値設定もできる
        static string ShowInfo(string name="ゴンベ",int age=20) {
            return $"{ name}({ age})";
        }
        static int CalcAdd(params int[] data) {
            int sum = 0;
            foreach(var n in data) {
                sum += n;
            }
            return sum;
        }
        static int CalcAdd2(int f,params int[] data) {
            int sum = f;
            foreach(var n in data) {
                sum +=n;
            }
            return sum;
        }
    }
}
