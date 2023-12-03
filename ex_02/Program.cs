﻿// // Напишите программу, которая 
// // выводит случайное число из отрезка [10, 99]
// // и показывает наибольшую цифру числа.

// // Например:
// // 78 -> 8 
// // 12-> 2
// // 85 -> 8

// // [0, 3) => 0,1,2
// int number = new Random().Next(10, 100);
// // [10,99] или [10,100)
// // "/" - деление, "%" - взятие остатка
// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // 78 % 10 = 8
// // max = 7
// int max = firstDigit; // Пусть максимум - 1 цифра числа
// if (secondDigit > max) // secondDigit(8) > max(7)
// {
//     max = secondDigit; // max = 8
// }
// Console.WriteLine($"Максимальная цифра в числе {number}: {max}");

// Напишите программу, которая выводит случайное 
// трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// // [100, 999]: Next(100,1000)
// int number = new Random().Next(100, 1000);
// int firstDigit = number / 100; // 456 / 100 = 4
// int thirdDigit = number % 10; // 456 % 10 = 6
// // 4 * 10 + 6
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"{number} -> {result}");



// Напишите программу, которая принимает 
// на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23. Если число не кратно 7 и 23,
// то программа выводит остаток от деления.
 
// 14 -> нет
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" - "И", апельсины И яблоки (обязательно выполнить оба усл-я)
// "||" - "ИЛИ" (хотя бы одно условие - истина)
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Да, число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно");
    Console.WriteLine($"Остаток от деления {number} на 7 = {number % 7}");
    Console.WriteLine($"Остаток от деления {number} на 23 = {number % 23}");
}