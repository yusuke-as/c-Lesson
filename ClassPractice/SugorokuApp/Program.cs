using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugoroluApp {
    class Program {
        static void Main(string[] args) {
            Console.Write("いくつのサイコロで遊びますか？>");
            int playNumber = int.Parse(Console.ReadLine());            
            Console.Write("ゴールまでの距離は何マスにしますか？>");
            int startPosition = int.Parse(Console.ReadLine());
            Console.Write("何ターン以内の勝負にしますか？>");
            int maxTurn = int.Parse(Console.ReadLine());
            //diceの生成
            Dice[] dices = new Dice[playNumber];
            for (int i = 0; i < dices.Length; i++) {
                dices[i] = new Dice("dice" + (i + 1), startPosition);
            }
            int diceNumber;//出たサイコロの目を保持する
            int turnCount = 1;//現在のターン数をカウント
            bool isFinish = false;//メイン処理終了判定用
            Random rand = new Random();
            Console.WriteLine();
            //メイン処理
            while (turnCount <= maxTurn) {
                Console.WriteLine($"-------ターン{turnCount}-------");
                //diceの数分for文を回し、どれかのdiceのpositionが0になったらfor文終了
                for(int i = 0; i < dices.Length; i++) {
                    diceNumber = rand.Next(1, 7);
                    dices[i].DoTurn(diceNumber);
                    if (dices[i].Position == 0) {
                        isFinish = true;
                        break;
                    }
                }
                //isFinishがtrueのとき、メイン処理を終了
                if (isFinish) {
                    break;
                }               
                turnCount++;
            }
            //勝敗判定
            Console.WriteLine("★結果★");
            for (int i = 0; i < dices.Length; i++) {
                if (dices[i].Position == 0) {
                    Console.WriteLine($"{dices[i].Name} WIN!");
                    return;
                }
            }         
            Console.WriteLine("DRAW!!!");
        }
    }
}
