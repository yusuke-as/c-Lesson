using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class Program {
        static void Main(string[] args) {
            AbstractDisplay cd = new CharDisplay('T');
            AbstractDisplay sd = new StringDisPlay("Design Pattern");
            AbstractDisplay sd2 = new StringDisPlay("Template Method");
            cd.Display();
            sd.Display();
            sd2.Display();
        }

    }
}
