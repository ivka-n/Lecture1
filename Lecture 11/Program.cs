




//string[] pokemons = File.ReadAllLines("pokedex.txt");


// nacte vsechno najednou
//foreach (string pokemon in pokemons)
//{
//    Console.WriteLine(pokemon);
//}



// nacte postupne

//StreamReader reader = new StreamReader("pokedex.txt");

//while (!reader.EndOfStream)
//{
//    string line = reader.ReadLine();
//    Console.WriteLine(line);
//}

// musime vzdycky ten soubor zavrit
//reader.Close();


// samo to zavira ten soubor
//using (StreamReader using_reader = new StreamReader("pokedex.txt"))
//{
//    while (!using_reader.EndOfStream)
//    {
//        string line = using_reader.ReadLine();
//        Console.WriteLine(line);

//    }
//}

//if (File.Exists("favorite.txt"))
//{
//    string previousFavorite = File.ReadAllText("favorite.txt");
//    Console.WriteLine("Your previous favorite was");
//    Console.WriteLine(previousFavorite);
//}
//else
//{
//    Console.WriteLine("You dont have a favorite pokemon.");
//}



//Console.WriteLine("What's zour favorite pokemon?");
//string favorite = Console.ReadLine();

//File.WriteAllText("favorite.txt", favorite);

// File.AppendAllLines - pridava dalsi text, File.Copy - kopiruje text


//using (StreamWriter using_writer = new StreamWriter("pokedex.txt"))
//{
//    using_writer.WriteLine(favorite);
//}


string[] pokemonStats = File.ReadAllLines("pokedex1.txt");


string longestName = "";

foreach (string pokemon in pokemonStats)
{
    string[] parts = pokemon.Split(',');
    Console.WriteLine("Pokemon" + ": " + parts[1]);
    Console.WriteLine("Type" + ": " + parts[2]);
    Console.WriteLine("Health" + ": " + parts[5]);
    Console.WriteLine();

    if (parts[1].Length > longestName.Length)
    {
        longestName = parts[1];
    }

}

Console.WriteLine("Longest name:" +  longestName);


