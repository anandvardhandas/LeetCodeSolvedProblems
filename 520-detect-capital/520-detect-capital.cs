public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word.Length == 1)
            return true;
        
        char fc = word[0];
        int[] cases = new int[3];
        if(fc >= 97 && fc <= 122){
            cases[1] = 1;
        }
        else{
            if(word[1] >= 65 && word[1] <= 90){
                cases[0] = 1;
            }
            else{
                cases[2] = 1;
            }
        }
        
        for(int i = 1; i < word.Length; i++){
            char c = word[i];
            if(cases[0] == 1){
                if(c < 65 || c > 90)
                    return false;
            }
            else if(cases[1] == 1){
                if(c < 97 || c > 122)
                    return false;
            }
            else if(cases[2] == 1){
                if(c < 97 || c > 122)
                    return false;
            }
        }
        
        return true;
    }
}