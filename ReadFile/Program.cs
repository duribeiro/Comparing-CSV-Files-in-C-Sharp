const string filePath1 = @"C:\Projects\repos\ReadFile\File\FileCSV1.csv";
const string filePath2 = @"C:\Projects\repos\ReadFile\File\FileCSV2.csv";

//Console.WriteLine("Digite o caminho do primeiro arquivo CSV\r");
//Console.WriteLine("-------------------------------\r");

//var filePath1 = Console.ReadLine();

//Console.WriteLine("Digite o caminho do segundo arquivo CSV\r");
//Console.WriteLine("-------------------------------\r");

//var filePath2 = Console.ReadLine();

var data1 = File.ReadAllLines(filePath1);
var data2 = File.ReadAllLines(filePath2);

void numberOfLines(string[] file1, string[] file2)
{
    Console.WriteLine();
    Console.WriteLine("Comparação de dados:\r");
    Console.WriteLine("--------------------\r");
    Console.WriteLine($"Arquivo 1: {file1.Length} Linhas");
    Console.WriteLine($"Arquivo 2: {file2.Length} Linhas");
    Console.WriteLine("--------------------\r");
    Console.WriteLine();
}

void repeatedLines(string[] file1, string[] file2)
{
    var crossArray = file1.Intersect(file2).ToArray();

    Console.WriteLine($"Linhas repetidas: {crossArray.Length}\r");
    Console.WriteLine("--------------------\r");

    foreach (var merge in crossArray)
    {
        Console.WriteLine(merge);
    }

    Console.WriteLine("--------------------\r");
    Console.WriteLine();
}

void linesOnlyInFile1(string[] file1, string[] file2)
{
    var comparation = file1.Except(file2).ToArray();

    Console.WriteLine($"linhas apenas no Arquivo 1: {comparation.Length}\r");
    Console.WriteLine("--------------------\r");

    foreach (var line in comparation)
    {
        Console.WriteLine(line);
    }

    Console.WriteLine("--------------------\r");
    Console.WriteLine();
}

void linesOnlyInFile2(string[] file1, string[] file2)
{
    var comparation = file2.Except(file1).ToArray();

    Console.WriteLine($"linhas apenas no Arquivo 2: {comparation.Length}\r");
    Console.WriteLine("--------------------\r");

    foreach (var line in comparation)
    {
        Console.WriteLine(line);
    }

    Console.WriteLine("--------------------\r");
    Console.WriteLine();
    Console.WriteLine("Fim do relatório.\r");
    Console.WriteLine("--\r");
    Console.WriteLine();
}

void report (string[] file1, string[] file2)
{
    numberOfLines(file1, file2);
    repeatedLines(file1, file2);
    linesOnlyInFile1(file1, file2);
    linesOnlyInFile2(file1, file2);
}

report(data1, data2);