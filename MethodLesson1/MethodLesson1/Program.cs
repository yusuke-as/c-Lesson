using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashikari{
    class Program {
        static void Main(string[] args) {
            string[] names = Console.ReadLine().Split(' ');
            ACount(names, out string min, out string max);
            Console.WriteLine($"max={max },min={min}");
            Console.WriteLine(String.Join(",",names.Where(s => s.Contains("i")).Select(s=>s.Replace('i', 'a')).ToArray()));
        }
        static void ACount(string[] names,out string min,out string max) {
            //var sorted=data.OrderBy(n=>n.Length);
            max = names[0];
            min = names[0];
            foreach(var name in names) {
                if (max.Length < name.Length) {
                    max = name;
                }
                if (min.Length > name.Length) {
                    min = name;
                }
            }
        }        
    }
}
