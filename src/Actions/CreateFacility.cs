using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");
            Console.Write("> ");

            string input = Console.ReadLine();
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Grazing Field Created!!!!!");
                    Console.WriteLine("Press Return to go back to the Main Menu");
                    Console.ReadLine();

                    break;
                default:
                    break;

            }
        }
    }
}