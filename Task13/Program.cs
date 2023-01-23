//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"из числа {number} получили {ThirdDigit} "); 


int ThirdDigit(int num)
{
    while (number > 999)
    {
        num = num  / 10 ;
        return num % 10;
    }
}

if ( number < 99 )
Console.WriteLine("третьей цифры нет");

