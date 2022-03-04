// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numberA = new Random().Next(100,1000);
Console.WriteLine($"число {numberA}");
int numberB = numberA / 10;
int numberC = numberB % 10;
Console.WriteLine($"вторая цифра числа {numberC}");







// Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.WriteLine("введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// if (c == a % b)
// {
//     c = 0;
//     Console.WriteLine("число кратно");
// }
// else 
// {
// c = a % b;
//     Console.WriteLine($"число не кратно, остаток {c}");
// }










// Задача 15: Дано число. Проверить кратно ли оно 7 и 23

// Console.WriteLine("введите  число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int number0 = 0;

// if (number0 == numberA % 7)
// {
//     Console.WriteLine("число кратно 7");
// }
// else if (number0 == numberA % 23)
// {
//     Console.WriteLine("число кратно 23");
// }
// else
// {
//     Console.WriteLine("число не крато ни 7 ни 23");
// }
