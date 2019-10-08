using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matsuda {
    class Program {
        static void Main(string[] args) {
            Console.Write("身長は(cm)?>");
            int cm = int.Parse(Console.ReadLine());
            Console.Write("体重は(kg)?>");
            int kg = int.Parse(Console.ReadLine());

            CalcBMI(cm, kg, out float BMI, out string ans);
            Console.WriteLine($"身長:{cm}cm,体重:{kg}kgのあなたのBMIは{BMI:F2}です。\n{ans}です。");

        }
        static void CalcBMI(int cm,int kg,out float BMI,out string ans) {
            float m = cm /100f;
            BMI = kg / (m * m);
            if (BMI >= 25) {
                ans = "肥満";
            }else if(BMI < 18.5){
                ans = "やせ型";
            }else{
                ans = "標準体重";
            }
        }
    }
}
