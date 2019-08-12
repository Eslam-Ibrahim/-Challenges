using Palindrome.Domain.Models;
using Xunit;
using System;
namespace Palindrome.Testing
{
	public class PalindromeGameTesting{

		// Test one
		[Fact]
		public void test1(){
			// Arrange --> Expected Value
				PalindromeGame pal1 = new PalindromeGame("noon");
				bool expected = true;
				// Act --> Actual Value
				bool actual = pal1.PlayPalindrome();
				// Assert
				Assert.True(expected.Equals(actual));
		}
		// Test two
		[Fact]
		public void test2(){
			// Arrange --> Expected Value
				PalindromeGame pal2 = new PalindromeGame("civic");
				bool expected = true;
				// Act --> Actual Value
				bool actual = pal2.PlayPalindrome();
				// Assert
				Assert.True(expected.Equals(actual));
		}
		// Test three
		[Fact]
		public void test3(){
			// Arrange --> Expected Value
				PalindromeGame pal3 = new PalindromeGame("cell");
				bool expected = false;
				// Act --> Actual Value
				bool actual = pal3.PlayPalindrome();
				// Assert
				Assert.True(expected.Equals(actual));
		}

	}
		
}