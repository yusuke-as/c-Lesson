using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInOutLesson {
    class Program {
        static void Main(string[] args) {
            string path = @"./data.log";
            using(var writer=new StreamWriter(path, true)) {
                writer.WriteLine(DateTime.Now.ToString());
            }
            FileInfo file = new FileInfo(path);
            if (file.Exists) {
                using(var reader=new StreamReader(path)) {
                    string line;
                    while ((line = reader.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
