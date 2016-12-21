using System;

namespace CSharp.ValueTypes
{
    public class DecimalType
    {
        public static void DisplayOutput()
        {
            decimal amount, interestRate, interestAmount, totalAmount;

            amount = 100.50m;
            interestRate = 12.24m;
            interestAmount = amount * interestRate / 100;
            totalAmount = amount + interestAmount;

            Console.WriteLine("Original Amount = {0}, Interest is {1}, and Amount with Interest Added = {2}", amount, 
                interestAmount, totalAmount);
        }
    }
}
