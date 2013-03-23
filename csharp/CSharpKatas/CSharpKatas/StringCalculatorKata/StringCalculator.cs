using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpKatas.StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var defaultSeparators = new List<string>{",", "\n" };
            AddSeparatorIfProvided(defaultSeparators, numbers);
            RemoveCustomSeparatorPart(ref numbers);
            numbers = numbers.Replace(Environment.NewLine, "");
            var numbersCol = numbers.Split(defaultSeparators.ToArray(), StringSplitOptions.None).Select(int.Parse);
            if (numbersCol.Any(x => x < 0))
                throw new Exception("Hey, no negatives!");
            return numbersCol.Sum(x => x);
        }

        private void RemoveCustomSeparatorPart(ref string numbers)
        {
            if (numbers.StartsWith("//"))
                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
        }

        private void AddSeparatorIfProvided(List<string> defaultSeparators, string numbers)
        {
            //var regex = new Regex(@"//[.]*\n");
            //if (!regex.IsMatch(numbers))
            //    return;
            //defaultSeparators.Add(regex.Match(numbers).Captures[0].Value);

            if(numbers.StartsWith(@"//"))
                defaultSeparators.Add(numbers.Substring(2, numbers.IndexOf("\n") - 2));
        }
    }
}
