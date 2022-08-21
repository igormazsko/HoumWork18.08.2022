// Задача 38: Задайте массив вещественных чисел. Найдите разницу между мфксимальным и минимальным элементов массива. 
using static System.Console;
Clear ();
Write("Задайте количество элементов массива - ");
int n = int.Parse(ReadLine());
// Write("Задайте минимальный элемент массива - ");
// double min = Convert.ToDouble(ReadLine());
// Write("Задайте максимальный элемент массива - ");
// double max = Convert.ToDouble(ReadLine());
double [] array = new double [n];
FillArr(array);
Write("[");
PrintArr(array);
WriteLine("]");
WriteLine($"Максимальное число массива {FindMax(array)}");
WriteLine($"Минимальное число массива {FindMin(array)}");
WriteLine($"Разница между максимальным и минимальным равна {FindMax(array)-FindMin(array)}");


// Задать массив
void FillArr(double[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr [i] = new Random().NextDouble();
    }
}
// Печать массива
void PrintArr(double [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Write($"{arr [i]}");
        if (i<arr.Length-1) Write (" ");
    }
}

// поиск максимального
double FindMax(double[] array)
{
    double max = array[0];
    foreach(double item in array)
    {
        if (item>max)
        {
            max = item;
        }
    }
    return max;
}

// поиск минимального
double FindMin(double[] array)
{
    double min = array[0];
    foreach(double item in array)
    {
        if (item<min)
        {
            min = item;
        }
    }
    return min;
}