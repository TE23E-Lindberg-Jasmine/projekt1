Console.WriteLine("Vällkommen till cook out!");
Console.WriteLine("I detta spel ska du välja olika ingridienser som du ska göra en hamburgare ");
Console.WriteLine("du har 150kr");

using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar olika ingrediensobjekt som spelaren kan använda
        Ingredient bread   = new Ingredient("Bread", 5);
        Ingredient meat    = new Ingredient("Meat", 8);
        Ingredient cheese  = new Ingredient("Cheese", 7);
        Ingredient lettuce = new Ingredient("Lettuce", 4);
        Ingredient tomato  = new Ingredient("Tomato", 5);
        Ingredient bacon   = new Ingredient("Bacon", 9);

        // Skapar en hamburgare
        Hamburger burger = new Hamburger();

        // Lägger till ingredienser (du kan låta spelaren välja detta senare)
        burger.AddIngredient(bread);
        burger.AddIngredient(meat);
        burger.AddIngredient(cheese);

        // Beräknar och skriver ut hamburgarens poäng
        Console.WriteLine("Burger score: " + burger.CalculateScore());
    }
}
