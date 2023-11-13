double number = double.Parse(Console.ReadLine());   
string mejor = Console.ReadLine();
string resultMejor = Console.ReadLine();

if (mejor == "mi")
{
    number = number * 0.000621;
}
if (mejor == "mm")
{
    number = number * 1000;
}
if (mejor == "ft")
{
    number = number * 3.28;
}
Console.WriteLine(number);
