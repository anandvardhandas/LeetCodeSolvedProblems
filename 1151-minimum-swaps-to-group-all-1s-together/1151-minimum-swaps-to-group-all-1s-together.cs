public class Solution {
    public int MinSwaps(int[] data) {
        int len = data.Length;
        
        if(len <= 2)
            return 0;
        
        int totalones = 0;
        for(int i = 0; i < len; i++){
            if(data[i] == 1){
                totalones++;
            }
        }
        
        int currones = 0;
        for(int i = 0; i < totalones; i++){
            if(data[i] == 1){
                currones++;
            }
        }
        
        if(currones == totalones)
            return 0;
        
        int maxones = currones;
        
        int left = 0, right = totalones-1;
        while(right < len-1){
            if(data[left] == 1){
                currones--;
            }
            
            left++;
            right++;
            
            if(data[right] == 1){
                currones++;
            }
            
            maxones = Math.Max(maxones, currones);
        }
        
        return totalones - maxones;

    }
}