/*
 * Démonstration 04 - Structures conditionnelles
 */

// 1.  L'instruction "if"

if (true)
{
    Console.WriteLine($"Exécution du bloc");
}

if (false)
{
    Console.WriteLine($"Ne sera pas exécuté");
}

// 2.  L'instruction "else"
// Prévoir un comportement par défaut

if (true)
{
    Console.WriteLine($"Exécution du bloc");
}
else
{
    Console.WriteLine($"Ne sera pas exécuté");
}

if (false)
{
    Console.WriteLine($"Ne sera pas exécuté");
}
else
{
    Console.WriteLine($"Exécution du bloc");
}

// 3.  L'instruction "else if"
// Permet de vérifier plus d'une condition

if (false)
{
    // ...
}
else if (true)
{
    Console.WriteLine($"Exécution");
}
else if (true)
{
    Console.WriteLine($"Code non exécuté");
}
else
{
    // ...
}

// 4.  Raccourci

if (true) Console.WriteLine($"Exécution");
else if (false)
    Console.WriteLine($"Non exécution");
else
{
    Console.WriteLine($"Avec accolades");
}

// 5.  L'instruction "switch"

string jour = "mercredi";

// 5.1.  Avec un if 

if (jour == "lundi")
{
    Console.WriteLine($"Pâtes au sucre");
}
else if (jour == "mardi")
{
    Console.WriteLine($"Pizza ananas");
}
else if (jour == "mercredi")
{
    Console.WriteLine($"Hamburger avec une feuille de salade");
}
else if (jour == "jeudi")
{
    Console.WriteLine($"Lasagne de cheval");
}
else if (jour == "vendredi")
{
    Console.WriteLine($"Frites avec moule pas fraiche");
}
else
{
    Console.WriteLine($"Plus d'argent");
}

// 5.2.  Avec "switch"

switch (jour)
{
    case "lundi": Console.WriteLine($"Pâtes au sucre"); break;
    case "mardi": Console.WriteLine($"Pizza ananas"); break;
    case "mercredi":
    case "jeudi":
        Console.WriteLine($"Lasagne de cheval");
        break;
    case "vendredi":
        Console.WriteLine($"Frites avec moule pas fraiche");
        break;
    default:
        Console.WriteLine($"Plus d'argent");
        break;
}

int value = -42;

switch (value)
{
    case > 0: Console.WriteLine($"Valeur positive.");
        break;

    default: Console.WriteLine($"Valeur négative");
        break;
}

// 6.  Opérateur ternaire
// condition ? si_vrai : si_faux

Console.WriteLine( value > 0 ? "Valeur positive" : "Valeur négative" );

// age < 18: mineur
// 18 <= age < 65: adulte
// age >= 65: senior

int age = 29;

Console.WriteLine(age < 18 ? "Mineur" : (age >= 65 ? "Senior" : "Adulte"));
