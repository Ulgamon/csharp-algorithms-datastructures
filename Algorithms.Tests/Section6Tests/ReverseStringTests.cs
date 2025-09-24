using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section6;

namespace Algorithms.Tests.Section6
{
    public class ReverseStringTests
    {
        [Fact]
        public void IsCorrectlyReversedStringOne()
        {
            // Arrange
            StringBuilder input = new StringBuilder("nitsuJ si eman ym iH");
            string output = "Hi my name is Justin";

            // Act
            StringBuilder result = ReverseString.StringReverse(input);
            Console.WriteLine(input);
            // Assert

            Assert.True(result.ToString() == output);
        }

        [Fact]
        public void IsCorrectlyReversedStringTwo()
        {
            StringBuilder input = new StringBuilder("Testiranje Stringa Dva");
            string output = "avD agnirtS ejnaritseT";

            StringBuilder result = ReverseString.StringReverse(input);
            Console.WriteLine(input);

            Assert.True(result.ToString() == output);
        }
    }
}
