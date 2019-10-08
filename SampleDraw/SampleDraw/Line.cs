using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw {
    class Line:Figure {
        string penColor;
        int penSize;
        public Line(int sx, int sy, int ex, int ey, string color,int size) : base(sx, sy, ex, ey) {
            this.penColor = color;
            this.penSize = size;
        }
        public override void Draw() {
            Console.WriteLine($"({this.startPosX},{this.startPosY})から({this.endPosX},{this.endPosY}(に太さ{this.penSize}で{this.penColor}色の直線を引く");
        }
    }
}
