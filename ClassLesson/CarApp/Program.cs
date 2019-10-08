using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {
    class Program {
        static void Main(string[] args) {
            Car car = new Car(30.0f, 8.4f, 60.0f);           
            while (true) {
                Console.Write("1. 走行 / 2. 給油 / 3. 残量表示 / 4. 終了 >");
                int select = int.Parse(Console.ReadLine());
                switch (select) {
                    case 1:
                        Console.Write("何キロ走行しますか >");
                        int i = int.Parse(Console.ReadLine());
                        car.Drive(i);
                        break;
                    case 2:
                        Console.Write("何リットル給油しますか >");
                        float f = float.Parse(Console.ReadLine());
                        car.AddFuel(f);
                        break;
                    case 3:
                        car.ShowFuel();
                        break;
                    default:
                        Console.WriteLine("アプリケーションを終了します。");
                        return;
                }
            }
        }
    }
}
