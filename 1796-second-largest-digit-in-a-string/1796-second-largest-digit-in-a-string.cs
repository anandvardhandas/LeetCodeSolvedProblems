public class Solution {
    public int SecondHighest(string s) {
        int hi = -1, low = -1;
        for(int i = 0; i < s.Length; i++){
            if(int.TryParse(s[i].ToString(), out int num)){
                if(hi == int.MinValue){
                    hi = int.Parse(s[i].ToString());
                }
                else{
                    if(num > hi){
                        low = hi;
                        hi = num;
                    }
                    else if(num < hi && num > low){
                        low = num;
                    }
                }
            }
        }
        
        return low;
    }
}