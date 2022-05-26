//программа принимает 2 числа  и проверяет является ли второе число квадратом
Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n2 == n1 * n1)
{
    Console.WriteLine("Да");
}
else
{

    Console.WriteLine("Нет");
}

