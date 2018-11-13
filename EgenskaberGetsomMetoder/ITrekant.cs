namespace EgenskaberGetsomMetoder
{
    public interface ITrekant
    {
        int Grundlinje { get; }
        int Højde { get; }

        double GetAreal();
    }
}