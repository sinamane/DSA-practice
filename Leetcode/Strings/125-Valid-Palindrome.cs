/*
Problem Statement:
https://leetcode.com/problems/valid-palindrome/

*/

/*
Approach 1:
Remove all non-alphanumeric charcters and convert the string to lower case.
Use two pointers moving toward the middle to each if each letters match.

Runtime: 86 ms, faster than 59.24% of C# online submissions for Valid Palindrome.
Memory Usage: 42.8 MB, less than 37.32% of C# online submissions for Valid Palindrome.

Complexity Analysis:
Time complextity:
Space complexity:
*/

using System;
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        
        if(s == " ") return true;
        string word = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();
        int left_pointer = 0, right_pointer = word.Length - 1;
        
        while(left_pointer <= right_pointer)
        {
           if(word[left_pointer] != word[right_pointer])
           {
               return false;
           }
            left_pointer++;
            right_pointer--;
        }
        
        return true;
    }
}