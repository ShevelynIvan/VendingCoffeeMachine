namespace VendingCoffeeMachine.Contracts
{
    internal interface IContainingWater
    {
        /// <summary>
        /// Adds some water
        /// </summary>
        /// <param name="amountOfWater">Amount of water in ml</param>
        void AddWater(int amountOfWater);
    }
}
