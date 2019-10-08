using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp {
    class Human {
        public int StartWeight { get; }
        public int NowWeight { set; get; }
        public int GoalWeight { get; }
        public Human(int now,int goal) {
            StartWeight = now;
            NowWeight = now;
            GoalWeight = goal;
        }
        public void Run10() {
            Console.WriteLine("1kg減りました！この調子で頑張りましょう！");           
        }
        public void Run20() {
            Console.WriteLine("5kg減りました！この調子で頑張りましょう！");            
        }
        public void Run30() {
            Console.WriteLine("10kg減りました！この調子で頑張りましょう！");            
        }
        public void ShowStatus() {
            Console.WriteLine($"{StartWeight-NowWeight}kg痩せてます！残り{NowWeight-GoalWeight}kgです！頑張りましょう！");          
        }
        public bool Gudge() {
            if (NowWeight <= GoalWeight) {
                Console.WriteLine("目標達成です！Congratulation!");
                return true;
            }
            return false;
        }
    }
}
