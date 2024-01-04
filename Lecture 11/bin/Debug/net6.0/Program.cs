



//try
//{
//    Console.WriteLine("Napis jaky soubor chces precist");
//    string soubor = Console.ReadLine();
//    File.ReadAllText(soubor);
//    Console.WriteLine(soubor + " existuje");
//    StreamReader reader = new StreamReader(soubor);

//    while (!reader.EndOfStream)
//    {
//        string line = reader.ReadLine();
//        Console.WriteLine(line);
//    }
//    reader.Close();
//}
//catch
//{
//    Console.WriteLine("Neplatny soubor");
//}

static string GetPathFromUser()
{
    Console.WriteLine("Enter path");
    string path = Console.ReadLine();
    return path;
}

static void PrintErrorMessage()
{
    Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
    return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
    try
    {
        string contents = GetFileContents(path);
        Console.WriteLine(contents);
    }
    catch (Exception e)
    {
        PrintErrorMessage();
    }
}

static void UserReadFile()
{
    string path = GetPathFromUser();

    PrintFileContents(path);
}


UserReadFile();