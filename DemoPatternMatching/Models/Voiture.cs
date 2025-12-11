namespace DemoPatternMatching.Models;

internal class Voiture : Vehicule
{
    public int nbRoue;

    public void Rouler()
    {
        Console.WriteLine($"La voiture roule...");
    }
}
