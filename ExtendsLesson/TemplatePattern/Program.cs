using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern {
    class Program {
        static void Main(string[] args) {
            var mc = new MyCharacter {
                Name = "ロト"
            };
            mc.Introduce();
        }
    }
    abstract class Character {
        public string Name { set; get; }
        public void Introduce() {
            Console.WriteLine($"はじめまして{Name}です。");
            DoIntroduce();
            Console.WriteLine("よろしくお願いいたします。");
        }
        public abstract void DoIntroduce();
    }
    class MyCharacter : Character {
        public override void DoIntroduce() {
            Console.WriteLine("特技は走ることです");
        }
    }
}
