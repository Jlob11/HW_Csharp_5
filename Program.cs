/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] array = Getarray(5, 100, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"В массиве количество четных чисел = {HowManyEven(array)}");


int HowManyEven(int[] array)
{
int count = 0;

for (int i = 0; i <= array.Length; i++)
    {
        if (i % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int[] Getarray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}




/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] array = Getarray(5, 1, 5);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {SumOdd(array)} ");


int SumOdd(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];

    }
    return sum;
}

int[] Getarray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}




/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] array = Getarray(5, 0, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Diff = {Max(array) - Min(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {MAXX(array) - Min(array)}");



double[] Getarray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {

        res[i] = new Random().NextDouble() * 100;

    }
    return res;
}



double Min(double[] array)
{
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MAXX(double[] array)
{
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}






