using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public int SeedCount
        {
            get
            {
                return _seeds.Count;
            }
        }
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public double GetCount
        {
            get
            {
                return _seeds.Count;
            }
        }

        public void AddResource(ISeedProducing seed)
        {
            _seeds.Add(seed);
            // throw new NotImplementedException();
        }

        public void AddResource(List<ISeedProducing> seeds)
        {
            int incomingListCount = seeds.Count;
            int currentListCount = _seeds.Count;
            int availableSpace = _capacity - incomingListCount + currentListCount;
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            if (evaluatedAvailableSpace == 1)
            {
                seeds.ForEach(a => _seeds.Add(a));
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

            output.Append($"Plowed field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        public void listSeeds()
        {
            var sesameSortedList = _seeds.Where(sesame => sesame.returnSeedType == "Sesame");
            Console.Write($"Sesame: {sesameSortedList.Count()}");
        }
    }
}