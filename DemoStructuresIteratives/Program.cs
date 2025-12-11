/*
 * Démonstration 06 - Structures itératives
 */

// 3 éléments importants pour qu'une boucle fonctionne:
// a. Initialisation (où je commence)
// b. Condition d'arrêt (où je m'arrête)
// c. Modification (comment je m'y rends)

// 1.  Boucle "while" (Tantque)

using System.Collections;

int compteur = 1; // Initialisation

while (compteur <= 10) // Condition d'arrêt
{
    Console.WriteLine($"Compteur: {compteur++}"); // Modification
}

// -- 


Console.WriteLine($"Entrez une valeur numérique: ");
while (!int.TryParse( Console.ReadLine(), out compteur ))
{
    Console.WriteLine($"erreur, réessayez: ");
}


// 2.  Boucle "do...while" (Faire...Tantque)

// Idem que while sauf qu'il va exécuté une première fois le bloc d'instructions


// 3.  Boucle "for" (Pour)


//    initialsiation ; condition ; modification
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}

for (int i = 0, j = 1; i < 10; i++, j+=2)
{
    Console.WriteLine($"i: {i}, j: {j}");
}


// 4.  Boucle "foreach" (Pour chaque)


string message = "C'est bientôt l'heure de la pause.";

foreach (char lettre in message)
{
    Console.Write($"{lettre}  ");
}

ArrayList a = new ArrayList();
a.AddRange(new[] { 1, 2, 3, 4 });

foreach (var item in a)
{
    Console.WriteLine($"item: {item}");
}