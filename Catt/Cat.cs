using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    internal class Cat
    {

        public string NickName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int Energy { get; set; }
        public int MealQuantity { get; set; }
        public double Price { get; set; }

        public void Eat()
        {
            if (MealQuantity == 100)
                Console.WriteLine("I am Full!");
            else
                MealQuantity += 10;
            Console.WriteLine("I am Hungry");
        }
        public void Sleep()
        {
            if (Energy == 100)
                Console.WriteLine("I dont want Sleep!");
            else
                Energy++;
            Console.WriteLine("I want Sleep");
        }
        public void Play()
        {
            if (Energy >= 10 && MealQuantity >= 10)
            {
                Console.WriteLine("I played");
                Energy -= 10;
                MealQuantity -= 10;
                return;
            }
            if (Energy == 0)
            {
                Console.WriteLine("I tired i go to sleep!");
                Sleep();
            }
            if (MealQuantity == 0)
            {
                Console.WriteLine("I tired i go to eat!");
                Eat();
            }
        }
    }

}
