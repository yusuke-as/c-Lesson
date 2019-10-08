using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw {
    class Program {
        static void Main(string[] args) {
            Circle c1 = new Circle(100, 200, 300, 400, "赤");
            Ractangle r1 = new Ractangle(100, 200, 300, 400, "青");
            Line l1 = new Line(10, 20, 30, 40, "黒", 5);
            var figures = new List<Figure>() {
                c1,r1,l1
            };
            foreach(var f in figures) {
                f.Draw();
            }

        }
    }
}
