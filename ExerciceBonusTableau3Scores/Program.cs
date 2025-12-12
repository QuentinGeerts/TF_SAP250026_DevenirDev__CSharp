/*
 * Écrire un algorithme demandant à l’utilisateur le nombre de joueurs (max 10 joueurs).
 * Ensuite, l’algorithme doit demander à l’utilisateur le score de chaque joueur. 
 * Une fois ceci fini, il faut afficher la moyenne des scores.
 */

string format = "";
int nbJoueurs = 0;
bool valide = false;
double somme = 0, moyenne = 0;

// Demander à l'utiliser le nombre de joueurs
Console.WriteLine($"Entrez le nombre de joueurs (max: 10): ");

while (!valide )
{
    while (!int.TryParse(Console.ReadLine(), out nbJoueurs))
    {
        Console.WriteLine($"Erreur, réessayez: ");
    }

    if (nbJoueurs > 0 && nbJoueurs <= 10) valide = true;
    else Console.WriteLine($"Vous devez entrer un nombre entre 1 et 10: ");
}

double[] scores = new double[nbJoueurs];

// Demander à l'utilisateur les scores des joueurs

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Entrez le score du joueur n°{i + 1}:");
    double score = 0;
    while (!double.TryParse(Console.ReadLine(), out score))
    {
        Console.WriteLine($"Erreur, réessayez:");
    }
    scores[i] = score;

    // Calcul de la somme
    somme += score;

    // La gestion du format du tableau
    format += score;
    if (i < scores.Length - 1) format += ", ";
}

// Calcul de la moyenne
moyenne = somme / scores.Length;

Console.WriteLine($"Scores: {format}");
Console.WriteLine($"Scores: {string.Join(", ", scores)}");
Console.WriteLine($"Moyenne des scores: {moyenne}");
