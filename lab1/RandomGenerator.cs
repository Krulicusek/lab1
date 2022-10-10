using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class RandomGenerator
    {
        #region Methods
        public List<double> GetRandomNumbersList(int count)
        {
            List<double> numbers = new List<double>();  
            for (int i = 0; i <= count; i++)
            {
               Random rand = new();
               numbers.Add(rand.NextDouble());   
            }
            return numbers;
        }
        #endregion
    }
}
