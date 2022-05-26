// Вывод всех чисел от -N до N
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = -n;
while (a <= n)
{
    Console.Write(a);
    Console.Write(' ');
    a+=1;
}
