namespace LeetCode
{
    public class LeetCodeExercises
    {
        public string LongestPalindrome(string s) 
        {
            string longestPalindrome = string.Empty;

            for(int i = 0; i< s.Length - 1; i++)
            {
                for(int j = i+1 ; j < s.Length; j++)
                {
                    if(isPalindrome(s.Substring(i, j - i + 1)))
                    {
                        longestPalindrome = s.Substring(i, j - i + 1);
                    }
                }
            }
            return longestPalindrome;
        }

        public bool isPalindrome(string s)
        {
            string p = s;
            return (new string(s.ToCharArray().Reverse().ToArray())).Equals(p);
        }
    }
}