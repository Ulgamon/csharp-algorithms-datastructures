using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section7;

namespace Algorithms.Tests.Section7Tests
{
    public class FirstRecurringCharacterTests
    {

        // Given an array = [2,5,1,2,3,5,1,2,4]
        // It should return 2

        // Given an array = [2,1,1,2,3,5,1,2,4]
        // It should return 1

        // Given an array = [2,3,4,5]
        // It should return null
        [Fact]
        public void FirstRecurringCharacterTestOne()
        {
            int[] array = [2, 5, 1, 2, 3, 5, 1, 2, 4];

            int? result = FirstRecurringCharacter.FirstRecurringCharacterMethod(array);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FirstRecurringCharacterTestTwo()
        {
            int[] array = [2, 1, 1, 2, 3, 5, 1, 2, 4];

            int? result = FirstRecurringCharacter.FirstRecurringCharacterMethod(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void FirstRecurringCharacterTestThree()
        {
            int[] array = [2, 3, 4, 5];

            int? result = FirstRecurringCharacter.FirstRecurringCharacterMethod(array);

            Assert.Null(result);
        }

        [Fact]
        public void FirstRecurringCharacterTestFour()
        {
            int[] array = [];

            int? result = FirstRecurringCharacter.FirstRecurringCharacterMethod(array);

            Assert.Null(result);
        }
    }
}
