/*
 * Démonstration 07 - Les tableaux à une dimension
 */

// Pseudo-Code: Variable nomTableau : Tableau de Type[Taille]
// C#: Type[] nomTableau;

// 1.  Déclaration

// Création de l'instance du tableau
int[] monTableau = new int[10]; // Typage et taille définie (immuable)

// 2.  Récupération de la taille d'un tableau:
// Propriété .Length

Console.WriteLine($"Taille du tableau: {monTableau.Length}");

// 3.  Accéder à un emplacement dans le tableau
// Opérateur d'indexation: [ ]
// Index: 
// - Commence à 0
// - Termine à Length - 1

Console.WriteLine($"monTableau[0]: {monTableau[0]}");
Console.WriteLine($"monTableau[5]: {monTableau[5]}");
Console.WriteLine($"monTableau[9]: {monTableau[9]}");

// ⚠️ IndexOutOfRangeException !!
//Console.WriteLine($"monTableau[-1]: {monTableau[-1]}");
//Console.WriteLine($"monTableau[10]: {monTableau[10]}");

// 4.  Modification d'un élément

monTableau[0] = 42;
monTableau[1] = default(int); // Par défaut

// 5.  Déclaration et instancier un tableau avec des valeurs initiales

int[] monTableau2 = { 1, 2, 3, 4, 5 }; // Avant C# 12
int[] monTableau3 = [ 1, 2, 3, 4, 5 ]; // Collection expression (C# 12)

// 6.  Parcourir un tableau

Console.WriteLine($"Parcourt et initialisation des valeurs du tableau");
for (int i = 0; i < monTableau.Length; i++)
{
    monTableau[i] = Random.Shared.Next(100);
    Console.WriteLine($"monTableau[{i}]: {monTableau[i]}");
}

int compteur = 0;
// Avec foreach
Console.WriteLine($"Parcourt du tableau avec foreach");
foreach (var entier in monTableau)
{
    Console.WriteLine($"{compteur++}: {entier}");
}

