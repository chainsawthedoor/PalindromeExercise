namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        if (word == null || word.Length == 0)
        {
            return false;
        }
        
        string wordLower = word.ToLower();
        string backwards = "";

        for (int i = wordLower.Length - 1; i >= 0; i--)
        {
            backwards += word[i];
        }
        
        return wordLower == backwards;
        
        // if (word == backwards)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
    }
}