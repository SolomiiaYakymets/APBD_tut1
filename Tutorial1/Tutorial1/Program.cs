using Tutorial1;

Console.WriteLine("This is modification one!");
Console.WriteLine("This is modification two!");
Console.WriteLine("This is modification three!");

var numbers = Enumerable.Range(0,10).ToArray();
double average = Utility.CalculateAverage(numbers);
Console.WriteLine("Average: " + average);