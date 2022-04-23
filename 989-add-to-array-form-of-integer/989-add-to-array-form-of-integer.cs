public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        List<int> knum = new List<int>();
        while(k > 0){
            knum.Add(k%10);
            k = k/10;
        }
        
        int[] nums = knum.ToArray();
        Array.Reverse(nums);
        
        int i = num.Length-1, j = nums.Length-1;
        
        IList<int> result = new List<int>();
        int carry = 0;
        while(i >= 0 || j >= 0){
            int sum = carry;
            if(i >= 0){
                sum += num[i];
                i--;
            }
            
            if(j >= 0){
                sum += nums[j];
                j--;
            }
            
            carry = sum/10;
            sum = sum%10;
            
            result.Add(sum);
        }
        
        if(carry > 0){
            result.Add(carry);
        }
        
        return result.Reverse().ToList();
    }
}