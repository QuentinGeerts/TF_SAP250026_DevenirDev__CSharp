/*
 * En utilisant la méthode « Console.ReadLine() »
 *  - Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *  la conversion devra utiliser la méthode « int.Parse() »
 *  - Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *  la conversion devra utiliser la méthode « int.TryParse() »
 */

// 1.  Avec int.Parse()

Console.WriteLine($"Entrez le premier nombre: ");
int firstNumber = int.Parse( Console.ReadLine() );

Console.WriteLine($"Entrez le deuxième nombre: ");
int secondNumber = int.Parse( Console.ReadLine() );

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");


// 2.  Avec int.TryParse()

Console.WriteLine($"Entrez le premier nombre: ");
bool successA = int.TryParse(Console.ReadLine(), out int nb1);

Console.WriteLine($"Entrez le deuxième nombre: ");
bool successB = int.TryParse(Console.ReadLine(), out int nb2);

if (successA && successB)
    Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");

