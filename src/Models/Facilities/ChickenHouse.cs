using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    //IPecking contains: double GrainPerDay { get; set; }, void Peck();, string returnAnimalType { get; }

    public class ChickenHouse : IFacility<IPecking>
    {
        //stating capacity for the ChickenHouse, if it's full then no more chickens!
        private int _capacity = 15;
        //public unique identifier. This is where you'll see the ID number for the chicken house (Ex., ChickenHouse 4d3k8n[set to 6 char])
        //So, when you press 4 you will see the unique ID
        private Guid _id = Guid.NewGuid();

        //when a chicken is added, it goes to this list
        private List<IPecking> _chickens = new List<IPecking>();

        //double refers to a decimal placement for an int. In this instance we are counting the number of chickens.
        public double GetCount
        {
            get
            {
                return _chickens.Count;
            }
        }

        //counting how many chickens there are in a house
        public int AnimalCount
        {
            get
            {
                return _chickens.Count;
            }
        }
        //refers to the max number of chickens allowed in a house
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        //where we place the chicken in a particular chicken house
        public void AddResource(IPecking chicken)
        {
            _chickens.Add(chicken);
            // throw new NotImplementedException();
        }

        //we are declaring incoming chickens, current chickens, space available
        public void AddResource(List<IPecking> chickens)
        {
            int incomingListCount = chickens.Count;
            int currentListCount = _chickens.Count;
            //the 'math' function to determine if there is enough space for placing a chicken in a particular house
            int availableSpace = _capacity - incomingListCount + currentListCount;
            //this evaulates the numerical value that is created from available space. Math.Sign returns an integer that indicates the sign of a number.
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            //we state evaulatedAvaliableSpace to equal one so if we can't add 'one' then we get the 'else' statement.
            if (evaluatedAvailableSpace == 1)
            {
                chickens.ForEach(a => _chickens.Add(a));
            }
            else
            {
                Console.WriteLine("at max Capacity");
            }
        }

        //this is taking our selections and stringing/portraying the words. 
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            //The way it reads in the console: The ChickenHouse ID (number/char)
            //Length-6 is limiting the characters for the chickenHouse ID
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            //output is taking whatever is in the quotation marks and displaying the count of chickens in the particular house
            output.Append($"The Chicken House {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            //stringify the output
            return output.ToString();
        }

        //using this list in the CreateChickenHouse file
        public void listAnimals()
        {
            var chickenSortedList = _chickens.Where(chicken => chicken.returnAnimalType == "Chicken");
            Console.Write($"Chicken: {chickenSortedList.Count()}");
        }
    }
}