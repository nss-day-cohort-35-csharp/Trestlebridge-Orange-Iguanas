using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IPecking>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IPecking> _chickens = new List<IPecking>();


        public double GetCount
        {
            get
            {
                return _chickens.Count;
            }
        }
        public int AnimalCount
        {
            get
            {
                return _chickens.Count;
            }
        }
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPecking chicken)
        {
            _chickens.Add(chicken);
            // throw new NotImplementedException();
        }

        public void AddResource(List<IPecking> chickens)
        {
            int incomingListCount = chickens.Count;
            int currentListCount = _chickens.Count;
            int availableSpace = _capacity - incomingListCount + currentListCount;
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            if (evaluatedAvailableSpace == 1)
            {
                chickens.ForEach(a => _chickens.Add(a));
            }
            else
            {
                Console.WriteLine("at max Capacity");
            }
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"The Chicken House {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        public void listAnimals()
        {
            var chickenSortedList = _chickens.Where(chicken => chicken.returnAnimalType == "Chicken");
            Console.Write($"Chicken: {chickenSortedList.Count()}");
        }
    }
}