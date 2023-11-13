int vineyardArea = int.Parse(Console.ReadLine());
double grapePerSqare = double.Parse(Console.ReadLine());
int neededLiters = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());

double harvestPerVine = grapePerSqare * vineyardArea * 0.40;
double vine = harvestPerVine / 2.5;

if (vine >= neededLiters)
{
    double vineLeft = vine / workers;
    Console.WriteLine($"Good harvester this year! Total wine {vine} litres");
    Math.Floor((vine));
    Console.WriteLine($"{vineLeft} liters left -> {vineLeft / harvestPerVine} liters per person.");
    Math.Ceiling((vineLeft));
    Math.Ceiling((vineLeft / harvestPerVine));
}
