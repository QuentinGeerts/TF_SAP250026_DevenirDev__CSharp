/*
 * Démonstration 7.9 - Collection générique - Dictionary [Hashtable]
 */

Dictionary<string, string?> monDictionnaire = new Dictionary<string, string?>();
monDictionnaire.Add("0001", "Eliott");
monDictionnaire.Add("0002", "Ibrahima");
monDictionnaire.Add("0003", "Selena");


string s = monDictionnaire["0001"] ?? "Aucun utilisateur trouvé.";

foreach (KeyValuePair<string, string?> p in monDictionnaire)
{
    Console.WriteLine($"Personne: {p} - clef: {p.Key} - valeur: {p.Value}");
}