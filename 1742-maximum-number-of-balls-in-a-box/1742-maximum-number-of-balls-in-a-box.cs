public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        Dictionary<int,int> map = new Dictionary<int,int>();
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
            
            if(!map.ContainsKey(sum))
                map.Add(sum, 1);
            else
                map[sum]++;
            
            result = Math.Max(result, map[sum]);
            
            num++;
        }
        
        return result;
    }
}