
using DemoPatternMatching.Models;
using System.Collections;

List<Vehicule> garage = new List<Vehicule>();

// Remplissage du garage
for (int i = 0; i < 10; i++)
{
    int proba = Random.Shared.Next(100);

    if (proba < 50)
    {
        // Créer une voiture
        Voiture voiture = new Voiture();
        garage.Add(voiture);
    }
    else
    {
        // Créer un avion
        garage.Add(new Avion());
    }
}

for (int i = 0; i < garage.Count; i++)
{
    Vehicule v = garage[i];

    v.Demarrer();

    if (v is Avion)
    {
        Avion a = (Avion) v;
        //a.Demarrer();
        a.Voler();
        //a.Arreter();
    }
    else if (v is Voiture voi)
    {
        //voi.Demarrer();
        voi.Rouler();
        //voi.Arreter();
    }

    v.Arreter();

    Console.WriteLine(  );
}