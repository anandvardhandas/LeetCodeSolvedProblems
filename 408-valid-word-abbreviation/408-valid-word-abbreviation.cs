public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int len = abbr.Length;
        int index = 0;
        int i = 0;
        for(; i < len; i++){
            int num = 0;
            bool isdigit = false;
            if(Char.IsDigit(abbr[i]) && (abbr[i] - '0') == 0)
                return false;
            while(i < len && Char.IsDigit(abbr[i])){
                isdigit = true;
               num = num * 10 + (abbr[i] - '0');
               i++;
            }
            
            index = index + num;
            if((index < word.Length && i < len && word[index] != abbr[i]) || index > word.Length || (index == word.Length && i < len))
                return false;
            
            if(isdigit)
                i--;
            
            if(num == 0)
                index++;
        }
        
        if(index < word.Length || i < len)
            return false;
        
        return true;
    }
}