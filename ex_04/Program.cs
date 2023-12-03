//Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// Задача 4*(не обязательно): Дано натуральное число
// в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

/*Console.Write("Введите число от 1 до 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
// Посчитаем количество цифр в числе = размер массива
int count = 0;
while (number > 0)
{
    number /= 10;
    count++; // Инкремент - увл. на 1(count = count + 1)
}
Console.WriteLine($"Количество цифр в в числе {temp} = {count}");

// 425 => [4 2 5]
int[] digits = new int[count]; // Кол-во цифр = размер массива

// Массив digits заполнен изначально нулями 
for (int i = digits.Length - 1; i >= 0; i--)
{
    digits[i] = temp % 10; // i = 2; [0 0 5]
    temp /= 10; // i = 1, number = 42, [0 2 5]
    // i = 0 , number = 4 , [4 3 5]
}
Console.WriteLine($"[ {string.Join("; ", digits)} ]");*/

//калькулятор
/*int Calculate(int a, int b, char sign)
{
    if (sign == '+') // "строчка", 'символ'
    {
        return a + b; // Отдал человеку сумму чисел
    }
    else if (sign == '-') // "строчка", 'символ'
    {
        return a - b; // Отдал человеку разность чисел
    }
    else if (sign == '*') // "строчка", 'символ'
    {
        return a * b; // Отдал человеку пр-е чисел
    }
    else if (sign == '/') // "строчка", 'символ'
    {
        return a / b;
    }
    else
    {
        Console.WriteLine("Invalid input");
        return 0;
    }
}

// Вызов метода
Console.WriteLine(Calculate(2, 3, '+')); // 5
Console.WriteLine(Calculate(2, 3, '*')); // 6
Console.WriteLine(Calculate(2, 3, '/')); // 0
Console.WriteLine(Calculate(2, 3, '-')); // -1
Console.WriteLine(Calculate(2, 3, '.')); // Invalid input, 0

int res = Calculate(2, 3, '+');
Console.WriteLine(res); // 5
*/

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2

/*int[] CreateArray(int size, int minRandom, int maxRandom)
{
    int[] array = new int[size]; // Создаем массив на size эл
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minRandom, maxRandom + 1);
    }
    return array;
}

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            count++; 
        }
    }
    return count; 
}

// Вызов метода
int[] result = CreateArray(15, 21, 100);
// Получим массив на 10 элементов, эл: [-10, 50]
Console.WriteLine($"[ {string.Join("; ", result)} ]");
Console.WriteLine($"Total: {GetCount(result)}");
*/

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size, int minRandom, int maxRandom)
{
    int[] array = new int[size]; // Создаем массив на size эл
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minRandom, maxRandom + 1);
    }
    return array;
}
int ConvertArrayToInteger(int[] arr)
{
    int result = 0;
    // i - индекс эл, j -  степень десятки 
    // Math.Pow(число, степень) => Math.Pow(2, 3) => 8
    for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
    {
        result = result + arr[i] * (int)Math.Pow(10, j);
    }
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 8)
{
    Console.WriteLine("Больше 8 элементов в массиве быть не может");
    return; // На данной строчке программа завершится
}
int[] array = CreateArray(size, 0, 9);
Console.WriteLine($"[ {string.Join("; ", array)} ]");
Console.WriteLine($"Number: {ConvertArrayToInteger(array)}");