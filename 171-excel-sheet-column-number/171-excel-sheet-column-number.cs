public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;
        int power = 0;
        for(int i = columnTitle.Length - 1; i >= 0; i--){
            result += (int)Math.Pow(26, power) * ((columnTitle[i]-65)+1);
            power++;
        }
        
        return result;
    }
}