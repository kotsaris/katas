using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var separator = ',';
            numbers = numbers.Replace(Environment.NewLine, "");
            var numbersCol = numbers.Split(separator).Select(int.Parse);

            return numbersCol.Sum(x => x);
        }
    }
}
