using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing Field");
            Console.WriteLine("2. Plowed Field");
            Console.WriteLine("3. Natural Field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");
            Console.Write("> ");

            //this is where we are stating the selections and what/where they will be going to
            string input = Console.ReadLine();
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Grazing Field Created!!!!!");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();
                    break;

                case 2:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("Plowed field created.");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();
                    break;

                case 3:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("Natural field created.");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();
                    break;

                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("Chicken House(coop) built!!!");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();
                    break;

                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("Duck House built quack quack!!!");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();
                    break;

                default:
                    break;

            }
        }
    }
}