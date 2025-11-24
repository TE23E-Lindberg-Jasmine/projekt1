// Klassen Ingredient representerar EN ingrediens i hamburgaren.
// Den har ett namn och en "kvalitetspoäng".
public class Ingredient
{
    // Namnet på ingrediensen, t.ex. "Cheese"
    public string Name { get; set; }

    // Kvaliteten på ingrediensen, t.ex. 1–10
    public int Quality { get; set; }

    // Konstruktor – körs när du skapar en ny Ingredient
    // Ex: new Ingredient("Meat", 8);
    public Ingredient(string name, int quality)
    {
        Name = name;
        Quality = quality;
    }
}
