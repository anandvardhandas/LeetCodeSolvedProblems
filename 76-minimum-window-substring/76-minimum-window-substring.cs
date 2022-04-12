public class Solution {
    public string MinWindow(string s, string t) {
        int minlen = int.MaxValue;
        string minstring = "";
        
        int size = t.Length;
        int len = s.Length;
        
        Dictionary<char,int> map = new Dictionary<char,int>();
        Dictionary<char,int> map2 = new Dictionary<char,int>();
        string str = "abcdefghijklmnopqrstuvwxyz";
        foreach(char c in str){
            map2.Add(c,0);
            map2.Add(Char.ToUpper(c),0);
        }
        
        foreach(char c in t){
            if(map.ContainsKey(c)){
                map[c]++;
            }
            else{
                map.Add(c,1);
            }
        }
        
        int l = 0, r = 0;
        
        
        int count = 0;
        while(r < len){
            
            while(r < len && count < size){
                if(map.ContainsKey(s[r])){
                    map2[s[r]]++;
                    if(map2[s[r]] <= map[s[r]]){
                        count++;
                    }
                }
                r++;
            }
            
            if(count == size){
                if(r-l < minlen){
                    minlen = r-l;
                    minstring = s.Substring(l, minlen);
                }
            }
            
            while(count == size){
                if(map.ContainsKey(s[l])){
                    map2[s[l]]--;
                    if(map2[s[l]] < map[s[l]]){
                        count--;
                        
                        if(r-l < minlen){
                            minlen = r-l;
                            minstring = s.Substring(l, minlen);
                        }
                    }
                }
                
                l++;
            }
        }
        
        return minstring;
    }
}