public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int len = s.Length;
        int open = 0, close = 0;
        List<char> chars = new List<char>();
        foreach(char c in s){
            if(c == '('){
                open++;
            }
            else if(c == ')'){
                close++;
                if(close > open){
                    close--;
                    continue;
                }
                else{
                    open--;
                    close--;
                }
            }
            
            chars.Add(c);
        }
        
        StringBuilder result = new StringBuilder();
        //Console.WriteLine(open);
        for(int i = chars.Count-1; i >= 0; i--){
            if(chars[i] == '(' && open > 0){
                open--;
                continue;
            }
            
            result.Append(chars[i].ToString());
        }
        
        char[] res = result.ToString().ToCharArray();
        Array.Reverse(res);
        return new string(res);
    }
}