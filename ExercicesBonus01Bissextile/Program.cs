/*
 * Réaliser un petit algorithme qui sur base d’une année donnée va déterminer 
 * s’il s’agit d’une année bissextile. Une année est bissextile si elle est 
 * divisible par 4, mais non divisible par 100. Ou si elle est divisible par 400.
 */

Console.WriteLine($"Entrez une année : ");
int annee = int.Parse( Console.ReadLine()! );

bool estDivPar4 = annee % 4 == 0;
bool estDivPar100 = annee % 100 == 0;
bool estDivPar400 = annee % 400 == 0;

if (estDivPar4 && !estDivPar100 || estDivPar400)
{
    Console.WriteLine($"{annee} est bissextile");
}
else
{
    Console.WriteLine($"{annee} n'est pas bissextile");
}