using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson {
    class Program {
        static void Main(string[] args) {
            Player player = new Player("たかし", 500);
            /*int newHp = player.GetHp() - 2000;
            player.SetHp(newHp);
            Console.WriteLine("HP:"+player.GetHp());
            */
            player.Hp-=2000;
            Console.WriteLine(player.Name+"HP:"+player.Hp);
            Person p1 = new Person("久保",18);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
            p1.AgePlus();
            Console.WriteLine(p1.Age);
            Tomato t1 = new Tomato();
            t1.Color = "赤";
            t1.Price = 120;
            t1.ShowInfo();
        }
    }
}
