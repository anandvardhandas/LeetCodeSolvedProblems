public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int len = numbers.Length;
        int low = 0, hi = len-1;
        
        while(low < hi){
            int sum = numbers[low]+numbers[hi];
            if(sum > target){
                hi--;
            }
            else if(sum < target){
                low++;
            }
            else{
                return new int[] { low+1, hi+1 };
            }
        }
        
        return new int[] { 1, 1 };
    }
}