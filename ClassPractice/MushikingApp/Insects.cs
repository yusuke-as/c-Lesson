using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushikingApp {
    class Insects {
        public string Name { get; }
        public int HP { set; get; }
        public int ATK { set; get; }
        public int SpecialATK { set; get; }
        public string Hands { set; get; }
        public Insects(string name, int hp,int atk,int spAtk) {
            Name=name;
            HP =hp;
            ATK =atk;
            SpecialATK = spAtk;
            NumberToHands();
        }

        public void NumberToHands() {
            if (SpecialATK == 1) {
                Hands = "グー";
            }else if (SpecialATK == 2) {
                Hands = "チョキ";
            } else {
                Hands = "パー";
            }
        }
        public void ShowStatus() {
            Console.WriteLine($"{Name} HP:{HP}");
        }
        public void Attack(Insects i,int n) {
            int ATKPower = this.ATK;
            if(n == 1){
                ATKPower *= 2;
            }else if (n == 2) {
                ATKPower/= 2;
            }            
            i.HP -= ATKPower;
            Console.WriteLine($"{this.Name}は{i.Name}に{ATKPower}のダメージを与えた");
        }
    }
}
