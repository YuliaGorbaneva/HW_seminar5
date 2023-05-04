// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SummaMasiva()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int [] array = new int [size];
    
    FillNumbers(array);
    PrintNumbers(array);
   
    int sum = SummaOddIndex(array);
    Console.WriteLine($"Сумма элементов с нечетными индексами = {sum}");
}
SummaMasiva();

void FillNumbers(int [] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 100);
    }
}

void PrintNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

int SummaOddIndex(int [] array)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
           sum = sum + array[i];
        }
        if (array.Length == 1)
        {
            sum = array[i];
        }
    }
    return sum;
}
