// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("Enter the length of the array --> ");
int Leng = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[Leng];

void SumOddElements(int[] Arr)
{
    int SumElements = 0;
    for (int i = 0; i < Leng; i++)
    {
        Arr[i] = new Random().Next(-99, 100);
        if (i % 2 == 1)
        {
            SumElements = SumElements + Arr[i]; 
        }
        Console.Write($"{Arr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"sum of odd elements {SumElements}");
}
SumOddElements(Arr);