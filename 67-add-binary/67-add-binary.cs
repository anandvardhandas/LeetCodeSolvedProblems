public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new StringBuilder();
        
        int len1 = a.Length, len2 = b.Length;
        int i = len1-1, j = len2-1;
        int carry = 0;
        while(i >= 0 || j >= 0){
            int sum = carry;
            
            if(i >= 0){
                sum += int.Parse(a[i].ToString());
                i--;
            }
            
            if(j >= 0){
                sum += int.Parse(b[j].ToString());
                j--;
            }
            
            carry = sum/2;
            sum = sum % 2;
            
            result.Append($"{sum}");
        }
        
        if(carry == 1){
            result.Append("1");
        }
        
        string res = result.ToString();
        
        char[] list = res.ToCharArray();
        Array.Reverse(list);
        
        return new string(list);
    }
}