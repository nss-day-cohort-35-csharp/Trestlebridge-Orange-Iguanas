using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        //anything that is in the parentheses we're collecting the input from the Farm, IPecking, and we're setting a conditional in the boolean (for fullness)
        public static void CollectInput(Farm farm, IPecking chicken, bool clear = true)
        {
            //this will check if the ChickenHouse is created or not, if not then it displays the WriteLine.
            bool allFull = farm.ChickenHouses.All(field => field.GetCount == field.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();

            }
            //when it's not full (by using the !)
            while (!allFull)
            {
                //we use this for going back to the Main Menu. See Utils.cs for the code
                Utils.Clear();

                //this is where it displays the current capactity, etc for the particular house in the console
                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    Console.Write($"{i + 1}. Chicken House: Total: {farm.ChickenHouses[i].GetCount} of {farm.ChickenHouses[i].Capacity} (");
                    farm.ChickenHouses[i].listAnimals();
                    Console.WriteLine(")");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                try
                {
                    //determines our selection for place the chicken in a particular chicken house.
                    int choice = Int32.Parse(Console.ReadLine());
                    //this is checking the house if it has enough capacity, and if so then it places it in there. If not then it will display the else statement.
                    //we use -1 to get onto the index of chicken house
                    if (farm.ChickenHouses[choice - 1].GetCount < farm.ChickenHouses[choice - 1].Capacity)
                    {
                        farm.ChickenHouses[choice - 1].AddResource(chicken);
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