//  найти факториал  - От 1 до n: n! = 1 * 2... * n
// 4! = 1 * 2 * 3 * 4 = 24

/*int FindFactorial(int n)
{
    // 5! = 5 * 4
    // n! = n * ... * 1
    // Базовый случай - выход из рекурсии
    if (n == 1) return 1;
    // Рекурсивный случай - работу рекурсии 
    return n * FindFactorial(n - 1);
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Факториал от числа {N} = {FindFactorial(N)}");*/


// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N = 5 => "1 2 3 4 5"

/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// start = 1, end = N
string PrintNumbers(int start, int end)
{
    // Базовый случай , N = 5 => "1 2 3 4 5"
    if (start == end) return start.ToString();
    // Рекурсивный случай
    return start + " " + PrintNumbers(start + 1, end);
}

Console.WriteLine($"Печать чисел от 1 до {N} = {PrintNumbers(1, N)}");*/


// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    // Базовый случай - случаи выхода из рекурсии 
    if (num / 10 == 0) return num; // 45 => 5 + 4
    // Рекурсивный случай
    return num % 10 + SumNumbers(num / 10);
}

Console.WriteLine($"Сумма цифр от {number} = {SumNumbers(number)}");



