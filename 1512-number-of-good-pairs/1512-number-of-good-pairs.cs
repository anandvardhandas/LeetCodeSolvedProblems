public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int[] countmap = new int[101];
        foreach(int num in nums){
            countmap[num]++;
        }
        
        int total = 0;
        for(int i = 1; i < 101; i++){
            if(countmap[i] > 1){
                int n = countmap[i]-1;
                total += (n * (n+1))/2;
            }
        }
        
        return total;
    }
}