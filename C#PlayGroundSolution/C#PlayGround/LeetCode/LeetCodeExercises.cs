using System.Diagnostics;
using System.Text;

namespace LeetCode
{
    public class LeetCodeExercises
    {
        public string LongestPalindrome(string s) 
        {
            // Stopwatch sw = Stopwatch.StartNew();
            // if(s.Length == 1)   return s;
            // string longestPalindrome = string.Empty;

            // for(int i = 0; i< s.Length ; i++)
            // {
            //     for(int j = i ; j < s.Length; j++)
            //     {
            //         if(isPalindrome(s.Substring(i, j - i + 1)) && s.Substring(i,j-i+1).Length > longestPalindrome.Length)
            //         {
            //             longestPalindrome = s.Substring(i, j - i + 1);
            //         }
            //     }
            // }
            // sw.Stop();
            // //Console.WriteLine($"Total execution time: { sw.ElapsedMilliseconds }");
            // return longestPalindrome;

            if(s.Length == 1) return s;
            string longestPalindrome = string.Empty;
            int r,l;
            for(int i = 0; i< s.Length ;i++)
            {
                r  = l = i;
                while(true)
                {
                    if(r>=0 && l < s.Length)
                    {
                        if(s.Substring(r,l-r+1).Length > longestPalindrome.Length && s[r] == s[l])
                            longestPalindrome = s.Substring(r,l-r+1);
                    }
                    if(l<s.Length)
                    {
                        if(s.Substring(i,l-i+1).Length > longestPalindrome.Length && s[l] == s[i])
                            longestPalindrome = s.Substring(i,l-i+1);
                    }
                    if(r >= 0)
                    {
                        if(s.Substring(r,i-r+1).Length > longestPalindrome.Length && s[r] == s[i])
                            longestPalindrome = s.Substring(r,i-r+1);
                    }
                    if(r<0 && l < s.Length)
                    {
                        if(s[i] != s[l])    break;
                    }
                    if(r>=0 && l>= s.Length)
                    {
                        if(s[i] != s[r]) break;
                    }
                    if(r<0 && l>= s.Length) break;
                    if((r >= 0 && l <s.Length) && s[r] != s[l]) break;
                    r--;l++;
                }
            }

            return longestPalindrome;
        }

        public bool isPalindrome(string s)
        {
            string p = s;
            return (new string(s.ToCharArray().Reverse().ToArray())).Equals(p);
        }
    
        public string ZigZag(string s, int numRows)
        { 
            Dictionary<int, string> zigzag = new Dictionary<int, string>();
            int cKey = 1;
            int offset = -1;
            for(int i = 0; i< s.Length; i++)
            {
                if(cKey == 0)   offset = 1;
                if(cKey == numRows - 1) offset = -1;

                cKey += offset;
                if(zigzag.Keys.Contains(cKey))
                    zigzag[cKey] += s[i];
                else
                    zigzag[cKey] = s[i].ToString();

            }

            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,string> key in zigzag)
            {
                sb.Append(key.Value);
            }

            return sb.ToString();
        }
    }
}