// Задача :Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arr = new string[] {"лом", "домик", "сон", "23456", "сок", "мандарин","111"};
string[] arr2 = new string[arr.Length];

ThreeSymbolInArr(arr, arr2);
PrintArr(arr2);

void ThreeSymbolInArr(string[] arr, string[] arr2)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
}

void PrintArr(string[] arr)
{
    
    foreach(string item in arr)
    {
        Console.Write($"{item}, ");
    } 
    Console.WriteLine();
}

