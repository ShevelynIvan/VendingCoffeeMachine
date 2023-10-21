namespace VendingCoffeeMachine.Contracts
{
    internal interface IContainingMilk
    {
        /// <summary>
        /// Adds some milk
        /// </summary>
        /// <param name="amountOfMilk">Amount of milk in ml</param>
        void AddMilk(int amountOfMilk);
    }
}
