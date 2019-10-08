using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureApp {
    class Program {
        static void Main(string[] args) {          
            Console.Write("ユーザーネーム：");
            string userName = Console.ReadLine();
            Adventure user = new Adventure(userName);
            Console.Write("ヒロインネーム：");
            string herName = Console.ReadLine();
            Adventure her = new Adventure(herName);
           
                while (true) {
                    if (her.RelGauge <= 0) {
                        Console.WriteLine("バッドエンド！！");
                        Console.Write("続けますか？（１…yes、２…no）：");
                        int ans = int.Parse(Console.ReadLine());
                        if (ans == 2) {
                            return;
                        }
                        if (ans == 1) {
                            her.RelGauge = 5;
                        }                        
                    }
                    if (her.RelGauge >= 10) {
                        Console.WriteLine($"{her.Name}ちゃんが嬉しそうに{user.Name}君を見つめている…");
                        Console.WriteLine("★トゥルーエンド★");
                        return;
                    }

                    Console.Write(herName + "ちゃんとデートの待ち合わせをします。どこにしますか？（１…自宅、2…公園、３…駅、4...映画館）:");
                    int select = int.Parse(Console.ReadLine());
                    switch (select) {
                        case 1:
                            her.AtHome(user);
                            break;
                        case 2:
                            her.AtPark();
                            break;
                        case 3:
                            her.AtStation();
                            break;
                        case 4:
                            her.AtSinema();
                            break;
                    }
                }
            
        }
    }
}
