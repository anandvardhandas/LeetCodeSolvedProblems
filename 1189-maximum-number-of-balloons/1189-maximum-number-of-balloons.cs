public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] map = new int[26];
        foreach(char c in text){
            map[c-97]++;
        }
        
        int count = int.MaxValue, count2 = int.MaxValue;
        
        for(int i = 0; i < 26; i++){
            if(map[i] > 0){
                if(i == 0 || i == 1 || i == 13){ // 0 -> a, 1-> b, 
                    count = Math.Min(count, map[i]);
                }
                else if(i == 11 || i == 14){
                    count2 = Math.Min(count2, map[i]);
                }
            }
        }
        
        return (count == int.MaxValue || count2 == int.MaxValue) ? 0 : Math.Min(count,count2/2);
    }
}