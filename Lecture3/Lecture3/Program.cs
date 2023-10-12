// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");



//int number1 = 0;
//while (number1 < 21)
//{
//    Console.WriteLine(number1); number1 = number1 + 1;

//}




//for (int i = 1; i <= 20; i++)
//{
//    //Console.WriteLine(i);
//    //Console.Write(" ");
//    //Console.WriteLine(i % 3);

//    if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0) ;
//    {
//        Console.WriteLine("Buzz");
//    }
//  else if (i % 15 == 0) ;
//    {
//        Console.WriteLine("FizzBuzz");
//    }
// }


int cislo1 = 0;
int cislo2 = 0;


Console.WriteLine("Zadej číslo: ");
string nazev1 = Console.ReadLine();
int.TryParse(nazev1, out cislo1);

Console.WriteLine("Zadej 2. číslo: ");
string nazev2 = Console.ReadLine();
int.TryParse(nazev2, out cislo2);

Console.WriteLine("Napiš +/-/*//");
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


