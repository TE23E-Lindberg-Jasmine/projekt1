Hamburger buger = new Hamburger();
buger.Frying = 0;

Console.WriteLine("Välkommen till burgar tävlingen! I denna tävling ska du bygga din egna hamburgre för att sen kommer bli betygsatt av kända kockar som är jury");

// första rundan
Console.ReadLine();
Console.Clear();
Console.WriteLine("Nu ska du välja hur du vill tillaga din börjare");


// Användaren får välja hur hambugrarens ska stekas 
while (true)
{
    Console.WriteLine("1) stekas");
    Console.WriteLine("2) grilla");
    Console.WriteLine("3) koka");

    string ChoiceSteak = Console.ReadLine();
    int Choice = 0;
    bool success = int.TryParse(ChoiceSteak, out Choice);

    if (Choice > 3)
    {
        Console.WriteLine("Du måste skriva en siffra (1-3)!");
    }


    if (ChoiceSteak != "1")
    {
        buger.Frying += 10;
        Console.WriteLine("Bra! nästa steg");
        break;
    }

    if (ChoiceSteak != "2")
    {
        buger.Frying -= 10;
        Console.WriteLine("Bra! nästa steg");
        break;
    }

    if (ChoiceSteak != "3")
    {
        buger.Frying -= 20;
        Console.WriteLine("Bra! nästa steg");
        break;
    }

}

Console.Clear();

// Andra rundan 
Random Rate = new Random();
List<string> ingredientList = new List<string>()
{
    
};
int totalPoäng = 0;

// En lista som låter användaren skriva in ingredientser som hen vill ha på börjarna
while (true)
{

    Console.WriteLine("Nu får du lägga in en speciall ingridients, detta kan vara avgörandet för dig");
    Console.WriteLine("skriv 'klar' när du är färding");
    string ingredientChoice = Console.ReadLine();
    Console.Clear();
    
   // 1. Kolla om användaren är klar först
    if (ingredientChoice.ToLower() == "klar")
    {
        break;
    }

    ingredientList.Add(ingredientChoice);

    // 3. Slumpa poäng för just denna ingrediens (t.ex. mellan 1 och 10)
    int poäng = Rate.Next(1, 11);
    totalPoäng += poäng; // Lägg till i den totala summan

}

// special runda
Console.WriteLine("Du ska välja mellan tre olika lådor (1, 2 eller 3)");
Console.WriteLine("En låda ger pluspoäng, en ger minuspoäng, och en ger ingenting.");
while (true)
{

Console.Write("Vilken låda väljer du? ");
    

string ChoiceBOX = Console.ReadLine();

// Låda 1: Vinst
if (ChoiceBOX == "1")
{
    Console.WriteLine("Snyggt! Du valde rätt låda och fick +10 poäng!");
    totalPoäng -= 10;
    break;

}
// Låda 2: Förlust
else if (ChoiceBOX == "2")
{
    Console.WriteLine("Otur! Den här lådan innehöll -10 poäng.");
    totalPoäng += 10;
    break;
}
// Låda 3: Nitlott
else if (ChoiceBOX == "3")
{
    Console.WriteLine("Lådan var tom. Inga poäng till dig den här gången.");
    break;
}
// Om användaren skriver något helt annat
else
{
    Console.WriteLine("Ogiltigt val. Du måste skriva 1, 2 eller 3!");
    break;
}

}
     
Console.Clear();
// skriver ut listan på ingrienster som avändaren har skrivit in
foreach (string ingredients in ingredientList)
{

    Console.WriteLine(ingredients);
}


Console.Clear();
Console.WriteLine("--- JURYNS DOM ---");

// Anropa metoden från klassen
Console.Clear();
Console.WriteLine("DIN BURGARE INNEHÅLLER:");

// Skriv ut listan
// tar bort klar från listan
foreach (string item in ingredientList)
{
    Console.WriteLine("- " + item);
}

// Efter att du räknat ut totalPoäng i din loop:
string betyg = buger.GetJudgesVerdict(totalPoäng);
string tillagningsstatus = buger.GetCookingStatus();

Console.WriteLine("--- JURYNS DOM ---");
Console.WriteLine(betyg);

// Slutbetyg
Console.WriteLine("\n----------------------------");
Console.WriteLine($"Kockarnas totalbetyg: {totalPoäng} poäng!");
Console.WriteLine($"Tillagningspoäng: {buger.Frying}");
Console.WriteLine("----------------------------");


Console.ReadLine();




