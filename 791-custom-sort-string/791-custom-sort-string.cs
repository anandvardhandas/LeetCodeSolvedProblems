public class Solution {
    public string CustomSortString(string order, string s) {
        StringBuilder sb = new StringBuilder();
        
        int[] map = new int[26];
        foreach(char c in s){
            map[c-97]++;
        }
        
        foreach(char c in order){
            int times = map[c-97];
            if(times > 0){
                sb.Append(Helper(c, times));
                map[c-97] = 0;
            }
            else{
                continue;
            }
        }
        
        for(int i = 0; i < 26; i++){
            if(map[i] > 0){
                sb.Append(Helper(Convert.ToChar(i+97), map[i]));
            }
        }
        
        return sb.ToString();
    }
    
    public string Helper(char c, int times){
        StringBuilder result = new StringBuilder();
        while(times > 0){
            result.Append(c);
            times--;
        }
        
        return result.ToString();
    }
}