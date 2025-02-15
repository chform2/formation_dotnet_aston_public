﻿Console.WriteLine("--- Calcul des intérêts ---\n");
Console.Write("Entrez Capital de départ (en Euros) : ");
double capitalDepart = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux d'intérêts (en %) : ");
double tauxInterets = double.Parse(Console.ReadLine());
Console.Write("Entrez la durée de l'épargne (en années) : ");
int nombreAnnees = int.Parse(Console.ReadLine());
double montantInterets = Math.Round(capitalDepart * Math.Pow(1 + tauxInterets / 100, nombreAnnees) - capitalDepart, 2);
Console.WriteLine($"Le montant des intérêts sera de {montantInterets} Euros après 5 ans");
double capitalFinal = Math.Round(capitalDepart * Math.Pow(1 + tauxInterets / 100, nombreAnnees), 2);
Console.WriteLine($"Le capital final sera de {capitalFinal} Euros après 5 ans");
