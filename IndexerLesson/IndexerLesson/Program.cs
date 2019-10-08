using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson {
    class Program {
        static void Main(string[] args) {
            string str = "hello";
            for (int i = 0; i < str.Length; i++) {
                Console.WriteLine(str[i]);
            }
            Colors colors = new Colors();
            for(int i = 0; i < 3; i++) {
                Console.WriteLine(colors[i]);
            }
            colors[0] = "黒";
            Console.WriteLine(colors[0]);
        }
        class Colors {
            private string[] data = { "赤", "青", "黄" };
            public string this[int index] {
                set {
                    this.data[index] = value;
                }
                get {
                    return data[index];
                }
            }
        }
    }
}
