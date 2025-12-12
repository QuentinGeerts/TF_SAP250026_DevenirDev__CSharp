/*
 * Démonstration 07.3 - Tableaux Matriciels
 * Tableau de "tableaux" de tailles identiques
 */

// 1.  Déclaration
// Syntaxe: Type[,] nomTableau = new Type[nbTableaux,taille];

int[,] monTableau = new int[2, 4]; // [ [0, 0, 0, 0], [0, 0, 0, 0] ] 
int[,] monTableau2 = { 
    { 1, 2, 3, 4 },  // 0
    { 5, 6, 7, 8 }  // 1
};

// 2.  Accéder à un élément

Console.WriteLine($"monTableau2[0,2]: {monTableau2[0,2]}"); // 3

// 3.  Récupérer la taille du tableau

Console.WriteLine($"Taille du tableau: {monTableau.Length}"); // 8
Console.WriteLine($"Taille du tableau: {monTableau.GetLength(0)}"); // 2
Console.WriteLine($"Taille du tableau: {monTableau.GetLength(1)}"); // 4

// 4.  Parcourt de la matrice

for (int i = 0; i < monTableau.GetLength(0); i++)
{
    for (int j = 0; j < monTableau.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}]: {monTableau[i,j]}\t");
    }
    Console.WriteLine();
}
