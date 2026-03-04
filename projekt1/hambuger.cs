

public class Hamburger
{
   

    private int _frying;
    public int frying 
    { 
        get => _frying; 
        set => _frying = Math.Max(0, value); // Förhindrar negativ stektid
    }

    public string Ingredients { get; set; } = "";

    // Metod som kollar hur burgaren mår baserat på stektid
    public string GetCookingStatus()
    {
        if (frying == 0) return "Helt rå (du glömde slå på spisen!)";
        if (frying < 10) return "Lite väl blodig, nästan rå.";
        if (frying >= 10 && frying <= 15) return "Perfekt stekt! Saftig och god.";
        if (frying > 15 && frying <= 25) return "Genomstekt och lite torr.";
        return "Ett kolsvart stycke gummi. Oätligt!";
    }

 
 

    public string GetIngredients()
    {
   
        return Ingredients;
    }
}

