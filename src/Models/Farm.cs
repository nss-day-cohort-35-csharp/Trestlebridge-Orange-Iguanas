using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddChickenHouse(ChickenHouse coop)
        {
            ChickenHouses.Add(coop);
        }

        public void AddDuckHouse(DuckHouse canopy)
        {
            DuckHouses.Add(canopy);
        }

        public void AddPlowedField(PlowedField plowField)
        {
            PlowedFields.Add(plowField);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            ChickenHouses.ForEach(ch => report.Append(ch));

            DuckHouses.ForEach(dh => report.Append(dh));

            PlowedFields.ForEach(pf => report.Append(pf));

            return report.ToString();
        }
    }
}