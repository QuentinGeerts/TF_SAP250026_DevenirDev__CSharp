/*
 * Réaliser l’algorithme d’un lanceur de balles de tennis. 
 * Ce lanceur possède deux états :
 * prêt : permet de savoir si le tennisman est prêt. 
 *  Il ne faut pas lancer de balles dans le cas contraire
 *  panierVide : permet de savoir s’il y a encore des balles disponibles
 *  Le lanceur de balle possède l’opération « lancerBalle » qui, vous l’aurez 
 *  compris, permet de lancer une balle.
 */


Console.WriteLine("Es-tu prêt ? (true / false)");
bool pret = bool.Parse(Console.ReadLine()!);

Console.WriteLine($"As-tu des balles ? (true / false)");
bool panierVide = !bool.Parse(Console.ReadLine()!);


if (pret && !panierVide)
{
    Console.WriteLine($"Lancer la balle");
}
else
{
    Console.WriteLine($"Ne pas lancer la balle");

    if (!pret)
        Console.WriteLine($"Car tu n'es pas prêt");
    if (panierVide)
        Console.WriteLine($"Car le panier est vide");
}
