using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpKatas.Anagram;
using Xunit;
using Xunit.Extensions;

namespace CSharpKatas.Tests.Anagram
{
    public class AnagramerTests
    {
        public class Generate
        {
            [Fact]
            public void ShouldAnagramCorrectly()
            {
                var sut = new Anagramer();
                var value = "biro";

                var result = sut.Generate(value).OrderBy(x => x);
                var expected = TakeExerciseExpectedResult().OrderBy(x => x);
                Assert.Equal(result, expected);
            }

            private string[] TakeExerciseExpectedResult()
            {
                return ("biro bior brio broi boir bori" +
                " ibro ibor irbo irob iobr iorb" +
                " rbio rboi ribo riob roib robi" +
                " obir obri oibr oirb orbi orib").Split(' ').ToArray();
            }
        }
    }
}
