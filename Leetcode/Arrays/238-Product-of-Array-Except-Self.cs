/*
Problem Statement:
https://leetcode.com/problems/product-of-array-except-self/

*/

/*
Approach 1:
Two pointer

Runtime: 180 ms, faster than 32.81% of C# online submissions for Product of Array Except Self.
Memory Usage: 54.3 MB, less than 62.50% of C# online submissions for Product of Array Except Self.

Complexity Analysis:
Time complextity:
O(n)
Space complexity:
O(1)
*/
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int prefix = 1, postfix = 1;
        int[] answer = new int[nums.Length];
    
        for(int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= postfix;
            postfix *= nums[i];
        }
        
        return answer;
    }
}