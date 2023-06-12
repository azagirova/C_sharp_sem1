//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()!);
if(number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.Write("max = " + max + ", " + "min = " + min);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine()!);
if(number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (max > number3)
{
    max = max;
}
else
{
    max = number3;
}
Console.Write("max = " + max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine()!);
int even = number % 2;

if (even == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8



Console.Write("Напишите любое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int even = 2;
if (number > 1)
    while (even <= number)
    {
        Console.Write(even + ", ");
        even = even + 2;
    }
