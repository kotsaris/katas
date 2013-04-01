using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.Anagram
{
    public class Anagramer
    {
        public string[] Generate(string word)
        {
            var chars = word.ToList();
            return Anagram(chars).ToArray();
        }

        private List<string> Anagram(List<char> chars)
        {
            var result = new List<string>();
            if (chars.Count() == 1)
                result.Add(chars.First().ToString());

            for (var i = 0; i < chars.Count(); i++)
            {
                var i1 = i;
                var subs = Anagram(chars.Where((item, index) => index != i1).ToList());
                result.AddRange(subs.Select(sub => chars.ElementAt(i) + sub));
            }

            return result;
        }
    }
}
