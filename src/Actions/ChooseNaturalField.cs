using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed, bool clear = true)
        {
            bool allFull = farm.NaturalFields.All(field => field.SeedCount == field.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();

            }
            while (!allFull)
            {

                Utils.Clear();

                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Natural Field: Total: {farm.NaturalFields[i].SeedCount} of {farm.NaturalFields[i].Capacity} (");
                    farm.NaturalFields[i].listSeeds();
                    Console.WriteLine(")");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the seed where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.NaturalFields[choice - 1].SeedCount < farm.NaturalFields[choice - 1].Capacity)
                    {
                        farm.NaturalFields[choice - 1].AddResource(seed);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("This facility is full, please choose another one");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, please chose another.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}