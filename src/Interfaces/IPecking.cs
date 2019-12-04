namespace Trestlebridge.Interfaces
{
    public interface IPecking
    {
        double GrainPerDay { get; set; }
        void Peck();

        string returnAnimalType { get; }
    }
}