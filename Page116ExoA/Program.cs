/*
 * Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux moitiés 
 * de celui-ci donne le nombre, afficher « le nombre est paire »
 * sinon « le nombre est impaire ».
 */

Console.WriteLine($"Entrez un nombre:");
int nombre;
bool success = int.TryParse(Console.ReadLine(), out nombre);

if (success)
{
    Console.WriteLine($"Le nombre est { ( nombre / 2 * 2 == nombre ? "pair" : "impair" ) }");
}
else
{
    Console.WriteLine($"Erreur lors de la conversion.");
}