/*
 * Démonstration 05 - Opérateurs
 */

// 1.  Opérateurs d'affectation et leurs raccourcis

int a = 5;

a = a + 2; // +=
a += 2; // Même chose
a -= 2;
a *= 2;
a /= 2;

// 2.  Pré/post - Incrémentation / Décrémentation

// Pré: Modifie d'abord, ensuite on affecte
// Post: On affecte puis on modifie

// 2.1.  Incrémentation

// 2.1.1.  Pré

int b = 5;
int c = ++b; // b: 6 | c: 6

// 2.1.2.  Post

int d = b++; // b: 7 | d: 6

// 2.2.  Décrémentation

// 2.2.1.  Pré

int e = --b; // b: 6 | e: 6

// 2.2.2.  Post

int f = b--; // b: 5 | f: 6


// 3.  Opérateur ternaire

// condition ? si_vrai : si_faux


//(true ? Console.Write("Coucou") : Console.WriteLine("Hello")); // à ne pas utiliser

Console.WriteLine(true ? "Coucou" : "Hello"); // ✅


// 4.  Opérateur coalesce
// Permet de vérifier s'il y a une valeur non nulle; sinon donne une autre valeur

string str = null;


string resultat = str ?? "valeur par défaut";

str = str ?? "valeur par défaut";
str ??= "valeur par défaut"; // version raccourcie


int.TryParse(Console.ReadLine() ?? "0", out int g); // Exemple

// 5.  Opérateur typeof

object monObjet = 42;


Type typeType = typeof(int); // Récupération du type d'un type
Type typeValeur = monObjet.GetType();


if (typeValeur == typeType) // 42 est un int32 ?
{
    Console.WriteLine($"{monObjet} est un {typeType}");
}


if (monObjet.GetType() == typeof(Int32))
{

}

if (monObjet.GetType() == typeof(object))
{
    Console.WriteLine($"{monObjet} est de type object"); // Pas le cas
}

// 6.  Opérateur is

int valeur = 42;

// Avec typeof et GetType()

if (valeur.GetType() == typeof(int))
{
    Console.WriteLine($"{valeur} est un entier");
}

if (valeur.GetType() == typeof(ValueType))
{
    Console.WriteLine($"{valeur} est un type valeur");
}

if (valeur.GetType() == typeof(object))
{
    Console.WriteLine($"{valeur} est un type object");
}

// Avec is

if (valeur is int)
{
    Console.WriteLine($"{valeur} est un entier");
}

if (valeur is ValueType)
{
    Console.WriteLine($"{valeur} est un type valeur");
}

if (valeur is object)
{
    Console.WriteLine($"{valeur} est un type object");
}

// 6.2.  Pattern Matching

object obj = "Hello"; // Cast implicite (car une string est un objet)

if (obj is int)
{
    Console.WriteLine($"{obj} est un entier");
    int i = (int)obj; // Cast explicite
}
else if (obj is string)
{
    Console.WriteLine($"{obj} est une chaîne de caractères");
    string s = (string)obj;
    ((string)obj).ToLower();
    ((string)obj).ToUpper();
}
else if (obj is long l)
{
    Console.WriteLine($"{l} est un long");
    //l.TryFormat();
}

// 7.  Opérateur AS

object p = 12;

string? str2 = p is string ? (string)p : null;
string? str3 = p as string;


//int entier2 = p as int; // Attention, as retourne la valeur convertie potentiellement null
int? entier2 = p as int?;

// 8.  Opérateurs checked / unchecked

//checked
//{
//    int h = int.MaxValue;
//    int j = h + 1;
//    Console.WriteLine($"h: {h}");
//    Console.WriteLine($"j: {j}");
//}


// Propriété du projet > Build > Advanced > Check for arithmetic overflow
// → permet de faire check automatiquement

// Pour ne plus vérifier
unchecked
{
    int h = int.MaxValue;
    int j = h + 1;
    Console.WriteLine($"h: {h}");
    Console.WriteLine($"j: {j}");
    // Code non vérifié
}

