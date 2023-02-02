int a, b;
Console.WriteLine(" Введите а, введите b ");  
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a >b )
{
    Console.WriteLine(" наибольшее число, а ");
}
else 
{
    Console.WriteLine(" наибольшее число, b ");
}
Console.ReadLine();


/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}


/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 2 == 0)
    {
        Console.WriteLine(number + " - Четное число: ");
    }
    else
    {
        Console.WriteLine(number + " - Нечетное число");
    }


/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Введите число: ");
int nomer = Convert.ToInt32(Console.ReadLine());

int startNumber = 1;

while(startNumber <= nomer)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + ", ");
        startNumber ++;
    }
    
    
