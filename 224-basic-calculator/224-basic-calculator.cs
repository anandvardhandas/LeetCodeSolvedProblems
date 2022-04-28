public class Solution {
    public int Calculate(string s) {
        int sign = 1; //-1 for negative +1 for positive
        
        Stack<int> st = new Stack<int>();
        
        int len = s.Length;
        int i = 0;
        int total = 0;
        while(i < len){
            Console.WriteLine(sign);
            if(s[i] == '+'){
                sign = 1;
                i++;
            }
            else if(s[i] == '-'){
                sign = -1;
                i++;
            }
            else if(Char.IsDigit(s[i])){
                int num = 0;
                while(i < len && Char.IsDigit(s[i])){
                    num = num * 10 + int.Parse(s[i].ToString());
                    i++;
                }
                
                num = num*sign;
                
                total += num;
            }
            else if(s[i] == '('){
                st.Push(total);
                st.Push(sign);
                
                total = 0;
                sign = 1;
                i++;
            }
            else if(s[i] == ')'){
                total = total * st.Pop();
                total += st.Pop();
                i++;
            }
            else{
                i++;
            }
        }
        
        return total;
    }
}