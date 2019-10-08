using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example{
    class Program{
        static void Main(string[] args){
            var data = Console.ReadLine().Split(',');
            var d1 = int.Parse(data[0]);
            var d2 = int.Parse(data[1]);
            Console.WriteLine((d1 + d2) % 2 == 0 ? "NG" : "OK");

            var data2 = Console.ReadLine().Split(',');
            bool hasEven = false;
            bool hasOdd = false;
            foreach(var n in data) {
                if (int.Parse(n) % 2 == 0) {
                    hasEven = true;
                } else {
                    hasOdd = true;
                }
                if (hasEven && hasOdd) {
                    break;
                }
            }
            Console.WriteLine((hasEven&&hasOdd)? "OK":"NG");

            var data3 = Console.ReadLine();
            if(data3.Contains(',')&& data3.Contains('.')) {
                var cCount = data3.Split(',').Length;
                var pCount = data3.Split('.').Length;
                if (cCount >= pCount) {
                    data3 = data3.Replace('.', ',');
                } else {
                    data3 = data3.Replace(',', '.');
                }

            }


                /*string line = Console.ReadLine();
            string[] nums = line.Split(',');
            if(int.Parse(nums[0])%2==0 && int.Parse(nums[1])%2!=0 || int.Parse(nums[0])%2!=0 && int.Parse(nums[1]) % 2 == 0){
                Console.WriteLine("OK");
            }else{
                Console.WriteLine("NG");
            }*/

        }
    }
}
