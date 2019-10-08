using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleRPG {
    class Player {
        public string name;
        public int hp;

        public Player(string name,int hp) {
            this.name = name;
            this.hp = hp;
        }
   
        public void Attack() {
            Console.WriteLine(this.name + "は攻撃した");
        }
        public void Defense() {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
