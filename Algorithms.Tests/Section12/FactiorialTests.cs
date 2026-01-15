using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section12;

namespace Algorithms.Tests.Section12
{
    public class FactiorialTests
    {
        [Fact]
        public void FactorialSimpleTest()
        {
            long factorial = Factorial.FactorialFunction(1);

            Assert.Equal(1, factorial);
        }

        [Fact]
        public void FactorialMiddleTest()
        {
            long factorial = Factorial.FactorialFunction(10);

            Assert.Equal(3628800, factorial);
        }

        [Fact]
        public void FactorialBigTest()
        {
            long factorial = Factorial.FactorialFunction(20);

            long result = 2432902008176640000;

            Assert.Equal(result, factorial);
        }
    }
}
