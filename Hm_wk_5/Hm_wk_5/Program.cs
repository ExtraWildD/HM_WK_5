/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Enter the number of array elements: ");
int f = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[f];

void Show(int x)
    {
        for (int i = 0; i < f; i++)
        {
            Array[i] = new Random().Next(99,999);
        Console.WriteLine(Array[i] + " ");
        }
    }

int Fill(int[]  Array)
    {
        int k = 0;
        for (int i = 0; i < Array.Length; i++)
            {
              if (Array[i] % 2 == 0)
              k++;   
            }
        return k;
    }

Show(f);
Console.WriteLine($"Number of even numbers in the array:{Fill(Array)}");
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Enter the number of array elements: ");
int f = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[f];

void Show(int x)
{
    for (int i = 0; i < f; i++)
    {
        Array[i] = new Random().Next(1,9);
        Console.WriteLine(Array[i] + " ");
    }
}
int Count(int[] Array)
{
    int sum = 0;
    int i = 0;
    while (i < Array.Length)
    {
        sum = sum + Array[i];
        i += 2;
    }
    return sum;
}
Show(f);
Console.WriteLine($"Sum of elements in odd positions: {Count(Array)}");
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/