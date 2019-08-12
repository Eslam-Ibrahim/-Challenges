namespace Palindrome.Domain.Models{

	public class PalindromeGame{


		// Prop
		public string word { get;}
		public PalindromeGame(string word){
			this.word = word;
		}
		public bool PlayPalindrome(){

			// Defensive step
			if ((word == null) || (word.Length == 0) || (word.Length == 1)){
				return true;
			}
			// Else, Let's get into business
			string reverse = "";
			for (int i = word.Length-1; i >=0; i--){
					reverse += word[i];
			}
			if (word.Equals(reverse)){
				return true;
			}else{
				return false;
			}
		}
	}
}