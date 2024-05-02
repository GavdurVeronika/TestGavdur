// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", “Denmark", "Kazan"] → []


string[] originalArray = { "Hello", "2", "world", ":-)" };
string[] filterArray = new string[originalArray.Length];
int index = 0;
foreach (string str in originalArray)
{
    if (str.Length <= 3)
    {
        filterArray[index] = str;
        index++;
    }
}
string[] finalArray = new string[index];
Array.Copy(filterArray, finalArray, index);

Console.Write("[ ");
foreach (string str in originalArray)
{
    Console.Write(str + ", ");
}
Console.Write("] => [ ");
foreach (string str in finalArray)
{
    Console.Write(str + ", ");
}
Console.Write("]");