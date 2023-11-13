int swimming = int.Parse(Console.ReadLine());
int traba1 = int.Parse(Console.ReadLine());
int traba2 = int.Parse(Console.ReadLine());
double notThere = double.Parse(Console.ReadLine());

double water = traba1 + traba2 * notThere;

if (water <= swimming)
{
    Console.WriteLine($"The pool is {0}% full. Pipe1: {1}%. Pipe2: {2}%.");
    Math.Truncate(0 = swimming * 100);
    Math.Truncate(water = swimming / traba1 * 100);
    Math.Truncate(water = swimming / traba2 * 100);
}
else
{
    Console.WriteLine("For {0} hours the pool overflows with {1} liters.");
}