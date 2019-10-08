using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp {
    class Program {
        static void Main(string[] args) {
            var list = new List<MemberPeyment>();
            string[] str;
            string path = @"./data.csv";
            FileInfo file = new FileInfo(path);
            if (file.Exists) {
                using (var reader = new StreamReader(path)) {
                    string line;
                    while ((line = reader.ReadLine()) != null) {
                        str = line.Split( ',');
                        MemberPeyment mp = new MemberPeyment(str[0], str[1],int.Parse( str[2]));                      
                        list.Add(mp);                       
                    }
                }
            }            
            foreach(var i in list) {
                Console.WriteLine(i.Name+i.Purpose+i.Payment);
            }
            var result = list.OrderByDescending(n=>n.Payment).ToList() ;
            foreach (var i in result) {
                Console.WriteLine(i.Name+i.Payment);
            }
            var result2 = list.OrderByDescending(n => n.Payment).ToList();
            foreach (var i in result2) {
                Console.WriteLine(i.Name + i.Payment);
            }
            Console.WriteLine(result);
            
        }
    }
}
