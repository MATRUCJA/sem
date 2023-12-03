//Задайте двумерный массив. Найдите элементы, 
// у которых оба
// индекса чётные, и замените 
// эти элементы на их квадраты.

/*int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    // Матрица размером rows на columns
    Random rand = new Random();
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // i, j, m , m , k
        for (int j = 0; j < columns; j++) // стлб, j < matrix.GetLength(1)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    //[rows, columns]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} "); // "\t" = tab
        }
        Console.WriteLine();
    }
}

int[,] res = CreateMatrix(3, 4, 0, 10);
// Таблица: 2 строчки, 4 столбца, элементы: [0;10]
PrintMatrix(res);*/

// Задайте двумерный массив. Найдите элементы, 
// у которых оба
// индекса чётные, и замените 
// эти элементы на их квадраты.

/*int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    // Матрица размером rows на columns
    Random rand = new Random();
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // i, j, m , m , k
        for (int j = 0; j < columns; j++) // стлб, j < matrix.GetLength(1)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    //[rows, columns]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = tab
        }
        Console.WriteLine();
    }
}

void SquareElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           if (i % 2 == 0 && j % 2 == 0) // Стр и столб - четные
           {
                matr[i, j] *= matr[i, j];
                // matr[i, j] =  matr[i, j] * matr[i, j]
           }
        }
    }
}

int[,] res = CreateMatrix(3, 4, 0, 10);
// Таблица: 2 строчки, 4 столбца, элементы: [0;10]
PrintMatrix(res); // Матрица ДО умножения
Console.WriteLine("Результат: ");
SquareElements(res); // Умножение 
PrintMatrix(res);// Матрица ПОСЛЕ умножения*/

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.


/*int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    // Матрица размером rows на columns
    Random rand = new Random();
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // i, j, m , m , k
        for (int j = 0; j < columns; j++) // стлб, j < matrix.GetLength(1)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    //[rows, columns]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = tab
        }
        Console.WriteLine();
    }
}
int MainDiagonalSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) // Глав. диагональ 
            {
                sum += matr[i, j]; // sum = sum + matr[i, j]
            }
        }
    }
    return sum;
}
int[,] res = CreateMatrix(4, 4, 0, 10);
// Таблица: 2 строчки, 4 столбца, элементы: [0;10]
PrintMatrix(res); // Матрица ДО умножения
Console.WriteLine($"Сумма элементов на гл. диагонали: {MainDiagonalSum(res)}");*/

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

/*int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    // Матрица размером rows на columns
    Random rand = new Random();
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // i, j, m , m , k
        for (int j = 0; j < columns; j++) // стлб, j < matrix.GetLength(1)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    //[rows, columns]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = tab
        }
        Console.WriteLine();
    }
}
// Вернем одномерный массив вещ. чисел
double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    // Размер массива со сред. арифм. строчки матрицы =
    // количеству строк 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum += matrix[i, j]; // Здесь сумма элементво стр
        }
        double currentMean = currentSum / matrix.GetLength(1);
        // Сумма : количество столбцов
        means[i] = currentMean;
    }
    return means;
}
int[,] res = CreateMatrix(4, 4, 0, 10);
// Таблица: 2 строчки, 4 столбца, элементы: [0;10]
PrintMatrix(res); // Матрица выводится на экран
double[] means = GetArrayWithMeans(res);
Console.WriteLine($"Массив: { string.Join(";\t", means)}");*/