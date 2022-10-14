// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int heigth = EnterInt("Веедите число строк: ");
int width = EnterInt("Введите число столбцов: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
FindMinRow2DArray(numbers);

int EnterInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],9}");
        }
        Console.WriteLine();
    }
}

void FindMinRow2DArray(int[,] numbers)
{   
    int minRow=0;
    int minSum=0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        minSum+=numbers[0,j];
    }  
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < numbers.GetLength(1); j++)  
        {
            sum+=numbers[i,j];
        }

        if( minSum>sum)
        {
            minSum=sum;
            minRow=i;       
        }
    }
        Console.WriteLine($"Минимальная строка: {minRow} ");
}

