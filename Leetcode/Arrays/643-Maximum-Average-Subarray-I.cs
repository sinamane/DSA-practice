/*
Problem Statement:
https://leetcode.com/problems/maximum-average-subarray-i/

*/

/*
Approach 1:
Sliding Window

Runtime: 275 ms, faster than 96.40% of C# online submissions for Maximum Average Subarray I.
Memory Usage: 60.1 MB, less than 28.10% of C# online submissions for Maximum Average Subarray I.

Complexity Analysis:
Time complextity:
O(n^2)
Space complexity:
O(1)
*/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxAvg = double.MinValue, sum = 0;
        int winStart = 0;
        
        for(int winEnd = 0; winEnd < nums.Length; winEnd++)
        {
            sum += nums[winEnd];
            
            if(winEnd >= k - 1)
            {
                maxAvg = Math.Max(maxAvg, sum/k);
                sum -= nums[winStart];
                winStart++;
            }
        }
        
        return maxAvg;
        
    }
}
