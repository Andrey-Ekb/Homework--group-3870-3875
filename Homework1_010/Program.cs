// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.WriteLine("Ввети кратное число - ");
int Number1=int.Parse(Console.ReadLine());
Console.WriteLine("Ввети делитель числа - ");
int Number2=int.Parse(Console.ReadLine());
int ost=Number1 % Number2;
if (ost>0)
{ 
    Console.WriteLine("число "+ Number1 + " неявляется кратным, при делителт "+ Number2+" т.к. остаток равен "+ost);
}
else
{
    Console.WriteLine("число "+ Number1 + " является кратным, при делителт "+ Number2+", остаток равен 0");
}
