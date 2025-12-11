namespace DemoPatternMatching.Models;

internal class Vehicule
{
    public string Marque;
    public string Modele;

    public void Demarrer()
    {
        Console.WriteLine($"Le {GetType().Name} démarre...");
    }

    public void Arreter()
    {
        Console.WriteLine($"Le {GetType().Name} s'arrête...");
    }
}
