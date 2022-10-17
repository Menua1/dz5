/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите размер массива и нажмите Enter");
int size = int.Parse(Console.ReadLine());
int[] num = new int[size];
RandomNumbers(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
int summ = 0;

for (int z = 1; z < num.Length; z+=2)
    summ = summ + num[z];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов на нечётных позициях = {summ}");

void RandomNumbers(int[] num)//заполнение массива
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(10,100);
        }
}
void PrintArray(int[] num)//печать массива
{

    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.WriteLine();
}