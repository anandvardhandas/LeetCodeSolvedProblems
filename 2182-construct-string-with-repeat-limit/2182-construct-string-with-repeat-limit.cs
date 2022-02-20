public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int len = s.Length;
        
        int[] map = new int[26];
        foreach(char c in s){
            map[c-97]++;
        }
        
        char[] arr = new char[len];
        
        for(int i = 25; i >= 0; i--){
            int charcount = map[i];
            int index = 0;
            while(index < len && charcount > 0){
                int count = 0;
                while(index < len && count < repeatLimit && charcount > 0){
                    if(index < len && arr[index] == 0){
                        arr[index] = (char)(i+97);

                        count++;
                        charcount--;
                    }
                    else
                        count = 0;

                    index++;
                }
                
                if(count == repeatLimit){
                    index++;
                }
            }
        }
        
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < len; i++){
            if(arr[i] == 0)
                break;
            
            sb.Append(arr[i].ToString());
        }
        
        return sb.ToString();
    }
}