using lab1;

int randomNumbersCount = 10;
RandomGenerator randomGenerator = new();
List<double> randomList = randomGenerator.GetRandomNumbersList(randomNumbersCount);
for (int i = 0; i < randomNumbersCount; i++)
{
    Console.WriteLine(randomList[i]);
}