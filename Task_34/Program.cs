// Задача 34: Задайте массив заполненный случайными положительными числами. Напишите программуБ которая покажет количество чётных чисел в массиве
using static System.Console;
Clear ();
Write("Задайте количество элементов массива - ");
int n = int.Parse(ReadLine());
int [] array = new int [n];
FillArr(array);
Write("[");
PrintArr(array);
WriteLine("]");
WriteLine($"Количество четных чисел - {QuantityEven(array)}");

// Метод подсчет четных
int QuantityEven(int[] arr)
{
    int a = 0;
    for(int i=0; i<n; i++)
    {
        if(array[i]%2==0)
        {
            a = a + 1;
        }
        a = a + 0;
    }
return a;
}

// Методз задать массив
void FillArr(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(100, 1000);
    }
}

// Метод печать массива
void PrintArr(int [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Write($"{arr [i]}");
        if (i<arr.Length-1) Write (",");
    }
}
