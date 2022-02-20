public class Solution {
    public int[] map = new int[1001];
    public int[] prefix = new int[1001];
    public Solution(){
        for(int i = 1; i <= 1000; i++){
            int num = i;
            int sum = 0;
            while(num > 0){
                sum += num%10;
                num = num/10;
            }
            
            if(sum%2 == 0){
                map[i] = 1;
            }
            
            prefix[i] = prefix[i-1] + (map[i] == 1 ? 1 : 0);
        }
        
        
    }
    public int CountEven(int num) {
        return prefix[num];
    }
}