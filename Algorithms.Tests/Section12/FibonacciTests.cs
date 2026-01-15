using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section12;

namespace Algorithms.Tests.Section12
{
    public class FibonacciTests
    {
        [Fact]
        public void FibonacciTestValid()
        {
            int ficonacci = Fibonacci.FibonacciFunction(10);

            int result = 55;

            Assert.Equal(result, ficonacci);
        }

        [Fact]
        public void FibonacciTestValidMiddle()
        {
            int ficonacci = Fibonacci.FibonacciFunction(16);

            int result = 987;

            Assert.Equal(result, ficonacci);
        }

        [Fact]
        public void FibonacciTestRecursiveValid()
        {
            int ficonacci = Fibonacci.FibonacciRecursive(10);

            int result = 55;

            Assert.Equal(result, ficonacci);
        }

        [Fact]
        public void FibonacciTestRecursiveValidMiddle()
        {
            int ficonacci = Fibonacci.FibonacciRecursive(16);

            int result = 987;

            Assert.Equal(result, ficonacci);
        }
    }
}
