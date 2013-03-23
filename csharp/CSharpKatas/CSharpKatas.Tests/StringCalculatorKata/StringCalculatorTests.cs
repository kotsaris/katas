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

            [Theory]
            [InlineData("//;\n1;2")]
            public void ShouldReturnSum_WhenANewDelimiterIsIntroduced(string numbers)
            {
                var calc = GetSut();

                var result = calc.Add(numbers);

                Assert.Equal(3, result);
            }

            [Theory]
            [InlineData("-1,2")]
            [InlineData("2,-1")]
            public void ShouldThrownAnException_WhenPassedNumberIsNegative(string numbers)
            {
                var calc = GetSut();

                Assert.Throws<Exception>(() =>calc.Add(numbers));
            }

            [Fact]
            public void ShouldBeAbleToHandleAnUnknownAmountOfNumbers()
            {
                var calc = GetSut();
                var amountOfNumbers = _random.GetNextInteger(1, 1000);
                var numbers = string.Empty;
                var expectedResult = 0;
                for (int i = 0; i < amountOfNumbers; i++)
                {
                    numbers += i;
                    expectedResult += i;
                    if (i != amountOfNumbers - 1)
                        numbers += ",";
                }

                var actual = calc.Add(numbers);

                Assert.Equal(expectedResult, actual);
            }
        }
    }
}
