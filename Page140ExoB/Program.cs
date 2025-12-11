/*
 * Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK 
 * sur la console sinon KO.
 * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
 * Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
 * (utilisez la méthode « Substring » de la classe « string »).
 */

// 539007990797
// 063008790997
// 310123456109
// 001234567858
// 732556677844

// --- 

bool checkBban (string bban)
{
    if (bban is null) return false;
    bban = bban.Replace("-", "");
    if (bban.Length != 12) return false;
    if (!long.TryParse(bban, out _)) return false;

    Console.Write($"BBAN: {bban}\t Taille du bban: {bban.Length} ");

    long tenFirstDigits = long.Parse(bban.Substring(0, 10));
    int twoLastDigits = int.Parse(bban.Substring(10));

    if (
        (tenFirstDigits % 97 == twoLastDigits) || 
        (tenFirstDigits % 97 == 0 && twoLastDigits == 97)) return true;
    else return false;
}



Console.WriteLine("null: " + checkBban(null));
Console.WriteLine("001701881669: " + checkBban("001701881669"));
Console.WriteLine("970000000097: " + checkBban("970-0000000-97"));