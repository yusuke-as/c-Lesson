﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame {
    class Star :Enemy{
        public override void Move() {
            Console.WriteLine("回転しながらに移動");
        }
    }
}
