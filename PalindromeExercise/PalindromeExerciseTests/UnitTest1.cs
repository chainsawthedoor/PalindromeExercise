using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData("hello world", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("Racecar", false)]
        [InlineData("WoWiE", false)]
        
        public void Test1(string word, bool expected)
        {
            //Arrange
            var smith = new WordSmith();
            
            //Act
            var actual = smith.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
