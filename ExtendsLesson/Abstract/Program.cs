using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    class Program {
        static void Main(string[] args) {
            Figure[] figures = new Figure[2];
            figures[0] = new Square("四角形", 5.0, 4.0);
            figures[1] = new Triangle("三角形", 4.0, 3.0);
            for(int i = 0; i < figures.Length; i++) {
                Console.WriteLine($"横:{figures[i].Width:f1},縦:{figures[i].Height:f1},図形:{figures[i].Name}の面積は{figures[i].GetArea():f1}");
            }

            /*
            var list = new List<Figure> {
                new Square("四角形",5.0,4.0),
                new Triangle("三角形",4.0,3.0)
            };
            list.ForEach(v=>Console.WriteLine($"横:{v.Width:f1},縦:{v.Height:f1},図形:{v.Name}の面積は{v.GetArea():f1}"));
            */
        }
    }
    abstract class Figure {
        public string Name { set; get; }
        public double Width { set; get; }
        public double Height { set; get; } 
        public Figure(string name,double width,double height) {
            Name = name;
            Width = width;
            Height = height;
        }
        public abstract double GetArea();
    }
    class Square : Figure {
        public Square(string name,double width,double height) : base(name, width, height) { }
        public override double GetArea() {
            return Width * Height;
        }
    }
    class Triangle : Figure {
        public Triangle(string name,double width,double height) : base(name, width, height) { }
        public override double GetArea() {
            return Width * Height / 2;
        }
    }
}
