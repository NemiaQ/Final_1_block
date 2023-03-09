/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.Write(" ]\n");
}

string[] СreateFilterArray(string[] array, int lengthString = 3)
{
    string trueIndex = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthString)
        {
            trueIndex += i.ToString();
        }
    }

    string[] filterArray = new string[trueIndex.Length];
    for (int i = 0; i < filterArray.Length; i++)
    {
        filterArray[i] = array[int.Parse(trueIndex[i].ToString())];
    }

    return filterArray;
}

string[] myArray = {"hello", "2", "world", ":-)"};
PrintArray(myArray);
string[] filterArray = СreateFilterArray(myArray);
PrintArray(filterArray);
