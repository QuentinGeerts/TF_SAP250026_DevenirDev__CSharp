/*
 * 4. Inverser un tableau : soit un tableau T. Saisir ce tableau. 
 * Changer de place les éléments de ce tableau de façon à ce que le nouveau 
 * tableau soit une sorte de miroir de l'ancien et afficher le nouveau tableau.
 * 
 * 5. À l’aide des boucles, réalisez un algorithme permettant de trier un 
 * tableau d’entier dans l’ordre croissant.
 */

List<int> ints = new();

for (int i = 0; i < 10; i++)
{
    ints.Add(Random.Shared.Next(100));
}

Console.WriteLine($"Liste actuelle: {string.Join(", ", ints)}");

ints.Reverse();

Console.WriteLine($"Liste renversée: {string.Join(", ", ints)}");

ints.Sort();

Console.WriteLine($"Liste triée: {string.Join(", ", ints)}");
