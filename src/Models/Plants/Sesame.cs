using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    //we're contracting out IResource where is contains, string Type { get; }
    //we're contacting out ISeedProducing which contains, double Harvest(); & string returnSeedType { get; }
    public class Sesame : IResource, ISeedProducing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";

        public string returnSeedType => Type;

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Who wants some Sesame seeds? You do! Thanks, pal.";
        }

    }
}