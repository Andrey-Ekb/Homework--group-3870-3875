// Показать последнюю цифру трехзначного числа
Console.Clear();
Console.Write("Введите трехзначное число ");
int Number=int.Parse(Console.ReadLine());
string strNumber=Number.ToString();
    char Number3=strNumber[strNumber.Length-1];
    Console.WriteLine("последняя цифра - "+Number3);
