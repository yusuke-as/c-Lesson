using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicPra2 {
    class Program {
        static void Main(string[] args) {
            var dic = new Dictionary<string, string>();
            dic.Add("赤", "red");
            dic.Add("緑", "green");
            dic.Add("青", "blue");
            while (true) {
                Console.Write("処理番号を入力してください。1.登録,2.検索,3.一覧,4.終了>");
                var select = Console.ReadLine();
                switch (select) {
                    case "1":
                        Console.Write("登録する色(日本語)を入力してください>");
                        var jap = Console.ReadLine();
                        Console.Write("登録する色(英語)を入力してください>");
                        var en = Console.ReadLine();
                        dic[jap] = en;
                        Console.WriteLine($"{jap}:{en}を登録しました");
                        break;
                    case "2":
                        Console.Write("検索する色(日本語)を入力してください>");
                        var input = Console.ReadLine();
                        if (dic.ContainsKey(input)) {
                            Console.WriteLine($"{input}:{dic[input]}");
                        } else {
                            Console.WriteLine("未登録です");
                        }
                        break;
                    case "3":
                        foreach(var color in dic) {
                            Console.WriteLine($"{color.Key}:{color.Value}");
                        }
                        break;
                    default:
                        Console.WriteLine("アプリケーションを終了します。 ");
                        return;
                }
            }
        }
    }
}
