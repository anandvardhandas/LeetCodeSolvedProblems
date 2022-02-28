class Solution {
    public int shipWithinDays(int[] weights, int days) {
        int len = weights.length;
        
        int total = weights[0];
        int max = total;
        
        for(int i = 1; i < len; i++){
            max = Math.max(max, weights[i]);
            total += weights[i];
        }
        
        int low = max;
        int hi = total;
        
        while(low < hi){
            int midcap = low + (hi-low)/2;
            int daystocomp = GetDays(weights, midcap);

            if(daystocomp > days){
                low = midcap+1;
            }
            else{
                hi = midcap;
            }
        }
        
        return low;
    }
    
    private int GetDays(int[] weights, int cap){
        int len = weights.length;
        int totaldays = 0;
        int i = 0;
        
        while(i < len){
           int curr = 0;
            while(i < len && curr+weights[i] <= cap){
                curr = curr + weights[i];
                i++;
            }
            
            totaldays++;
        }
        
        return totaldays;
    }
}