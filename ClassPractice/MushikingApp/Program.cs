using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushikingApp {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            string[] hand = { "グー", "チョキ", "パー" };
            int hp = 0, atk = 0;
            Console.WriteLine("あなたが使う甲虫を選んでね");
            Console.Write("1:小型甲虫(HP90,ATK50),2:中型甲虫(HP130,ATK40),3:大型甲虫(HP170,ATK30)＞");
            int userChoice=int.Parse(Console.ReadLine());
            if (userChoice == 1) {
                hp = 90;
                atk = 50;
            }else if (userChoice == 2) {
                hp = 130;
                atk = 40;
            } else {
                hp = 170;
                atk = 30;
            }
            Console.Write("名前をつけてね＞");
            string userName = Console.ReadLine();
            Console.Write("必殺技の手を選んでね(1:グー2:チョキ,3:パー)＞");
            int userSpATK = int.Parse(Console.ReadLine());
            Insects user = new Insects(userName, hp, atk, userSpATK);            
            Console.WriteLine($"{user.Name}(HP:{user.HP},ATK{user.ATK},必殺技:{user.Hands})が生まれました");

           Console.WriteLine("CPUが使う甲虫を選んでね");
            Console.Write("1:小型甲虫(HP90,ATK50),2:中型甲虫(HP130,ATK40),3:大型甲虫(HP170,ATK30)＞");
            int cpuChoice = int.Parse(Console.ReadLine());
            if (cpuChoice == 1) {
                hp = 90;
                atk = 50;
            } else if (cpuChoice == 2) {
                hp = 130;
                atk = 40;
            } else {
                hp = 170;
                atk = 30;
            }
            Console.Write("名前をつけてね＞");
            string cpuName = Console.ReadLine();
            Console.Write("必殺技の手を選んでね(1:グー2:チョキ,3:パー)＞");
            int cpuSpATK = int.Parse(Console.ReadLine());
            Insects cpu = new Insects(cpuName, hp, atk, cpuSpATK);            
            Console.WriteLine($"{cpu.Name}(HP:{cpu.HP},ATK{cpu.ATK},必殺技:{cpu.Hands})が生まれました");
            Console.WriteLine();
            Console.WriteLine("バトル開始！");
            while (true) {
                user.ShowStatus();
                cpu.ShowStatus();
                Console.Write("じゃんけんの手を選んでね(1:グー2:チョキ,3:パー)＞");
                int userSelect = int.Parse(Console.ReadLine());
                int cpuSelect = rand.Next(1, 4);
                Console.WriteLine("あなた:"+hand[userSelect-1]);
                Console.WriteLine("cpu:" + hand[cpuSelect - 1]);
                if ((userSelect - cpuSelect + 3) % 3 == 0) {
                    Console.WriteLine("あいこ");
                    user.Attack(cpu, 2);
                    cpu.Attack(user, 2);                
                }else if ((userSelect - cpuSelect + 3) % 3 == 1) {
                    Console.WriteLine("CPUの勝ち");
                    if (cpuSelect == cpu.SpecialATK) {
                        Console.WriteLine("やられた！相手の必殺技だ！");
                        cpu.Attack(user, 1);
                    } else {
                        cpu.Attack(user, 0);
                    }
                } else if ((userSelect - cpuSelect + 3) % 3 == 2) {
                    Console.WriteLine("あなたの勝ち");
                    if (userSelect == user.SpecialATK) {
                        Console.WriteLine("やったー必殺技だー！");
                        user.Attack(cpu, 1);
                    } else {
                        user.Attack(cpu, 0);
                    }
                }
                Console.WriteLine();
                if (user.HP <= 0) {
                    Console.WriteLine($"{user.Name}さんのHPが0になった");
                    Console.WriteLine("CPUの勝ち！");
                    return;
                }
                if (cpu.HP <= 0) {
                    Console.WriteLine($"{cpu.Name}さんのHPが0になった");
                    Console.WriteLine("あなたの勝ち！");
                    return;
                }
            }

        }
    }
}
