/*
Problem Statement:
https://leetcode.com/problems/reverse-integer/

*/

/*
Approach 1:


Runtime: 20 ms, faster than 93.96% of C# online submissions for Reverse Integer.
Memory Usage: 26.5 MB, less than 95.67% of C# online submissions for Reverse Integer.

Complexity Analysis:
Time complextity:
O(log10(x))
Space complexity:
O(1)
*/

public class Solution {
    public int Reverse(int x) {
  
        if(x <= Int32.MinValue || x >= Int32.MaxValue) return 0;
        
        int revNum =  0;
        int prevNum = 0;
        bool isPositive = x >= 0 ? true : false;
        x = Math.Abs(x);
        
        while(x > 0)
        {
            int lastDigit = x % 10;
           
            revNum = (revNum * 10)+ lastDigit;
            
            if((revNum - lastDigit) / 10 != prevNum) return 0;
            
            prevNum = revNum;
            
            x /= 10;
        }
    
        
        return  isPositive ? revNum : revNum * -1 ;
    }
}