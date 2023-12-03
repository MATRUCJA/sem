// Программа, которая на вход принимает число и выдает его квадрат 
// using System.Data;

// int number = -5;
// int result = number * number;
// Console.Write("результат: " + result);
// Console.Write("Результат: ");
// Console.Write(result);



// //новая Программа
// // Задача №3. Напишите программу, которая будет 
// // выдавать название дня недели по заданному номеру.
// // 3 -> Среда 
// // 5 -> Пятница
// // camelCase: 1 буква - маленькая, следующее слово
// // начинается с большой буквы
// Console.Write("Введите номер дня недели: ");
// int numberOfDays = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство (5 == 5 => true)
// if (numberOfDays == 1) // В numberOfDays лежит цифра 1
// {
//     Console.WriteLine("Понедельник");
// }
// else if (numberOfDays == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (numberOfDays == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (numberOfDays == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (numberOfDays == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (numberOfDays == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (numberOfDays == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else // Все случаи, когда numberOfDays <= 0 и numberOfDays > 7
// {
//     Console.WriteLine("Такого дня недели НЕТ");
// }


//новая Задача
// Задача №5. Напишите программу, 
// которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в
// промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); 
if (N < 0)
{
    N *= -1; // Если N - отрц. число, делаю из него положительное
}
int negativeN = N * -1; 

while (negativeN <= N) // negN = -2,-1,0,1,2
{
    Console.Write(negativeN + " "); // -2
    // negativeN++; // Инкремент: увл. negativeN на 1(negativeN = negativeN +1)
    negativeN += 1; // negativeN = negativeN + 1
}