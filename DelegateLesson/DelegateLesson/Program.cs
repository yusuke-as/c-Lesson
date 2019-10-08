using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson {
    class Program {
        //引数の型と戻り値を定義
        delegate void Decorate(string s);
        static void Main(string[] args) {
            //Star("hoge");
            string str = "hello";
            //引数の型と戻り値が同じメソッドを登録できる
            Decorate dec = Star;
            dec(str);
            Console.WriteLine();
            //decに違うメソッドを登録
            dec = Atsign;
            dec(str);
            Console.WriteLine();
            //decに追加,削除
            dec += Star;
            dec(str);
            Console.WriteLine();
            dec -= Atsign;
            dec(str);
            Console.WriteLine();

            dec = Console.WriteLine;
            dec(str);
        }
        static void Star(string s) {
            Console.WriteLine($"*{s}*");
        }
        static void Atsign(string s) {
            Console.WriteLine($"@{ s}@");
        }
    }
}
