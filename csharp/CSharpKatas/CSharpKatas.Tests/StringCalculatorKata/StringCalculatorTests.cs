using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpKatas.Tests.Utils;
using Xunit;
using CSharpKatas.StringCalculatorKata;
using Xunit.Extensions;

namespace CSharpKatas.Tests.StringCalculatorKata
{
    public class StringCalculatorTests
    {
        public class TheAddMethod
        {
            private RandomUtil _random = new RandomUtil();
 
            private StringCalculator GetSut()
            {
                return new StringCalculator(); ;
            }

            [Fact]
            public void ShouldReturnZeroWhenThereAreNoNumbers()
            {
                var calc = GetSut();
                
                Assert.Equal(0, calc.Add(""));
            }

            [Fact]
            public void ShouldReturnSum_WhenOneNumberIsPassed()
            {
                var calc = GetSut();

                var result = calc.Add("1");

                Assert.Equal(1, result);
            }

            [Fact]
            public void ShouldReturnSum_WhenTwoNumbersArePassed()
            {
                var calc = GetSut();

                var result = calc.Add("1,2");

                Assert.Equal(3, result);
            }

            [Theory]
            [InlineData("1,\n2")]
            [InlineData("\n1,\n2")]
            public void ShouldReturnSum_WhenNumbersIncludeNewLinesInBetween(string numbers)
            {
                var calc = GetSut();

                var result = calc.Add(numbers);

                Assert.Equal(3, result);
            }

            [Fact]
            public void ShouldReturnSum_WhenPassedNumbersAreOfVariableLength()
            {
                var calc = GetSut();
                var amountOfNumbers = _random.GetNextInteger(1, 100);
                var listOfNumbers = new List<int>();

                for (int i = 0; i < amountOfNumbers; i++)
                {
                    listOfNumbers.Add(_random.GetNextInteger(0, 1000));       
                }

                var expectedResult = listOfNumbers.Sum(x => x);
                var numbersString = "";
                foreach(var s in listOfNumbers.Select(x => "," + x))
                    numbersString += s;
                numbersString = numbersString.Remove(0, 1);

                var actualResult = calc.Add(numbersString);

                Assert.Equal(expectedResult, actualResult);
            }
        }
    }
}
