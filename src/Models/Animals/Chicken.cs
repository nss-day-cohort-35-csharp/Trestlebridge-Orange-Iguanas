using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    //IResource is using string Type { get; }
    //IPecking is using double GrainPerDay { get; set; }, string returnAnimalType { get; }
    //IMeatProducing is using double Butcher ();
    public class Chicken : IResource, IPecking, IMeatProducing
    {
        //unique ID number
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private double _eggProduced = 7;

        private double _feathersProduced = 0.5;

        //concatinating the ID by subtracing 6
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrainPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";

        // Methods
        //calling Peck() that was created in IPecking
        public void Peck()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.GrainPerDay}kg of grain");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        //displays on Farm Status
        public override string ToString()
        {
            return $"Chicken {this._shortId}. CluckCluckCluck!";
        }

        public string returnAnimalType { get { return Type; } }

    }
}