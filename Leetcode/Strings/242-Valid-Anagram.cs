/*
Problem Statement:
https://leetcode.com/problems/valid-anagram/

*/

/*
Approach 1:
Convert both stings to lists.
Remove every letter in the first list from the second list. 
If a letter in the first list does not exist in the second list, return false.
However, if all the letters are removed form the second list, return true.

Runtime: 154 ms, faster than 7.29% of C# online submissions for Valid Anagram.
Memory Usage: 40.9 MB, less than 24.75% of C# online submissions for Valid Anagram.

Complexity Analysis:
Time complextity:
O(n), we loop through each character of the first string once.
Space complexity:
O(2n), 
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
Create an integer array of size 26, representing all letters of the alphabet.
Using a forloop increase the value of the integer array using an index determined by finding ascii
value of a character in the first string. We decrese the same valuse based on the second string.
Use a foreach loop to ensure that all values in the integer array equal to zero. 
If not false, otherwise return true. 

Runtime: 80 ms, faster than 77.29% of C# online submissions for Valid Anagram.
Memory Usage: 39.7 MB, less than 84.71% of C# online submissions for Valid Anagram.

Complexity Analysis:
Time complextity:
O(n), we loop through each character of both strings once.
Space complexity:
O(1), because the size of the integer array is constant
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