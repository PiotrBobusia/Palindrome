using Palindrome;

do
{
    Console.Clear();
    Console.WriteLine("Please enter your string to verify palindrome:");

    string toVerify = Console.ReadLine();

    Console.WriteLine("isPalindrome: " + PalindromeVerifier.isPalindrome(toVerify));

    Console.WriteLine("\nPress [ENTER] to continue");
    Console.ReadLine();
} while (true);


