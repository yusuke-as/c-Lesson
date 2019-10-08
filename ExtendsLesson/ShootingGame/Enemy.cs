using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame {
    abstract class Enemy {
        public int hp;
        public abstract void Move();
    }
}
