Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
else if (b < max)   
{
    max = a;
}

if (c > max)
{
    max = c;
}
else if (c < max)
{
    max = max;
}

Console.WriteLine("Максимальное число " + max);
