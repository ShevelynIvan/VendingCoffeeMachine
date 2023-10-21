using VendingCoffeeMachine.Contracts;

namespace VendingCoffeeMachine.Entities
{
    internal class Cup : CupBase, IContainingWater, IContainingCoffee, IContainingSugar, IContainingMilk
    {
        private int _freeVolume;

        /// <summary>
        /// Volume of the cup. Can't be less than 100 and more than 400. 
        /// If there is an error, the volume is set to 200.
        /// </summary>
        public int FreeVolume
        {
            get => _freeVolume;
            set
            {
                if (value > 400 || value < 100)
                    _freeVolume = 200;
                else
                    _freeVolume = value;
            }
        }

        /// <summary>
        /// Constructor to create the cup.
        /// </summary>
        /// <param name="volume"> Volume of the cup. Can't be less than 100 and more than 400. 
        /// If there is an error, the volume is set to 200.</param>
        public Cup(int volume) => FreeVolume = volume;        

        /// <summary>
        /// Adds some coffee to the cup 
        /// </summary>
        /// <param name="countOfTeaspoons">Count of teaspoons of coffee</param>
        public void AddCoffee(int countOfTeaspoons)
            => AddCountOfTeaspoons(countOfTeaspoons, "coffee");

        /// <summary>
        /// Adds some sugar to the cup 
        /// </summary>
        /// <param name="countOfTeaspoons">Count of teaspoons of sugar</param>
        public void AddSugar(int countOfTeaspoons)
            => AddCountOfTeaspoons(countOfTeaspoons, "sugar");

        /// <summary>
        /// Adds some milk
        /// </summary>
        /// <param name="amountOfMilk">Amount of milk in ml</param>
        public void AddMilk(int amountOfMilk)
            => AddSomeLiquid(amountOfMilk, "milk");

        /// <summary>
        /// Add some water
        /// </summary>
        /// <param name="amountOfWater">Amount of water in ml</param>
        public void AddWater(int amountOfWater)
            => AddSomeLiquid(amountOfWater, "water");

        /// <summary>
        /// Helper method to keep principle DRY. Adds to the cup some teaspoons of something
        /// </summary>
        /// <param name="countOfTeaspoons">Count of teaspoons of substance to add to the cup</param>
        /// <param name="entity">kind of this substance</param>
        private void AddCountOfTeaspoons(int countOfTeaspoons, string entity)
        {
            if (countOfTeaspoons < 0)
                countOfTeaspoons = 0;
            if (countOfTeaspoons > 5)
                Console.WriteLine($"Error! Too many teaspoons of {entity}. Try to add less.");
            else 
                Console.WriteLine($"{countOfTeaspoons} teaspoon(s) of {entity} was added to the cup.");
        }

        /// <summary>
        /// Helper method to keep principle DRY. Adds to the cup some liquid
        /// </summary>
        /// <param name="amountOfSomething">Amount of some liquid to add</param>
        /// <param name="entity">kind of this liquid</param>
        private void AddSomeLiquid(int amountOfSomething, string entity)
        {
            if (amountOfSomething > _freeVolume)
            {
                Console.WriteLine($"Not enough space for {amountOfSomething} ml of {entity} in the cup.");
                Console.WriteLine($"Free volume: {_freeVolume} ml.");
            }
            else
            {
                _freeVolume -= amountOfSomething;
                Console.WriteLine($"{amountOfSomething} ml of {entity} was successfully added.");
                Console.WriteLine($"Free volume: {_freeVolume} ml.");
            }
        }
    }
}
