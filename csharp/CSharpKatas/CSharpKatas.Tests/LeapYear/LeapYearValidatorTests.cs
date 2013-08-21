using CSharpKatas.LeapYear;
using Xunit;

namespace CSharpKatas.Tests.LeapYear
{
    public class LeapYearFacts
    {
        public class TheLeapYear
        {

            private LeapYearValidator _leapYearValidator;

            public TheLeapYear()
            {
                _leapYearValidator = new LeapYearValidator();
            }

            [Fact]
            public void ShouldBeOneThatIsDivisableBy4()
            {
                var year = 1996;

                bool isLeapYear = _leapYearValidator.IsLeapYear(year);

                Assert.True(isLeapYear);
            }

            [Fact]
            public void ShouldBeOneThatIsDivisableBy4And100And400()
            {
                var year = 2000;

                bool isLeapYear = _leapYearValidator.IsLeapYear(year);

                Assert.True(isLeapYear);
            }

            [Fact]
            public void ShouldNotBeOneThatIsDivisableBy4And100ButNot400()
            {
                var year = 1900;

                bool isLeapYear = _leapYearValidator.IsLeapYear(year);

                Assert.False(isLeapYear);
            }
        }
    }
}
