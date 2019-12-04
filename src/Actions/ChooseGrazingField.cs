using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal, bool clear = true)
        {
            bool allFull = farm.GrazingFields.All(field => field.GetCount == field.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();

            }
            while (!allFull)
            {

                Utils.Clear();

                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Grazing Field: Total: {farm.GrazingFields[i].GetCount} of {farm.GrazingFields[i].Capacity} (");
                    farm.GrazingFields[i].listAnimals();
                    Console.WriteLine(")");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.GrazingFields[choice - 1].GetCount < farm.GrazingFields[choice - 1].Capacity)
                    {
                        farm.GrazingFields[choice - 1].AddResource(animal);
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

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
            // Utils.Clear();

            // if (farm.GrazingFields.Count < 1)
            // {
            //     Console.WriteLine("Facility doesn't exist for selected animal.");
            //     Console.WriteLine("Press return key to go back to main menu.");
            //     Console.ReadLine();
            //     Utils.Clear();
            // }
            // else
            // {

            //     for (int i = 0; i < farm.GrazingFields.Count; i++)
            //     {
            //         Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].AnimalCount} {(farm.GrazingFields[i].AnimalCount == 1 ? "animal" : "animals")})");
            //     }

            //     Console.WriteLine();

            //     // How can I output the type of animal chosen here?
            //     Console.WriteLine($"Place the animal where?");

            //     Console.Write("> ");
            //     int choice = Int32.Parse(Console.ReadLine());
            //     choice = choice - 1;
            //     int currentListCount = farm.GrazingFields[choice].AnimalCount;
            //     int availableSpace = Convert.ToInt32(farm.GrazingFields[choice].Capacity) - currentListCount;
            //     int evaluatedAvailableSpace = Math.Sign(availableSpace);
            //     if (evaluatedAvailableSpace == 1)
            //     {
            //         farm.GrazingFields[choice].AddResource(animal);
            //     }
            //     else
            //     {
            //         // Console.Clear();
            //         Console.WriteLine("Facility is full. Please choose another facility.");
            //         Console.ReadLine();

            //         ChooseGrazingField.CollectInput(farm, animal, false);
            //     }

            //     // farm.GrazingFields[choice].AddResource(animal);

            //     /*
            //         Couldn't get this to work. Can you?
            //         Stretch goal. Only if the app is fully functional.
            //      */
            //     // farm.PurchaseResource<IGrazing>(animal, choice);
            // }
        }
    }
}