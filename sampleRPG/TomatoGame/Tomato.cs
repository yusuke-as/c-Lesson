using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoGame {
    class Tomato {
        public int price;
        public string color;
        public Tomato(string color,int price) {
            this.color = color;
            this.price = price;
        }
        public void ShowStatus() {
            Console.WriteLine(this.color + ":" + this.price);
        }
    }
}
