﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.ComponentModel.Design;

Console.WriteLine("Tvá osobní kalkulačka :)))");

string pokracovat = "ano";
while (pokracovat == "ano")
{

    double cislo1 = 0;
    double cislo2 = 0;


    Console.WriteLine("Zadej číslo: ");
    string nazev1 = Console.ReadLine();
    double.TryParse(nazev1, out cislo1);

    Console.WriteLine("Zadej 2. číslo: ");
    string nazev2 = Console.ReadLine();
    double.TryParse(nazev2, out cislo2);
    string prikaz = "ano";
    while (prikaz == "ano")
    {
        Console.Write("Napiš jakou operaci chceš s čísly provést:");
        string znamenko = Console.ReadLine();

        if (znamenko == "+")
        {
            Console.WriteLine(cislo1 + cislo2);
        }
        else if (znamenko == "-")
        {
            Console.WriteLine(cislo1 - cislo2);
        }
        else if (znamenko == "*")
        {
            Console.WriteLine(cislo1 * cislo2);
        }
        else if (znamenko == "/")
        {
            Console.WriteLine(cislo1 / cislo2);
        }
        else
            Console.WriteLine("Špatně!");
        Console.WriteLine("Chceš provést další operaci s těmito čísly? [ano/ne] ");
        prikaz = Console.ReadLine();

    }
   
    Console.WriteLine("Přejete si zadat další příklad? [ano/ne]");
    pokracovat = Console.ReadLine();
}
Console.WriteLine("Chápu, pro dnešek už bylo matiky dost.:)))");