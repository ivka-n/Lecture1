// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x;
x = 2;
int y = 3;
double procento = 0.42;

// Vypiš proměnné

/*
 * Ahoj,
 * uívej.
 */

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);

string name = "Ivča";
Console.WriteLine("Hallo, " + name); // Dva stejný zápisy
Console.WriteLine("Hello,{0}", name);


int number1 = 9;
int number2 = 3;
Console.WriteLine(number1 + number2);
Console.WriteLine(number1 - number2);

// jiný způsob, kde se vypíše celý příklad

Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
// další jiný způsob
Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

//přiřaď výsledek do proměnné
int result = number1 + number2;


Console.WriteLine($"result = {result}");
// pro des číslo

double number3 = 14;
double number4 = 4;

Console.WriteLine($"{number3} / {number4} = {number3 / number4}");

// z doubleu do intelu
double result2 = number3 + number4;
Console.WriteLine(result2);
// Přetypování proměnné 
int result2int = (int)result2;
Console.WriteLine(result2int);

double result2double = result2int;

bool bool1 = true;
bool bool2 = false;

Console.WriteLine("{0} || = {2}", bool1, bool2, bool1 || bool2);
Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
Console.WriteLine("!{0} = {1}", bool1, !bool1);

int cislo = 7;
Console.WriteLine("{0} == 7 -> {1}", cislo, cislo == 7);

Console.WriteLine("Jak se jmenujes?");
string jmeno = Console.ReadLine();
Console.WriteLine($"Ahoj, {jmeno}!");




string cislooduzivatele = Console.ReadLine();
int cislooduzivatele;
bool succes = int.TryParse(cislooduzivatele, out cislooduzivatele);
Console.WriteLine($"success = {success}");
Console.WriteLine(cislooduzivatele + 3);

