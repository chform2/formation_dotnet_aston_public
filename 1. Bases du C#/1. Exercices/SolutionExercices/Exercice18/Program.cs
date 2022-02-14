﻿int age;

Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...? --- \n");
Console.Write("Entrez l'âge de votre enfant : ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

switch (age)
{
    case int ageTmp when ageTmp < 3:
        Console.WriteLine("Votre enfant est trop jeune pour pratiquer !\n");
        break;
    case int ageTmp when ageTmp >= 3 && ageTmp <= 6:
        Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !\n");
        break;
    case int ageTmp when ageTmp >= 7 && ageTmp <= 8:
        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !\n");
        break;
    case int ageTmp when ageTmp >= 9 && ageTmp <= 10:
        Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !\n");
        break;
    case int ageTmp when ageTmp >= 11 && ageTmp <= 12:
        Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !\n");
        break;
    case int ageTmp when ageTmp >= 13 && ageTmp <= 17:
        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !\n");
        break;
    default:
        Console.WriteLine("Mais ce n'est plus un enfant !\n"); break;
}