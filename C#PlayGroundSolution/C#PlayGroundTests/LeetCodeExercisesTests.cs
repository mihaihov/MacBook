using LeetCode;
using ConsoleDatabase.Entities;
namespace PlayGroundTests
{
    public class LeetCodeExercisesTests
    {
        public static IEnumerable<object[]> EmployeeData => 
            new List<object[]>{
                new object[]{ new List<Employee>{ 
                                                    new Employee() {Id = 1, Salary = 350.5m} 
                                                },  null 
                            },
                new object[]{ new List<Employee> { 
                                                    new Employee() {Id = 1, Salary = 350.5m},
                                                    new Employee() {Id = 2, Salary = 450.5m},  
                                                    new Employee() {Id = 2, Salary = 550.5m}, 
                                                },  450.5m 
                            }
            };


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

        [Theory]
        [InlineData("",1,"")]
        [InlineData("a",1,"a")]
        [InlineData("PAYPALISHIRING",3,"PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING",4,"PINALSIGYAHRPI")]
        public void ZigZag_ShouldReturnCorrectResult(string s, int numrows, string result)
        {
            //arrange
            LeetCodeExercises lce = new LeetCodeExercises();

            //act
            var zigZagResult = lce.ZigZag(s,numrows);

            //assert
            Assert.Equal(result,zigZagResult);

        }

        [Theory]
        [MemberData(nameof(EmployeeData))]
        public void GetSecondBiggestSalary(IEnumerable<Employee> employees, decimal? expected)
        {
            //arrange, act
            var result = SQLExercises.SecondHighestSalary(employees);

            //assert
            Assert.Equal(expected, result);
        }
    }
}