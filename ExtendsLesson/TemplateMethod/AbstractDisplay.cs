using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    public abstract class AbstractDisplay {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();
        public void Display() {
            Open();
            for(int i = 0; i < 3; i++) {
                Print();
            }
            Close();
        }
    }
    public class CharDisplay : AbstractDisplay {
        char ch;
        public CharDisplay(char ch) {
            this.ch = ch;
        }       
        public override void Open() {
            Console.Write("***");
        }
        public override void Print() {
            Console.Write(ch);
        }
        public override void Close() {
            Console.WriteLine("***");
        }
    }
    public class StringDisPlay : AbstractDisplay {
        string str;
        int width;
        public StringDisPlay(string str) {
            this.str = str;
            this.width = str.Length;
        }
        public override void Open() {
            PrintLine();
        }
        public override void Print() {
            Console.WriteLine("|" + str+"|");
        }
        public override void Close() {
            PrintLine();
        }
        void PrintLine() {
            Console.Write("+");
            for(int i = 0; i < width; i++) {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
