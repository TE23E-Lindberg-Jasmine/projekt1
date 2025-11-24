using System.Collections.Generic;


// Klassen Hamburger representerar en hamburgare som består av flera ingredienser.
public class Hamburger
{
    // En lista som innehåller alla ingredienser som lagts i hamburgaren.
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    // Metod för att lägga till en ingrediens i hamburgaren.
    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    // Metod som räknar ut totalpoängen på hamburgaren
    // genom att summera kvaliteten på varje ingrediens.
    public int CalculateScore()
    {
        int score = 0;

        // Loopar igenom varje ingrediens i listan och adderar quality
        foreach (var ing in Ingredients)
        {
            score += ing.Quality;
        }

        return score;
    }
}

