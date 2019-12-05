using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    //we're contracting out IResource where is contains, string Type { get; }
    //we're contacting out ISeedProducing which contains, double Harvest(); & string returnSeedType { get; }

    public class Wildflowers : IResource, ISeedProducing
    {
        //stating how many seeds are produced; made private due to not wanting it to be manipulated elsewhere.
        //We use the underscore to designate private entities
        private int _seedsProduced = 65;
        //stating what 'type' we're getting when we run the function, the returnSeedType
        public string Type { get; } = "Wildflowers";
        //on our function, designating the return seed type on selection
        public string returnSeedType => Type;

        //our Harvest/Processing ticket... we haven't gotten there yet.
        public double Harvest()
        {
            return _seedsProduced;
        }
        //where it displays on farm status, it returns this string.
        public override string ToString()
        {
            return $"Wildflowers. We got 'em now.";
        }

    }
}