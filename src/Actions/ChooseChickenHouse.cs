using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IPecking chicken, bool clear = true)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House ({farm.ChickenHouses[i].AnimalCount} {(farm.ChickenHouses[i].AnimalCount == 1 ? "chicken" : "chickens")})");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice = choice - 1;
            int currentListCount = farm.ChickenHouses[choice].AnimalCount;
            int availableSpace = Convert.ToInt32(farm.ChickenHouses[choice].Capacity) - currentListCount;
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            if (evaluatedAvailableSpace == 1)
            {
                farm.ChickenHouses[choice].AddResource(chicken);
            }
            else
            {
                // Console.Clear();
                Console.WriteLine("Facility is full. Please choose another facility.");
                Console.ReadLine();

                ChooseChickenHouse.CollectInput(farm, chicken, false);
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