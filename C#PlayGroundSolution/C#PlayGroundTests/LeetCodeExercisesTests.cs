using LeetCode;

namespace PlayGroundTests
{
    public class LeetCodeExercisesTests
    {
        [Theory]
        [InlineData("abab","aba")]
        [InlineData("aaaaaaaaa","aaaaaaaaa")]
        [InlineData("x","x")]
        [InlineData("","")]
        [InlineData("ac","a")]
        [InlineData("cbbd","bb")]
        [InlineData("aacabdkacaa","aca")]
        [InlineData("abcba","abcba")]
        [InlineData("cappacx","cappac")]
        public void LongestPalindrome_ReturnCorrectResult(string s, string expected)
        {
            //arrange
            LeetCodeExercises lce = new LeetCodeExercises();

            //act
            var result = lce.LongestPalindrome(s);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LongestPalindrome_ShouldReturnTheStringWhenLengthIsOne()
        {
            //arrange
            LeetCodeExercises lce = new LeetCodeExercises();
            
            //act
            var result = lce.LongestPalindrome("a");

            //assert
            Assert.Equal("a", result);
        }
    }
}