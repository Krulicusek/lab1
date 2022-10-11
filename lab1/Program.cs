using lab1;

int randomNumbersCount = 10;
TemperatureSensorSimulator temperatureSensorSimulator = new();
temperatureSensorSimulator.GetRandomNumbersList(randomNumbersCount);
Console.WriteLine(temperatureSensorSimulator.ToString());