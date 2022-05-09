public class Solution {
    public int GetMaxLen(int[] nums) {
        int negatives = 0, firstNeg = -1, maxlen = 0;
        int zeropos = -1;
        int len = nums.Length;
        
        int i = 0;
        while(i < len){
            if(nums[i] < 0){
                negatives++;
                if(firstNeg == -1){
                    firstNeg = i;
                }
            }
            
            if(nums[i] == 0){
                zeropos = i;
                negatives = 0;
                firstNeg = -1;
            }
            else{
                if(negatives%2==0){
                    maxlen = Math.Max(maxlen, i-zeropos);
                }
                else{
                    maxlen = Math.Max(maxlen, i-firstNeg);
                }
            }
            
            i++;
        }
        
        return maxlen;
    }
}