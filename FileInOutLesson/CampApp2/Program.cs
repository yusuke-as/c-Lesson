using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp2 {
    class Program {
        static void Main(string[] args) {
            var personPay = new Dictionary<string, int>();
            var purposePay = new Dictionary<string, int>();
            string[] str;
            string path = @"./data.csv";
            FileInfo file = new FileInfo(path);
            Console.WriteLine("csvデータ");
            Console.WriteLine("-----");
            if (file.Exists) {
                using (var reader = new StreamReader(path)) {
                    string line;
                    while ((line = reader.ReadLine()) != null) {
                        Console.WriteLine(line);
                        str = line.Split(',');
                        if (personPay.ContainsKey(str[0])) {
                            personPay[str[0]]=personPay[str[0]]+ int.Parse(str[2]);
                        } else {
                            personPay.Add(str[0], int.Parse(str[2]));
                        }
                        if (purposePay.ContainsKey(str[1])) {
                            purposePay[str[1]] = purposePay[str[1]] + int.Parse(str[2]);
                        } else {
                            purposePay.Add(str[1], int.Parse(str[2]));
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("キャンプ会計");
            Console.WriteLine("-----");
            var array = purposePay.OrderByDescending(n => n.Value).ToArray();
            foreach(var p in array) {
                Console.WriteLine($"{ p.Key}:{p.Value}");
            }
            Console.WriteLine("-----");
            int sum = purposePay.Values.Sum();
            int ave = sum / personPay.Count();
            Console.WriteLine($"合計:{sum}円");
            Console.WriteLine();

            Console.WriteLine($"個人別会計(一人当たり:{ave}円)");
            Console.WriteLine("-----");
            var array2 = personPay.OrderByDescending(n => n.Value).ToArray();
            foreach (var p in array2) {
                Console.WriteLine($"{ p.Key}:{((p.Value-ave > 0) ? "+"+(p.Value - ave):""+(p.Value - ave))}円");
            }
        }
    }
}
