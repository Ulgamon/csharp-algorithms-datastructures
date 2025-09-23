using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Exercises;

namespace Algorithms.Tests.ExercisesTests
{
    public class InterviewQuestionTests
    {
        [Fact]
        public void TestWithParameters1()
        {
            //Arrange
            char[] array1 = ['a', 'b', 'c', 'x'];
            char[] array2 = ['z', 'y', 'i'];

            //Act
            bool result = InterviewQuestion.FindCommonItem(array1, array2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TestWithParameters2()
        {
            //Arrange
            char[] array1 = ['a', 'b', 'c', 'x'];
            char[] array2 = ['z', 'y', 'x'];

            //Act
            bool result = InterviewQuestion.FindCommonItem(array1, array2);

            //Assert
            Assert.True(result);
        }
    }
}
