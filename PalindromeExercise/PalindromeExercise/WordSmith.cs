using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			if (word == null || word  == "") return false;
			char[] charArray = word.ToCharArray();
			Array.Reverse(charArray);
			string reversedWord = new string(charArray);

			if (reversedWord == word)
			{
				return true;
			} else
			{
				return false;
			}
		}
	}
}
