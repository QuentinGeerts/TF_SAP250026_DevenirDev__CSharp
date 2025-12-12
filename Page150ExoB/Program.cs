/*
 *  Calculer le factoriel d’un nombre entré au clavier
 */

Console.WriteLine($"Entrez un nombre: ");
int.TryParse(Console.ReadLine(), out int nb);
int res = 1;

for (int i = 0; i < nb - 1; i++)
{
    //res = res * (nb - i);
    res *= (nb - i);
}

Console.WriteLine($"!{nb} = {res}");
