

Hamburger buger = new Hamburger();
buger.frying = 0;

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
        buger.frying += 10;
        Console.WriteLine("Bra! nästa steg");
        break;
    }

    if (ChoiceSteak != "2")
    {
        buger.frying -= 10;
        Console.WriteLine("Bra! nästa steg");
        break;
    }

    if (ChoiceSteak != "3")
    {
        buger.frying -= 20;
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

    Console.WriteLine("Vad skulle du vilja ha på din hamburgare");
    Console.WriteLine("skriv 'klar' när du är färding");
    string ingredientChoice = Console.ReadLine();
    buger.Ingredients = ingredientChoice;


   // 1. Kolla om användaren är klar först!
    if (ingredientChoice.ToLower() == "klar")
    {
        break;
    }

    
    ingredientList.Add(ingredientChoice);

    // 3. Slumpa poäng för just denna ingrediens (t.ex. mellan 1 och 10)
    int poäng = Rate.Next(1, 11);
    totalPoäng += poäng; // Lägg till i den totala summan

 
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
foreach (string item in ingredientList)
{
    Console.WriteLine("- " + item);
}

// Slutbetyg
Console.WriteLine("\n----------------------------");
Console.WriteLine($"Kockarnas totalbetyg: {totalPoäng} poäng!");
Console.WriteLine($"Tillagningspoäng: {buger.frying}");
Console.WriteLine("----------------------------");









Console.ReadLine();




