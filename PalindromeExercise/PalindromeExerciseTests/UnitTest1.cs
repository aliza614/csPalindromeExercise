using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello", false)]
        public void TestIsAPalindrome(String s, bool expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            var actual=wordSmith.IsAPalindrome(s);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
    //Red-run all tests DONE
    //green-Implement
}
