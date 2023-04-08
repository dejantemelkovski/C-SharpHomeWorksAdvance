using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Pet.Classes
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog: {Name}, Type: {Type}, Age: {Age}, Favorite food: {FavoriteFood}");
        }
    }
}
