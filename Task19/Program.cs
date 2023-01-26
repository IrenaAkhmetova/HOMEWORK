/* Задача 19 Напишите программу,
 которая принимает на вход пятизначное число
  и проверяет,
   является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arry = new int [5];
int i = 4;

 while ( i > 0)
{
   arry [i] = number % 10;
    number /= 10;
    i--;
}  
    if (arry [0] == arry [4] && arry [1] == arry [3])
    {
        Console.WriteLine ("Число является полидромом");
    }
    else 
    {
        Console.WriteLine ("Число не является полидромом");
    }






