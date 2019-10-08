using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyApp {
    class Monkey {
        public string Name { set; get; }
        public int Age { set; get; }
        public void Aisatsu() {
            Console.WriteLine($"こんにちは{this.Name}({this.Age}才)です。よろしく！");
        }
        public void Takeuma() {
            Console.WriteLine($"{this.Name}は上手に竹馬に乗った！");
        }
        public void Sakadachi() {
            Console.WriteLine($"{this.Name}はひょいと逆立ちをした！");
        }
    }
}
