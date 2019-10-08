using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpApp {
    class Trump {
        public List<int> deck = new List<int>();
        public Trump() {
            MakeDeck();
        }

        public void MakeDeck() {
            for(int i = 0; i < 4; i++) {
                for(int j = 1; j <= 13; j++) {
                    deck.Add( i*100 + j);
                }
            }
            deck.Add(99);
            deck.Add(999);
        }
    }
}
