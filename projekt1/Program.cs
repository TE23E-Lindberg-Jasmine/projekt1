Hamburger buger = new Hamburger();
buger.Frying = 0;

Console.WriteLine("Välkommen till burgartävlingen! I denna tävling ska du bygga din egen hamburgare som sedan blir betygsatt av kända kockar i juryn.");

// Första rundan
Console.ReadLine();
Console.Clear();
Console.WriteLine("Nu ska du välja hur du vill tillaga din burgare.");

// Användaren får välja hur hamburgaren ska tillagas
while (true)
{
    Console.WriteLine("1) Steka");
    Console.WriteLine("2) Grilla");
    Console.WriteLine("3) Koka");

    string choiceSteak = Console.ReadLine();

    if (choiceSteak == "1")
    {
        buger.Frying += 10;
        Console.WriteLine("Bra! Burgaren steks fint. Nästa steg!");
        break;
    }
    else if (choiceSteak == "2")
    {
        buger.Frying += 5;
        Console.WriteLine("Bra! Burgaren grillas. Nästa steg!");
        break;
    }
    else if (choiceSteak == "3")
    {
        buger.Frying += 0;
        Console.WriteLine("Du kokade burgaren... Nästa steg!");
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva 1, 2 eller 3!");
    }
}

Console.ReadLine();
Console.Clear();

// Andra rundan
Random rate = new Random();
int totalPoäng = 0;


// Användaren får lägga till ingredienser
int IngredientPoints = 0;
while (IngredientPoints < 3)
{
    Console.WriteLine("Nu får du lägga in en speciell ingrediens. Detta kan vara avgörande för dig!");
    Console.WriteLine("Skriv 'klar' när du är färdig.");
    string IngredientPoint = Console.ReadLine();
    Console.ReadLine();

    bool success = int.TryParse(IngredientPoint, out IngredientPoints);


    if (IngredientPoint.ToLower() == "klar")
    {
        break;
    }

    buger.AddIngredient(IngredientPoint);

    int poäng = rate.Next(1, 11);
    totalPoäng += poäng;

    Console.WriteLine($"{IngredientPoint} gav {poäng} poäng!");
    Console.WriteLine($"Totalpoäng just nu: {totalPoäng}");
    Console.WriteLine();
}

// generisk klass för som redan har bestämda poäng 
Dictionary<string, int> ingredientPoäng = new Dictionary<string, int>()
{
    {"ost", 10},
    {"bacon", 15},
    {"sallad", 5},
    {"tomat", 5},
    {"chili", 12}
};

while (true)
{
    Console.WriteLine("Nu får du lägga in en speciell ingrediens.");
    Console.WriteLine("Välj mellan: ost, bacon, sallad, tomat, lök, chili, jalapeno, tryffel");
    Console.WriteLine("Skriv 'klar' när du är färdig.");

    string ingredientChoice = Console.ReadLine().ToLower();

    if (ingredientChoice == "klar")
    {
        break;
    }

    if (ingredientPoäng.ContainsKey(ingredientChoice))
    {
        buger.AddIngredient(ingredientChoice);

        int poäng = ingredientPoäng[ingredientChoice];
        totalPoäng += poäng;

        Console.WriteLine($"{ingredientChoice} lades till och gav {poäng} poäng!");
        Console.WriteLine($"Totalpoäng just nu: {totalPoäng}");
    }
    else
    {
        Console.WriteLine("Den ingrediensen finns inte i köket! -5 poäng.");
        totalPoäng -= 5;
    }

    Console.WriteLine();
}

// Specialrunda
Console.Clear();
Console.WriteLine("Du ska välja mellan tre olika lådor (1, 2 eller 3).");
Console.WriteLine("En låda ger pluspoäng, en ger minuspoäng, och en ger ingenting.");

while (true)
{
    Console.Write("Vilken låda väljer du? ");
    string choiceBox = Console.ReadLine();

    if (choiceBox == "1")
    {
        Console.WriteLine("Snyggt! Du valde rätt låda och fick +10 poäng!");
        totalPoäng += 10;
        break;
    }
    else if (choiceBox == "2")
    {
        Console.WriteLine("Otur! Den här lådan innehöll -10 poäng.");
        totalPoäng -= 10;
        break;
    }
    else if (choiceBox == "3")
    {
        Console.WriteLine("Lådan var tom. Inga poäng till dig den här gången.");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val. Du måste skriva 1, 2 eller 3!");
    }
}

Console.ReadLine();
Console.Clear();

Console.WriteLine("DIN BURGARE INNEHÅLLER:");
Console.WriteLine("- bröd");
Console.WriteLine("- kött");

// skriver ut listan 
foreach (string item in buger.IngredientList)
{
    Console.WriteLine("- " + item);
}

Console.WriteLine("- bröd");

// Juryns dom
string betyg = buger.GetJudgesVerdict(totalPoäng);
string tillagningsstatus = buger.GetCookingStatus();


// Skriver ut resultatet 
Console.WriteLine("--- JURYNS DOM ---");
Console.WriteLine(betyg);
Console.WriteLine(tillagningsstatus);

Console.WriteLine("\n----------------------------");
Console.WriteLine($"Kockarnas totalbetyg: {totalPoäng} poäng");
Console.WriteLine($"Tillagningspoäng: {buger.Frying}");
Console.WriteLine("----------------------------");

Console.ReadLine();