/*
Problem Statement:
https://leetcode.com/problems/contains-duplicate/

*/

/*
Approach 2:
Two pointer

Runtime: 2627 ms, faster than 10.28% of C# online submissions for Contains Duplicate.
Memory Usage: 53.6 MB, less than 57.13% of C# online submissions for Contains Duplicate.

Complexity Analysis:
Time complextity:
O(n^2)
Space complexity:
O(n)
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
            
        for(int main = 0; main < nums.Length; main++)
        {
            for(int sub = main + 1; sub < nums.Length; sub++)
            {
                if(nums[main] == nums[sub]) return true;
            }
        }
        
        return false;
        
    }
}


/*
Approach 2:
Two pointer

Runtime: 223 ms, faster than 28.89% of C# online submissions for Contains Duplicate.
Memory Usage: 55.7 MB, less than 7.86% of C# online submissions for Contains Duplicate.

Complexity Analysis:
Time complextity:
O(n)
Space complexity:
O(n)
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();

        foreach(int n in nums)
        {
            if(dup.Contains(n)) return true;
            dup.Add(n);

        }
        return false;
        
    }
}


/*
Approach 3:
Two pointer

Runtime: 205 ms, faster than 67.49% of C# online submissions for Contains Duplicate.
Memory Usage: 53.6 MB, less than 64.79% of C# online submissions for Contains Duplicate.

Complexity Analysis:
Time complextity:
O(n)
Space complexity:
O(n)
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       
        HashSet<int> dup = new HashSet<int>(nums);
        return dup.Count == nums.Length? false:true;
        
    }
}