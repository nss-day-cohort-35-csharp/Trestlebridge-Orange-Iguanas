using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflowers");
            Console.WriteLine("3. Wildflowers");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            //depending on the input selected, we determine where the selection goes in the appropiate field. If one doesn't exist it will state that.
            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;

                case 2:
                    ChoosePlowedField.CollectInput(farm, new Sunflowers());
                    break;

                case 3:
                    ChooseNaturalField.CollectInput(farm, new Wildflowers());
                    break;
                default:
                    break;
            }
        }
    }
}