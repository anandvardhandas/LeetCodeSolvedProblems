public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
        int[] map = new int[1001];
        for(int i = 0; i < nums.Length; i++){
            map[nums[i]]++;
        }
        int low = 1, hi = 1000;
        int maxSum = -1;
        while(low <= hi){
            if(map[low] > 0 && map[hi] > 0){
                if(low == hi && map[low] == 1) // only single frequency of the number hence cannot sum hence breaking out
                    break;
                
                int currSum = low+hi;
                if(currSum >= k){
                    hi--;
                }
                else{
                    maxSum = Math.Max(maxSum, currSum);
                    low++;
                }
            }
            else if(map[hi] == 0){
                hi--;
            }
            else{
                low++;
            }
            
        }
        
        return maxSum;
    }
}