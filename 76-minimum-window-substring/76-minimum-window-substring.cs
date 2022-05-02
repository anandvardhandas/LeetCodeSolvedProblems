public class Solution {
    public string MinWindow(string s, string t) {
        int len1  = t.Length, len2 = s.Length;
        if(len1 > len2)
            return "";
        int min = int.MaxValue;
        string res = "";
        Dictionary<char,int> map1 = new Dictionary<char,int>();
        Dictionary<char,int> map2 = new Dictionary<char,int>();
        
        FillMap(map1);
        FillMap(map2);
        
        foreach(char c in t){
            map1[c]++;
        }
        
        int count = 0;
        
        
        int low = 0, hi = 0;
        while(hi < len2){
            while(hi < len2 && count < len1){
                char c = s[hi];
                if(map1[c] > 0){
                    map2[c]++;
                    if(map2[c] <= map1[c]){
                        count++;
                    }
                }
                
                hi++;
            }
            
            if(count == len1 && hi-low < min){
                min = hi-low;
                res = s.Substring(low, hi-low);
            }
            
            while(count == len1){
                char c = s[low];
                if(map1[c] > 0){
                    if(map2[c] <= map1[c]){
                        count--;
                        
                        if(hi-low < min){
                           min = hi-low;
                           res = s.Substring(low, hi-low);
                       }
                    }
                    
                    map2[c]--;
                }
                
                low++;
            }
        }
        
        return res;
    }
    
    private void FillMap(Dictionary<char,int> map){
        string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach(char c in str){
            map.Add(c,0);
        }
    }
}