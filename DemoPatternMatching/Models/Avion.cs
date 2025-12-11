namespace DemoPatternMatching.Models;

internal class Avion : Vehicule
{
    public double longueurAile;

    public void Voler()
    {
        Console.WriteLine($"L'avion vole...");
    }
}
