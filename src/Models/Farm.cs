using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        //creating Lists for when a user created a particular facility
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */

        //IResource contains string Type { get; }
        //when we want to place the appropiate selection in the facility, this adds that resource to the selected field
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

        //setting the Add to the appropiate List 
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
        public void AddNaturalField(NaturalField naturalField)
        {
            NaturalFields.Add(naturalField);
        }

        //when we look at the Farm status report, this is where it's grabbing the created instances of the facilities
        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            ChickenHouses.ForEach(ch => report.Append(ch));

            DuckHouses.ForEach(dh => report.Append(dh));

            PlowedFields.ForEach(pf => report.Append(pf));

            NaturalFields.ForEach(nf => report.Append(nf));

            return report.ToString();
        }
    }
}