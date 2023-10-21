namespace VendingCoffeeMachine.Contracts
{
    internal interface IContainingSugar
    {
        /// <summary>
        /// Adds some sugar
        /// </summary>
        /// <param name="countOfTeaspoons">Count of teaspoons of sugar</param>
        void AddSugar(int countOfTeaspoons);
    }
}
