/*
 * Écrire un programme qui permet de demander à l'utilisateur ses informations 
 * et ensuite les afficher.
 * Un utilisateur est caractérisé par :
 * - un nom (string)
 * - un prénom (string)
 * - une date de naissance (jour (byte), mois (byte) et année (short)) 
 *  [rechercher sur internet comment créer une date] DateOnly
 * - une adresse (rue (string), numéro (string), code postal (string) et ville (string))
 * - s'il est marié ou non (bool)
 * - une taille (en mètre) (float / double / Décimal)
 */

// Déclaration

string nom, prenom, rue, numero, codePostal, ville;
byte jour, mois;
short annee;
DateOnly dateNaissance;
bool estMarie;
float taille;

// Initialisation

Console.WriteLine("Entrez votre nom:");
nom = Console.ReadLine();

Console.WriteLine("Entrez votre prénom:");
prenom = Console.ReadLine();


Console.WriteLine("Entrez votre jour de naissance:");
byte.TryParse(Console.ReadLine(), out jour);

Console.WriteLine("Entrez votre mois de naissance:");
byte.TryParse(Console.ReadLine(), out mois);

Console.WriteLine("Entrez votre mois de naissance:");
short.TryParse(Console.ReadLine(), out annee);

dateNaissance = new DateOnly(annee, mois, jour);

Console.WriteLine($"Êtes-vous marié•e ?");
estMarie = Console.ReadLine() == "true";

Console.WriteLine($"Quelle est ta taille ? (en mètre)");
float.TryParse(Console.ReadLine(), out taille);


Console.WriteLine($"{nom} {prenom}, né le {dateNaissance}");