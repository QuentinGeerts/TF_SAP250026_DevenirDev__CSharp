/*
 * Démonstration 10 - Structures
 */

using DemoStructures.Models;

Contact c1 = new Contact();
c1.FirstName = "Quentin";
c1.LastName = "Geerts";
c1.Email = "quentin.geerts@bstorm.be";
c1.BirthDate = new DateOnly(1996, 4, 3);

Console.WriteLine($"C1: {c1.Informations()}");

Contact c2 = new Contact
{
    FirstName = "John",
    LastName = "Doe"
};

void passageParStruct(Contact c)
{
    Console.WriteLine($"{c.FirstName}"); // Quentin
    c.FirstName = "Technofutur";
    Console.WriteLine($"{c.FirstName}"); // Technofutur
}

Console.WriteLine($"c1: {c1.FirstName}"); // Quentin
passageParStruct(c1);
Console.WriteLine($"c1: {c1.FirstName}"); // Quentin