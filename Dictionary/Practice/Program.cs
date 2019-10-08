using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice {
    class Program {
        static void Main(string[] args) {
            var dict = new Dictionary<string, string>() {
                {"山田","000-123-4563" },
                {"小山田","000-123-2222" },
                {"山本","000-111-2222" }
            };
            Console.WriteLine(dict["山田"]);
        }
    }
}
