/*
Problem Statement:
https://leetcode.com/problems/two-sum/

*/

/*
Approach 1:
Two pointer

Runtime: 177 ms, faster than 41.90% of C# online submissions for Two Sum
Memory Usage: 44.2 MB, less than 83.19% of C# online submissions for Two Sum

Complexity Analysis:
Time complextity:
O(n^2)
Space complexity:
O(1)
*/

/*
Examples:
Input: nums = [2,7,11,15], target = 9, Output: [0,1]
Input: nums = [3,2,4], target = 6, Output: [1,2]
Input: nums = [3,3], target = 6, Output: [0,1]
Input: nums = [3,2,3], target = 6, Output: [0,2]
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int x = 0; x < nums.Length; x++ )
        {
            for(int y = x + 1; y < nums.Length; y++)
            {
                if(nums[x] + nums[y] == target) 
                return new int []{ x, y};
            }
        }

        return Array.Empty<int>();
    }
}


/*
Approach 1:
Hash table

Runtime: 157 ms, faster than 68.37% of C# online submissions for Two Sum.
Memory Usage: 45.1 MB, less than 8.20% of C# online submissions for Two Sum.

Complexity Analysis:
Time complextity:
O(n), where n is the length of the input array and the maximum iterations taken to find the to numbers
Space complexity:
O(n), where n is the maximum elements stored in the dictionary
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            
            if(dict.ContainsKey(temp))
            {
                return new int[] {dict[temp], i};
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        
        return null;
    }
}