using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Zazu = new Bird("Zazu", 5, 2, true, false, "hornbill", true, "contour");
            Console.WriteLine($"{Zazu.Name} is a {Zazu.Type} bird who is {Zazu.Age} years old.\n" +
                $"He has {Zazu.Legs} legs and {Zazu.FeatherType} feathers. It is also {Zazu.HasBackbone} that \n" +
                $"he has a backbone, {Zazu.IsProtected} that he is protected, and {Zazu.IsDiurnal} that he is diurnal.\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Tortoise = new Reptile("Jeffrey", 126, 4, true, true, false, "dry", "shell");
            Console.WriteLine($"The incredible tortoise named {Tortoise.Name} \n" +
                $"has lived many lifetimes... {Tortoise.Age} in fact!\n" +
                $"At the pinnacle of the animal kingdom, {Tortoise.Name} has {Tortoise.Legs} powerful leges \n" +
                $"and a hard outer {Tortoise.Defense} for defense to survive in his \n" +
                $"{Tortoise.Environment} environment.\n" +
                $"It is {Tortoise.HasBackbone} that {Tortoise.Name} has a back bone, \n" +
                $"{Tortoise.IsColdBlooded} that he is cold blooded, and \n" +
                $"{Tortoise.HasScales} that he has scales.");
            

        }
    }
}
