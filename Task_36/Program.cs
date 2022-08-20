// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов стоящих на нечетных позициях 
using static System.Console;
Clear ();
Write("Задайте количество элементов массива - ");
int n = int.Parse(ReadLine());
Write("Задайте минимальный элемент массива - ");
int min = int.Parse(ReadLine());
Write("Задайте максимальный элемент массива - ");
int max = int.Parse(ReadLine());
int [] array = new int [n];
FillArr(array, min, max);
Write("[");
PrintArr(array);
WriteLine("]");
WriteLine($"Суммa элементов стоящих на нечётной позиции массива равна {SumNamberOddPosition(array)}");


// Сумма элементов стоящих на нечетной позиции
int SumNamberOddPosition (int[] arr)
{
    int sum = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum = sum + arr [i];
    }
return sum;
}




// Печать массива
void PrintArr(int [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Write($"{arr [i]}");
        if (i<arr.Length-1) Write (",");
    }
}
// Задать массив
void FillArr(int[] arr, int minValue, int maxValue)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(minValue, maxValue+1);
    }
}