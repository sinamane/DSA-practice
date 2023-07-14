/*
Problem Statement:
https://leetcode.com/problems/top-k-frequent-elements/

*/

/*
Approach 1:
Count the number of unique elements and store it in a dictionary.
Find the k most frequent elements using a foreach loop to compare the max value and return the result.

Runtime: 176 ms, faster than 15.53% of C# online submissions for Top K Frequent Elements.
Memory Usage: 46.2 MB, less than 73.08% of C# online submissions for Top K Frequent Elements.

Complexity Analysis:
Time complextity:
O(n^2), where n is the leght of the input array and the maximum iterations taken to find the
maximum frequency elements
Space complexity:
O(n + k), where n is all the unique elements and k is the consent length of the result
*/ 
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        if(nums.Length == 1) return nums;
        
        int[] result = new int[k];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) //n
        {
            dict[nums[i]] = 1 + (dict.ContainsKey(nums[i]) ? dict[nums[i]] : 0); //1
            
        }
        
        for(int i = 0; i < k; i++) //m
        {
            int maxValue = int.MinValue;
            int maxKey = 0;
            
            
            foreach(var d in dict)
            {
                if(d.Value > maxValue)
                {
                    maxKey = d.Key;
                    maxValue = d.Value;
                }
            }
            
            result[i] = maxKey;
            dict.Remove(maxKey);
        }
        
        return result;
    }
}