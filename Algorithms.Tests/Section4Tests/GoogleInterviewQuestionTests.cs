using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Exercises;

namespace Algorithms.Tests.ExercisesTests
{
    public class GoogleInterviewQuestionTests
    {
        [Fact]
        public void hasPairWithSum1()
        {
            List<int> array = [1, 2, 3, 9];
            int sum = 8;

            bool result = GoogleInterviewQuestion.hasPairWithSum(array, sum);

            Assert.False(result);
        }

        [Fact]
        public void hasPairWithSum2()
        {
            List<int> array = [1, 2, 4, 4];
            int sum = 8;

            bool result = GoogleInterviewQuestion.hasPairWithSum(array, sum);

            Assert.True(result);
        }
    }
}
