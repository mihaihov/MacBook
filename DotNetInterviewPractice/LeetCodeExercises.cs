using System.Text;

namespace LeetCodeExercises
{
    public static class LeetCodeExercises
    {
        public static int RemoveStones(int[][] stones) {
            HashSet<int> Px = new HashSet<int>();
            HashSet<int> Py = new HashSet<int>();
            Dictionary<int,int> coordinatesX = new Dictionary<int,int>();
            Dictionary<int,int> coordinatesY = new Dictionary<int,int>();
            for(int i = 0; i< stones.Length; i++)
            {
                coordinatesX.Add(i,stones[i][0]);
            }

            foreach(KeyValuePair<int,int> pair in coordinatesX)
            {
                var added = Px.Add(pair.Value);
                if(added)
                {
                    coordinatesY.Add(pair.Key,pair.Value);
                }
            }

            foreach(KeyValuePair<int,int> pair in coordinatesY)
            {
                Py.Add(stones[pair.Key][1]);
            }

            return stones.Length - Py.Count;
        }

        public static string LongestPalindrome(string s)
        {
            string result = s[0].ToString();

            for(int i=0; i< s.Length - 1; i++)
            {
                for(int j = i + 1 ; j < s.Length; j++)
                {
                    string substring = s.Substring(i,j-i);
                    string reversedSubstring = substring.Reverse().ToString();
                    if(substring.Reverse().Equals(substring))
                    {
                        if(substring.Length > result.Length)
                            result = substring;
                    }
                }
            }

            return result;
        }

        public static int MaximumProductOfWordLength(string[] words)
        {
            int max = 0;
            for(int i = 0 ; i < words.Length - 1; i++)
            {
                for(int j = i+1 ; j < words.Length; j++)
                {
                    if(!words[i].Intersect(words[j]).Any())
                    {
                        max = words[i].Length * words[j].Length > max ? words[i].Length * words[j].Length : max;
                    }
                }
            }

            return max;
        }

        public static bool UniqueCharacters(string word)
        {
            if(word.Length > 128) return false;
            Dictionary<char,int> count = new Dictionary<char, int>();
            foreach(char c in word)
            {
                if(count.Keys.Contains(c))
                    return false;
                else
                    count[c] = 1;
            }
            return true;
        }

        //this assumes that the string only contains character a through z.
        //checker variable is used to store in a binary way which character was encountered so far.
        //1<<val creates a masks in the bitset which specify which character we are currently checking.
        //checker |= (1<<val) "marks" the current character as encountered in the past and stores that into 
            //the checker var.
        public static bool UniqueCharactersWithoutAdditionalDataStructure(string word)
        {
            int checker = 0;
            for(int i = 0; i< word.Length; i++)
            {
                int val = word[i] - 'a';
                if((checker & (1 << val)) > 0){
                    return false;
                }
                checker |= (1<<val);
            }
            return true;
        }

        public static bool CheckAnagrams(string word1, string word2)
        {
            if(word1.Length != word2.Length) return false;
            var word1Characters = word1.ToCharArray().ToList();
            word1Characters.Sort();
            var word2Characters = word2.ToCharArray().ToList();
            word2Characters.Sort();
            return word1Characters.SequenceEqual(word2Characters);
        }

        public static void ReplaceWhiteSpaces(string word)
        {
            var wordsWithoutSpaces = word.Split(' ').Where(w => !string.IsNullOrEmpty(w));
            word = string.Join("%20",wordsWithoutSpaces);
            Console.WriteLine(word);
        }

        public static bool PalindromPermutationCheck(string w)
        {
            int oddCharacters = 0;
            var characterWithoutSpaces = w.ToLower().ToCharArray().Where(c => c != ' ');
            Dictionary<char,int> charOccurence = new Dictionary<char, int>();
            foreach(char c in characterWithoutSpaces)
            {
                if(charOccurence.ContainsKey(c))
                    charOccurence[c]++;
                else
                    charOccurence[c] = 1;
            }

            foreach(KeyValuePair<char,int> pair in charOccurence)
            {
                if(pair.Value % 2 != 0)
                    oddCharacters ++;
                if(oddCharacters > 1)
                    return false;
            }

            return true;
        }
        //Cracking the code interview - 1.5 / page 91.
        //needs to be refactored. The interesect and diffrence operations do not account for characters position.
        //Example lepa and bale would return true even though they are not one edit away (or zero edits).
        public static bool OneWay(string word1, string word2)
        {
            if(Math.Abs(word1.Length - word2.Length) > 1)   return false;
            if(word1.SequenceEqual(word2)) return true;

            if(word1.Length == word2.Length)
            {
                IEnumerable<char> difference = word1.ToCharArray().Except(word2.ToCharArray());
                if(difference.Count() > 1) return false;
            }
            else
            {
                IEnumerable<char> intersection = word1.ToCharArray().Intersect(word2.ToCharArray());
                if(intersection.Count() != Math.Max(word1.Length, word2.Length) - 1) return false;
            }

            return true;
        }

        public static string StringCompresion(string word)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<char,int> frequencies = new Dictionary<char,int>();
            foreach(char c in word)
            {
                if(frequencies.ContainsKey(c))
                    frequencies[c]++;
                else
                    frequencies[c] = 1;
            }
            foreach(KeyValuePair<char,int> pair in frequencies)
            {
                result.Append(pair.Key);
                result.Append(pair.Value.ToString());
            }

            return result.ToString();
        }
    }

}