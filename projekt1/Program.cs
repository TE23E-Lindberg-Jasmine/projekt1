

hambuger buger = new hambuger();
buger.frying = 0;

Console.WriteLine("Välkommen till burgar tävlingen! I denna tävling ska du bygga din egna hamburgre för att sen kommer bli betygsatt av kända kockar som är jury");
Console.WriteLine("De kommer vara 3 rundor där du kommer få välja hur du ska steka din börjare och vad du ska ha på din burgare");

// första rundan

Console.WriteLine("Nu ska du välja hur du vill tillaga din börjare");

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
    }

    if (ChoiceSteak != "2")
    {
        buger.frying -= 10;
    }

    if (ChoiceSteak != "3")
    {
        buger.frying -= 20;
    }

    else
    {
        Console.WriteLine("Bra! nästa steg");
        break;
    }

}










Console.WriteLine("Vad skulle du vilja ha på din hamburgare");
string Choice2 = Console.ReadLine();




Console.ReadLine();




