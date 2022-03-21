public class Solution {
    public IList<int> PartitionLabels(string s) {
        List<int> result = new List<int>();
        int[] map = new int[26];
        
        for(int i = 0; i < s.Length; i++){
            map[s[i]-97] = i;
        }
        
        int l = 0, r = 0;
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            r = Math.Max(r, map[c-97]);
            if(i == r){
                result.Add(r-l+1);
                l = r+1;
                r = l;
            }
        }
        
        return result;
    }
}