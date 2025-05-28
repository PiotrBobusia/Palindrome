namespace Palindrome.Tests
{
    public class PalindromeVerifierTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("Kajak")]
        [InlineData("A to, idiota!")]
        [InlineData("Engage le jeu que je le gagne.")]
        [InlineData("Was it a car or a cat I saw?")]
        public void isPalindrome_verifyTruePalindroms_returnTrue(string value)
        {
            // arrange


            //act
            var result = PalindromeVerifier.isPalindrome(value);

            //assert
            Assert.True(result);
        }


        [Theory]
        [InlineData("Kajag")]
        [InlineData("A to, debil!")]
        [InlineData("Ala ma kota")]
        [InlineData("Was it a dog or a cat I saw?")]
        public void isPalindrome_verifyNotPalindroms_returnFalse(string value)
        {
            // arrange


            //act
            var result = PalindromeVerifier.isPalindrome(value);

            //assert
            Assert.False(result);
        }

    }
}