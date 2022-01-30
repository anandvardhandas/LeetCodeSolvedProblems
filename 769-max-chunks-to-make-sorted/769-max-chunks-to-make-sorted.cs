public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int len = arr.Length;
        int max = 0;
        int total = 0;
       for(int i = 0; i < len; i++){
           max = Math.Max(max,arr[i]);
           if(max == i){
               total++;
           }
       }
        
        return total;
    }
}