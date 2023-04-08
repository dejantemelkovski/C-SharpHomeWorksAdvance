using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Pet.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish: {Name}, Type: {Type}, Age: {Age}, Color: {Color}, Size: {Size}");
        }
    }
}
