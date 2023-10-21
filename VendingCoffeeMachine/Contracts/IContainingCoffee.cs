namespace VendingCoffeeMachine.Contracts
{
    internal interface IContainingCoffee
    {
        /// <summary>
        /// Adds some coffee
        /// </summary>
        /// <param name="countOfTeaspoons">Count of teaspoons of coffee</param>
        void AddCoffee(int countOfTeaspoons);
    }
}
