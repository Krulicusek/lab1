using lab1;

int randomNumbersCount = 10;
TemperatureSensorSimulator temperatureSensorSimulator = new();
temperatureSensorSimulator.GetReadingsList(randomNumbersCount);
Console.WriteLine("Enter the count of numbers to print.");
int number; 
bool success = int.TryParse(Console.ReadLine(), out number);
if (success && number >= 0)
{
    temperatureSensorSimulator.PrintCount = number;
}
else
{
    Console.WriteLine("There was an error trying to parse input, are you sure that you are providing a positive intiger value?");
}
temperatureSensorSimulator.SaveToFile();
Console.WriteLine(temperatureSensorSimulator.ToString());