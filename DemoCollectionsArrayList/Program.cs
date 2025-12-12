/*
 * Démonstration 7.4 - Collection "ArrayList"
 * Ensemble de valeurs variables de types différents 
 */

using System.Collections;

// 1.  Déclaration et instanciation d'une collection
ArrayList arrayList = new ArrayList();


// 2. Ajouter dans la collection

arrayList.Add(42); // 0
arrayList.Add("hello"); // 1
arrayList.Add(true); // 2
arrayList.Add(true); // 2

// 3.  Retirer un élément
arrayList.Remove(42); // <!> décalage des autres éléments

Console.WriteLine($"arrayList: {arrayList}");

