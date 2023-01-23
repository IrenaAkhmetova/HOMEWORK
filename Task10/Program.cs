// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых
 //операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трех значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
  int result = num / 10 % 10;
  return result;
}
int result = SecondDigit  (number);

if ( number < 100 || number > 999)
Console.WriteLine("не правильное число: ");
else
Console.WriteLine($"из числа {number} получили {result} ");
