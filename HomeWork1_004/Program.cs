// Выяснить, является ли число четным
Console.Write("Ведите число - ");
int number = int.Parse(Console.ReadLine());
int ost=(number%2);
if (ost>0)
    Console.WriteLine("Введенное число нечетное" );
else
    Console.WriteLine("Введеное число является четным");
