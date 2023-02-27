// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которого меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Напишите, что хотите и программа будет искать массив меньше трёх символов: "); 
string[] str1 = Console.ReadLine().Split(' '); // заведение элементов в массив из строки 
string[] str2 = new string[str1.Length];

void SecondArrayWithIF(string[] str1, string[] str2)
{
    int count = 0;
    for (int i = 0; i < str1.Length; i++)
    {
    if(str1[i].Length <= 3)
        {
        str2[count] = str1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(str1, str2);
PrintArray(str2);