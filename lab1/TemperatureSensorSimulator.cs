using System.Text;

namespace lab1
{
    internal class TemperatureSensorSimulator
    {
        #region Members
        private List<double?> randomNumbersList = new();
        #endregion
        #region Properties
        List<double?> RandomNumbersList
        {
            get => randomNumbersList;
            set => GetReadingsList(10);
        }

        public int PrintCount { get; set; }
        #endregion
        #region Methods
        public void GetReadingsList(int count)
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

        public void SaveToFile()
        {
            string fileName = "plikDane.txt";
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);

            using (StreamWriter sw = new StreamWriter(stream))
            {
                sw.WriteLine(this.ToString());
            }
           
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            
            for (int i = 0; i < PrintCount; i++)
            {
                stringBuilder.AppendLine(string.Format($"{RandomNumbersList[i]:F2}"));
            }
            return stringBuilder.ToString();
        }
        #endregion

    }
}
