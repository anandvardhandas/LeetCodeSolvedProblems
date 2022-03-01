public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n+1];
        for(int i = 0; i <= n; i++){
            result[i] = BitCount(i);
        }
        
        return result;
    }
    
    private int BitCount(int num){
        int total = 0;
        
        while(num > 0){
            int n = num & 1;
            if(n == 1)
                total++;
            
            num = num >> 1;
        }
        
        return total;
    }
}