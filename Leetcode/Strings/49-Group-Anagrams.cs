/*
Problem Statement:
https://leetcode.com/problems/group-anagrams/

*/

/*
Approach 1:
Convert both stings to lists.
Remove every letter in the first list from the second list. 
If a letter in the first list does not exist in the second list, return false.
However, if all the letters are removed form the second list, return true.

Runtime: 184 ms, faster than 84.68% of C# online submissions for Group Anagrams.
Memory Usage: 61 MB, less than 80.65% of C# online submissions for Group Anagrams.

Complexity Analysis:
Time complextity:
O(n * (mlogm)), where n is the length of the input array and m is the maximum length of a 
string in the array.
Space complexity:
O(n * m), where n number of unique values and m the maximum length of each sorted word.
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        
        for(int i = 0; i < strs.Length; i++)
        {
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);
            
            if(dict.ContainsKey(sortedWord))
            {
                dict[sortedWord].Add(strs[i]);
            }
            else
            {
                dict.Add(sortedWord, new List<string>(){strs[i]});
                
            }
        }
        
        var result = dict.Values.ToList();
        return result;
    }
}