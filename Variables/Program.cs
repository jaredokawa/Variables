using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring and initializing a VARIABLE
            string dogNAME = "Ralph";
            int dogAge = 10;
            char dogRank = 'a';
            bool isAlive = true;
            double interestRate = 5;
            decimal dogMoney = 100.75M;

            Console.WriteLine($"My dog's name is {dogNAME}. He is {dogAge}. He is ranked {dogRank} amongst all living dogs {isAlive}. He wanted to buy a new dog house but interest rates are at {interestRate} and he only has {dogMoney} so he cannot afford it.");
        }
    }
}
