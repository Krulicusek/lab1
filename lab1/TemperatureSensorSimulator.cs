using System.Text;

namespace lab1
{
    internal class TemperatureSensorSimulator
    {
        private List<double?> randomNumbersList = new();
        #region Members
        List<double?> RandomNumbersList
        {
            get => randomNumbersList;
            set => GetRandomNumbersList(10);
        }
        #endregion
        #region Methods
        public void GetRandomNumbersList(int count)
        {
            List<double?> numbers = new List<double?>();
            for (int i = 0; i <= count; i++)
            {
                Random rand = new();

                numbers.Add(GetNewReading());
            }
            randomNumbersList =  numbers;
        }
        public double? GetNewReading()
        {
            Random random = new();
            int reading = random.Next(-100, 101);
            if (reading <= -80)
            {
                return null;
            }
            if (reading == 100)
            {
                return reading;
            }
            double readingAsDouble = (double) (reading + random.NextDouble());
            return readingAsDouble;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            
            foreach (double? number in randomNumbersList)
            {
                stringBuilder.AppendLine(string.Format($"{number:F2}"));
            }
            return stringBuilder.ToString();
        }
        #endregion

    }
}
