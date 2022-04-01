using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomFood, randomDrink, randomMovie;
            string[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
            string[] drinks = { "Coca-Cola", "Fanta", "RedBull", "Appel juice", "Sprite" };
            string[] movies = { "Toy Story 1", "Toy Story 2", "Toy Story 3", "Toy Story 4", "Cars" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

 
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
