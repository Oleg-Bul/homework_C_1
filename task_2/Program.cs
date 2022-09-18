Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
     Console.WriteLine("Максимальное число a = " +  a);
}
else if(a < b)
{
   Console.WriteLine("Максимальгное число b = " + b); 
}
else
{
    Console.WriteLine("Число a и b равны");
}