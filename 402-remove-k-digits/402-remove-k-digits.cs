public class Solution {
    public string RemoveKdigits(string num, int k) {
        int len = num.Length;
        if(k == len)
            return "0";
        
        char[] nums = num.ToCharArray();
        StringBuilder result = new StringBuilder();
        Stack<char> st = new Stack<char>();
        st.Push(nums[0]);
        for(int i = 1; i < len; i++){
            while(k > 0 && st.Count > 0 && (nums[i]-'0') < (st.Peek()-'0')){
                st.Pop();
                k--;
            }
                
            st.Push(nums[i]);
        }
        
        while(k > 0){
            st.Pop();
            k--;
        }
        
        while(st.Count > 0){
            result.Append(st.Pop().ToString());
        }
        
        string res = new string(result.ToString().Reverse().ToArray());
        
        if(res.Length > 1)
            res = res.TrimStart('0');
        
        return res == "" ? "0" : res;
    }
}