/*
Problem Statement:
https://leetcode.com/problems/valid-palindrome/

*/

/*
Approach 1:
Remove all non-alphanumeric charcters and convert the string to lower case.
Use two pointers moving toward the middle to each if each letters match.

Runtime: 154 ms, faster than 7.29% of C# online submissions for Valid Anagram.
Memory Usage: 40.9 MB, less than 24.75% of C# online submissions for Valid Anagram.

Complexity Analysis:
Time complextity:
Space complexity:
*/

using System.Collections.Generic;

public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) return false;
        
        List<char> sList = s.ToList();
        List<char> tList = t.ToList();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(!tList.Remove(sList[i])) return false;
        }
        
        return true;

    }
}

/*
Approach 2:
Remove all non-alphanumeric charcters and convert the string to lower case.
Use two pointers moving toward the middle to each if each letters match.

Runtime: 80 ms, faster than 77.29% of C# online submissions for Valid Anagram.
Memory Usage: 39.7 MB, less than 84.71% of C# online submissions for Valid Anagram.

Complexity Analysis:
Time complextity:
Space complexity:
*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) return false;
        
        int[] counter = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }
        
        foreach(int c in counter)
        {
            if(c != 0) return false;
        }
        
        return true;

    }
}