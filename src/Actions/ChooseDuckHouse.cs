using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IQuacking duck, bool clear = true)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House ({farm.DuckHouses[i].AnimalCount} {(farm.DuckHouses[i].AnimalCount == 1 ? "duck" : "ducks")})");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice = choice - 1;
            int currentListCount = farm.DuckHouses[choice].AnimalCount;
            int availableSpace = Convert.ToInt32(farm.DuckHouses[choice].Capacity) - currentListCount;
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            if (evaluatedAvailableSpace == 1)
            {
                farm.DuckHouses[choice].AddResource(duck);
            }
            else
            {
                // Console.Clear();
                Console.WriteLine("Facility is full. Please choose another facility.");
                Console.ReadLine();

                ChooseDuckHouse.CollectInput(farm, duck, false);
            }


            // farm.GrazingFields[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}