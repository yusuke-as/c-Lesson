using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson {
    class Tomato {
        public string Color { get; set; }
        public int Price{get;set;}
        public void ShowInfo() {
            Console.WriteLine($"color:{this.Color},price:{this.Price}");
        }
    }
}
