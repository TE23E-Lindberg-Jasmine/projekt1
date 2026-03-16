public class Hamburger
{
    private int _frying;
    public int Frying // Ändrat till PascalCase
    {
        get => _frying;
        set => _frying = Math.Max(0, value);
    }

    // Vi gör 'set' privat så att ingredienser bara kan läggas till via AddIngredient-metoden
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
        string status = Frying > 5 ? "Välstekt" : "Medium";
        return $"Hamburgaren har {IngredientList.Count} ingredienser och är {status}.";
    }

    public string GetJudgesVerdict(int totalPoints)
    {
        if (totalPoints > 50) return "Enastående! Kockarna vill ha receptet.";
        if (totalPoints > 25) return "Bra jobbat, men den saknar det lilla extra.";
        return "Tyvärr, det här var ingen smakupplevelse.";
    }

}
