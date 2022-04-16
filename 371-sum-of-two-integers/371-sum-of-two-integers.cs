public class Solution {
    public int GetSum(int a, int b) {
        int hld = 0;
        while(b != 0){
            hld = a & b;
            a = a ^ b;
            b = hld << 1;
        }
        
        return a;
    }
}