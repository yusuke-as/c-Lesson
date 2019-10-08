using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson {
    class Player {
        private string name;
        private int hp;
        public Player(string name,int hp) {
            this.name = name;
            this.hp = hp;
        }
        public int Hp {
            set {
                this.hp = value;
                if (this.hp < 0) {
                    this.hp = 0;
                }
            }
            get {
                return this.hp;
            }
        }
        public string Name {
            set {
                if (value.Length <= 8){
                    this.name = value;
                }
            }
            get {
                return this.name;
            }
        }
        /*
        public void SetHp(int hp) {
            this.hp = hp;
            if (this.hp < 0) {
                this.hp = 0;
            }
        }
        public int GetHp() {
            return this.hp;
        }
        public void SetName(string name) {
            if (name.Length <= 8) {
                this.name = name;
            }
        }
        public string GetName() {
            return this.name;
        }
        */
        public void attack() {
            Console.WriteLine(this.name + "は攻撃した");
        }
        public void Deffence() {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
