int number = int.Parse(Console.ReadLine());
double bonusPointys = 0.0;
if (number <= 100)
{
    bonusPointys = 5;
}
else if (number > 100)
{
    bonusPointys = number * 0.20;
}
else if (number > 1000)
{
    bonusPointys = number * 0.10;
}
 if (number % 10 == 5)
{
    bonusPointys += 2;
}
else if (number % 2 == 0)
{
    bonusPointys += 1;
}

    

Console.WriteLine(bonusPointys);
Console.WriteLine(number  + bonusPointys);