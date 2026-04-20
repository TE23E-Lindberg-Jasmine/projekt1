
public class Judge
{
    public string Name { get; set; }

    public Judge(string name)
    {
        Name = name;
    }

    public string JudgeBurger(int totalPoints)
    {
        if (totalPoints > 50)
            return $"{Name}: Enastående! Kockarna vill ha receptet.";
        else if (totalPoints > 25)
            return $"{Name}: Bra jobbat, men den saknar det lilla extra.";
        else
            return $"{Name}: Tyvärr, det här var ingen smakupplevelse.";
    }
}