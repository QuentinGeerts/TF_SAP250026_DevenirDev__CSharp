namespace DemoMethodes.Models;

public class MaClasse
{
    public void DireBonjour()
    {
        Console.WriteLine($"Bonjour");
    }

    public void DireBonjour(string destinataire)
    {
        Console.WriteLine($"Bonjour {destinataire}");
    }

    public void DireBonjour(string expediteur, string destinataire)
    {
        Console.WriteLine($"{expediteur} dit bonjour à {destinataire}");
    }

    public void DireBonjour(int nbRepetition)
    {
        Console.WriteLine($"{string.Join("..", Enumerable.Repeat("Bonjour", nbRepetition))}");
    }
}
