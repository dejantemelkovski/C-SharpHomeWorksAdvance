using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Pet.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cat: {Name}, Type: {Type}, Age: {Age}, Lazy: {Lazy}, Lives left: {LivesLeft}");
        }
    }
}
