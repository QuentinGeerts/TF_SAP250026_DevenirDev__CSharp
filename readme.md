# SAP250026 - Devenir Développeur - C# Fondamentaux

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp)](https://docs.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-Educational-blue.svg)]()

Ce repository contient l'ensemble des démonstrations et exercices du cours de bases de C#. Chaque projet illustre des concepts fondamentaux de la programmation avec des exemples pratiques et progressifs.

## 📚 Table des Matières

- [Structure du Projet](#-structure-du-projet)
- [Démonstrations](#-démonstrations)
- [Exercices Pratiques](#-exercices-pratiques)
- [Projet Récapitulatif](#-projet-récapitulatif---bookmanager)
- [Technologies](#-technologies-utilisées)
- [Installation](#-installation)
- [Guide d'Apprentissage](#-guide-dapprentissage)

---

## 📂 Structure du Projet

```
SAP250026_DevenirDev__CSharp/
├── 01 Introduction/
│   ├── DemoIntroduction/
│   └── DemoIntroductionWithoutTopLevel/
├── 02 Variables/
│   ├── DemoVariables/
│   └── ExerciceInformationsUtilisateur/
├── 03 Conversions/
│   ├── DemoConversions/
│   └── Page106ExoA/
├── 04 Structures conditionnelles/
│   ├── DemoStructuresConditionnelles/
│   └── Page116ExoA/
├── 05 Operateurs/
│   ├── DemoOperateurs/
│   ├── DemoPatternMatching/
│   ├── Page140ExoA/
│   └── Page140ExoB/
├── 06 Structures iteratives/
│   ├── DemoStructuresIteratives/
│   ├── Page150ExoA/
│   └── Page150ExoB/
├── 07 Tableaux/
│   ├── DemoTableau/
│   ├── DemoTableauOrthogonal/
│   ├── DemoTableauMatriciel/
│   ├── DemoCollectionsArrayList/
│   ├── DemoCollectionHashtable/
│   ├── DemoCollectionQueue/
│   ├── DemoCollectionStack/
│   ├── DemoCollectionGeneriqueList/
│   ├── DemoCollectionGeneriqueDictionary/
│   ├── ExerciceBonusTableau3Scores/
│   └── ExerciceBonusCollection4Et5/
├── 08 Enum/
│   └── DemoEnum/
├── 09 Methodes/
│   ├── DemoMethodes/
│   └── Methodes/
├── 10 Structures/
│   └── DemoStructures/
└── Exercices/
    ├── BookManager/
    ├── ExerciceBonus01Bissextile/
    └── ExerciceBonus02LanceurBalles/
```

---

## 🎓 Démonstrations

### 01 - Introduction
**Projet:** `DemoIntroduction`

Premiers pas avec C# et la console.

**Concepts abordés:**
- Utilisation de la classe `Console`
- Méthodes `WriteLine()` et `Write()`
- Lecture avec `ReadLine()`
- Nettoyage de la console avec `Clear()`
- Commentaires (simple ligne `//` et multi-lignes `/* */`)
- Opérateur d'accès aux membres (`.`)

```csharp
// Écriture dans la console
Console.WriteLine("L'ambulance arrive à toute allure.");
Console.Write("Hello");
Console.Write("World !");

// Lecture depuis la console
Console.WriteLine("Tu as tapé: " + Console.ReadLine());

// Nettoyage de la console
Console.Clear();
```

**Projet:** `DemoIntroductionWithoutTopLevel`

Structure traditionnelle d'un programme C# sans Top-Level Statements.

```csharp
namespace DemoIntroductionWithoutTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + args);
        }
    }
}
```

---

### 02 - Variables
**Projet:** `DemoVariables`

Déclaration, affectation et gestion des variables.

**Concepts abordés:**
- Déclaration de variables
- Affectation et initialisation
- Interpolation de chaînes (`$"{variable}"`)
- Portée des variables
- Constantes (`const`)
- Types nullable (`int?`, `Nullable<int>`)

```csharp
// Déclaration
string prenom;

// Affectation (initialisation)
Console.WriteLine("Entrez votre prénom: ");
prenom = Console.ReadLine();

// Interpolation de chaînes
Console.WriteLine($"Tu t'appelles {prenom}");

// Constante
const double PI = 3.141592;

// Nullable
string variableImplicitementNullable = null;  // Types référence
int? variableNullable = null;  // Types valeur

// Portée
if (true)
{
    string nom = "Geerts";  // Variable locale au bloc
    Console.WriteLine(prenom);  // Accessible
}
// Console.WriteLine(nom);  // ❌ Erreur - hors de portée
```

**Exercice:** `ExerciceInformationsUtilisateur`

Collecte et affichage d'informations utilisateur (nom, prénom, date de naissance, adresse, état civil, taille).

```csharp
string nom, prenom;
byte jour, mois;
short annee;
DateOnly dateNaissance;
bool estMarie;
float taille;

// Collecte des informations...
dateNaissance = new DateOnly(annee, mois, jour);
Console.WriteLine($"{nom} {prenom}, né le {dateNaissance}");
```

---

### 03 - Conversions
**Projet:** `DemoConversions`

Méthodes de conversion entre types.

**Concepts abordés:**
- `ToString()` - Type → string
- Classe `Convert` - Type base → type base
- `Parse()` - String → type base (avec exceptions)
- `TryParse()` - String → type base (sécurisé)
- Transtypage (cast) implicite et explicite
- Boxing et Unboxing

```csharp
// 1. ToString()
int a = 42;
string aString = a.ToString();

// 2. Convert
string b = "42";
int bConverted = Convert.ToInt32(b);

// 3. Parse() - Peut lever des exceptions
string c = "42";
int cConverted = int.Parse(c);
// Exceptions possibles:
// - ArgumentNullException (si null)
// - FormatException (si format invalide)
// - OverflowException (si valeur trop grande)

// 4. TryParse() - Méthode sécurisée ✅
string d = "42";
bool success = int.TryParse(d, out int dConverted);

if (success)
{
    Console.WriteLine($"Conversion réussie: {dConverted}");
}

// Exemple pratique
Console.WriteLine("Entrez un nombre entre 0 et 10 : ");
int result = 0;
bool validValue = false;

while (!validValue)
{
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("Tu dois entrer un nombre ! Réessaie:");
    }
    
    if (result >= 0 && result <= 10) 
        validValue = true;
    else 
        Console.WriteLine("La valeur doit être entre 0 et 10 !!!");
}

// 5. Transtypage (cast)
// 5.1 Conversion implicite (sans perte de données)
int entier1 = 42;
long long1 = entier1;  // int → long (OK)

// 5.2 Conversion explicite (potentielle perte)
long long2 = 42L;
int entier2 = (int)long2;  // long → int (cast requis)

// 6. Boxing / Unboxing
// Boxing: Type valeur → type référence
int monEntier = 42;
object monObjet = monEntier;  // Boxing automatique

// Unboxing: Type référence → type valeur
int monEntier2 = (int)monObjet;  // Unboxing explicite
```

**Exercice:** `Page106ExoA`

Addition de deux nombres avec `Parse()` et `TryParse()`.

---

### 04 - Structures Conditionnelles
**Projet:** `DemoStructuresConditionnelles`

Instructions de contrôle de flux.

**Concepts abordés:**
- `if` / `else` / `else if`
- `switch` / `case` / `default`
- Opérateur ternaire (`? :`)
- Pattern matching dans switch

```csharp
// 1. if / else
if (true)
{
    Console.WriteLine("Exécution du bloc");
}
else
{
    Console.WriteLine("Ne sera pas exécuté");
}

// 2. else if (conditions multiples)
if (false)
{
    // ...
}
else if (true)
{
    Console.WriteLine("Exécution");
}
else
{
    // ...
}

// 3. Forme courte (sans accolades)
if (true) 
    Console.WriteLine("Exécution");

// 4. switch
string jour = "mercredi";

switch (jour)
{
    case "lundi": 
        Console.WriteLine("Pâtes au sucre"); 
        break;
    case "mardi": 
        Console.WriteLine("Pizza ananas"); 
        break;
    case "mercredi":
    case "jeudi":  // Cases multiples
        Console.WriteLine("Lasagne de cheval");
        break;
    default:
        Console.WriteLine("Plus d'argent");
        break;
}

// 5. switch avec pattern matching
int value = 42;

switch (value)
{
    case > 0: 
        Console.WriteLine("Valeur positive");
        break;
    case < 0: 
        Console.WriteLine("Valeur négative");
        break;
    default: 
        Console.WriteLine("Zéro");
        break;
}

// 6. Opérateur ternaire
int age = 29;
Console.WriteLine(value > 0 ? "Positif" : "Négatif");

// Ternaire imbriqué
Console.WriteLine(age < 18 ? "Mineur" : (age >= 65 ? "Senior" : "Adulte"));
```

**Exercice:** `Page116ExoA`

Vérifier si un nombre est pair ou impair.

```csharp
Console.WriteLine("Entrez un nombre:");
int.TryParse(Console.ReadLine(), out int nombre);

Console.WriteLine($"Le nombre est {(nombre % 2 == 0 ? "pair" : "impair")}");
```

---

### 05 - Opérateurs
**Projet:** `DemoOperateurs`

Tous les opérateurs disponibles en C#.

**Concepts abordés:**
- Opérateurs d'affectation et raccourcis
- Pré/post incrémentation/décrémentation
- Opérateur ternaire
- Opérateur coalesce (`??`, `??=`)
- `typeof` et `GetType()`
- Opérateur `is` et pattern matching
- Opérateur `as`
- `checked` / `unchecked`

```csharp
// 1. Opérateurs d'affectation et raccourcis
int a = 5;
a += 2;  // a = a + 2
a -= 2;  // a = a - 2
a *= 2;  // a = a * 2
a /= 2;  // a = a / 2

// 2. Pré/post incrémentation
int b = 5;
int c = ++b;  // Pré: modifie d'abord (b=6, c=6)
int d = b++;  // Post: affecte puis modifie (b=7, d=6)

int e = --b;  // Pré-décrémentation (b=6, e=6)
int f = b--;  // Post-décrémentation (b=5, f=6)

// 3. Opérateur ternaire
Console.WriteLine(true ? "Vrai" : "Faux");

// 4. Opérateur coalesce
string str = null;
string resultat = str ?? "valeur par défaut";  // "valeur par défaut"

str ??= "valeur par défaut";  // Affectation conditionnelle

// 5. typeof et GetType()
object monObjet = 42;

Type typeType = typeof(int);  // Type d'un type
Type typeValeur = monObjet.GetType();  // Type d'une valeur

if (typeValeur == typeType)
{
    Console.WriteLine($"{monObjet} est un {typeType}");
}

// 6. Opérateur is
int valeur = 42;

if (valeur is int)
{
    Console.WriteLine($"{valeur} est un entier");
}

if (valeur is ValueType)  // Vérifie la hiérarchie
{
    Console.WriteLine($"{valeur} est un type valeur");
}

if (valeur is object)  // Tout est un objet
{
    Console.WriteLine($"{valeur} est un type object");
}

// 7. Pattern matching avec is
object obj = "Hello";

if (obj is int i)
{
    Console.WriteLine($"{i} est un entier");
}
else if (obj is string s)
{
    Console.WriteLine($"{s} est une chaîne");
    s.ToUpper();
}
else if (obj is long l)
{
    Console.WriteLine($"{l} est un long");
}

// 8. Opérateur as (cast sécurisé)
object p = 12;

string? str2 = p as string;  // null si échec
int? entier2 = p as int?;     // null si échec

// 9. checked / unchecked
checked  // Vérifie les dépassements
{
    int h = int.MaxValue;
    // int j = h + 1;  // OverflowException
}

unchecked  // Ne vérifie pas
{
    int h = int.MaxValue;
    int j = h + 1;  // Débordement silencieux
    Console.WriteLine($"j: {j}");  // Valeur négative
}
```

**Projet:** `DemoPatternMatching`

Exemple pratique avec polymorphisme et pattern matching.

```csharp
// Hiérarchie: Vehicule > Voiture / Avion
List<Vehicule> garage = new List<Vehicule>();

// Remplissage aléatoire
for (int i = 0; i < 10; i++)
{
    if (Random.Shared.Next(100) < 50)
        garage.Add(new Voiture());
    else
        garage.Add(new Avion());
}

// Traitement avec pattern matching
foreach (Vehicule v in garage)
{
    v.Demarrer();
    
    if (v is Avion a)
    {
        a.Voler();
    }
    else if (v is Voiture voi)
    {
        voi.Rouler();
    }
    
    v.Arreter();
}
```

**Exercices:**
- `Page140ExoA` - Division entière, modulo et division
- `Page140ExoB` - Validation de compte BBAN belge

```csharp
// Vérification BBAN
bool checkBban(string bban)
{
    if (bban is null) return false;
    bban = bban.Replace("-", "");
    if (bban.Length != 12) return false;
    if (!long.TryParse(bban, out _)) return false;
    
    long tenFirstDigits = long.Parse(bban.Substring(0, 10));
    int twoLastDigits = int.Parse(bban.Substring(10));
    
    return (tenFirstDigits % 97 == twoLastDigits) || 
           (tenFirstDigits % 97 == 0 && twoLastDigits == 97);
}
```

---

### 06 - Structures Itératives
**Projet:** `DemoStructuresIteratives`

Les 4 types de boucles en C#.

**Concepts abordés:**
- `while` (tant que)
- `do...while` (faire...tant que)
- `for` (pour)
- `foreach` (pour chaque)

**3 éléments essentiels d'une boucle:**
1. **Initialisation** - Où je commence
2. **Condition d'arrêt** - Quand je m'arrête
3. **Modification** - Comment j'avance

```csharp
// 1. while (tant que)
int compteur = 1;  // Initialisation

while (compteur <= 10)  // Condition
{
    Console.WriteLine($"Compteur: {compteur}");
    compteur++;  // Modification
}

// Exemple pratique: validation d'entrée
Console.WriteLine("Entrez une valeur numérique: ");
while (!int.TryParse(Console.ReadLine(), out compteur))
{
    Console.WriteLine("Erreur, réessayez: ");
}

// 2. do...while (exécute au moins une fois)
do
{
    Console.WriteLine("Exécuté au moins une fois");
} while (false);

// 3. for (boucle comptée)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}

// for avec plusieurs variables
for (int i = 0, j = 1; i < 10; i++, j += 2)
{
    Console.WriteLine($"i: {i}, j: {j}");
}

// 4. foreach (parcours de collections)
string message = "C'est bientôt l'heure de la pause.";

foreach (char lettre in message)
{
    Console.Write($"{lettre}  ");
}

ArrayList liste = new ArrayList { 1, 2, 3, 4 };

foreach (var item in liste)
{
    Console.WriteLine($"item: {item}");
}
```

**Exercices:**
- `Page150ExoA` - Suite de Fibonacci (25 premiers nombres)
- `Page150ExoB` - Calcul de factorielle

```csharp
// Fibonacci
int a = 1, b = 1, c;
Console.WriteLine($"1. {a}");
Console.WriteLine($"2. {b}");

for (int i = 0; i < 23; i++)
{
    c = a + b;
    Console.WriteLine($"{i + 3}. {c}");
    a = b;
    b = c;
}

// Factorielle
Console.WriteLine("Entrez un nombre: ");
int.TryParse(Console.ReadLine(), out int nb);
int res = 1;

for (int i = 0; i < nb - 1; i++)
{
    res *= (nb - i);
}
Console.WriteLine($"!{nb} = {res}");
```

---

### 07 - Tableaux et Collections

#### 07.1 - Tableaux à une dimension
**Projet:** `DemoTableau`

Tableaux fixes de taille immuable.

**Concepts abordés:**
- Déclaration et instanciation
- Propriété `Length`
- Indexation (`[]`)
- Parcours avec `for` et `foreach`
- Collection expressions (C# 12)

```csharp
// 1. Déclaration et création
int[] monTableau = new int[10];  // Taille fixe

// 2. Taille du tableau
Console.WriteLine($"Taille: {monTableau.Length}");

// 3. Accès par index (commence à 0)
Console.WriteLine($"Premier: {monTableau[0]}");
Console.WriteLine($"Dernier: {monTableau[9]}");
// Console.WriteLine($"{monTableau[10]}");  // ❌ IndexOutOfRangeException

// 4. Modification
monTableau[0] = 42;
monTableau[1] = default(int);  // 0

// 5. Déclaration avec valeurs initiales
int[] monTableau2 = { 1, 2, 3, 4, 5 };        // Ancien
int[] monTableau3 = [ 1, 2, 3, 4, 5 ];        // C# 12 ✅

// 6. Parcours avec for
for (int i = 0; i < monTableau.Length; i++)
{
    monTableau[i] = Random.Shared.Next(100);
    Console.WriteLine($"monTableau[{i}]: {monTableau[i]}");
}

// 7. Parcours avec foreach
foreach (var entier in monTableau)
{
    Console.WriteLine($"Valeur: {entier}");
}
```

#### 07.2 - Tableaux Orthogonaux (Jagged Arrays)
**Projet:** `DemoTableauOrthogonal`

Tableaux de tableaux de tailles différentes.

```csharp
// 1. Déclaration
int[][] monTableau = new int[3][];
monTableau[0] = new int[3];     // [0, 0, 0]
monTableau[1] = new int[2];     // [0, 0]
monTableau[2] = new int[5];     // [0, 0, 0, 0, 0]

// Avec collection expressions
int[][] monTableau2 = [
    new int[3],
    [0, 0],
    [0, 0, 0, 0, 0]
];

// 2. Accès
Console.WriteLine($"monTableau[0][0]: {monTableau[0][0]}");

// 3. Taille
Console.WriteLine($"Nombre de lignes: {monTableau.Length}");       // 3
Console.WriteLine($"Taille ligne 0: {monTableau[0].Length}");      // 3
Console.WriteLine($"Taille ligne 1: {monTableau[1].Length}");      // 2

// 4. Parcours
for (int i = 0; i < monTableau.Length; i++)
{
    for (int j = 0; j < monTableau[i].Length; j++)
    {
        Console.Write($"[{i}][{j}]: {monTableau[i][j]}\t");
    }
    Console.WriteLine();
}
```

#### 07.3 - Tableaux Matriciels
**Projet:** `DemoTableauMatriciel`

Tableaux multidimensionnels de tailles identiques.

```csharp
// 1. Déclaration
int[,] monTableau = new int[2, 4];  // 2 lignes, 4 colonnes

int[,] monTableau2 = { 
    { 1, 2, 3, 4 },  // Ligne 0
    { 5, 6, 7, 8 }   // Ligne 1
};

// 2. Accès
Console.WriteLine($"monTableau2[0,2]: {monTableau2[0,2]}");  // 3

// 3. Taille
Console.WriteLine($"Total éléments: {monTableau.Length}");      // 8
Console.WriteLine($"Nombre de lignes: {monTableau.GetLength(0)}");   // 2
Console.WriteLine($"Nombre de colonnes: {monTableau.GetLength(1)}"); // 4

// 4. Parcours
for (int i = 0; i < monTableau.GetLength(0); i++)
{
    for (int j = 0; j < monTableau.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}]: {monTableau[i,j]}\t");
    }
    Console.WriteLine();
}
```

#### 07.4 - ArrayList
**Projet:** `DemoCollectionsArrayList`

Collection non générique de taille variable.

```csharp
using System.Collections;

// 1. Déclaration
ArrayList arrayList = new ArrayList();

// 2. Ajout (types mixtes)
arrayList.Add(42);      // int
arrayList.Add("hello"); // string
arrayList.Add(true);    // bool

// 3. Suppression
arrayList.Remove(42);  // Décale les autres éléments

// ⚠️ Problème: Pas de type-safety
// ✅ Solution: Utiliser List<T> à la place
```

#### 07.5 - Hashtable
**Projet:** `DemoCollectionHashtable`

Collection clé-valeur non générique.

```csharp
using System.Collections;

// 1. Déclaration
Hashtable hashtable = new Hashtable();

// 2. Ajout
hashtable.Add("0001", 42);
hashtable.Add("0002", 43);
// hashtable.Add("0001", 52);  // ❌ ArgumentException (clé existe)
// hashtable.Add(null, 52);     // ❌ ArgumentNullException

// 3. Parcours
foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine($"Clé: {item.Key} | Valeur: {item.Value}");
}

// ⚠️ Problème: Pas de type-safety
// ✅ Solution: Utiliser Dictionary<TKey, TValue>
```

#### 07.6 - Queue (File d'attente)
**Projet:** `DemoCollectionQueue`

Collection FIFO (First In, First Out).

```csharp
using System.Collections;

// 1. Déclaration
Queue queue = new Queue();  // Non-générique
Queue<string> fileAttente = new Queue<string>();  // Générique ✅

// 2. Enqueue (ajouter)
queue.Enqueue("Eliott");
queue.Enqueue("Mathieu");
queue.Enqueue("Eddy");

// 3. Dequeue (retirer le premier)
string premier = (string)queue.Dequeue();  // "Eliott"

// 4. Peek (voir sans retirer)
string suivant = (string)queue.Peek();  // "Mathieu"

// Exemple: File d'attente avec traitement aléatoire
int count = queue.Count;
for (int i = 0; i < count;)
{
    string stagiaire = (string)queue.Peek();
    Console.WriteLine($"C'est au tour de {stagiaire}");
    
    if (Random.Shared.Next(100) > 50)
    {
        Console.WriteLine("Le problème a été traité.");
        queue.Dequeue();
        i++;
    }
    else
    {
        Console.WriteLine("Problème non traité, réessaie.");
    }
}
```

#### 07.7 - Stack (Pile)
**Projet:** `DemoCollectionStack`

Collection LIFO (Last In, First Out).

```csharp
using System.Collections;

// 1. Déclaration
Stack stack = new Stack();
Stack<string> pileAssiettes = new Stack<string>();  // Générique ✅

// 2. Push (empiler)
stack.Push("Assiette 1");
stack.Push("Assiette 2");
stack.Push("Assiette 3");
stack.Push("Assiette 4");

// 3. Pop (dépiler - retire le dernier)
string derniere = (string)stack.Pop();  // "Assiette 4"

// 4. Peek (voir sans retirer)
string suivante = (string)stack.Peek();  // "Assiette 3"

// Exemple: Nettoyage d'assiettes avec probabilité d'échec
int count = stack.Count;
for (int i = 0; i < count;)
{
    string item = (string)stack.Peek();
    Console.WriteLine($"Nettoyage de : {item}");
    
    if (Random.Shared.Next(100) > 30)
    {
        Console.WriteLine("Nettoyage réussi");
        stack.Pop();
        i++;
    }
    else
    {
        Console.WriteLine("Les tâches sont tenaces...");
    }
}
```

#### 07.8 - List<T> (Collection Générique)
**Projet:** `DemoCollectionGeneriqueList`

Version générique et type-safe d'ArrayList.

```csharp
// 1. Déclaration
List<string> jours = new List<string>();
List<double> nombres = new();  // Inférence de type (C# 9)

// 2. Ajout
jours.Add("Lundi");
jours.AddRange(["Mardi", "Mercredi", "Jeudi", "Vendredi"]);  // C# 12

// 3. Accès par index
string aujourdhui = jours[4];  // "Vendredi"

// 4. Avantages vs ArrayList
// ✅ Type-safety (pas de cast nécessaire)
// ✅ Performance (pas de boxing/unboxing)
// ✅ IntelliSense amélioré
```

#### 07.9 - Dictionary<TKey, TValue>
**Projet:** `DemoCollectionGeneriqueDictionary`

Version générique et type-safe de Hashtable.

```csharp
// 1. Déclaration
Dictionary<string, string?> monDictionnaire = new();

// 2. Ajout
monDictionnaire.Add("0001", "Eliott");
monDictionnaire.Add("0002", "Ibrahima");
monDictionnaire.Add("0003", "Selena");

// 3. Accès
string nom = monDictionnaire["0001"] ?? "Aucun utilisateur trouvé.";

// 4. Parcours
foreach (KeyValuePair<string, string?> p in monDictionnaire)
{
    Console.WriteLine($"Clé: {p.Key} - Valeur: {p.Value}");
}

// 5. Avantages vs Hashtable
// ✅ Type-safety
// ✅ Pas de cast nécessaire
// ✅ Performance
```

**Exercices:**
- `ExerciceBonusTableau3Scores` - Moyenne de scores de joueurs
- `ExerciceBonusCollection4Et5` - Inversion et tri de tableau

---

### 08 - Énumérations
**Projet:** `DemoEnum`

Liste de valeurs immuables et nommées.

**Concepts abordés:**
- Déclaration d'énumérations
- Valeurs personnalisées
- Conversion et parsing
- Énumérations avec flags
- Méthodes `Enum.GetNames()`, `Enum.GetValues()`

```csharp
// 1. Déclaration d'énumération
public enum Languages
{
    FRENCH = 1,   // Valeur explicite
    ENGLISH,      // 2 (auto-incrémenté)
    DUTCH,        // 3
    ITALIAN,      // 4
    JAPANESE      // 5
}

// 2. Utilisation
Languages language = Languages.FRENCH;

switch (language)
{
    case Languages.FRENCH:
        Console.WriteLine("Bonjour");
        break;
    case Languages.ENGLISH:
        Console.WriteLine("Hello");
        break;
    case Languages.ITALIAN:
        Console.WriteLine("Buongiorno");
        break;
}

// 3. Itération sur une énumération
foreach (Languages langue in Enum.GetValues<Languages>())
{
    Console.WriteLine($" - {langue} - {(int)langue}");
}

// 4. Récupération depuis le clavier
Console.WriteLine("Sélectionnez une langue:");
string userInput = Console.ReadLine();

while (!Enum.IsDefined(typeof(Languages), userInput.ToUpper()))
{
    Console.WriteLine("Erreur, réessayez: ");
    userInput = Console.ReadLine();
}

Languages selected = Enum.Parse<Languages>(userInput.ToUpper());

// 5. Énumérations avec flags (combinaisons)
[Flags]
public enum Rights
{
    None = 0,      // 0000 0000
    Read = 1,      // 0000 0001
    Write = 2,     // 0000 0010
    Execute = 4    // 0000 0100
}

// Utilisation des flags
Rights userRights = Rights.Read;
Rights adminRights = Rights.Read | Rights.Write | Rights.Execute;

// Vérification
if (adminRights.HasFlag(Rights.Write))
{
    Console.WriteLine("L'admin peut écrire");
}

// Utilisation dans un modèle
public class Personne
{
    public string LastName = "Anonyme";
    public string FirstName = "Anonyme";
    public Rights Rights = Rights.None;
}

Personne admin = new Personne
{
    LastName = "Geerts",
    FirstName = "Quentin",
    Rights = Rights.Read | Rights.Write | Rights.Execute
};

// Vérification des droits
if (admin.Rights.HasFlag(Rights.Execute))
{
    Console.WriteLine($"{admin.FirstName} peut exécuter");
}
```

---

### 09 - Méthodes
**Projet:** `DemoMethodes`

Déclaration, paramètres et surcharge de méthodes.

**Concepts abordés:**
- Déclaration et invocation
- Méthodes avec/sans retour
- Opérateur null-conditionnel (`?.`)
- Paramètres obligatoires et optionnels
- Paramètres nommés
- Mots-clés: `in`, `params`, `ref`, `out`
- Surcharge de méthodes

```csharp
// 1. Déclaration
void maMethode()  // Procédure (sans retour)
{
    Console.WriteLine("Exécution");
}

int maMethode2()  // Fonction (avec retour)
{
    return 42;
}

// 2. Invocation
maMethode();  // Exécution
int resultat = maMethode2();  // Récupération du retour

// 3. Opérateur null-conditionnel
string str = null;
// str.ToUpper();   // ❌ NullReferenceException
str?.ToUpper();     // ✅ Retourne null si str est null

// 4. Paramètres
void maMethode3(string s, int i)
{
    Console.WriteLine($"s: {s}, i: {i}");
}

maMethode3("Hello", 42);           // Position
maMethode3(i: 42, s: "Hello");     // Nommés

// 5. Paramètres optionnels
void maMethode4(int i, string s = null)  // s est optionnel
{
    if (s == null) 
        Console.WriteLine("Pas de valeur");
    else 
        Console.WriteLine($"s: {s}");
}

maMethode4(42, "Hello");  // Avec paramètre optionnel
maMethode4(42);           // Sans paramètre optionnel

// 6. Mot-clé "in" (immuable)
void maMethode5(in int i)
{
    // i = 5;  // ❌ Impossible de modifier
    Console.WriteLine($"i: {i}");
}

// 7. Mot-clé "params" (nombre variable d'arguments)
void maMethode6(params object[] objs)
{
    foreach (object o in objs)
    {
        Console.WriteLine($"- {o}: {o.GetType()}");
    }
}

maMethode6(42, "Hello", true, 42.2);
maMethode6();  // OK sans arguments

double addition(params double[] values)
{
    return values.Sum();
}

// 8. Mot-clé "ref" (passage par référence)
// Types valeur: Passage par valeur par défaut
void passageParValeur(int i)
{
    Console.WriteLine($"i: {i}");  // 42
    i = 0;
    Console.WriteLine($"i: {i}");  // 0
}

void passageParReference(ref int i)
{
    Console.WriteLine($"i: {i}");  // 42
    i = 0;
    Console.WriteLine($"i: {i}");  // 0
}

// Utilisation
int a = 42;
passageParValeur(a);
Console.WriteLine($"a: {a}");  // 42 (inchangé)

passageParReference(ref a);
Console.WriteLine($"a: {a}");  // 0 (modifié)

// 9. Mot-clé "out" (valeur de retour multiple)
bool equationSecondDegre(double a, double b, double c, 
                         out double? x1, out double? x2)
{
    x1 = null;  // Obligation d'initialiser
    x2 = null;
    
    if (a == 0) return false;
    
    double discriminant = (b * b) - (4 * a * c);
    
    if (discriminant < 0) 
        return false;
    else if (discriminant == 0) 
        x1 = -b / (2 * a);
    else
    {
        x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    }
    
    return true;
}

// Utilisation
if (equationSecondDegre(2, -1, -6, out double? x1, out double? x2))
{
    if (x2 != null)
        Console.WriteLine($"2 solutions: {x1}, {x2}");
    else
        Console.WriteLine($"1 solution: {x1}");
}
else
{
    Console.WriteLine("Aucune solution");
}

// 10. Surcharge de méthodes
public class MaClasse
{
    public void DireBonjour()
    {
        Console.WriteLine("Bonjour");
    }
    
    public void DireBonjour(string destinataire)
    {
        Console.WriteLine($"Bonjour {destinataire}");
    }
    
    public void DireBonjour(string expediteur, string destinataire)
    {
        Console.WriteLine($"{expediteur} dit bonjour à {destinataire}");
    }
    
    public void DireBonjour(int nbRepetition)
    {
        Console.WriteLine(string.Join("..", Enumerable.Repeat("Bonjour", nbRepetition)));
    }
}

// Utilisation
MaClasse obj = new MaClasse();
obj.DireBonjour();                    // Bonjour
obj.DireBonjour("Eliott");            // Bonjour Eliott
obj.DireBonjour("Kevin", "Kevin");    // Kevin dit bonjour à Kevin
obj.DireBonjour(3);                   // Bonjour..Bonjour..Bonjour
```

**Projet:** `Methodes` (Exercice)

Méthodes utilitaires : vérifier si un nombre est pair et premier.

```csharp
bool estPair(int entier)
{
    return entier % 2 == 0;
}

bool estPremier(int nb)
{
    if (nb < 0) 
        throw new Exception("Un nombre premier ne peut pas être négatif");
    if (nb <= 2) 
        return false;
    
    for (int i = 2; i <= Math.Sqrt(nb); i++)
    {
        if (nb % i == 0) return false;
    }
    
    return true;
}

// Utilisation
Console.WriteLine($"42 est pair ? {estPair(42)}");

for (int i = 0; i < 100; i++)
{
    if (estPremier(i)) 
        Console.WriteLine($"{i} est premier");
}
```

---

### 10 - Structures
**Projet:** `DemoStructures`

Types valeur personnalisés.

**Concepts abordés:**
- Déclaration avec `struct`
- Différence avec les classes (type valeur vs référence)
- Passage par valeur
- Méthodes dans les structures

```csharp
// 1. Déclaration
public struct Contact
{
    public string LastName;
    public string FirstName;
    public string Email;
    public string PhoneNumber;
    public DateOnly BirthDate;
    
    public string Informations()
    {
        return $"Contact: {LastName} {FirstName}";
    }
}

// 2. Instanciation et utilisation
Contact c1 = new Contact();
c1.FirstName = "Quentin";
c1.LastName = "Geerts";
c1.Email = "quentin.geerts@bstorm.be";
c1.BirthDate = new DateOnly(1996, 4, 3);

Console.WriteLine(c1.Informations());

// Avec initialiseur d'objet
Contact c2 = new Contact
{
    FirstName = "John",
    LastName = "Doe"
};

// 3. Passage par valeur (copie)
void passageParStruct(Contact c)
{
    Console.WriteLine($"{c.FirstName}");  // Quentin
    c.FirstName = "Technofutur";
    Console.WriteLine($"{c.FirstName}");  // Technofutur
}

Console.WriteLine($"c1: {c1.FirstName}");  // Quentin
passageParStruct(c1);
Console.WriteLine($"c1: {c1.FirstName}");  // Quentin (inchangé)

// Différences struct vs class:
// Struct (type valeur):
// - Stockée sur la pile (stack)
// - Copiée lors du passage en paramètre
// - Pas d'héritage possible
// - Performance pour petits objets

// Class (type référence):
// - Stockée sur le tas (heap)
// - Référence passée en paramètre
// - Héritage possible
// - Meilleure pour objets complexes
```

---

## 🏋️ Exercices Pratiques

### Exercices Bonus

#### ExerciceBonus01Bissextile
**Objectif:** Déterminer si une année est bissextile.

**Règles:**
- Divisible par 4, mais non divisible par 100
- OU divisible par 400

```csharp
Console.WriteLine("Entrez une année : ");
int annee = int.Parse(Console.ReadLine()!);

bool estDivPar4 = annee % 4 == 0;
bool estDivPar100 = annee % 100 == 0;
bool estDivPar400 = annee % 400 == 0;

if (estDivPar4 && !estDivPar100 || estDivPar400)
{
    Console.WriteLine($"{annee} est bissextile");
}
else
{
    Console.WriteLine($"{annee} n'est pas bissextile");
}
```

---

#### ExerciceBonus02LanceurBalles
**Objectif:** Simuler un lanceur de balles de tennis.

**États:**
- `pret` : le joueur est prêt
- `panierVide` : il reste des balles

```csharp
Console.WriteLine("Es-tu prêt ? (true / false)");
bool pret = bool.Parse(Console.ReadLine()!);

Console.WriteLine("As-tu des balles ? (true / false)");
bool panierVide = !bool.Parse(Console.ReadLine()!);

if (pret && !panierVide)
{
    Console.WriteLine("Lancer la balle");
}
else
{
    Console.WriteLine("Ne pas lancer la balle");
    
    if (!pret)
        Console.WriteLine("Car tu n'es pas prêt");
    if (panierVide)
        Console.WriteLine("Car le panier est vide");
}
```

---

#### ExerciceBonusTableau3Scores
**Objectif:** Calculer la moyenne des scores de joueurs.

**Fonctionnalités:**
- Demander le nombre de joueurs (max 10)
- Collecter les scores
- Calculer et afficher la moyenne

```csharp
int nbJoueurs = 0;
bool valide = false;
double somme = 0, moyenne = 0;

// Demander le nombre de joueurs
Console.WriteLine("Entrez le nombre de joueurs (max: 10): ");

while (!valide)
{
    while (!int.TryParse(Console.ReadLine(), out nbJoueurs))
    {
        Console.WriteLine("Erreur, réessayez: ");
    }
    
    if (nbJoueurs > 0 && nbJoueurs <= 10) 
        valide = true;
    else 
        Console.WriteLine("Vous devez entrer un nombre entre 1 et 10: ");
}

double[] scores = new double[nbJoueurs];

// Collecter les scores
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Entrez le score du joueur n°{i + 1}:");
    double score;
    while (!double.TryParse(Console.ReadLine(), out score))
    {
        Console.WriteLine("Erreur, réessayez:");
    }
    scores[i] = score;
    somme += score;
}

// Calcul de la moyenne
moyenne = somme / scores.Length;

Console.WriteLine($"Scores: {string.Join(", ", scores)}");
Console.WriteLine($"Moyenne des scores: {moyenne}");
```

---

#### ExerciceBonusCollection4Et5
**Objectif:** Inverser et trier un tableau.

```csharp
List<int> ints = new();

// Remplissage aléatoire
for (int i = 0; i < 10; i++)
{
    ints.Add(Random.Shared.Next(100));
}

Console.WriteLine($"Liste actuelle: {string.Join(", ", ints)}");

// Inversion
ints.Reverse();
Console.WriteLine($"Liste renversée: {string.Join(", ", ints)}");

// Tri
ints.Sort();
Console.WriteLine($"Liste triée: {string.Join(", ", ints)}");
```

---

## 📦 Projet Récapitulatif - BookManager

**Objectif:** Application complète de gestion de livres utilisant tous les concepts du cours.

### Structure du Projet

```
BookManager/
├── Enums/
│   ├── Menu.cs
│   └── Status.cs
├── Models/
│   └── Book.cs
└── Program.cs
```

### Fonctionnalités

1. **Afficher tous les livres**
2. **Afficher uniquement les livres terminés**
3. **Afficher les livres par statut**
4. **Changer le statut d'un livre**
5. **Quitter l'application**

### Code Complet

**Enums/Status.cs**
```csharp
public enum Status
{
    NotStarted,   // Pas commencé
    InProgress,   // En cours
    Completed,    // Terminé
    Abandoned     // Abandonné
}
```

**Enums/Menu.cs**
```csharp
public enum Menu
{
    None,
    GetAllBooks,
    GetCompletedBooks,
    GetBooksByStatus,
    UpdateBookStatus,
    Quit
}
```

**Models/Book.cs**
```csharp
public struct Book
{
    public string Title;
    public string Author;
    public int NbPages;
    public Status Status;
    
    public string DisplayInformation()
    {
        return $"[{Status}] {Title} de {Author} ({NbPages} pages)";
    }
    
    public void UpdateStatus(Status newStatus)
    {
        if (!Enum.IsDefined(typeof(Status), newStatus)) return;
        Status = newStatus;
    }
    
    public bool IsRead()
    {
        return Status == Status.Completed;
    }
}
```

**Program.cs**
```csharp
List<Book> books = new List<Book>();

#region Création des livres
Book b1 = new Book
{
    Title = "L'épée de vérité",
    Author = "Terry GoodKind",
    NbPages = 576,
    Status = Status.InProgress
};

Book b2 = new Book
{
    Title = "Le Petit Prince",
    Author = "Antoine de Saint-Exupéry",
    NbPages = 96,
    Status = Status.Completed
};

books.AddRange([b1, b2, /* ... */]);
#endregion

#region Menu
Menu userInput = Menu.None;

while (userInput != Menu.Quit)
{
    Console.WriteLine(" --- Gestionnaire de livres --- ");
    Console.WriteLine(" 1. Afficher tous les livres");
    Console.WriteLine(" 2. Afficher uniquement les livres terminés");
    Console.WriteLine(" 3. Afficher les livres par statut");
    Console.WriteLine(" 4. Changer le statut d'un livre");
    Console.WriteLine(" 5. Quitter");
    
    Console.Write("Choix: ");
    while (!Enum.TryParse(Console.ReadLine(), true, out userInput))
    {
        Console.Write("Erreur, réessayez: ");
    }
    
    switch (userInput)
    {
        case Menu.GetAllBooks:
            Console.WriteLine(" --- Liste des livres ---");
            DisplayBooks();
            Pause();
            break;
            
        case Menu.GetCompletedBooks:
            Console.WriteLine(" --- Liste des livres terminés ---");
            DisplayBooks(Status.Completed);
            Pause();
            break;
            
        case Menu.GetBooksByStatus:
            Console.WriteLine(" --- Liste des livres filtrées ---");
            Status status = GetStatus();
            DisplayBooks(status);
            Pause();
            break;
            
        case Menu.UpdateBookStatus:
            Console.WriteLine(" --- Mise à jour du statut ---");
            DisplayBooks();
            
            Console.Write("Entrez le nom du livre à modifier: ");
            string bookTitle = Console.ReadLine()!;
            
            Book selectedBook;
            int index;
            while (!ContainsBook(bookTitle, out selectedBook, out index))
            {
                Console.Write("Introuvable, réessayez: ");
                bookTitle = Console.ReadLine()!;
            }
            
            Console.WriteLine($"Livre sélectionné: {selectedBook.Title}");
            Status newStatus = GetStatus();
            
            selectedBook.Status = newStatus;
            books.RemoveAt(index);
            books.Insert(index, selectedBook);
            
            Console.WriteLine("Le statut a été mis à jour.");
            Pause();
            break;
            
        case Menu.Quit:
            Console.WriteLine("Au revoir !");
            break;
    }
}
#endregion

#region Utilitaires
void Pause()
{
    Console.WriteLine("Appuyez sur une touche pour continuer...");
    Console.ReadLine();
    Console.Clear();
}

bool ContainsBook(string title, out Book selectedBook, out int index)
{
    foreach (Book book in books)
    {
        if (book.Title == title)
        {
            selectedBook = book;
            index = books.IndexOf(book);
            return true;
        }
    }
    selectedBook = default;
    index = -1;
    return false;
}

Status GetStatus()
{
    Console.WriteLine("Liste des status: ");
    foreach (Status s in Enum.GetValues<Status>())
    {
        Console.WriteLine($"{(int)s}. {s}");
    }
    
    Console.Write("Choix: ");
    Status status;
    while (!Enum.TryParse(Console.ReadLine(), true, out status))
    {
        Console.Write("Erreur, réessayez: ");
    }
    return status;
}

void DisplayBooks(Status? status = null)
{
    foreach (Book book in books)
    {
        if ((status != null && book.Status == status) || status == null)
        {
            Console.WriteLine($" - {book.DisplayInformation()}");
        }
    }
}
#endregion
```

### Concepts Utilisés

✅ **Variables** - Déclaration, types, nullable  
✅ **Conversions** - TryParse pour saisie sécurisée  
✅ **Structures conditionnelles** - if, switch  
✅ **Opérateurs** - Comparaison, logiques, ternaire  
✅ **Boucles** - while, foreach  
✅ **Collections** - List<T>  
✅ **Énumérations** - Status, Menu, TryParse  
✅ **Méthodes** - Avec/sans retour, paramètres, out  
✅ **Structures** - Book (struct)  

---

## 🛠️ Technologies Utilisées

- **.NET 10.0** - Framework de développement
- **C# 12** - Langage de programmation
- **Visual Studio 2025** - IDE recommandé
- **Top-Level Statements** - Syntaxe simplifiée
- **Implicit Usings** - Imports automatiques
- **Nullable Reference Types** - Sécurité des null

### Fonctionnalités C# Utilisées

| Fonctionnalité | Version C# | Exemples |
|---------------|-----------|----------|
| Top-Level Statements | C# 9 | Pas de classe Program explicite |
| Collection expressions | C# 12 | `int[] nums = [1, 2, 3];` |
| String interpolation | C# 6 | `$"Hello {name}"` |
| Null-conditional operator | C# 6 | `obj?.Method()` |
| Null-coalescing operator | C# 6 | `value ?? default` |
| Pattern matching | C# 7+ | `if (obj is int i)` |
| Expression-bodied members | C# 6-7 | `int Add(int a, int b) => a + b;` |

---

## 📥 Installation

### Prérequis
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Un IDE : [Visual Studio 2025](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Cloner le Projet
```bash
git clone https://github.com/votre-username/SAP250026_DevenirDev__CSharp.git
cd SAP250026_DevenirDev__CSharp
```

### Ouvrir la Solution
```bash
# Avec Visual Studio
start SAP250026_DevenirDev__CSharp.slnx

# Avec VS Code
code .

# Avec CLI
dotnet build
```

### Exécuter un Projet
```bash
# Exemple: lancer BookManager
cd BookManager
dotnet run

# Ou avec le chemin complet
dotnet run --project BookManager/BookManager.csproj
```

---

## 📖 Guide d'Apprentissage

### Progression Recommandée

#### 🟢 Semaine 1 - Bases
**Objectif:** Maîtriser les fondamentaux

1. ✅ **Introduction** - Console, commentaires
2. ✅ **Variables** - Types, déclaration, constantes
3. ✅ **Conversions** - Parse, TryParse, ToString
4. ✅ **Structures conditionnelles** - if/else, switch

**Exercices:**
- ExerciceInformationsUtilisateur
- Page106ExoA
- Page116ExoA

---

#### 🟡 Semaine 2 - Contrôle de flux
**Objectif:** Maîtriser les boucles et opérateurs

5. ✅ **Opérateurs** - Arithmétiques, logiques, typeof, is
6. ✅ **Boucles** - while, for, foreach

**Exercices:**
- Page140ExoA et B (BBAN)
- Page150ExoA (Fibonacci)
- Page150ExoB (Factorielle)
- ExerciceBonus01Bissextile
- ExerciceBonus02LanceurBalles

---

#### 🔵 Semaine 3 - Collections
**Objectif:** Manipuler des données structurées

7. ✅ **Tableaux** - Simple, orthogonal, matriciel
8. ✅ **Collections non génériques** - ArrayList, Hashtable, Queue, Stack
9. ✅ **Collections génériques** - List<T>, Dictionary<TKey,TValue>

**Exercices:**
- ExerciceBonusTableau3Scores
- ExerciceBonusCollection4Et5

---

#### 🟣 Semaine 4 - Concepts avancés
**Objectif:** Structurer le code

10. ✅ **Énumérations** - Enum, flags, parsing
11. ✅ **Méthodes** - Paramètres, surcharge, ref/out
12. ✅ **Structures** - struct vs class

**Exercices:**
- Methodes (pair/premier)

---

#### 🔴 Semaine 5 - Projet final
**Objectif:** Intégrer tous les concepts

13. ✅ **BookManager** - Application complète

---

## 🎯 Objectifs Pédagogiques

À la fin de ce cours, vous serez capable de:

- ✅ Écrire des programmes C# fonctionnels
- ✅ Utiliser les types de données appropriés
- ✅ Gérer les conversions de manière sécurisée
- ✅ Implémenter des structures conditionnelles et itératives
- ✅ Manipuler des tableaux et collections
- ✅ Créer et utiliser des énumérations
- ✅ Structurer votre code avec des méthodes
- ✅ Choisir entre structures et classes
- ✅ Développer des applications console complètes

---

## 📚 Ressources Complémentaires

### Documentation Officielle
- [Documentation C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
- [Documentation .NET](https://docs.microsoft.com/fr-fr/dotnet/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

---

## 📝 Licence

Ce projet est sous licence **Educational** - voir le fichier [LICENSE](LICENSE) pour plus de détails.

---

## 👨‍🏫 Formateur

**Quentin Geerts**  
Formation: SAP250026 - Devenir Développeur

---

<div align="center">

**⭐ Bon apprentissage du C# ! ⭐**

Made with ❤️ for learning C# fundamentals

</div>
