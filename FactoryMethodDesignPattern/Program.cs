﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    /// <summary>

    /// MainApp startup class for Structural 

    /// Factory Method Design Pattern.

    /// </summary>
    class Program
    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // An array of creators

            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
