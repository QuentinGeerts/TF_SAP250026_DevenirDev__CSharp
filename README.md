# TF SAP250026 - Formation C# Devenir Dev

Repository de formation C# contenant des démonstrations et des exercices pratiques sur les concepts fondamentaux du langage.

## 📚 Structure du projet

### 🎯 Démonstrations

#### Concepts de base
- **DemoIntroduction** - Introduction à C# et premiers pas
- **DemoIntroductionWithoutTopLevel** - Introduction sans l'utilisation des top-level statements
- **DemoVariables** - Déclaration et manipulation de variables
- **DemoConversions** - Conversions de types (casting, parsing)
- **DemoOperateurs** - Opérateurs arithmétiques, logiques et de comparaison
- **DemoPatternMatching** - Utilisation du pattern matching en C#

#### Structures de contrôle
- **DemoStructuresConditionnelles** - Structures if, switch, et conditions
- **DemoStructuresIteratives** - Boucles for, while, foreach

#### Tableaux et Collections
- **DemoTableau** - Manipulation de tableaux simples (Démonstration 07.1)
- **DemoTableauOrthogonal** - Tableaux orthogonaux/jagged arrays (Démonstration 07.2)
- **DemoTableauMatriciel** - Tableaux multidimensionnels/matrices (Démonstration 07.3)

##### Collections de base
- **DemoCollectionsArrayList** - Collection ArrayList (dynamique, non typée)
- **DemoCollectionStack** - Collection Stack (LIFO - Last In First Out)
- **DemoCollectionQueue** - Collection Queue (FIFO - First In First Out)
- **DemoCollectionHashtable** - Collection Hashtable (clé-valeur)

##### Collections génériques
- **DemoCollectionGeneriqueList** - List<T> (collection générique typée)
- **DemoCollectionGeneriqueDictionary** - Dictionary<TKey, TValue> (collection clé-valeur typée)

#### Concepts avancés (⭐ Nouveautés récentes)
- **DemoEnum** - ⭐ **Démonstration 08 - Énumérations**
  - Déclaration et utilisation d'énumérations
  - Itération sur les valeurs d'une énumération
  - Utilisation des flags avec l'attribut [Flags]
  - Validation et parsing d'énumérations

- **DemoMethodes** - ⭐ **Démonstration 09 - Méthodes**
  - Déclaration et invocation de méthodes
  - Paramètres obligatoires, optionnels et nommés
  - Mot-clés `in`, `ref`, `out` et `params`
  - Passage par valeur vs passage par référence
  - Surcharge de méthodes
  - Opérateur null conditionnel (`?.`)

- **DemoStructures** - ⭐ **Démonstration 10 - Structures**
  - Déclaration de structures (struct)
  - Différence entre struct et class
  - Passage par valeur des structures
  - Initialisation d'objets

### 📝 Exercices

#### Exercices du manuel
- **Page106ExoA** - Exercice A page 106
- **Page116ExoA** - Exercice A page 116
- **Page140ExoA** - Exercice A page 140 (structures conditionnelles)
- **Page140ExoB** - Exercice B page 140 (structures conditionnelles)
- **Page150ExoA** - Exercice A page 150 (boucles)
- **Page150ExoB** - Exercice B page 150 (boucles)

#### Exercices bonus
- **ExerciceBonus01Bissextile** - Détermination des années bissextiles
- **ExerciceBonus02LanceurBalles** - Simulation de lanceur de balles
- **ExerciceBonusTableau3Scores** - ⭐ Gestion de scores avec tableaux (correction récente)
- **ExerciceBonusCollection4Et5** - ⭐ Exercices 4 et 5 sur les collections (correction récente)

#### Exercices pratiques
- **ExerciceInformationsUtilisateur** - Collecte et affichage d'informations utilisateur
- **Methodes** - Exercices pratiques sur les méthodes

### 🎓 Projet récapitulatif

- **BookManager** - ⭐ **Gestionnaire de livres (Exercice récapitulatif)**
  - Application console complète utilisant les concepts appris
  - Gestion d'une collection de livres avec statuts
  - Menu interactif avec énumérations
  - Filtrage et mise à jour de données
  - Utilisation de structures, méthodes et collections génériques

### 🗑️ Divers
- **ASupprimer** - Dossier temporaire à supprimer

## 🚀 Utilisation

Chaque projet est une application console C# indépendante. Pour exécuter un projet :

```bash
cd [NomDuProjet]
dotnet run
```

Pour compiler un projet :

```bash
cd [NomDuProjet]
dotnet build
```

## 📖 Progression de la formation

Les démonstrations sont numérotées et suivent une progression logique :

1. **Introduction et bases** (Variables, Opérateurs, Conversions)
2. **Structures de contrôle** (Conditionnelles, Itératives)
3. **Tableaux** (Simples, Orthogonaux, Matriciels)
4. **Collections** (ArrayList, Stack, Queue, Hashtable)
5. **Collections génériques** (List<T>, Dictionary<TKey,TValue>)
6. **Énumérations** (Démonstration 08)
7. **Méthodes** (Démonstration 09)
8. **Structures** (Démonstration 10)

## 🔄 Mises à jour récentes

- ✅ Ajout de la démonstration sur les énumérations (DemoEnum)
- ✅ Ajout de la démonstration sur les méthodes (DemoMethodes)
- ✅ Ajout de la démonstration sur les structures (DemoStructures)
- ✅ Création du projet récapitulatif BookManager
- ✅ Correction des exercices bonus sur les collections (4 et 5)
- ✅ Correction de l'exercice bonus sur les tableaux (scores)
- ✅ Correction de l'exercice récapitulatif BookManager

## 📋 Prérequis

- .NET SDK 8.0 ou supérieur
- Un IDE C# (Visual Studio, Visual Studio Code, Rider, etc.)

## 👨‍💻 Auteur

Formation Technofutur TIC - SAP250026 Devenir Dev
