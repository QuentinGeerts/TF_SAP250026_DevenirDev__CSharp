/*
 * Démonstration 7.7 - Collection Stack
 */
using System.Collections;

// LIFO - Last In First Out

// 1.  Déclaration
Stack stack = new Stack();
Stack<string> pileAssiettes = new Stack<string>(); // Générique

stack.Push("Assiette 1");
stack.Push("Assiette 2");
stack.Push("Assiette 3");
stack.Push("Assiette 4");

int count = stack.Count;

for (int i = 0; i < count; )
{
    string item = (string)stack.Peek();

    Console.WriteLine($"Nettoyage de : {item}");

    if (Random.Shared.Next(100) > 30)
    {
        Console.WriteLine($"Nettoyage réussi");
        stack.Pop();
        i++;
    }
    else
    {
        Console.WriteLine($"Les tâches sont tenaces...");
    }

}

