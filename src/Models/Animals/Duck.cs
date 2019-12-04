using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IQuacking
    {

        private Guid _id = Guid.NewGuid();
        private double _eggProduced = 6;

        private double _featherProduced = 0.75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrainPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        public void Quack()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrainPerDay}kg of grain");
        }

        // public double Butcher () {
        //     return _meatProduced;
        // }

        public override string ToString()
        {
            return $"Duck {this._shortId}. AFLAC. Flying V, Quaaaaaack!";
        }
        public string returnAnimalType { get { return Type; } }

    }
}