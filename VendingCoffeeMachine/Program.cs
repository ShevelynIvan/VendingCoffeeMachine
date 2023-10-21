using System.Net.NetworkInformation;
using VendingCoffeeMachine.Contracts;
using VendingCoffeeMachine.Entities;

namespace VendingCoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cup myCup = new Cup(200);

            AddCoffee(myCup, 3);
            AddSugar(myCup, 1);
            myCup.Stir();

            AddWater(myCup, 50);
            myCup.Stir();

            AddMilk(myCup, 130);

            AddMilk(myCup, 50);
        }

        static void AddCoffee(IContainingCoffee cup, int countOfTeaspoons)
            => cup.AddCoffee(countOfTeaspoons);

        static void AddSugar(IContainingSugar cup, int countOfTeaspoons)
            => cup.AddSugar(countOfTeaspoons);

        static void AddWater(IContainingWater cup, int amountOfWater)
            => cup.AddWater(amountOfWater);

        static void AddMilk(IContainingMilk cup, int amountOfMilk) 
            => cup.AddMilk(amountOfMilk);
    }
}