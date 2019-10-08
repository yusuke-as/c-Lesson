using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq {
    class Program {
        static void Main(string[] args) {
            int[] hp = { 420, 120, 600, 0, 1200 };
            //引数にmethodを登録できるようにした→さらにラムダ式で短くした！
            var newHp = hp.Where(n => n >= 500);
            foreach(int h in newHp) {
                Console.WriteLine(h);
            }

            var minusHp = hp.Select(n => n - 100);
            foreach(int n in minusHp) {
                Console.WriteLine(n);
            }

            int count = hp.Where(n => n <= 0).Count();
            Console.WriteLine(count);

            int ans = hp.Select(n => n - 500).Where(n => n > 0).Count();
            Console.WriteLine(ans);

            var list = hp.Select(n => n - 500).Where(n => n > 0).ToList();
            Console.WriteLine(list);
        }
    }
}
