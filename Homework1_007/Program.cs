// Показать вторую цифру трехзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int Number=int.Parse(Console.ReadLine());
string strNumber=Number.ToString();
    char Number2=strNumber[strNumber.Length-2];
    Console.WriteLine("вторая цифра равна - "+Number2);
 