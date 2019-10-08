using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, float> weights = new Dictionary<string, float>();
            weights.Add("2016/12/10",41.2f);
            weights.Add("2016/12/11", 41.6f);
            weights.Add("2016/12/12", 41.0f);
            weights.Add("2016/12/13", 41.1f);
            weights.Add("2016/12/14", 41.9f);
            weights.Add("2016/12/15", 41.7f);
            weights.Add("2016/12/16", 40.8f);
            /*
             * var weights=new Dictionary<string,float>(){
             * {"2016/12/10",41.2f},
             * ...
             * }
             * var list=new List<int>(){2,3,4};
             * int[] arr=new int[]{2,3,4};
             */
            Console.WriteLine(weights["2016/12/15"]);
        }
    }
}
