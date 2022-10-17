/*
: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
RandomNumbers(array);
Console.WriteLine();
PrintArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine($"всего {count} четных чисел.");

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    
    Console.WriteLine();
}