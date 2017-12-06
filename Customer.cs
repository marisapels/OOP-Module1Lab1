using System;

namespace Mod1_Lab1
{
    public class Customer: ILoyalityCardHolder
    {
        private int totalPoints;

        int ILoyalityCardHolder.TotalPoints
        {
            get
            {
                return totalPoints;
            }
        }

        public void AddPoints(decimal transactionValue)  
        {
            this.totalPoints = this.totalPoints + Decimal.ToInt32(transactionValue); 
        }

        void ILoyalityCardHolder.ResetPoints() => this.totalPoints = 0;
    }
}