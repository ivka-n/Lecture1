﻿using System.Text;
Console.OutputEncoding = Encoding.UTF8;

string[] ZkOtazky = File.ReadAllLines("questions.data");



static string[] MichacOtazek(string[] Michac)
{

    string[] ZamichatOtazky = { };
    while (ZamichatOtazky.Length < Michac.Length)
    {
        Random rand = new Random();
        int RandCis = rand.Next(Michac.Length);

        if (!ZamichatOtazky.Contains(Michac[RandCis]))
        {
            Array.Resize(ref ZamichatOtazky, ZamichatOtazky.Length + 1);
            ZamichatOtazky[ZamichatOtazky.Length - 1] = Michac[RandCis];
        }
    }
    return ZamichatOtazky;
}

ZkOtazky = MichacOtazek(ZkOtazky);
Console.WriteLine("Vitej v kurzu autoskoly, pro ukonceni napis \"exit\"");
int SpravnaOdp = 0;
int SpatnaOdp = 0;

for (int i = 0; i < ZkOtazky.Length; i++)
{
   
    string[] RozdelRadek = ZkOtazky[i].Split('|');
    Console.WriteLine(RozdelRadek[0]);
    string[] SeznamOdp = { "A", "B" };
    for (int k = 2; k < RozdelRadek.Length; k++)
    {
        if (k == 2)
        {
            Console.WriteLine($"A) {RozdelRadek[k]}");
        }
        else if (k == 3)
        {
            Console.WriteLine($"B) {RozdelRadek[k]}");
        }
        else
        {
            Array.Resize(ref SeznamOdp, SeznamOdp.Length + 1);
            SeznamOdp[SeznamOdp.Length - 1] = "C";
            Console.WriteLine($"C) {RozdelRadek[k]}");
        }

    }
    string OdpovedOdUz = "";
    while (!SeznamOdp.Contains(OdpovedOdUz))
    {
        OdpovedOdUz = OdpovedOdUzivatele();

        if (!SeznamOdp.Contains(OdpovedOdUz))
        {
            Console.WriteLine("Neplatny vstup."); // prepsat
        }
    }
    Console.Clear();
    if (OdpovedOdUz == RozdelRadek[1]) // kdyz je odpoved spravna tak..
    {
        SpravnaOdp++;
        Console.WriteLine("Spravna odpoved ;))");
    }
    else
    {
        SpatnaOdp++;
        Console.WriteLine("Spatna odpoved :((");

        Console.WriteLine("Spravna odpoved je:");

        if (RozdelRadek[1] == "A")
        {
            Console.WriteLine($"A) {RozdelRadek[2]}");
        }
        else if (RozdelRadek[1] == "B")
        {
            Console.WriteLine($"B) {RozdelRadek[3]}");
        }
        else
        {          
            Console.WriteLine($"C) {RozdelRadek[4]}");
        }

    }
    Console.WriteLine();

}
ProcentUspesnost();

 string OdpovedOdUzivatele()
{
    string Odpoved = Console.ReadLine().Trim().ToUpper();
    if (Odpoved == "EXIT")
    {
        ProcentUspesnost();
        Environment.Exit(0);
    }
    return Odpoved;
}

void ProcentUspesnost()
{
    Console.WriteLine("Konec testu");
    float PocetOtazek = SpravnaOdp + SpatnaOdp;
    Console.WriteLine($"Spravnych otazek: {SpravnaOdp}");
    Console.WriteLine($"Tva procentualni uspesnost byla {SpravnaOdp / PocetOtazek * 100}%");
}

