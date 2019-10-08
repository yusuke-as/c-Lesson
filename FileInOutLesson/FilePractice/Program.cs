using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePractice {
    class Program {
        static void Main(string[] args) {
            string path = @"./log.txt";
            while (true) {
                Console.Write("操作を入力してください1…体重を入力、2…一覧を見る、3…終了>");
                var select = Console.ReadLine();
                switch (select) {
                    case "1":
                        Console.Write("体重を入力してください>");
                        var weight = double.Parse(Console.ReadLine());
                        using(var writer=new StreamWriter(path, true)) {
                            writer.WriteLine($"{DateTime.Now} {weight}kg");
                        }
                        break;
                    case "2":
                        FileInfo file = new FileInfo(path);
                        if (file.Exists) {
                            using(var reader=new StreamReader(path)) {
                                string line;
                                while ((line = reader.ReadLine()) != null) {
                                    Console.WriteLine(line);
                                }
                            }
                        } else {
                            Console.WriteLine("まだデータがないよ");
                        }
                        break;
                    default:
                        Console.WriteLine("アプリケーションを終了します。");
                        return;
                }
            }
        }
    }
}
