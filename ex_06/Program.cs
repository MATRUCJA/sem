//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении 
//которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца
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
// indexes = [row, column]
int[] GetIndexMinElement(int[,] matrix)
{
    int[] indexes = new int[2]; // Массив на 2 эл, сост из нулей
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // 5000 > 1, min = 1
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] GetResultMatrix(int[,] matrix, int[] indexes)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0; // Нужны для обхода result
    int col = 0; // Нужны для обхода result
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, col] = matrix[i, j];
            col++; // Переход к след. элементу матрицы result
        }
        col = 0; // Закончил строчку, обнулил счетчик
        row++; // Иду к новой строчке матрицы result
    }
    return result;
}
int[,] res = CreateMatrix(4, 4, 0, 10);
PrintMatrix(res); 
Console.WriteLine($"Мин. элемент: [{string.Join("; ",GetIndexMinElement(res))}]");
PrintMatrix(GetResultMatrix(res, GetIndexMinElement(res)));*/


//Строчка - массив символов, символ - char
// Строка - массив char-ов
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
/*string GetStringFromCharArray(char[] array)
{
    string result = String.Empty; // ""
    // тип_данных имя in массив
    // var - дин. определение типа данных
    foreach (var symbol in array) // symbol = a,b,c,d
    {
        result = result + symbol;
    }
    return result;
}

char[] chars = { 'H', 'e', 'l', 'l', 'o' };
string result = GetStringFromCharArray(chars);
Console.WriteLine($"Result: {result}");*/


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

/*char[] ConvertToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}
Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
char[] chars = ConvertToCharArray(inputString);
Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");*/


// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

/*int GetVovelsCount(string str)
{
    // str = "Hi"
    string vovels = "aoueiy"; // Гласные буквы в 1 строчке
    int count = 0; // Количество гласных
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vovels.Length; j++)
        {
            if (str[i] == vovels[j]) 
            {
                count++; // Гласная найдена
            }
        }
    }
    return count; //Кол-во гласных
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
int countVovels = GetVovelsCount(inputString);
Console.WriteLine($"Количество гласных символов: {countVovels}");*/

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount(string str)
{
    // str = "Hi"
    char[] vovels = { 'a', 'o', 'e', 'i', 'y', 'u' };
    // "aoueiy"; // Гласные буквы в 1 строчке
    int count = 0; // Количество гласных
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vovels.Length; j++)
        {
            if (str[i] == vovels[j])
            {
                count++; // Гласная найдена
            }
        }
    }
    return count; //Кол-во гласных
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
int countVovels = GetVovelsCount(inputString);
Console.WriteLine($"Количество гласных символов: {countVovels}");