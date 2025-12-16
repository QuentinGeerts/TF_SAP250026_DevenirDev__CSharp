/*
 * Démonstration 08 - Enumérations
 * Liste de valeurs immuables
 */

using DemoEnum.Enums;

// 1.  Déclaration d'une variable sur base d'une énumération
Languages language = Languages.FRENCH;

switch (language)
{
    case Languages.FRENCH:
        Console.WriteLine($"Bonjour");
        break;

    case Languages.ENGLISH:
        Console.WriteLine($"Hello");
        break;

    case Languages.ITALIAN:
        Console.WriteLine($"Buongiorno");
        break;

    case Languages.DUTCH:
        Console.WriteLine($"Goedemorgen");
        break;

    case Languages.JAPANESE:
        Console.WriteLine($"Konichiwa");
        break;
}

// 2.  Itérer sur une énumération
Type languagesType = typeof(Languages);
string[] langues1 = Enum.GetNames(languagesType);

string[] langues2 = Enum.GetNames(typeof(Languages));

string[] langues3 = Enum.GetNames<Languages>(); // ♥

//foreach (var item in langues3) { }

Console.WriteLine($"Liste des langues:");
foreach (string langue in Enum.GetNames<Languages>())
{
    Console.WriteLine($" - {langue} - {(int)Enum.Parse<Languages>(langue)}");
}

foreach (Languages langue in Enum.GetValues<Languages>())
{
    Console.WriteLine($" - {langue} - {(int)langue}");
}

// 3.  Récupération au clavier d'une valeur d'une énumération et conversion

Console.WriteLine($"Sélectionnez une langue:");
string userInput = Console.ReadLine();

while (!Enum.IsDefined(typeof(Languages), userInput.ToUpper()))
{
    Console.WriteLine($"Erreur, réessayez: ");
    userInput = Console.ReadLine();
}
