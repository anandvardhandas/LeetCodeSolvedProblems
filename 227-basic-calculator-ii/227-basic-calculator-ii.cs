public class Solution {
    public int Calculate(string s) {
        int result = 0;
        s = s.Trim();
        Stack<int> st = new Stack<int>();
        
        int len = s.Length;
        char sign = '+';
        int i = 0;
        while(i < len){
            if(s[i] == '-'){
                sign = '-';
            }
            else if(s[i] == '+'){
                sign = '+';
            }
            else if(s[i] == '*'){
                sign = '*';
            }
            else if(s[i] == '/'){
                sign = '/';
            }
            else if(Char.IsDigit(s[i])){
                int num = 0;
                while(i < len && Char.IsDigit(s[i])){
                    num = num * 10 + int.Parse(s[i].ToString());
                    i++;
                }
                
                if(i<len)
                    i--;
                
                if(sign == '*'){
                    num = st.Pop() * num;
                    st.Push(num);
                }
                else if(sign == '/'){
                    num = st.Pop()/num;
                    st.Push(num);
                }
                else if(sign == '-'){
                    st.Push(-num);
                }
                else{
                    st.Push(num);
                }
            }
            
            i++;
        }
        
        while(st.Count > 0){
            result += st.Pop();
        }
        
        return result;
    }
}