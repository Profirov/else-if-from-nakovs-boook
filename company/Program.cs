int projectHours = int.Parse(Console.ReadLine());
int availableDays = int.Parse(Console.ReadLine());
int overtimeWorkers = int.Parse(Console.ReadLine());

double workDays = availableDays * 0.90;
double overTime = overtimeWorkers * 2 * workDays;
double workHours = Math.Floor((double)availableDays) * 8 + overtimeWorkers;


if (projectHours > workHours)
{
    Console.WriteLine($"{projectHours/workHours} hours left");
}
else
{
    Console.WriteLine($"Not enough time!{workHours-projectHours} hours needed.");
}
