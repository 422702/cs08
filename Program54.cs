//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int heigth = EnterInt("Веедите число строк: ");
int width = EnterInt("Введите число столбцов: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
Sort2DArray(numbers);
Console.WriteLine("Отсортированный массив");
Print2DArray(numbers, heigth, width);

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

void Sort2DArray(int[,] numbers)
{   
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1)-1; j++)  
        {
            for (int k = j+1; k < numbers.GetLength(1); k++)
            {
                if(numbers[i,j]<numbers[i,k])
                {
                    int temporary=numbers[i,j];
                    numbers[i,j]=numbers[i,k];
                    numbers[i,k]=temporary;
                }
            }
        }
    }
}
