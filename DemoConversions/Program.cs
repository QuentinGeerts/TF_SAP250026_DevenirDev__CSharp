/*
 * Démonstration 03 - Conversions
 */

// 1.  ToString()
// Convertir type → string

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

