public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        
        int sum = 0, num = x;
        while(num != 0)
        {
            sum = sum * 10 + num%10;
            num = num/10;
        }
        
        if(sum == x)
            return true;
        else
            return false;
    }
}