public class Solution {
    public long MinimumHealth(int[] damage, int armor) {
        int len = damage.Length;
        long total = 0;
        
        int max = 0;
        for(int i = 0; i < len; i++){
            total += damage[i];
            
            if(damage[i] > max){
                max = damage[i];
            }
        }
        
        return total-Math.Min(max,armor)+1;
    }
}