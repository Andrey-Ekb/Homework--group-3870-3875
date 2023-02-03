// По заданному номеру дня недели выяснить его название.
Console.WriteLine("Введите число от 1 до 7");
int Number=int.Parse(Console.ReadLine() ?? "0");
Number=Number-1;
string[]array={"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
if(Number<=7)
    Console.WriteLine("день недели - " + array[Number]);
else
    Console.WriteLine("несоотвуествие диапозона, попробуйте ещё");
