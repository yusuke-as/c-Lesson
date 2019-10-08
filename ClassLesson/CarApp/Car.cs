using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {
    class Car {
        float fuel;
        float fuelEfficient;
        float maxFuel;
        public Car(float a,float b,float c) {
            this.fuel = a;
            this.fuelEfficient = b;
            this.maxFuel = c;
        }
        public float Fuel {
            set {
                if (value > 0) { 
                this.fuel = value;
                }
            }
            get {
                return this.fuel;
            }
        }
        public float FuelEfficient {
            set {
                this.fuelEfficient = value;
            }
            get {
                return this.fuelEfficient;
            }
        }
        public void ShowFuel() {
            Console.WriteLine($"現在の燃料は{this.Fuel}リットルです。");
        }
        public void Drive(int n) {
            float f = n / FuelEfficient;
            if (f > this.Fuel) {
                Console.WriteLine("そんなに走れません！");
            } else {
                Console.WriteLine(n+"キロ走行します");
                this.Fuel -= f;
            }
        }
        public void AddFuel(float f) {
            if (f + this.Fuel > maxFuel) {
                f = maxFuel - this.Fuel;
            }
            Console.WriteLine(f + "リットル給油します");
            this.Fuel += f;
            ShowFuel();
        }
    }
}
