using System;
using System.Collections.Generic;
using HomeWork01Pet.Classes;

        PetStore<Dog> dogStore = new PetStore<Dog>();
        dogStore.AddPet(new Dog { Name = "Max", Type = "Golden Retriever", Age = 2, FavoriteFood = "Steak" });
        dogStore.AddPet(new Dog { Name = "Buddy", Type = "German Shepherd", Age = 3, FavoriteFood = "Chicken" });

        dogStore.BuyPet("Max");

        dogStore.PrintPets();

        PetStore<Cat> catStore = new PetStore<Cat>();
        catStore.AddPet(new Cat { Name = "Smokey", Type = "Persian", Age = 1, Lazy = true, LivesLeft = 8 });
        catStore.AddPet(new Cat { Name = "Tiger", Type = "Siamese", Age = 2, Lazy = false, LivesLeft = 7 });

        catStore.BuyPet("Tiger");

        catStore.PrintPets();