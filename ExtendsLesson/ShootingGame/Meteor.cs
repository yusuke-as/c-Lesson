using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame {
    class Meteor:Enemy {
        public override void Move() {
            Console.WriteLine("まっすぐに移動");
        }
    }
}
