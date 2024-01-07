// using System.Diagnostics.Contracts;
// using System.Globalization;

// Console.Clear();

// Console.Write("Enter a set of characters separated by commas: ");
// String inStringSimbol = Console.ReadLine() ?? "";
// String[] arraySimbol = GetArrayStringConsole(inStringSimbol);
// Console.WriteLine();
// Console.Write("Input symbols: ");
// PrintArray(arraySimbol);
// Console.WriteLine();
// Console.Write("Entered characters whose length is less than or equal to 3: ");
// PrintArray(GetArrayThreeSimbol(arraySimbol));
// Console.WriteLine();

// string[] GetArrayStringConsole (string consoleText)
// {
//     string[] arrayText = new string[consoleText.Length];
//     arrayText = consoleText.Split(",");
//     return arrayText;
// }

// string[] GetArrayThreeSimbol (string[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         string simbol = array[i];
//         if (simbol.Length <= 3)
//         {
//             temp++;
//         }
//     }
//     string[] arrayThreeSimbol = new string[temp];
//     for (int i = 0, j = 0; i < array.Length; i++)
//     {
//         string simbol = array[i];
//         if (simbol.Length <= 3)
//         {
//             arrayThreeSimbol[j] = simbol;
//             j++;
//         }
//     }
//     return arrayThreeSimbol;
// }

// void PrintArray (string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }

string[] CreateNewArray(string[] array)
{
    int k = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    Array.Resize(ref newArray, k);
    return newArray;
}

void ConvertArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"\"{array[i]}\"");
        else Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("]");
}

string GetInputText(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetInputText("Введите строку массива: ");
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Задайте размер массива: ");
string[] array = CreateArray(size);
ConvertArray(array);
Console.Write(" → ");
string[] newArray = CreateNewArray(array);
ConvertArray(newArray);