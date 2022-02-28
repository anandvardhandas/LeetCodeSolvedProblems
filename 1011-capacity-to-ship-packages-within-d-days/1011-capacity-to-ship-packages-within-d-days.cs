public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int len = weights.Length;
        
        int total = weights[0];
        int max = total;
        
        for(int i = 1; i < len; i++){
            max = Math.Max(max, weights[i]);
            total += weights[i];
        }
        
        int low = max;
        int hi = total;
        //Console.WriteLine(low);
        //Console.WriteLine(hi);
        
        while(low < hi){
            int midcap = low + (hi-low)/2;
            //Console.WriteLine(midcap);
            int daystocomp = GetDays(weights, midcap);
            //Console.WriteLine(daystocomp);

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
        int len = weights.Length;
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