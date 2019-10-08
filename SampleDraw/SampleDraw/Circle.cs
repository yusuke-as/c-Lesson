using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw {
    class Circle:Figure {
        string fillColor;
        public Circle(int sx,int sy,int ex,int ey,string color):base(sx,sy,ex,ey) {            
            this.fillColor = color;
        }
        public override void Draw() {
            int centerX = (this.startPosX + this.endPosX) / 2;
            int centerY = (this.startPosY + this.endPosY) / 2;
            int radius = Math.Abs(this.startPosX - this.endPosY) / 2;
            Console.WriteLine($"({centerX},{centerY})を中心にして半径{radius},{this.fillColor}色の円を描く");
        }
    }
}
