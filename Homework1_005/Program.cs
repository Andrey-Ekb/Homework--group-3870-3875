// Показать четные числа с 1 по N.
Console.Write("Введите последнее число - ");
int n= int.Parse(Console.ReadLine());
int number = 2;
while(number<=n)
{
    Console.WriteLine(number);
    number=number+2;
}