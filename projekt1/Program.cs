
using System;

    
    Console.WriteLine("Vällkommen!");
    Console.WriteLine("Välkommen till burgar tävlingen! I denna tävling ska du bygga din egna hamburgre för att sen kommer bli betygsatt av kända kockar som är jury");
    Console.WriteLine("De kommer vara 3 rundor där du kommer få välja hur du ska steka din börjare och vad du ska ha på din burgare");


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
        // Console.WriteLine("Burger score: " + burger.CalculateScore());
        Console.ReadLine();
    


