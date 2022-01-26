public class Solution {
    public IList<int> PartitionLabels(string s) {
        int len = s.Length;
        IList<int> result = new List<int>();
        int[] map = new int[26];
        for(int i = len-1; i >= 0; i--){
            if(map[s[i]-97] == 0){
                map[s[i]-97] = i;
            }
        }
        
        int index = 0;
        while(index < len){
            int low = index;
            int hi = map[s[index]-97];
            int diff = hi-low+1;
            for(int j = low; j <= hi; j++){
                if(map[s[j]-97] > hi){
                    hi = map[s[j]-97];
                    diff = hi-low+1;
                }
            }
            
            result.Add(diff);
            index = hi+1;
        }
        
        
        return result;
    }
}