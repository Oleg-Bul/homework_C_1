Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;
while(b < a-2)
{
    Console.WriteLine(b+2);
    b = b+2;
}