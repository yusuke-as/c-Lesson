using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoGame {
    class Program {
        static void Main(string[] args) {
            Tomato t1 = new Tomato("赤", 120);
            Tomato t2 = new Tomato("緑", 140);
            t1.ShowStatus();
            t2.ShowStatus();
        }
    }
}
