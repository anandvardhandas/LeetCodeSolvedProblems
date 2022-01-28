public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        int[] map = new int[46];
        int num = lowLimit;
        int result = -1;
        while(num <= highLimit){
            //calculate sum of all the integers in num
            int sum = 0;
            int n = num;
            while(n > 0){
                sum += n%10;
                n /= 10;
            }
            
            map[sum]++;
            result = Math.Max(result, map[sum]);
            num++;
        }
        
        return result;
    }
}