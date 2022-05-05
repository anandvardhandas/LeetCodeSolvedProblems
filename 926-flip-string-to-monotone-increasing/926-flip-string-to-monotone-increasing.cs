public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int countones = 0;
        
        int result = 0;
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '1'){
                countones++;
            }
            else{
                result++;//option 1 -> flip this to 1 hence one more step required here in result so far
                
                //and if we decide to remain this as zero then we have to make all the previous ones to zero, hence comparing to result and deciding which would be best
                result = Math.Min(countones, result);
            }
        }
        
        return result;
    }
    
   
}