// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void FillNumbers(int [] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
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

void RandomArray()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int [] array = new int [size];
    
    FillNumbers(array);
    PrintNumbers(array);
    
    int evenNumber = EvenElement(array);
    Console.WriteLine($"Колличество четных чисел - {evenNumber}");
    
}
RandomArray();

int EvenElement(int [] array)
{
    int chet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            chet ++;
        }
    }
    return chet;
}
