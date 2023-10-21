namespace VendingCoffeeMachine.Entities
{
    internal abstract class CupBase
    {
        /// <summary>
        /// Stirs the contents of the cup
        /// </summary>
        public void Stir()
        {
            Console.WriteLine("Starting stirring");
            Thread.Sleep(100);
            Console.WriteLine("Done! Cup has been stirred.");
        }
    }
}
