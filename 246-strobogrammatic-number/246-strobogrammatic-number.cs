public class Solution {
    public bool IsStrobogrammatic(string num) {
        Dictionary<char,char> map = new Dictionary<char,char>();
        map.Add('0','0');
        map.Add('1','1');
        map.Add('6','9');
        map.Add('8','8');
        map.Add('9','6');
        
        int l = 0, r = num.Length-1;
        while(l <= r){
            char c1 = num[l];
            char c2 = num[r];
            if(!map.ContainsKey(c1) || !map.ContainsKey(c2))
                return false;
            else if(map[c1] != c2 || map[c2] != c1)
                return false;
            
            l++;
            r--;
        }
        
        return true;
    }
}