## Итоговая работа.

### Задача:
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

[Текст итоговой контрольной работы по основному блоку](Final_Test.md)

Блок-схема:

![](block_diagram.drawio.png)


### Решение задачи:

1. Разделение строки из консоли в массив через запятую c помощью метода `GetArrayStringConsole`:
```cs
string[] GetArrayStringConsole (string consoleText)
{
    string[] arrayText = new string[consoleText.Length];
    arrayText = consoleText.Split(",");
    return arrayText;
}
```

2. Сортировка символов из массива с помощью метода `GetArrayThreeSimbol`:
```cs
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
```

3. Вывод информации из массива в консоль с помощью метода `PrintArray`:
```cs
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
```

4. Создание пользовательского ввод текста для вызова вышеуказанных методов:
```cs
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