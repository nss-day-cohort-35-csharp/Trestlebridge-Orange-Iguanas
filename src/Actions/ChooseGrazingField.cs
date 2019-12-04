using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal, bool clear = true)
        {
            Utils.Clear();

            if (farm.GrazingFields.Count < 1)
            {
                Console.WriteLine("Facility doesn't exist for selected animal.");
                Console.WriteLine("Press return key to go back to main menu.");
                Console.ReadLine();
                Utils.Clear();
            }
            else
            {

                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].AnimalCount} {(farm.GrazingFields[i].AnimalCount == 1 ? "animal" : "animals")})");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                choice = choice - 1;
                int currentListCount = farm.GrazingFields[choice].AnimalCount;
                int availableSpace = Convert.ToInt32(farm.GrazingFields[choice].Capacity) - currentListCount;
                int evaluatedAvailableSpace = Math.Sign(availableSpace);
                if (evaluatedAvailableSpace == 1)
                {
                    farm.GrazingFields[choice].AddResource(animal);
                }
                else
                {
                    // Console.Clear();
                    Console.WriteLine("Facility is full. Please choose another facility.");
                    Console.ReadLine();

                    ChooseGrazingField.CollectInput(farm, animal, false);
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
}