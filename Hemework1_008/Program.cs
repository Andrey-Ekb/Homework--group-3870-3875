// Дано число из отрезка(10,99). Показать наибольшую цифру числа

int Number=new Random().Next(10,99);
Console.WriteLine(Number);
int NumberMax=0;

int Number1=Number/10;
int Number2=Number%10;

if (Number1 > Number2)
{
    NumberMax=Number1;
}
else 
{
    NumberMax=Number2;
}

Console.WriteLine("Наибольшая цифра числа - "+Number + " является цифра - "+NumberMax);