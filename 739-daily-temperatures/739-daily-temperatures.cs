public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] result = new int[len];
        result[len-1] = 0;
        
        int hottest = temperatures[len-1];
        
        
        int i = len-2;
        while(i >= 0){
            if(temperatures[i] >= hottest){
                hottest = temperatures[i];
                result[i] = 0;
                i--;
            }
            else if(temperatures[i] < temperatures[i+1]){
                result[i] = 1;
                i--;
            }
            else{
                int j = i+1;
                while(temperatures[i] >= temperatures[j]){
                    j = j+result[j];
                }
                
                result[i] = j-i;
                
                i--;
            }
        }
        
        return result;
    }
}