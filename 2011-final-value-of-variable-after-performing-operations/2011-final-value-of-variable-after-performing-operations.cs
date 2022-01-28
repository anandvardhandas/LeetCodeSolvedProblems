public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int total = 0;
        foreach(string str in operations){
            if(str[0] == '+' || str[str.Length-1] == '+')
                total++;
            else
                total--;
        }
        
        return total;
    }
}