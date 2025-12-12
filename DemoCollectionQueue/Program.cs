/*
 * Démonstration 7.6 - Collection Queue
 */

// Collection FIFO (First In First Out) [file d'attente]

using System.Collections;

// 1.  Déclaration

Queue queue = new Queue(); // Non-générique
Queue<string> fileAttente= new Queue<string>(); // Générique


// 2.  Enqueue : permet d'ajouter un élément à la fois

queue.Enqueue("Eliott");
queue.Enqueue("Mathieu");
queue.Enqueue("Eddy");
queue.Enqueue("Ibrahima");
queue.Enqueue("Francesca");
queue.Enqueue("Serge");
queue.Enqueue("Paolo");
queue.Enqueue("Luca");
queue.Enqueue("Kevin");


// 3.  Dequeue : permet de retirer un élément à la fois

int count = queue.Count;
for (int i = 0; i < count;)
{
    string stagiaire = (string)queue.Peek();
    Console.WriteLine($"C'est au tour de {stagiaire}");
    if (Random.Shared.Next(100) > 50)
    {
        Console.WriteLine($"Le problème de {stagiaire} n'a pas été traité.");
    }
    else
    {
        Console.WriteLine($"Le problème a été traité.");
        queue.Dequeue();
        i++;
    }
}

// 4. Parcourt 
//foreach (var stagiaire in queue)
//{
//    Console.WriteLine($"stagiaire: {stagiaire}");
//}