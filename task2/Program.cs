//Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите число ");
string DayNumber = Console.ReadLine()!;

if (DayNumber == "1")
{
    Console.WriteLine("Понедельник");
}

if (DayNumber == "2")
{
    Console.WriteLine("Вторник");
}

if (DayNumber == "3")
{
    Console.WriteLine("Среда");
}

if (DayNumber == "4")
{
    Console.WriteLine("Четверг");
}

if (DayNumber == "5")
{
    Console.WriteLine("Пятница");
}

if (DayNumber == "6")
{
    Console.WriteLine("Суббота");
}

if (DayNumber == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Не день недели");
}
