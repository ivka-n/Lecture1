// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] array = new int[] { 4, 18, 12, 6, -4, 5 }; // Array může obsahovat více čísel najednou
// Funkce FindMax

int FindMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++) // array.Length bere celou tu délku té závorky??
    {
        //Console.WriteLine(array[i]); - Tohle mi vypíše všechna číslo z toho array
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
int maximum = FindMax(array);
Console.WriteLine(maximum);


int FindMaxIndex(int[] array)
{
    int max = 0;
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine(array[i]);
        if (array[i] > max)
        {
            max = array[i];
            maxIndex = i;
        }

    }
    return maxIndex;
}

int maximumIndex = FindMaxIndex(array);
Console.WriteLine(maximumIndex); /*Vypíše pozici, na které se maximum nachází*/
Console.WriteLine();

foreach (int num in array) /*Vypíše mi to všechna čísla v tom array - jednodušší verze*/
{
    if (num > 10) // Podmínka, aby mi to vypsalo pouze čísla větší než 10 v tom array
    {
        Console.WriteLine(num);
    }
    
}

Console.WriteLine();



//Funkce pro pozdrav uživatele

void GreetUser (string name)
{
    Console.WriteLine("Hello " + name);
}

GreetUser("Martin");
GreetUser("Johnny");

//static void GreetUser(string name)
//{
//    Console.WriteLine("Hello " + name);
//}

//GreetUser("Martin");
