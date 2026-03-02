// 1. Skapa objektet (stort H i Hamburger)
Hamburger buger = new Hamburger();

Console.WriteLine("Välkommen till burgartävlingen!");
Console.WriteLine("Tryck Enter för att starta...");
Console.ReadLine();
Console.Clear();

// --- FÖRSTA RUNDAN: TILLAGNING ---
while (true)
{
    Console.WriteLine("Hur vill du tillaga din burgare?");
    Console.WriteLine("1) Stekas\n2) Grillas\n3) Kokas");

    string choiceSteak = Console.ReadLine();

    // Vi kollar vad användaren valde med ==
    if (choiceSteak == "1")
    {
        buger.Frying += 10;
        Console.WriteLine("Stekt och klart!");
        break; // Avbryt loopen
    }
    else if (choiceSteak == "2")
    {
        buger.Frying += 15; // Lite extra för grillat
        Console.WriteLine("Grillat är godast!");
        break;
    }
    else if (choiceSteak == "3")
    {
        buger.Frying -= 10;
        Console.WriteLine("Koka burgare..? Okej då...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val, välj 1-3.");
    }
}

Console.Clear();

// --- ANDRA RUNDAN: INGREDIENSER ---
Random rate = new Random();
List<string> ingredientList = new List<string>();
int totalPoäng = 0;

while (true)
{
    Console.WriteLine("Vad vill du ha på din hamburgare? (Skriv 'klar' när du är färdig)");
    string ingredientChoice = Console.ReadLine();

    if (ingredientChoice.ToLower() == "klar")
    {
        break;
    }

    // Lägg till i listan
    ingredientList.Add(ingredientChoice);

    // Slumpa poäng
    int poäng = rate.Next(1, 11);
    totalPoäng += poäng;
    Console.WriteLine($"+{poäng} poäng för {ingredientChoice}!");
}

Console.Clear();
Console.WriteLine("DIN BURGARE INNEHÅLLER:");

// Skriv ut listan
foreach (string item in ingredientList)
{
    Console.WriteLine("- " + item);
}

// Slutbetyg
Console.WriteLine("\n----------------------------");
Console.WriteLine($"Kockarnas totalbetyg: {totalPoäng} poäng!");
Console.WriteLine($"Tillagningspoäng: {buger.Frying}");
Console.WriteLine("----------------------------");

Console.ReadLine();