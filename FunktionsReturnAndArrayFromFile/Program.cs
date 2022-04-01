using System;

namespace FunktionsReturnAndArrayFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "Chiken wings", "Pizza", "Sushi", "Popcorn", "Salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");


        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Coca-Cola", "Fanta", "RedBull", "Appel juice", "Sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrinks}");


        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Toy Story 1", "Toy Story 2", "Toy Story 3", "Toy Story 4", "Cars" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovies = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovies}");


        }



    }
}
