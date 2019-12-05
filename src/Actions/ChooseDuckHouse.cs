using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IQuacking duck, bool clear = true)
        {
            bool allFull = farm.DuckHouses.All(field => field.AnimalCount == field.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();
            }
            while (!allFull)
            {
                Utils.Clear();
                if (farm.DuckHouses.Count < 1)
                {
                    Console.WriteLine("Facility doesn't exist for selected animal.");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    Utils.Clear();
                }
                else
                {

                    for (int i = 0; i < farm.DuckHouses.Count; i++)
                    {
                        Console.Write($"{i + 1}. Duck House: Total: {farm.DuckHouses[i].AnimalCount} of {farm.DuckHouses[i].Capacity} (");
                        farm.DuckHouses[i].listDucks();
                        Console.WriteLine(")");
                    }

                    Console.WriteLine();

                    // How can I output the type of animal chosen here?
                    Console.WriteLine($"Place the animal where?");

                    Console.Write("> ");

                    try
                    {
                        int choice = Int32.Parse(Console.ReadLine());
                        if (farm.DuckHouses[choice - 1].AnimalCount < farm.DuckHouses[choice - 1].Capacity)
                        {
                            farm.DuckHouses[choice - 1].AddResource(duck);
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
}