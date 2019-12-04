using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IPecking, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private double _eggProduced = 7;

        private double _feathersProduced = 0.5;

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
        public void Peck()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.GrainPerDay}kg of grain");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. CluckCluckCluck!";
        }

        public string returnAnimalType { get { return Type; } }

    }
}