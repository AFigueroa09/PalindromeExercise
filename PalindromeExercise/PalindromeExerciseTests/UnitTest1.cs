using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
		[Theory]
		[InlineData("racecar", true)] // ← you will need to put some test data and expected result here.  
		[InlineData("face", false)]
		[InlineData("tacocat", true)]
		[InlineData("", false)]
		[InlineData(null, false)]
		public void PalindromeTester(string word, bool expected)
		{
			//Arrange
			var wordSmith = new WordSmith();

			//Act
			var actual = wordSmith.IsAPalindrome(word);

			//Assert
			Assert.Equal(expected, actual);
		}
	}
}
