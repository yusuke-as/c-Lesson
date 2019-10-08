using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureApp {
    class Adventure {
        public string Name {  get; }
        public int RelGauge { set; get; }
        public Adventure(string name) {
            this.Name = name;
            RelGauge = 5;
        }
        public void AtHome(Adventure a) {
            Console.Write($"自宅に隠し持っていた{a.Name}君の秘密がバレてしまった！（親密度-2)");
            RelGauge -= 2;
            Console.WriteLine($"現在:{RelGauge}");
        }
        public void AtPark() {
            Console.WriteLine($"その公園は蚊が多く{Name}ちゃんが嫌がってしまった！");
            RelGauge -= 3;
            Console.WriteLine($"現在:{RelGauge}");
        }
        public void AtStation() {
            Console.WriteLine($"思ったより早く着いたようだ、{Name}ちゃんも嬉しそうだ！(好感度+2)");
            RelGauge += 2;
            Console.WriteLine($"現在:{RelGauge}");
        }
        public void AtSinema() {
            Console.WriteLine($"丁度{Name}ちゃんの好きな映画が上映されていた、とても満足のようだ！(親密度+3)");
            RelGauge += 3;
            Console.WriteLine($"現在:{RelGauge}");
        }

    }
}
