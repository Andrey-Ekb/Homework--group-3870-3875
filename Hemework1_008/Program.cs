// Дано число из отрезка(10,99). Показать наибольшую цифру числа

int Number1=10;
int Number2=99;
int NumberMax=0;


if (Number1 > Number2)
{
    NumberMax=Number1;
}
else 
{
    NumberMax=Number2;
}

Console.WriteLine("Наибольшая цифра - "+ NumberMax);