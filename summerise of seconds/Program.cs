int runner1 = int.Parse(Console.ReadLine());
int runner2 = int.Parse(Console.ReadLine());
int runner3 = int.Parse(Console.ReadLine());

int seconds = runner1 + runner2 + runner3;
int minutes = 0;
if (seconds > 59)
{
    minutes++;
    seconds = seconds - 60;
}
if (seconds > 59)
{
    minutes++;
    seconds = seconds - 60;
}
if (seconds < 10)
{
    Console.WriteLine(minutes + ":" + "0" + seconds);
}
else
{
    Console.WriteLine(minutes + ":" + seconds);
}