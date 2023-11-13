int km = int.Parse(Console.ReadLine()); 
string timeOfTheDay = Console.ReadLine();

double cheapest = 0;

double taxi = 0;

if (timeOfTheDay == "day")
{
    taxi = 0.79;
}
else
{
    taxi = 0.90;
}
if (km < 20)
{
    cheapest = 0.70 + km * taxi;
}
else if (km < 100)
{
    cheapest = km * 0.9;
}
else
{
    cheapest = km * 0.06;
}
Console.WriteLine(cheapest);
