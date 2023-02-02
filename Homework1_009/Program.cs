// Удалить вторую цифру трехзначного числа
Console.WriteLine("Введите трехзначное число - ");
int Number = int.Parse(Console.ReadLine());

int firsNum=Number/100;

int secondNum=(Number-(firsNum*100))/10;

int fiNum=(Number-(firsNum*100)-(secondNum*10));

int rez= (firsNum*10)+fiNum;

Console.WriteLine(rez);


