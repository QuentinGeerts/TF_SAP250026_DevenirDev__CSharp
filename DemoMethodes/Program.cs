/*
 * Démonstration 09 - Méthodes
 */

// 1. Déclaration d'une méthode
using DemoMethodes.Models;
using System.Collections;

void maMethode() // Procédure
{
    // ...
}

int maMethode2()
{
    if (false) return 0;
    return 1;
}

// 2.  Invocation

Console.WriteLine($"Méthode: {maMethode}"); // Emplacement en mémoire
Console.WriteLine($"Méthode: {maMethode2}"); // Emplacement en mémoire
Console.WriteLine($"Méthode: {maMethode2()}"); // Exécution du code

maMethode(); // maMethode.Invoke() [Délégués]

// 3.  L'opérateur null conditionnel
string str = null;

//str.ToUpper(); // Génère un crash
str?.ToUpper(); // ♥

if (str != null) str.ToUpper(); // Version longue

// 4.  Les paramètres

void maMethode3 (string s, int i)
{
    Console.WriteLine($"s: {s}, i: {i}");
}

maMethode3("Hello", 42);
maMethode3(i:42, s:"Hello"); // Paramètres nommés

// 5.  Paramètres optionnels

// Attention, le paramètre optionnel sera TOUJOURS après les paramètres
// obligatoires
void maMethode4(int i, string s = null)
{
    if (s == null) Console.WriteLine($"Pas de valeur à afficher");
    else Console.WriteLine($"s: {s}");
}

maMethode4(42, "Hello");
maMethode4(42);

// 6.  Mot-clef "in"
// Permet de rendre un paramètre immuable

void maMethode5(in int i)
{
    // i = 5; // Impossible de le modifier
}

// 7.  Mot-clef "params"
// Permet de récupérer un nombre illimité d'argument en paramètre

void maMethode6 (params object[] objs)
{
    foreach (object o in objs)
    {
        Console.WriteLine($"- {o}: {o.GetType()}");
    }
}

maMethode6(42, "Hello", true, 42.2, new DateTime()
    , new ArrayList { 1, 2}, new int[] {1, 2});
maMethode6();

double addition (params double[] values)
{
    return values.Sum();
}

// 8. Mot-clef "ref"

// Type valeur (structure)
void passageParValeur (int i)
{
    Console.WriteLine($"i: {i}"); // i: 42
    i = 0;
    Console.WriteLine($"i: {i}"); // i: 0
}

void passageParValeurAvecRef(ref int i)
{
    Console.WriteLine($"i: {i}"); // i: 42
    i = 0;
    Console.WriteLine($"i: {i}"); // i: 0
}

void passageParReference(object[] o)
{
    Console.WriteLine($"o[0]: {o[0]}"); // o[0]: 42
    o[0] = 0;
    Console.WriteLine($"o[0]: {o[0]}"); // o[0]: 0
}


// Utilisation du passage par valeur
int a = 42;

Console.WriteLine($"a: {a}"); // a: 42
passageParValeur(a);
Console.WriteLine($"a: {a}"); // a: 42
passageParValeurAvecRef(ref a);
Console.WriteLine($"a: {a}"); // a: 0

// Utilsiation du passage par référence
object[] b = [42];

Console.WriteLine($"b[0]: {b[0]}"); // b[0]: 42
passageParReference(b);
Console.WriteLine($"b[0]: {b[0]}"); // b[0]: 0


// 9.  Mot-clef "out"


bool equationSecondDegre(double a, double b, double c, out double? x1, out double? x2)
{
    x1 = null;
    x2 = null;
    if (a == 0) return false;
    double discriminant = (b * b) - (4 * a * c);

    if (discriminant < 0) return false;
    else if (discriminant == 0) x1 = -b / (2 * a);
    else
    {
        x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    }

    return true;
}

double? x1, x2;

//bool reussi1 = equationSecondDegre(2, -1, -6, out x1, out x2); // 2 solutions
//bool reussi1 = equationSecondDegre(2, -3, (9/(double)8), out x1, out x2); // 1 solution
bool reussi1 = equationSecondDegre(1, 3, 10, out x1, out x2); // 0 solution

if (reussi1 == true)
{
    if (x2 != null)
    {
        Console.WriteLine($"2 solutions trouvées: {x1}, {x2}");
    }
    else
    {
        Console.WriteLine($"1 solution trouvée: {x1}");
    }
}
else
{
    Console.WriteLine($"Aucune solution trouvée.");
}

// 10.  Surcharge de méthodes

// Possible que :
// - Méthode de même nom
// - Différent en terme de paramètres (nombre et / ou type)

MaClasse maClasse = new MaClasse();
maClasse.DireBonjour();
maClasse.DireBonjour("Eliott");
maClasse.DireBonjour("Kévin", "Kevin");
maClasse.DireBonjour(3);
