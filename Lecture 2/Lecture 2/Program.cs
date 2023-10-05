// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter password!");

string password = Console.ReadLine();

if (password == "1234")
    // Po if, for, while se nepíše středník
{
    Console.WriteLine("You are the choosen one. Here's your answer:");
}

else
{
    Console.WriteLine("Wrong password");
}

//Console.WriteLine( "What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Hello, " + name);

//for (int i = 0; i < 5; i++)
//    // i++ znamená, že se každé další číslo zvětší o 1
//{
//    Console.WriteLine(i);
// }


//int number = 0;
//while (number < 5)
//{
//    Console.WriteLine(number);
//    number = number + 1;
//    // stejný zápis: number +=1, number++
//}


//int otherNumber = 0;
//do
//{
//    Console.WriteLine(otherNumber);
//    otherNumber = otherNumber + 1;

//} while (otherNumber < 5);

// stejný jako cyklus while, jediný rozdíl - podmínka kontroluje až na konci

bool success = false;
int numItarations = 0;
do
{
    Console.WriteLine("Enter a number");
    string numIterationsString = Console.ReadLine();
    int numIterations = 0;
    success = int.TryParse(numIterationsString, out numIterations);
    Console.WriteLine("success = " + success);

} while ( !success);


for (int i = 0; i < numIterations; i++)
{
    Console.WriteLine(i);
}
