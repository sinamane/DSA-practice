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
Approach 2:
Two pointer

Runtime: 177 ms, faster than 41.90% of C# online submissions for Two Sum
Memory Usage: 44.2 MB, less than 83.19% of C# online submissions for Two Sum

Complexity Analysis:
Time complextity:
Space complexity:
*/

/*
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
      int fast = 1;
      int[] res = new int[2];
        
     for(int slow = 0; slow < nums.Length; slow++)
     {
         int sum = nums[slow] + nums[fast];
         
         if(sum == target)
         {
             res[0] = slow;
             res[1] = fast;
             break;
         }
         fast++;
     }
    
     return res;
    
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
      int left_pointer = 0;
      int right_pointer = nums.Length - 1;
      int[] res = new int[2];
        
     while(left_pointer <= right_pointer)
     {
         int sum = nums[left_pointer] + nums[right_pointer];
         
         if(sum == target)
         {
             res[0] = left_pointer++;
             res[1] = right_pointer++;
             break;
         }
         
         if(sum < target)
             left_pointer++;
         else
             right_pointer--;
     }
    
     return res;
    }
}

*/