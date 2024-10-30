using Xunit;
using LeetCode;

namespace LeetCodeTests
{
    public class LongestPalindrome
    {
        [Fact]
        public void ReturnsLongestPalindrome()
        {
            //arrange
            LeetCodeExercises lce = new LeetCodeExercises();
            
            //act
            var result = lce.LongestPalindrome("abab");

            //assert
            Assert.Equal("aba", result);
        }
    }
}