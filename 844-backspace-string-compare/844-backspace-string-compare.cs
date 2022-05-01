public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int i = s.Length-1, j = t.Length -1;
        
        int back1 = 0, back2 = 0; //backspace char count
        
        while(i>=0 || j>= 0){
            while(i>=0){
                if(s[i] == '#'){
                    back1++;
                    i--;
                }
                else{
                    if(back1 > 0){
                        back1--;
                        i--;
                    }
                    else{
                        break;
                    }
                }
            }
            
            while(j>=0){
                if(t[j] == '#'){
                    back2++;
                    j--;
                }
                else{
                    if(back2 > 0){
                        back2--;
                        j--;
                    }
                    else{
                        break;
                    }
                }
            }
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            if(i >= 0 && j >= 0 && s[i] != t[j]){
                return false;
            }
            
            if((i<0 && j>= 0) || (j < 0 && i >=0)){
                return false;
            }
            
            i--;
            j--;
        }
        
        return true;
    }
}