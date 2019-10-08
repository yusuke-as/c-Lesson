using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecolateLesson3 {
    class Program {
        delegate void Button();
        static void Main(string[] args) {
            onclick(() => Console.WriteLine("開始しました"));
        }
        static void onclick(Button btn) {
            btn();
        }
    }
}
