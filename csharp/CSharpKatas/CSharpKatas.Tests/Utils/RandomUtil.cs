using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.Tests.Utils
{
    public class RandomUtil
    {
        private Random _random = new Random(Guid.NewGuid().GetHashCode());

        public int GetNextInteger(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }

        public int GetNextInteger()
        {
            return _random.Next();
        }
    }
}
