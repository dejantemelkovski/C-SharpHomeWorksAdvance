using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Pet.Classes
{
    public class PetStore<T> where T : Pet
    {
        private List<T> pets = new List<T>();

        public void AddPet(T pet)
        {
            pets.Add(pet);
        }

        public void PrintPets()
        {
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            bool found = false;

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Name == name)
                {
                    pets.RemoveAt(i);
                    found = true;
                    Console.WriteLine($"Successfully bought {name}");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Could not find pet named {name}");
            }
        }
    }

}
