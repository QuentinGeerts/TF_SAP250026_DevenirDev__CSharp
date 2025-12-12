/*
 * Démonstration 07.2 - Tableaux orthogonaux
 * Tableau de tableau de tailles différentes
 */

// 1.  Déclaration d'un tableau orthogonal

// Syntaxe: Type[][] nomTableau = new Type[NbTableaux][];

int[][] monTableau = new int[3][];
monTableau[0] = new int[3]; // [0, 0, 0]
monTableau[1] = new int[2]; // [0, 0]
monTableau[2] = new int[5]; // [0, 0, 0, 0, 0]

int[][] monTableau2 = [
    new int[3],
    new int[] { 0, 0 },
    [0, 0, 0, 0, 0]
];

// 2.  Accéder à un élément du tableau orthogonal

Console.WriteLine($"monTableau[0][0]: {monTableau[0][0]}");

// 3.  Taille des tableaux

Console.WriteLine($"monTableau.Length: {monTableau.Length}"); // 3
Console.WriteLine($"monTableau.Length: {monTableau[0].Length}"); // 3
Console.WriteLine($"monTableau.Length: {monTableau[1].Length}"); // 2
Console.WriteLine($"monTableau.Length: {monTableau[2].Length}"); // 5

// 4.  Parcourt des tableaux

for (int i = 0; i < monTableau.Length; i++)
{
    for (int j = 0; j < monTableau[i].Length; j++)
    {
        Console.Write($"[{i}][{j}]: {monTableau[i][j]}\t");
    }
    Console.WriteLine();
}

// 5. Tableau à 3 dimensions (pour le fun)

int[][][] monTableau3 = [
    [
        [1, 2],
        [3, 4]
    ],
    [
        [5, 6],
        [7, 8, 9],
        [10]
    ],
    [
        [11, 12, 13, 14],
    ]
];

for (int i = 0; i < monTableau3.Length; i++)
{
    for (int j = 0; j < monTableau3[i].Length; j++)
    {
        for (int k = 0; k < monTableau3[i][j].Length; k++)
        {
            Console.Write($"[{i}][{j}][{k}]: {monTableau3[i][j][k]}");
        }
        Console.Write("\t");
    }
    Console.WriteLine();
}