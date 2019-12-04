using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IQuacking>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IQuacking> _ducks = new List<IQuacking>();

        public int AnimalCount
        {
            get
            {
                return _ducks.Count;
            }
        }
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IQuacking duck)
        {
            _ducks.Add(duck);
            // throw new NotImplementedException();
        }

        public void AddResource(List<IQuacking> ducks)
        {
            int incomingListCount = ducks.Count;
            int currentListCount = _ducks.Count;
            int availableSpace = _capacity - incomingListCount + currentListCount;
            int evaluatedAvailableSpace = Math.Sign(availableSpace);
            if (evaluatedAvailableSpace == 1)
            {
                ducks.ForEach(a => _ducks.Add(a));
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

            output.Append($"The Duck House {shortId} has {this._ducks.Count} ducks\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
        public void listDucks()
        {
            var duckSortedList = _ducks.Where(duck => duck.returnDuckType == "Duck");
            Console.Write($"Ducks: {duckSortedList.Count()}");
        }
    }
}