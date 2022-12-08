/* Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if (num_a > num_b)
{
    Console.WriteLine("Первое число " + num_a + " больше, чем второе " + num_b);
}
else
{
    Console.WriteLine("Второе число " + num_b + " больше, чем первое " + num_a);
}


Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Введите три числа");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

    Console.WriteLine("Наибольшее число -> " + max);

    
Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введиет число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine(" Число " + num + " является НЕЧЕТНЫМ");

}
else
{
    Console.WriteLine(" Число " + num + " является ЧЕТНЫМ");

}


Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2! == 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет четных чисел!");
}*/


