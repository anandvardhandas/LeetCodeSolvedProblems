public class Solution {
    public int[] PlusOne(int[] digits) {
        
        int len = digits.Length;
        
        int i = len-1;
        int carry = 1;
        List<int> result = new List<int>();
        while(i >= 0){
            int sum = carry+digits[i];
            carry = sum/10;
            sum = sum%10;
            result.Add(sum);
            
            i--;
        }
        
        if(carry > 0){
            result.Add(carry);
        }
        
        int[] res = result.ToArray();
        Array.Reverse(res);
        
        return res;
    }
}