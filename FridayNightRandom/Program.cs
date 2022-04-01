using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };            
            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Coca-Cola", "Fanta", "RedBull", "Appel juice", "Sprite" };
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Toy Story 1", "Toy Story 2", "Toy Story 3", "Toy Story 4", "Cars" };
            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
