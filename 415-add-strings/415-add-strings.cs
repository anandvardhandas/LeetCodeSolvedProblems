public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder sb = new StringBuilder();
        int i = num1.Length-1, j = num2.Length-1;
        int carry = 0;
        
        while(i >= 0 || j >= 0){
            int sum = 0;
            if(i >= 0){
                sum += int.Parse(num1[i].ToString());
                i--;
            }
            
            if(j >= 0){
                sum += int.Parse(num2[j].ToString());
                j--;
            }
            
            sum += carry;
            carry = sum/10;
            sb.Append((sum%10).ToString());
        }
        
        if(carry == 1)
            sb.Append("1");
        
        return new string(sb.ToString().Reverse().ToArray());
    }
}