using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp {
    class MemberPeyment {
        public string Name { set; get; }
        public string Purpose { set; get; }
        public int Payment { set; get; }
        public MemberPeyment(string name,string purpose,int payment) {
            Name = name;
            Purpose = purpose;
            Payment = payment;
        }
    }
}
