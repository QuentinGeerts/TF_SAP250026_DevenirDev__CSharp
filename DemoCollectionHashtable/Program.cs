/*
 * Démonstration 7.5 - Collection HashTable
 */

using System.Collections;

// 1.  Déclaration

Hashtable hashtable = new Hashtable();

// 2.  Remplissage

hashtable.Add("0001", 42);
hashtable.Add("0002", 42);
//hashtable.Add("0001", 52); // ArgumentException
//hashtable.Add(null, 52); // ArgumentNullException

Console.WriteLine();
