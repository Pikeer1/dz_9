// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

void GetSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма чисел в промежутке от M до N = {sum}"); 
        return;
    }
    sum += (m++);
    GetSum(m, n, sum);
}

GetSum(m, n, 0);