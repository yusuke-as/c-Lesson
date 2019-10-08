using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson2 {
    class Program {
        static void Main(string[] args) {
            JMonth jMonth = new JMonth();
            Console.WriteLine(jMonth[6]);
            Console.WriteLine(jMonth["神無月"]);
        }
    }
    class JMonth {
        private string[] months = { "睦月", "如月", "弥生", "卯月", "皐月", "水無月", "文月", "葉月", "長月", "神無月", "霜月", "師走" };
        public string this[int index] {
            get {
                return months[index - 1];
            }
        }
        public int this[string name] {
            get {
                return Array.IndexOf(months, name) + 1;
            }
        }
    }
}
