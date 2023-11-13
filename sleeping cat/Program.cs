int  holiday = int.Parse(Console.ReadLine());

double working = 365 - holiday;
double totalPlayMinyte = working * 63 + holiday * 127;

double different =  Math.Abs(totalPlayMinyte - 30000);
double hours = different / 60;
double minutes = different % 60;

if (totalPlayMinyte > 30000)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes for play.");
}
else
{
    Console.WriteLine("Tom sleep well");
    Console.WriteLine($"{hours} hours and {minutes} less for play.");
}