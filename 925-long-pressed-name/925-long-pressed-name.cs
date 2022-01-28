public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        if(name.Length > typed.Length)
            return false;
        
        int i = 0;
        int j = 0;
        
        while(i < name.Length && j < typed.Length){
            int left = i, right = j;
            char c = name[i];
            while(i<name.Length && name[i] == c){
                i++;
            }
            
            while(j < typed.Length && typed[j] == c){
                j++;
            }
            
            if(i-left > j-right)
                return false;
        }
        
        return i == name.Length && j == typed.Length;
    }
}