// Вывод всех чисел от -N до N
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = -n - 1;
while (a < n)
{
    a += 1;
    Console.Write(a);
    Console.Write(' ');
}
