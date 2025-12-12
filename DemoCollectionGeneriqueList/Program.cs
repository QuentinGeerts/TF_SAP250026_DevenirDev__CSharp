/*
 * Démonstration 7.8 - Collection générique List [ArrayList]
 */

List<string> jours = new List<string>();
List<double> a = new(); // Inférence de type (Depuis C# 9)

jours.AddRange(["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"]);

string aujourdhui = jours[4];

Console.WriteLine($"Aujourd'hui: {aujourdhui}");