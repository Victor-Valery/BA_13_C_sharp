using System;

namespace BA_13_C_sharp
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 300)
                {
                    Console.WriteLine($"YANLIS DEGER {value}");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public void P()
        {
            Console.WriteLine($"MARKA: {this.Brand}\nMODEL: {this.Model}\nHIZ: {this.speed}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Brand = "BMW";
            c1.Model = "520";
            c1.Speed = 305;
            c1.P();

            Console.WriteLine("********************************");

            Car c2 = new Car();
            c2.Brand = "AUDI";
            c2.Model = "S5";
            c2.Speed = 250;
            c2.P();

        }
    }
}
