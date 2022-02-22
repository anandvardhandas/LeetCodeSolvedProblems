public class Solution {
    public string MinRemoveToMakeValid(string s) {
        List<char> result = new List<char>();
        
        int opened = 0, closed = 0;
        int i = 0;
        while(i < s.Length){
            if(s[i] == '('){
                opened++;
            }
            else if(s[i] == ')'){
                closed++;
            }
            
            if(closed <= opened){
                result.Add(s[i]);
            }
            else{
                closed--;
            }
            
            i++;
        }
        
        i = result.Count-1;
        while(i >= 0 && opened > closed){
            if(result[i] == '('){
                opened--;
                result.RemoveAt(i);
            }
            
            i--;
        }
        
        return new string(result.ToArray());
    }
}