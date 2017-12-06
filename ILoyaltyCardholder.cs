namespace Mod1_Lab1
{
    public interface ILoyalityCardHolder
    {
        int TotalPoints { get; }
        void AddPoints(decimal transactionValue);
        void ResetPoints();

    }
}