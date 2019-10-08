using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicPractice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("データを入力(Qで終了)");
            var dic = new Dictionary<string, int>();
            while (true) {
                var data = Console.ReadLine().Split(',');
                if (data[0].ToUpper() == "Q") {
                    break;
                }
                if (dic.ContainsKey(data[0])) {
                    dic[data[0]] = dic[data[0]] + int.Parse(data[1]);
                } else {
                    dic[data[0]] = int.Parse(data[1]);
                }
            }
            foreach(var kv in dic) {
                Console.WriteLine($"{kv.Key}:{kv.Value}");
            }
        }
    }
}
