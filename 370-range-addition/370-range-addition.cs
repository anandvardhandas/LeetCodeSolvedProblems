public class Solution {
    public int[] GetModifiedArray(int length, int[][] updates) {
        int[] result = new int[length];
        
        if(updates.Length == 0){
            return result;
        }
        
        foreach(int[] update in updates){
            int num = update[2];
            int left = update[0], right = update[1];
            
            result[left] += num;
            if(right < length-1){
                result[right+1] -= num;
            }
        }
        
        for(int i = 1; i < length; i++){
            result[i] = result[i-1]+result[i];
        }
        
        return result;
    }
}