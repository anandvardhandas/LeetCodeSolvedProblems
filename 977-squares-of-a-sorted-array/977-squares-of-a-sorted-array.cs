public class Solution {
    public int[] SortedSquares(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len];
        int i = 0, j = len-1;
        int index = len-1;
        while(i <= j){
            int max = 0;
            if(Math.Abs(nums[i]) >= Math.Abs(nums[j])){
                max = nums[i]*nums[i];
                i++;
            }
            else{
                max = nums[j]*nums[j];
                j--;
            }
            
            result[index--] = max;
        }
        
        return result;
    }
}