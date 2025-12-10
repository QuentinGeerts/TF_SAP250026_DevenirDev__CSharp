
bool estPair (int entier)
{
    return entier % 2 == 0;
}
bool estPremier(int nb)
{
    if (nb < 0) throw new Exception("Un nombre premier ne peut pas être négatif");
    if (nb <= 2) return false;

    for (int i = 2; i <= Math.Sqrt(nb); i++)
    {
        if (nb % i == 0) return false;
    }

    return true;
}


// -- Programme principal 

int monEntier = 42;

Console.WriteLine($"42 est pair ? " + estPair(monEntier));

for (int i = 0; i < 100; i++)
{
    if (estPremier(i)) Console.WriteLine($"{i} est premier");
}

