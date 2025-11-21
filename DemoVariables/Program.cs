/*
 * Démonstration 02 - Variables
 */

// 1. Déclaration

// Pseudo-Code: Variable nomVariable : Type
// C#: Type nomVariable;

string prenom;


// 2. Affectation
// 1ère affectation → Initialisation
// Pseudo-Code: nomVariable ← valeur
// C#: nomVariable = valeur;

Console.WriteLine("Entrez votre prénom: ");
prenom = Console.ReadLine();

//Console.WriteLine("Tu t'appelles " + prenom);

// Interpolation de chaînes de caractères
Console.WriteLine($"Tu t'appelles {prenom}");


// 3. Portée d'une variable

if (true)
{
    Console.WriteLine(prenom);
    string nom = "Geerts";
    Console.WriteLine(nom);
}

// Console.WriteLine(nom); // En dehors du context du if


// 4.  Constantes
// Pseudo-Code: Constante NOM_CONSTANTE ← valeur
// C#: const type NOM_CONSTANTE = valeur;

const double PI = 3.141592;
// PI = 3.1415; // Impossible de modifier une constante


// 5.  Nullable
// - Types valeurs: Ne sont pas IMPLICITEMENT nullables
// - Types références: Sont IMPLICITEMENT nullables

string variableImplicitementNullable = null;
//int variableNonImplicitementNullable = null;
//Nullable<int> variableNonImplicitementNullable = null;
int? variableNonImplicitementNullable = null;