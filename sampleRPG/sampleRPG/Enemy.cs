using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleRPG {
    class Enemy {
        public int hp;

        public void Attack() {
            Console.WriteLine("敵の攻撃！");
        }
        public void Run() {
            Console.WriteLine("逃げられた！");
        }
    }
}
