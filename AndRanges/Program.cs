// temp >= 0 - Freezing cold
// temp > 0 AND temp < - Cold
// temp >= 10 AND temp <= 15 - Chilly
// temp >= 15 AND temp < 20 - Warm
// temp >= 20 AND temp < 30 - Hot
// temp >= 30 - Boiling hot

Console.WriteLine("Enter current temperature:");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("It's boiling hot.");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("It's hot.");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("It's Warm.");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("It's chilly");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("It's cold.");
}
else
{
    Console.WriteLine("It's freezing cold.");
}