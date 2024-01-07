using System.Diagnostics.Contracts;
using System.Globalization;

Console.Clear();

Console.Write("Enter a set of characters separated by commas: ");
String inStringSimbol = Console.ReadLine() ?? "";
String[] arraySimbol = GetArrayStringConsole(inStringSimbol);
Console.WriteLine();
Console.Write("Input symbols: ");
PrintArray(arraySimbol);
Console.WriteLine();
Console.Write("Entered characters whose length is less than or equal to 3: ");
PrintArray(GetArrayThreeSimbol(arraySimbol));
Console.WriteLine();

string[] GetArrayStringConsole (string consoleText)
{
    string[] arrayText = new string[consoleText.Length];
    arrayText = consoleText.Split(",");
    return arrayText;
}

string[] GetArrayThreeSimbol (string[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simbol = array[i];
        if (simbol.Length <= 3)
        {
            temp++;
        }
    }
    string[] arrayThreeSimbol = new string[temp];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simbol = array[i];
        if (simbol.Length <= 3)
        {
            arrayThreeSimbol[j] = simbol;
            j++;
        }
    }
    return arrayThreeSimbol;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}