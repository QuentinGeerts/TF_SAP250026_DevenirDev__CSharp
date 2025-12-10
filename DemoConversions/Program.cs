/*
 * Démonstration 03 - Conversions
 */

// 1.  ToString()
// Convertir type → string

using DemoConversions;

int a = 42;

Console.WriteLine(a.GetType());
Console.WriteLine(a.ToString());

// 2.  Classe Convert
// Convertir type base → type base

string b = "42";
int bConverted = Convert.ToInt32(b);


// 3.  Méthode Parse()
// Convertir string → type base

//string c = null; // ArgumentNullException
//string c = "a"; // FormatException
//string c = (4_000_000_000).ToString(); // OverflowException
string c = "42";
int cConverted = int.Parse(c);

// 4.  Méthode TryParse()
// Convertir string → type base

//string d = (4_000_000_000).ToString();
string d = "42";

bool conversionReussie = int.TryParse(d, out int dConverted);

Console.WriteLine(conversionReussie);
Console.WriteLine($"Valeur à convertir: {d}, type origine: {d.GetType()}");
Console.WriteLine($"Valeur de dConverted: {dConverted}, type origine: {dConverted.GetType()}");

int eConverted;
bool conversionReussie2 = int.TryParse(d, out eConverted);

Console.WriteLine(conversionReussie2);
Console.WriteLine($"Valeur à convertir: {d}, type origine: {d.GetType()}");
Console.WriteLine($"Valeur de dConverted: {eConverted}, type origine: {eConverted.GetType()}");


Console.Clear();

// 4.1. Exemple
Console.WriteLine($"Entrez un nombre entre 0 et 10 : ");
int result = 0;
bool validValue = false;

while (!validValue)
{
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine($"Tu dois entrer un nombre ! Réessaie:");
    }

    Console.WriteLine($"Tu as entré: {result}");

    if (result >= 0 && result <= 10) validValue = true;
    else Console.WriteLine($"La valeur doit être comprise entre 0 et 10 !!!");
}

Console.WriteLine($"Valeur correcte: {result}");


// 5.  Transtypage (cast)

// 5.1. Conversion implicite (pas de potentiel perte de données)
// Exemple: int → long

int entier1 = 42;
long long1 = entier1; // Conversion implicite
int entier2 = (int)long1; // Conversion explicite

// 5.2.  Boxing / Unboxing

// 5.2.1.  Boxing: Type valeur → type référence
int monEntier = 42;
object monObjet = monEntier; // Polymorphisme + boxing

Personne personne = new Personne();
object monObjet2 = personne; // Polymorphisme (pilier OO)

// 5.2.2.  Unboxing: Type référence → type valeur

int monEntier2 = (int)monObjet; // Unboxing
Personne p2 = (Personne)monObjet2;
