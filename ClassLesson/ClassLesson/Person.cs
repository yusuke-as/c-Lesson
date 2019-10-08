using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson {
    class Person {
        string name;
        int age;
        public Person(string name) {
            this.name = name;
        }
        public Person(string name,int age) :this(name){
            this.age = age;
        }
        public string Name {
            set {
                this.name = value;
            }
            get {
                return this.name;
            }
        }
        public int Age {
            private set {
                this.age = value;
            }
            get {
                return this.age;
            }
        }
        public void AgePlus() {
            this.Age++;
        }
        public void ShowInfo() {
            Console.WriteLine($"name:{this.Name},age:{this.Age}");
        }

    }
}
