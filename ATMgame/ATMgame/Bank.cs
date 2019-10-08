using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMgame {
    class Bank {
        public string Name { get; }
        public int Dept { set; get; }
        int StartDept { set; get; }
        public bool isFinish{set;get;}
        public Bank(string name,int dept) {
            Name = name;
            Dept =StartDept= dept;
            isFinish = false;
        }
        public void ShowInfo() {
            Console.WriteLine($"{Name}:{Dept}万円");
        }
        public void GetMoney(int money) {
            Console.WriteLine($"{Name}へ{money}万円返済しました。");
            Dept -= money;
            if (Dept <= 0) {
                isFinish = true;
                Console.WriteLine($"{Name}への借金返済が完了した！！");
            }
        }
        public void Init() {
            Dept = StartDept;
            isFinish = false;
        }
    }
}
