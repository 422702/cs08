//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int heigth2;
int heigth = EnterInt("Веедите число строк первой матрицы: ");
int width = heigth2 = EnterInt("Введите число столбцов первой, это же будет число строк второй матрицы: ");
int width2 = EnterInt("Введите число столбцов втрой матрицы: ");

int[,] numbers1 = new int[heigth, width];
Fill2DArray(numbers1, heigth, width);
Console.WriteLine("Первая матрица");
Print2DArray(numbers1, heigth, width);

int[,] numbers2 = new int[heigth2, width2];
Fill2DArray(numbers2, heigth2, width2);
Console.WriteLine("Вторая матрица");
Print2DArray(numbers2, heigth2, width2);


Console.WriteLine("Произведение двух матриц ");
int[,] multiplication = Multiplication2DMatrix(numbers1, numbers2);
Print2DArray(multiplication, heigth, width2);

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

int[,] Multiplication2DMatrix(int[,] numbers1, int[,] numbers2)
{
    int[,] multiplication = new int[numbers1.GetLength(0), numbers2.GetLength(1)];

    for (int i = 0; i < numbers1.GetLength(0); i++)
        for (int k = 0; k < numbers2.GetLength(1); k++)
            for (int j = 0; j < numbers2.GetLength(0); j++)
                {
                    multiplication[i, k] += numbers1[i, j] * numbers2[j, k];
                }
    return multiplication;
}
