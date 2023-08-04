﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public class Dog : IAnimal, IDog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }

        public void BurySomething()
        {
            Console.WriteLine($"{Breed} buries something");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Bark!");
        }

        public void Move()
        {
            Console.WriteLine("Walk on a leash");
        }
    }
}
