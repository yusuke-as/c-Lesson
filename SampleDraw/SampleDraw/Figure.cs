using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw {
    abstract class Figure {
        protected int startPosX, startPosY, endPosX, endPosY;
        public Figure(int sx, int sy, int ex, int ey) {
            this.startPosX = sx;
            this.startPosY = sy;
            this.endPosX = ex;
            this.endPosY = ey;           
        }
        public abstract void Draw();
    }
}
