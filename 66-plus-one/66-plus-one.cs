public class Solution {
    public int[] PlusOne(int[] digits) {
        
        int len = digits.Length;
        
        int i = len-1;
        
        while(i >= 0){
            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }
            else{
                digits[i] = 0;
            }
            
            i--;
        }
        
        int[] result = new int[len+1];
        result[0] = 1;
        return result;
    }
}