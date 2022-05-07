public class Solution {
    public string Interpret(string command) {
        StringBuilder sb = new StringBuilder();
        int len = command.Length;
        string s = command;
        int i = 0;
        while(i < len-1){
            if(s[i] == 'G'){
                sb.Append("G");
                i++;
            }
            else{
                if(s[i+1] == ')'){
                    sb.Append("o");
                    i += 2;
                }
                else{
                    sb.Append("al");
                    i += 4;
                }
            }
        }
        
        if(i == len-1 && s[i] == 'G'){
            sb.Append("G");
        }
        
        return sb.ToString();
    }
}