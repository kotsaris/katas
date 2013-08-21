namespace CSharpKatas.LeapYear
{
    public class LeapYearValidator : ILeapYearValidator
    {
        public bool IsLeapYear(int year)
        {
            return IsDivisableByFour(year) && (!IsDivisableByAHundred(year) || IsDivisableByAHundredAndFourHundred(year));
        }

        private bool IsDivisableByAHundredAndFourHundred(int year)
        {
            return (IsDivisableByAHundred(year) && IsDivisableByFourHundred(year));
        }

        private bool IsDivisableByFourHundred(int year)
        {
            return (year % 400) == 0;
        }

        private bool IsDivisableByAHundred(int year)
        {
            return (year % 100) == 0;
        }

        private bool IsDivisableByFour(int year)
        {
            return (year % 4) == 0;
        }
    }
}
