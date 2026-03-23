public class Hamburger
{
    private int _frying;

    public int Frying
    {
        get => _frying;
        set => _frying = value;
    }

    public List<string> IngredientList { get; private set; } = new List<string>();

    public void AddIngredient(string ingredient)
    {
        if (!string.IsNullOrWhiteSpace(ingredient))
        {
            IngredientList.Add(ingredient);
        }
    }

    public string GetCookingStatus()
    {
        string status;

        if (Frying >= 10)
            status = "välstekt";
        else if (Frying >= 5)
            status = "grillad";
        else
            status = "dåligt tillagad";

        return $"Hamburgaren har {IngredientList.Count} ingredienser och är {status}.";
    }

    public string GetJudgesVerdict(int totalPoints)
    {
        if (totalPoints > 50) return "Enastående! Kockarna vill ha receptet.";
        if (totalPoints > 25) return "Bra jobbat, men den saknar det lilla extra.";
        return "Tyvärr, det här var ingen smakupplevelse.";
    }
}