# SAP250026 - Devenir Développeur C#

## 📚 Structure du Repository

Ce repository contient l'ensemble des démonstrations et exercices du cours de développement C# organisés par modules thématiques.

---

## 📂 Organisation des Modules

### 01 - Introduction
**Démonstrations:**
- `DemoIntroduction` - Premiers pas avec C# (Console, ReadLine, WriteLine, Clear)
- `DemoIntroductionWithoutTopLevel` - Structure traditionnelle d'un programme C# sans Top-Level Statements
- `ASupprimer` - Projet de test

**Concepts abordés:**
- Utilisation de la console
- Commentaires
- Structure de base d'un programme C#
- Top-Level Statements vs structure traditionnelle

---

### 02 - Variables
**Démonstrations:**
- `DemoVariables` - Déclaration, affectation, portée, constantes et nullable

**Exercices:**
- `ExerciceInformationsUtilisateur` - Collecte et affichage d'informations utilisateur

**Concepts abordés:**
- Déclaration et initialisation
- Types de données (string, byte, short, int, bool, float, DateOnly)
- Portée des variables
- Constantes (const)
- Types nullable

---

### 03 - Conversions
**Démonstrations:**
- `DemoConversions` - Toutes les méthodes de conversion en C#

**Exercices:**
- `Page106ExoA` - Conversion avec Parse() et TryParse()

**Concepts abordés:**
- ToString()
- Classe Convert
- Parse() et TryParse()
- Transtypage (cast)
- Conversions implicites et explicites
- Boxing et Unboxing

---

### 04 - Structures Conditionnelles
**Démonstrations:**
- `DemoStructuresConditionnelles` - Instructions if, else, else if, switch et opérateur ternaire

**Exercices:**
- `Page116ExoA` - Déterminer si un nombre est pair ou impair

**Concepts abordés:**
- if / else / else if
- switch / case
- Opérateur ternaire
- Pattern matching dans les conditions

---

### 05 - Opérateurs
**Démonstrations:**
- `DemoOperateurs` - Tous les opérateurs C#
- `DemoPatternMatching` - Pattern matching avec polymorphisme

**Exercices:**
- `Page140ExoA` - Division entière, modulo et division
- `Page140ExoB` - Validation de compte BBAN

**Concepts abordés:**
- Opérateurs d'affectation et raccourcis (+=, -=, *=, /=)
- Pré/post incrémentation et décrémentation (++, --)
- Opérateur ternaire (? :)
- Opérateur coalesce (??, ??=)
- typeof et GetType()
- Opérateur is et pattern matching
- Opérateur as
- checked / unchecked

---

### 06 - Structures Itératives
**Démonstrations:**
- `DemoStructuresIteratives` - Boucles while, do-while, for et foreach

**Exercices:**
- `Page150ExoA` - Suite de Fibonacci (25 premiers nombres)
- `Page150ExoB` - Calcul de factorielle

**Concepts abordés:**
- while
- do...while
- for (simple et multiple)
- foreach
- Parcours de chaînes de caractères
- Parcours de collections

---

### 07 - Tableaux
**Démonstrations:**
- `DemoTableau` - Tableaux à une dimension
- `DemoTableauOrthogonal` - Tableaux orthogonaux (jagged arrays)
- `DemoTableauMatriciel` - Tableaux multidimensionnels
- `DemoCollectionsArrayList` - Collection ArrayList
- `DemoCollectionHashtable` - Collection Hashtable
- `DemoCollectionQueue` - Collection Queue (FIFO)
- `DemoCollectionStack` - Collection Stack (LIFO)
- `DemoCollectionGeneriqueList` - Collection générique List<T>
- `DemoCollectionGeneriqueDictionary` - Collection générique Dictionary<TKey, TValue>

**Exercices:**
- `ExerciceBonusTableau3Scores` - Moyenne de scores de joueurs

**Concepts abordés:**
- Tableaux à une dimension
- Tableaux orthogonaux (int[][])
- Tableaux matriciels (int[,])
- ArrayList (collection non typée)
- Hashtable (clé-valeur non typé)
- Queue (file d'attente FIFO)
- Stack (pile LIFO)
- List<T> (collection générique)
- Dictionary<TKey, TValue> (collection générique clé-valeur)
- Propriété Length et méthode GetLength()
- Collection expressions

---

## 🛠️ Technologies

- **Framework**: .NET 10.0
- **Langage**: C#
- **Features activées**:
  - Implicit Usings
  - Nullable Reference Types
  - Collection Expressions
  - Top-Level Statements

---

## 📋 Configuration

Tous les projets utilisent la configuration suivante:
```xml
<PropertyGroup>
  <OutputType>Exe</OutputType>
  <TargetFramework>net10.0</TargetFramework>
  <ImplicitUsings>enable</ImplicitUsings>
  <Nullable>enable</Nullable>
</PropertyGroup>
```

Certains projets (DemoOperateurs) ont la vérification de dépassement arithmétique activée:
```xml
<CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
```

---

## 📖 Ressources

- [Documentation officielle C#](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
- [Documentation .NET](https://docs.microsoft.com/fr-fr/dotnet/)
- [Code source](https://source.dot.net/)

---

*Repository de formation - SAP250026*
