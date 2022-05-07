public class Solution {
    public string Interpret(string command) {
        StringBuilder sb = new StringBuilder();
        int len = command.Length;
        string s = command;
        int i = 0;
        while(i < len){
            if(s[i] == 'G'){
                sb.Append("G");
                i++;
            }
            else{
                if(s[i] == '(' && s[i+1] == ')'){
                    sb.Append("o");
                    i += 2;
                }
                else{
                    sb.Append("al");
                    i += 4;
                }
            }
        }
        
        return sb.ToString();
    }
}