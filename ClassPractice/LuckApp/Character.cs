using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckApp {
    class Character {
        public int Luck { set; get; }
        public Character(int n) {
            Luck = n;
        }
    }
}
