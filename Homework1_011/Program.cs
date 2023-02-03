// Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите число - ");
int value=int.Parse(Console.ReadLine() ??"0");
int Rez=value/100%10;

if (Rez>0)
    Console.WriteLine("Третья цифра равна - "+Rez);
else
    Console.WriteLine("В числе нет треьей цифры.");