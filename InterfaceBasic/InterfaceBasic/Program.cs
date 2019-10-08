using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic {
    class Program {
        static void Main(string[] args) {
            var list = new List<IPlay>(){
                new MusicPlayer(),
                new VideoPlayer()
            };
            /*
            var list = new List<IPlay>();
            list.Add(new MusicPlayer());
            list.Add(new VideoPlayer());
            */
            list.ForEach((v)=>{ v.Play();v.Stop(); });
            /*
            foreach (var v in list) {
                v.Play();
                v.Stop();
            }
            */
        }
        interface IPlay {
            void Play();
            void Stop();
        }
        class MusicPlayer : IPlay {
            public void Play() {
                Console.WriteLine("音楽を再生します");
            }
            public void Stop() {
                Console.WriteLine("音楽を停止します");
            }
        }
        class VideoPlayer : IPlay {
                public void Play() {
                    Console.WriteLine("ビデオを再生します");
                }
                public void Stop() {
                    Console.WriteLine("ビデオを停止します");
                }
         }
   }
}
