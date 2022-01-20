public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();
        int min = 1;
        
        while(min < max){
            int mid = min + (max-min)/2;
            //calculate hours
            int total = 0;
            for(int i = 0; i < piles.Length; i++){
                total += Convert.ToInt32(Math.Ceiling((decimal)piles[i]/mid));
            }
            
            if(total > h){
                min = mid+1;
            }
            else{
                max = mid;
            }
        }
        
        return max;
    }
}