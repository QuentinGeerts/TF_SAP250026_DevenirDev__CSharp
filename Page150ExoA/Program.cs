/*
 * Calculer les 25 premiers nombres de la suite de Fibonacci
 */

int a = 1, b = 1, c;

Console.WriteLine($"1. {a}");
Console.WriteLine($"2. {b}");

for (int i = 0; i < 23; i++)
{
    c = a + b;
    Console.WriteLine($"{i + 3}. {c}");
    a = b;
    b = c;
}
