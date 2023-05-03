// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

void SummaMaxMinElement()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    double [] array = new double [size];
    
    FillNumbers(array);
    PrintNumbers(array);
    double max = MaxElement(array);
    double min = MinElemen(array);

    double diff = Math.Round((max - min), 2);
    Console.WriteLine($"Разница между максимальным и минимальным числом = {diff}");

}
SummaMaxMinElement();

void FillNumbers(double [] array)
{   Random doubleRandom = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = doubleRandom.Next(1, 20) + Math.Round(doubleRandom.NextDouble(), 2);
    }
}

void PrintNumbers(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double MaxElement(double [] array)
{
    int i = 0;
    double max = array[i];
    for (i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] > array[i])
        {
            max = array[i + 1];
        }        
    }
    return max;
}

double MinElemen(double [] array)
{
    int i = 0;
    double min = array[i];
    
    for (i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] < array[i])
        {
            min = array[i + 1];
        }
    }
    return min;
}

// double DifferenceMaxMin()
// {
    
//     double diff = max - min;
// }